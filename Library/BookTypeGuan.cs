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
    public partial class BookTypeGuan : Form
    {
        public const string INPUTWARN = "输入提示";
        public const string INPUTBOOKTYPE = "请输入书籍类别";
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

        List<bType> bTypes = new List<bType>();
        bTypeManager bTypeManager = new bTypeManager();
        public BookTypeGuan()
        {
            InitializeComponent();
        }

        //非空验证
        public bool CheckInputNotEmpty()
        {
            if (this.tbBookTypeAdd.Text.Trim() == " ")
            {
                MessageBox.Show(INPUTBOOKTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbBookTypeAdd.Focus();
                return false;
            }
            return true;
        }

        //绑定data
        public void BookTypeDataBind()
        {
            List<bType> bTypeList = bTypeManager.GetbType(this.tbBookTypeQuery.Text.Trim());
            this.dataGridView1.DataSource = bTypeList;
        }

        //选择数据
        public void SelectedData()
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = this.dataGridView1.CurrentRow;
                this.tbBookTypeId.Text = dgvr.Cells[0].Value.ToString();
                this.tbBookTypeUpdate.Text = dgvr.Cells[1].Value.ToString();
            }
        }

        //窗体加载
        private void BookTypeGuan_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet1.BookType”中。您可以根据需要移动或删除它。
            this.bookTypeTableAdapter.Fill(this.libraryDataSet1.BookType);
            try
            {
                BookTypeDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool CheckUpdate()
        {
            if (this.tbBookTypeUpdate.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbBookTypeUpdate.Focus();
                return false;
            }
            return true;
        }

        //单击查询
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                BookTypeDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //单击单元格在下方显示
        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        //单击修改事件
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckUpdate())
                {
                    return;
                }
                bType bType = new bType();
                bType.BTypeId= Convert.ToInt32(this.tbBookTypeId.Text.Trim());
                bType.BookType = this.tbBookTypeUpdate.Text.Trim();

                int ret = new bTypeManager().UpdateBookType(bType);
                if (ret > 0)
                {
                    BookTypeDataBind();
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

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //右键删除数据
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(ISDELETE, OPERATIONWARN, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    string iCellvalue = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    int ret = bTypeManager.DeleteBookType(iCellvalue);
                    if (ret > 0)
                    {
                        MessageBox.Show(DELETESUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BookTypeDataBind();
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
                bType bType = new bType();
                bType.BookType = this.tbBookTypeAdd.Text.Trim();
                int ret = new bTypeManager().AddBookType(bType);
                if (ret > 0)
                {
                    BookTypeDataBind();
                    MessageBox.Show(INSERTSUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
