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
using System.Windows.Forms.DataVisualization.Charting;

namespace Library
{
    public partial class BookTong : Form
    {
        public const string INPUTWARN = "输入提示";
        public const string INPUTUSERTYPE = "请选择书籍类别";
        public const string QUERYSUCCEED = "查询成功";
        public const string QUERYFAILED = "此类书没有被借阅";
        public const string QUERYFAILEDTIME = "此时间段内不存在借阅记录";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILSED = "操作失败";

        int NumByType = 0;
        int NumByTime = 0;
        int NumById = 0;
        List<Books> books = new List<Books>();
        BookManager bm = new BookManager();
        IssManager im = new IssManager();

        public BookTong()
        {
            InitializeComponent();
        }

        private void BookTong_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet3.bookNum”中。您可以根据需要移动或删除它。
            this.bookNumTableAdapter.Fill(this.libraryDataSet3.bookNum);
            // TODO: 这行代码将数据加载到表“libraryDataSet.Books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
            // TODO: 这行代码将数据加载到表“libraryDataSet1.BookType”中。您可以根据需要移动或删除它。
            this.bookTypeTableAdapter.Fill(this.libraryDataSet1.BookType);

        }

        private void BtnNumByType_Click(object sender, EventArgs e)
        {
            try
            {
                NumByType = bm.QueryNumByType(this.cboBookType.Text.Trim());
                if (NumByType > 0)
                {
                    this.tbNumBytype.Text = Convert.ToString(NumByType);
                }
                else
                {
                    MessageBox.Show(QUERYFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnNumByTime_Click(object sender, EventArgs e)
        {
            try
            {
                NumByTime = im.QueryNumByTime(Convert.ToDateTime(this.dtpBorrowTime.Text.Trim()), Convert.ToDateTime(this.dtpReturnTime.Text.Trim()));
                if (NumByTime > 0)
                {
                    this.tbBookNum.Text = Convert.ToString(NumByTime);
                }
                else
                {
                    MessageBox.Show(QUERYFAILEDTIME, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnByUserName_Click(object sender, EventArgs e)
        {
            try
            {
                NumById = im.QueryNumByUserId(Convert.ToInt32(this.tbUserId.Text.Trim()));
                if (NumById > 0)
                {
                    this.tbNumByUserid.Text = Convert.ToString(NumById);
                }
                else
                {
                    MessageBox.Show(QUERYFAILEDTIME, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
