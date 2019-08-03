using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt_project
{
    public partial class Patient_Signup : Form
    {
        public Patient_Signup()
        {
            InitializeComponent();
            InitializeComponent();
           
            SexComboBoxInit();
        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            //执行注册
            if (this.User_TextBox.Text == "医护人员账号")
            {

            }
            else
            {

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

        private void Phone_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        
    }
}
