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
namespace mqtt_project
{
    public partial class Patient_Signup : Form
    {
        public Patient_Signup()
        {
            InitializeComponent();
            SexComboBoxInit();
        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 开始注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if(this.Room_TextBox.Text==null|| this.Room_TextBox.Text =="")
            {
                MessageBox.Show("请输入病床号");
                return;
            }
            if (this.User_TextBox.Text == null || this.User_TextBox.Text == null)
            {
                MessageBox.Show("请输入姓名");
                return;
            }
            if (this.Account_TextBox.Text == null || this.Account_TextBox.Text == null)
            {
                MessageBox.Show("请输入身份证号");
                return;
            }
            if (this.Phone_TextBox.Text == null || this.Phone_TextBox.Text == null)
            {
                MessageBox.Show("请输入手机号");
                return;
            }
            if (this.PWD_TextBox.Text == null || this.PWD_TextBox.Text == null)
            {
                MessageBox.Show("请输入密码");
                return;
            }
            if (this.PWD_TextBox.Text.Length < 8)
            {
                MessageBox.Show("密码必须大于8位");
                this.PWD_TextBox.Text = null;
                return;
            }
            ConMySQLByQuery(this.Room_TextBox.Text, this.User_TextBox.Text,this.Sex_CcomboBox.Text, this.Account_TextBox.Text, this.Phone_TextBox.Text, this.PWD_TextBox.Text);



        }
        /// <summary>
        /// 插入用户数据
        /// </summary>
        /// <param name="room"></param>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        /// <param name="account"></param>
        /// <param name="phone"></param>
        /// <param name="passwd"></param>
        public void ConMySQLByQuery(string room, string name,string sex,string account,string phone,string passwd)
        {
            
            string connecStr = "Server=2001:da8:270:2018:f816:3eff:fe1d:bb01;User ID=root;Password=lama940225;Database=MQTT_DATA";
            try
            {
                using (var conn = new MySqlConnection(connecStr))
                {
                    conn.Open();
                    MySqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO Patient_Login_Hospital (Account,Identity,sex,phone,passwd,room,type,isValid) values( " + "'"+name+"',"+"'"+account+"'," + "'" + sex + "'," + "'" + phone + "'," + "'" + passwd + "'," + "'" + room + "'" + ", 'customer','1' );");
                        cmd.Connection = conn;
                        cmd.Transaction = trans;
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("注册成功");
                        }
                        else {
                            MessageBox.Show("注册失败");
                        }
                        trans.Commit();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        conn.Close();
                        MessageBox.Show(ex.ToString());
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// 初始化性别下拉框
        /// </summary>
        void SexComboBoxInit()
        {
            this.Sex_CcomboBox.Items.Add("男");
            this.Sex_CcomboBox.Items.Add("女");
            this.Sex_CcomboBox.SelectedIndex = 0;
        }

       
        
        
    }
}
