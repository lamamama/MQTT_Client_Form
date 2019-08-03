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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            TypeComboBoxInit();
            SexComboBoxInit();
        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if (this.User_TextBox.Text == null||this.User_TextBox.Text == null)
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
            if (this.PWD_TextBox.Text.Length<8)
            {
                MessageBox.Show("密码必须大于8位");
                this.PWD_TextBox.Text = null;
                return;
            }
            
            //执行注册
            if (this.User_TextBox.Text == "医护人员账号")
            {

            } else
            {

            }
        }
        /// <summary>
        /// 初始化账号类型下拉框
        /// </summary>
       void TypeComboBoxInit()
        {
            this.Type_ComboBox.Items.Add("医护人员账号");
            this.Type_ComboBox.Items.Add("病患账号");
            this.Type_ComboBox.SelectedIndex = 0;
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
        /// <summary>
        /// 当切换用户类型时，首先隐藏该界面，然后打开，当子界面关闭后，关闭该界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Type_ComboBox.Text == "病患账号")
            {
                Patient_Signup P = new Patient_Signup();
                this.Visible = false;
                P.ShowDialog();
                this.Close();
            }
        }
    }
}
