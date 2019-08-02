using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using MySqlConnector.Authentication;
using MySqlConnector.Logging;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
namespace mqtt_project
{
    public partial class HistoryForm : Form
    {
        /// <summary>
        /// 保存用于折线图
        /// </summary>
        DataTable Chart_DATA = new DataTable();
        /// <summary>
        /// MQTT代理服务器地址
        /// </summary>
        public string MQTT_Border_IPAddress = "2409:8921:5a70:70d:ad78:d234:f05b:564";
        public DataTable His_DATA;
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            Init_Chart_DATA();//初始化DATATable
            Con_mysql();
            //Test_Date();
            Chain_Init();
        }
        
        /// <summary>
        /// 连接数据库并获取数据
        /// </summary>
        public void Con_mysql()
        {
            string connecStr = "Server=2001:da8:270:2018:f816:3eff:fe1d:bb01;User ID=root;Password=lama940225;Database=MQTT_DATA";
            using (var conn = new MySqlConnection(connecStr))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM DATA where date like '"+this.dateTimePicker1.Value.ToString("yyyy-MM-dd")+"%';");
                cmd.Connection = conn;
                cmd.Transaction = trans;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int count = 0;
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            string date = reader["date"].ToString();
                            string Pa_value = reader["RSSI"].ToString();
                            string TEMP = reader["TEMP"].ToString();
                            Chart_DATA.Rows.Add(date, Pa_value, TEMP);
                            count = count + 1;
                        }
                    }
                    Console.Write(count.ToString());
                }

            }

        }
        /// <summary>
        /// 初始化datatable结构
        /// </summary>
        public void Init_Chart_DATA()
        {
            Chart_DATA.Columns.Add("date");
            Chart_DATA.Columns.Add("Pa_value");
            Chart_DATA.Columns.Add("TEMP");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 测试数据
        /// </summary>
        public void Test_Date()
        {
            for (int i = 0; i < 20; i++)
            {
                Chart_DATA.Rows.Add(i.ToString(),i.ToString(),(i+3).ToString());
            }
            
        }
        /// <summary>
        /// 加载折线图
        /// </summary>
        public void Chain_Init()
        {
           
            this.chart1.Series.Clear();   //清空图表中的内容
            //this.chart1.Titles.Add("Total Income");//添加标题
            chart1.DataSource = Chart_DATA;
            Series series = this.chart1.Series.Add("Pa_value");//添加第一个表
            series.XValueMember = "date";  //x轴为时间
            series.YValueMembers = "Pa_value";  //y轴为数据
            Series series1 = this.chart1.Series.Add("TEMP");//添加第二个表
            series1.XValueMember = "date";
            series1.YValueMembers = "TEMP";
            this.chart1.Series[0].ChartType = SeriesChartType.Spline;//指定图表的类型，这里是折线图
            this.chart1.Series[0].Color = Color.Blue;
            this.chart1.Series[1].ChartType = SeriesChartType.Spline;
            this.chart1.Series[1].Color = Color.Red;
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date=this.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Chart_DATA.Rows.Clear();
            Con_mysql();
            Chain_Init();


        }
    }
}
