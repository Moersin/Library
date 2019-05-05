using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryModels;
using LibraryBll;

namespace Library
{
    public partial class FormLogin : Form
    {
        public const string INPUTUSERNAME = "请输入账号";
        public const string INPUTUSERPWD = "请输入密码";
        public const string INPUTWARN = "输入提示";
        public const string LOGINFALED = "登陆失败";
        public const string INPUTNOEXIST = "输入的账号或密码错误";
        AdminManager am = new AdminManager();
        StudentsManager ss = new StudentsManager();
        public string LoginId = string.Empty;

        //构造函数
        public FormLogin()
        {
            InitializeComponent();
        }


        private void CbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cbSelect.SelectedIndex = 0;
        }
        //单击登陆事件
        private void ButLogin_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            if (this.cbSelect.SelectedIndex==0)//管理员
            {
                if (am.CheckUserLogin(textFormId.Text.Trim(), textFormPwd.Text.Trim()))
                {
                    //MessageBox.Show("管理员登陆成功");
                    //跳转到indexForm页面，隐藏登陆页面
                    indexForm indexForm = new indexForm();
                    indexForm.Show();
                    this.Hide();
                }
                else{
                    MessageBox.Show(INPUTNOEXIST,INPUTWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                if (ss.CheckStudentsLogin(textFormId.Text.Trim(), textFormPwd.Text.Trim()))
                {
                    //MessageBox.Show("登陆成功");
                    //跳转到图书管理系统-读者页面
                    indexFormStu indexFormStu = new indexFormStu();
                    indexFormStu.Show();
                    this.Hide();
                    LoginId = this.textFormId.Text.Trim();
                }
                else
                {
                    MessageBox.Show(INPUTNOEXIST, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //输入验证
        public bool CheckInput()
        {
            if (this.textFormId.Text==" ")
            {
                MessageBox.Show(INPUTUSERNAME,INPUTUSERPWD,MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.textFormId.Focus();
                return false;
            }
            if (this.textFormPwd.Text == " ")
            {
                MessageBox.Show(INPUTUSERNAME, INPUTUSERPWD, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textFormPwd.Focus();
                return false;
            }
            return true;
        }
        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void ButExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
