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
    public partial class BookGuan : Form
    {
        #region 常量、变量
        public const string INPUTWARN = "输入提示";
        public const string INPUTBOOKID = "请输入编号";
        public const string INPUTBOOKNAME = "请输入书名";
        public const string INPUTBOOKTYPE = "请选择类型";
        public const string INPUTBOOKAUTHOR = "请输入作者";
        public const string INPUTBOOKPUBLISH = "请输入出版社";
        public const string QUERYSUCCEED = "查询成功";
        public const string QUERYFAILED = "查询失败";
        public const string UPDATESUCCEED = "修改成功";
        public const string UPDATEFAILED = "修改失败";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILSED = "操作失败";
        public const string DELETESUCCEED = "删除成功";
        public const string ISDELETE = "即将删除";
        public const string DELETEFAILED = "删除失败";

        List<Books> booksList = new List<Books>();
        BookManager bm = new BookManager();
        #endregion

        public BookGuan()
        {
            InitializeComponent();
        }

        #region 根据条件绑定书籍
        //根据条件绑定书籍
        public void BookDataBind()
        {
            List<Books> booksList = bm.GetBooksByNameAndType(this.textQueryBookName.Text.Trim(),this.cboQueryBooktype.Text.Trim());
            this.dataGridView1.DataSource = booksList;
        }
        #endregion

        #region 更新需要修改的数据
        //更新需要修改的数据
        public void SelectedData()
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = this.dataGridView1.CurrentRow;
                this.textUpdateBookId.Text = dgvr.Cells[0].Value.ToString();
                this.textUpdateBookName.Text = dgvr.Cells[1].Value.ToString();
                this.cboUpdateBookType.Text = dgvr.Cells[2].Value.ToString();
                this.textUpdateBookAuthor.Text = dgvr.Cells[3].Value.ToString();
                this.textUpdatebookPublish.Text = dgvr.Cells[4].Value.ToString();
            }
        }
        #endregion

        private void BookGuan_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet1.BookType”中。您可以根据需要移动或删除它。
            this.bookTypeTableAdapter.Fill(this.libraryDataSet1.BookType);
            // TODO: 这行代码将数据加载到表“libraryDataSet.Books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
            try
            {
                BookDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region 修改非空验证
        //非空验证
        public bool CheckUpdate()
        {
            if (this.textUpdateBookId.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKID, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textUpdateBookId.Focus();
                return false;
            }
            if (this.textUpdateBookName.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textUpdateBookName.Focus();
                return false;
            }
            if (this.cboUpdateBookType.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboUpdateBookType.Focus();
                return false;
            }
            if (this.textUpdateBookAuthor.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKAUTHOR, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textUpdateBookAuthor.Focus();
                return false;
            }
            if (this.textUpdatebookPublish.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKPUBLISH, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textUpdatebookPublish.Focus();
                return false;
            }
            return true;
        }
        #endregion

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                BookDataBind();
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckUpdate())
                {
                    return;
                }
                Books books = new Books();
                books.BookId = Convert.ToInt32(this.textUpdateBookId.Text.Trim());
                books.BookName = this.textUpdateBookName.Text.Trim();
                books.BookType = this.cboUpdateBookType.Text.Trim();
                books.BookAuthor = this.textUpdateBookAuthor.Text.Trim();
                books.BookPublish = this.textUpdatebookPublish.Text.Trim();

                int ret = new BookManager().UpdateBook(books);
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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(ISDELETE, OPERATIONWARN, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    string iCellvalue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int ret = bm.DeleteBook(iCellvalue);
                    if (ret > 0)
                    {
                        MessageBox.Show(DELETESUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BookDataBind();
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
    }
}
