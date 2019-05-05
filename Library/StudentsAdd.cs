using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryBll;
using LibraryModels;

namespace Library
{
    public partial class StudentsAdd : Form
    {
        #region 常量、变量
        public const string INPUTWARN = "输入提示";
        public const string INPUTID = "请输入账号";
        public const string INPUTPWD = "请输入密码";
        public const string INPUTNAME= "请输入姓名";
        public const string INPUTSEX = "请选择性别";
        public const string INPUTSTUTYPE = "请选择读者类别";
        public const string INPUTTELL = "请填写联系方式";
        public const string INPUTADDRESS = "请填写家庭住址";
        public const string INPUTEMAIL = "请填写电子邮件";
        public const string INSERTSUCCEED = "添加成功";
        public const string INSERTFAILED = "添加失败";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILSED = "操作失败";
        #endregion
        public StudentsAdd()
        {
            InitializeComponent();
        }
        #region 读者类别绑定
        //读者类别绑定
        private void StuTypeBind()
        {
            uTypeManager uTypeManager = new uTypeManager();
            this.comboStudentType.DataSource = uTypeManager.GetUserData();
            this.comboStudentType.DisplayMember = "userType";
        }
        #endregion

        #region 非空验证
        //非空验证
        public bool CheckInputNotEmpty()
        {
            if (this.textStudentId.Text.Trim() == "")
            {
                MessageBox.Show(INPUTID, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textStudentId.Focus();
                return false;
            }
            if (this.textStudentName.Text.Trim() == "")
            {
                MessageBox.Show(INPUTNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textStudentName.Focus();
                return false;
            }
            if (this.textStudentPwd.Text.Trim() =="")
            {
                MessageBox.Show(INPUTPWD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textStudentPwd.Focus();
                return false;
            }
            if (this.textStudentTell.Text.Trim() == "")
            {
                MessageBox.Show(INPUTTELL, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textStudentTell.Focus();
                return false;
            }
            if (this.textStudentAddress.Text.Trim() == "")
            {
                MessageBox.Show(INPUTADDRESS, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textStudentAddress.Focus();
                return false;
            }
            if (this.textStudentEmail.Text.Trim() == "")
            {
                MessageBox.Show(INPUTEMAIL, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textStudentEmail.Focus();
                return false;
            }
            if (!this.radioBtnF.Checked && !this.radioBtnM.Checked)
            {
                MessageBox.Show(INPUTSEX, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.radioBtnF.Focus();
                return false;
            }
            if (this.comboStudentType.Text.Trim() == "")
            {
                MessageBox.Show(INPUTSTUTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.comboStudentType.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region 窗体加载事件
        //窗体加载事件
        private void StudentsAdd_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet2.UserType”中。您可以根据需要移动或删除它。
            this.userTypeTableAdapter.Fill(this.libraryDataSet2.UserType);

        }
        #endregion

        #region 单击添加
        //单击添加
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNotEmpty())
                {
                    return;
                }
                string strSex = " ";
                if (this.radioBtnF.Checked)
                {
                    strSex = "男";
                }
                else if (this.radioBtnM.Checked)
                {
                    strSex = "女";
                }
                else
                {
                    return;
                }
                Students students = new Students();
                students.LoginId = Convert.ToInt32(this.textStudentId.Text.Trim());
                students.LoginPwd = this.textStudentPwd.Text.Trim();
                students.Name = this.textStudentName.Text.Trim();
                students.Sex = strSex;
                students.UserType = this.comboStudentType.Text.Trim();
                students.Tell = this.textStudentTell.Text.Trim();
                students.Address = this.textStudentAddress.Text.Trim();
                students.Email = this.textStudentEmail.Text.Trim();

                int ret = new StudentsManager().AddStudent(students);
                if (ret>0)
                {
                    MessageBox.Show(INSERTSUCCEED,OPERATIONWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(INSERTFAILED,OPERATIONWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 单击返回
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
