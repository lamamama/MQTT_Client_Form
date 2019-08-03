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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ComBoBox_Init();
            
        }
        /// <summary>
        /// ComboBox初始化
        /// </summary>
        public void ComBoBox_Init()
        {
            this.UserType_ComboBox.Items.Add("医护人员账号");
            this.UserType_ComboBox.Items.Add("病患账号");
            this.UserType_ComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 按下登陆的回调函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_BTN_Click(object sender, EventArgs e)
        {
            ConMySQLByUserAndPwsswd(this.User_TextBox.Text,this.PWD_TextBox.Text);
        }

        /// <summary>
        /// 通过用户名和密码以及类型查询是否存在
        /// </summary>
        /// <param name="user"></param>
        /// <param name="passwd"></param>
        public void ConMySQLByUserAndPwsswd(string user,string passwd) {
            string userType = this.UserType_ComboBox.Text;
            string datatable = null;
            if (userType == "医护人员账号")
            {
                datatable = "Worker_Login_Hospital";
            }
            else if (userType == "病患账号")
            {
                datatable = "Patient_Login_Hospital";
            }
            string connecStr = "Server=2001:da8:270:2018:f816:3eff:fe1d:bb01;User ID=root;Password=lama940225;Database=MQTT_DATA";
            try
            {
                using (var conn = new MySqlConnection(connecStr))
                {
                    conn.Open();
                    MySqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + datatable + " where Account= " + "'" + user + "'" + " and " + "passwd= " + "'" + passwd + "';");
                        cmd.Connection = conn;
                        cmd.Transaction = trans;

                        using (var reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                if (reader.HasRows)
                                {
                                    //登陆成功
                                }
                                else
                                {
                                    //登陆失败
                                    MessageBox.Show("用户名或密码错误，请重新输入");
                                    this.User_TextBox.Text = null;
                                    this.PWD_TextBox.Text = null;
                                }

                            }
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

        private void SignUp_BTN_Click(object sender, EventArgs e)
        {
            signup S = new signup();
            this.Visible=false;
            S.ShowDialog();
           
                this.Visible = true;


        }
    }
}
