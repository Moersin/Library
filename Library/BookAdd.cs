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
    public partial class BookAdd : Form
    {
        #region 常量/变量
        public const string INPUTBOOKID = "请输入书籍编号";
        public const string INPUTBOOKNAME = "请输入书名";
        public const string INPUTBOOKTYPE = "请选择书籍的类型";
        public const string INPUTBOOKAUTHOR = "请输入作者";
        public const string INPUTBOOKPUBLISH = "请输入出版社";
        public const string INSERTSUCCEED = "添加成功";
        public const string INSERTFAILED = "添加失败";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILED = "操作失败";

        List<Books> books = new List<Books>();
        BookManager bm = new BookManager();
        #endregion

        public BookAdd()
        {
            InitializeComponent();
        }

        #region 非空验证
        public bool CheckInputNotEmpty()
        {
            if (this.textBookId.Text.Trim()=="")
            {
                MessageBox.Show(INPUTBOOKID,OPERATIONWARN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.textBookId.Focus();
                return false;
            }
            if (this.textBookName.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKNAME, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBookName.Focus();
                return false;
            }
            if (this.textBookAuthor.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKAUTHOR, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBookAuthor.Focus();
                return false;
            }
            if (this.textBookPublish.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKPUBLISH, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBookPublish.Focus();
                return false;
            }
            if (this.comboBookType.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBOOKTYPE, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.comboBookType.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region 点击添加事件
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputNotEmpty())
                {
                    return;
                }
                Books books = new Books();
                books.BookId = Convert.ToInt32(this.textBookId.Text.Trim());
                books.BookName = this.textBookName.Text.Trim();
                books.BookType = this.comboBookType.Text.Trim();
                books.BookAuthor = this.textBookAuthor.Text.Trim();
                books.BookPublish = this.textBookPublish.Text.Trim();

                int ret = new BookManager().AddBook(books);
                if (ret>0)
                {
                    MessageBox.Show(INSERTSUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(INSERTFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 点击返回事件
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void BookAdd_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet1.BookType”中。您可以根据需要移动或删除它。
            this.bookTypeTableAdapter.Fill(this.libraryDataSet1.BookType);

        }
    }
}
