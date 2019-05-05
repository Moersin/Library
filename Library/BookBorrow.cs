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
    public partial class BookBorrow : Form
    {
        #region 常量、变量
        public const string INPUTWARN = "输入提示";
        public const string SELECTBOOK = "请选择书籍";
        public const string SELECTBORROWTIME = "请选择借阅时间";
        public const string INPUTBORROWSTUNAME = "请输入读者账号";
        public const string BORROWSUCCEED = "借阅成功";
        public const string BORROWFAILED = "借阅失败";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILSED = "操作失败";

        List<Books> booksList = new List<Books>();
        BookManager bm = new BookManager();
        #endregion
        public BookBorrow()
        {
            InitializeComponent();
        }

        #region 根据条件绑定书籍
        //根据条件绑定书籍
        public void BorrowDataBind()
        {
            List<Books> booksList = bm.GetBooksByName(this.textBorrowBookName.Text.Trim());
            this.dgvBorrow.DataSource = booksList;
        }
        #endregion

        #region 更新需要修改的数据
        //更新需要修改的数据
        public void SelectedData()
        {
            if (this.dgvBorrow.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = this.dgvBorrow.CurrentRow;
                this.tbBorrowBId.Text = dgvr.Cells[0].Value.ToString();
                this.tbBorrowBName.Text = dgvr.Cells[1].Value.ToString();
            }
        }
        #endregion

        private void BookBorrow_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet.Books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
            // TODO: 这行代码将数据加载到表“libraryDataSet.Iss”中。您可以根据需要移动或删除它。
            //this.issTableAdapter.Fill(this.libraryDataSet.Iss);
            try
            {
                BorrowDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBorrowQuery_Click(object sender, EventArgs e)
        {
            try
            {
                BorrowDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBorrowreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
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

        #region 非空验证
        //非空验证
        public bool CheckUpdate()
        {
            if (this.tbBorrowBId.Text.Trim() == "")
            {
                MessageBox.Show(SELECTBOOK, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbBorrowBId.Focus();
                return false;
            }
            if (this.tbBorrowBName.Text.Trim() == "")
            {
                MessageBox.Show(SELECTBOOK, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbBorrowBName.Focus();
                return false;
            }
            if (this.tbBorrowSId.Text.Trim() == "")
            {
                MessageBox.Show(INPUTBORROWSTUNAME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbBorrowSId.Focus();
                return false;
            }
            if (this.timeBorrow.Text.Trim() == "")
            {
                MessageBox.Show(SELECTBORROWTIME, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.timeBorrow.Focus();
                return false;
            }
            return true;
        }
        #endregion

        private void BtnBorrowSub_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (!CheckUpdate())
                {
                    return;
                }*/
                FormLogin formLogin = new FormLogin();
                this.tbBorrowSId.Text = formLogin.LoginId;
                //MessageBox.Show(FormLogin.LoginId);
                Iss iss = new Iss();
                iss.IssBookId = Convert.ToInt32(this.tbBorrowBId.Text.Trim());
                iss.IssBookName = this.tbBorrowBName.Text.Trim();
                //iss.IssUserId = Convert.ToInt32(formLogin.GetLoginId);
                iss.IssUserId = Convert.ToInt32(this.tbBorrowSId.Text.Trim());
                iss.IssBeginTime = Convert.ToDateTime(this.timeBorrow.Text.Trim());

                int ret = new IssManager().AddIss(iss);
                if (ret > 0)
                {
                    MessageBox.Show(BORROWSUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(BORROWFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TimeBorrow_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
