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
    public partial class UserTypeGuan : Form
    {
        public const string INPUTWARN = "输入提示";
        public const string INPUTUSERTYPE = "请输入用户类别";
        public const string QUERYSUCCEED = "查询成功";
        public const string QUERYFAILED = "查询失败";
        public const string UPDATESUCCEED = "修改成功";
        public const string UPDATEFAILED = "修改失败";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILSED = "操作失败";
        public const string DELETESUCCEED = "删除成功";
        public const string ISDELETE = "即将删除";
        public const string DELETEFAILED = "删除失败";
        public const string INSERTSUCCEED = "添加成功";
        public const string INSERTFAILED = "添加失败";

        List<uType> uTypes = new List<uType>();
        uTypeManager uTypeManager = new uTypeManager();

        public UserTypeGuan()
        {
            InitializeComponent();
        }

        //绑定data
        public void UserTypeDataBind()
        {
            List<uType> uTypeList = uTypeManager.GetuType(this.tbUserTypeQuery.Text.Trim());
            this.dataGridView1.DataSource = uTypeList;
        }

        //选择数据
        public void SelectedData()
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = this.dataGridView1.CurrentRow;
                this.tbUserTypeId.Text = dgvr.Cells[0].Value.ToString();
                this.tbUserTypeUpdate.Text = dgvr.Cells[1].Value.ToString();
            }
        }

        private void UserTypeGuan_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet2.UserType”中。您可以根据需要移动或删除它。
            this.userTypeTableAdapter.Fill(this.libraryDataSet2.UserType);
            try
            {
                UserTypeDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool CheckUpdate()
        {
            if (this.tbUserTypeUpdate.Text.Trim() == "")
            {
                MessageBox.Show(INPUTUSERTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbUserTypeUpdate.Focus();
                return false;
            }
            return true;
        }

        //非空验证
        public bool CheckInputNotEmpty()
        {
            if (this.tbUserTypeAdd.Text.Trim() == " ")
            {
                MessageBox.Show(INPUTUSERTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbUserTypeAdd.Focus();
                return false;
            }
            return true;
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                UserTypeDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               if (!CheckUpdate())
                {
                    return;
                }
                uType uType = new uType();
                uType.UTypeId = Convert.ToInt32(this.tbUserTypeId.Text.Trim());
                uType.UserType = this.tbUserTypeUpdate.Text.Trim();

                int ret = new uTypeManager().UpdateUserType(uType);
                if (ret > 0)
                {
                    MessageBox.Show(UPDATESUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserTypeDataBind();
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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(ISDELETE, OPERATIONWARN, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    string iCellvalue = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    int ret = uTypeManager.DeleteUserType(iCellvalue);
                    if (ret > 0)
                    {
                        MessageBox.Show(DELETESUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserTypeDataBind();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNotEmpty())
                {
                    return;
                }
                uType uType = new uType();
                uType.UserType = this.tbUserTypeAdd.Text.Trim();
                int ret = new uTypeManager().AddUserType(uType);
                if (ret > 0)
                {
                    MessageBox.Show(INSERTSUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserTypeDataBind();
                }
                else
                {
                    MessageBox.Show(INSERTFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
