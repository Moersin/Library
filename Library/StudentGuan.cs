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
    public partial class StudentGuan : Form
    {
        #region 常量、变量
        public const string INPUTWARN = "输入提示";
        public const string INPUTID = "请输入账号";
        public const string INPUTPWD = "请输入密码";
        public const string INPUTNAME = "请输入姓名";
        public const string INPUTSEX = "请选择性别";
        public const string INPUTSTUTYPE = "请选择读者类别";
        public const string INPUTTELL = "请填写联系方式";
        public const string INPUTADDRESS = "请填写家庭住址";
        public const string INPUTEMAIL = "请填写电子邮件";
        public const string QUERYSUCCEED = "查询成功";
        public const string QUERYFAILED = "查询失败";
        public const string UPDATESUCCEED = "修改成功";
        public const string UPDATEFAILED = "修改失败";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILSED = "操作失败";
        public const string DELETESUCCEED = "删除成功";
        public const string ISDELETE = "即将删除";
        public const string DELETEFAILED = "删除失败";

        List<Students> studentsList = new List<Students>();
        StudentsManager studentsManager = new StudentsManager();
        #endregion

        public StudentGuan()
        {
            InitializeComponent();
        }

        #region 根据条件学生信息绑定
        //根据条件学生信息绑定
        public void StudentDataBind()
        {
            List<Students> studentsList = studentsManager.GetStudentsByNameAndType(this.textQueryStuName.Text.Trim(), this.cboQueryStuType.Text.Trim());
            this.dataGridView1.DataSource = studentsList;
        }
        #endregion

        #region 更新需要修改的数据
        //更新需要修改的数据
        public void SelectedData()
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = this.dataGridView1.CurrentRow;
                this.textUpdateStuId.Text = dgvr.Cells[0].Value.ToString();
                this.textUpdateStuPwd.Text = dgvr.Cells[1].Value.ToString();
                this.textUpdateStuName.Text = dgvr.Cells[2].Value.ToString();
                if (dgvr.Cells[3].Value.ToString() == "男")
                {
                    this.rbUpdateSexBoy.Checked = true;
                }
                else
                {
                    this.rbUpdateSexGirl.Checked = true;
                }
                this.cboUpdateStuType.Text = dgvr.Cells[4].Value.ToString();
                this.textUpdateStuTell.Text = dgvr.Cells[5].Value.ToString();
                this.textUpdateStuAddress.Text = dgvr.Cells[6].Value.ToString();
                this.textUpdateStuEmail.Text = dgvr.Cells[7].Value.ToString();
            }
        } 
        #endregion

        #region 窗体加载
        private void StudentGuan_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet2.UserType”中。您可以根据需要移动或删除它。
            this.userTypeTableAdapter.Fill(this.libraryDataSet2.UserType);
            // TODO: 这行代码将数据加载到表“libraryDataSet.Students”中。您可以根据需要移动或删除它。
            this.studentsTableAdapter.Fill(this.libraryDataSet.Students);
            try
            {
                StudentDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
        #endregion

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region 修改非空验证
        //非空验证
        public bool CheckUpdate()
        {
            if (this.textUpdateStuName.Text.Trim() == "")
            {
                MessageBox.Show(INPUTNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textUpdateStuName.Focus();
                return false;
            }
            if (this.textUpdateStuPwd.Text.Trim() == "")
            {
                MessageBox.Show(INPUTPWD, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textUpdateStuPwd.Focus();
                return false;
            }
            if (this.textUpdateStuEmail.Text.Trim() == "")
            {
                MessageBox.Show(INPUTEMAIL, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textUpdateStuEmail.Focus();
                return false;
            }
            if (this.textUpdateStuTell.Text.Trim() == "")
            {
                MessageBox.Show(INPUTTELL, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textUpdateStuTell.Focus();
                return false;
            }
            if (!this.rbUpdateSexBoy.Checked && !this.rbUpdateSexGirl.Checked)
            {
                MessageBox.Show(INPUTSEX, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.rbUpdateSexBoy.Focus();
                return false;
            }
            if (this.cboUpdateStuType.Text.Trim() == "")
            {
                MessageBox.Show(INPUTSTUTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboUpdateStuType.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region 单击查询
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
        #endregion

        #region 单击返回
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 单击单元格在下方显示
        //单击单元格在下方显示
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 单击修改事件
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckUpdate())
                {
                    return;
                }
                string strSex = " ";
                if (this.rbUpdateSexBoy.Checked)
                {
                    strSex = "男";
                }
                else if (this.rbUpdateSexGirl.Checked)
                {
                    strSex = "女";
                }
                else
                {
                    return;
                }
                Students students = new Students();
                students.LoginId = Convert.ToInt32(this.textUpdateStuId.Text.Trim());
                students.LoginPwd = this.textUpdateStuPwd.Text.Trim();
                students.Name = this.textUpdateStuName.Text.Trim();
                students.Sex = strSex;
                students.UserType = this.cboUpdateStuType.Text.Trim();
                students.Tell = this.textUpdateStuTell.Text.Trim();
                students.Address = this.textUpdateStuAddress.Text.Trim();
                students.Email = this.textUpdateStuEmail.Text.Trim();

                int ret = new StudentsManager().UpdateStudent(students);
                if (ret > 0)
                {
                    MessageBox.Show(UPDATESUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(UPDATEFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 删
        //右键删除数据
        private void TsmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(ISDELETE,OPERATIONWARN,MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                if (dr==DialogResult.OK)
                {
                    string  iCellvalue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int ret = studentsManager.DeleteStudent(iCellvalue);
                    if (ret>0)
                    {
                        MessageBox.Show(DELETESUCCEED,OPERATIONWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        StudentDataBind();
                    }
                    else
                    {
                        MessageBox.Show(DELETEFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DELETEFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
        #endregion
    } 
}
