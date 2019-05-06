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
    
    public partial class BookReturn : Form
    {
        #region 常量、变量
        public const string SELECTBOOK = "请选择书籍";
        public const string INPUTRETURNSTUID = "请输入读者账号";
        public const string RETURNSUCCEED = "归还成功";
        public const string RETURNFAILED = "归还失败";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILSED = "操作失败";

        List<Iss> issList = new List<Iss>();
        IssManager im = new IssManager();
        #endregion
        public BookReturn()
        {
            InitializeComponent();
        }

        #region 根据条件绑定借阅信息
        //根据条件绑定
        public void IssDataBind()
        {
            List<Iss> issList = im.GetIssById(this.textBox1.Text.Trim());
            this.dataGridView1.DataSource = issList;
        }
        #endregion

        #region 更新需要修改的数据
        //更新需要修改的数据
        public void SelectedData()
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = this.dataGridView1.CurrentRow;
                this.tbIssId.Text = dgvr.Cells[0].Value.ToString();
                this.tbReturnBookId.Text = dgvr.Cells[2].Value.ToString();
                this.tbReturnBookName.Text = dgvr.Cells[3].Value.ToString();
                this.tbReturnUserId.Text = dgvr.Cells[4].Value.ToString();
                this.dtpBeginTime.Text = dgvr.Cells[5].Value.ToString();
                //this.dtpReturnEndTime.Text = dgvr.Cells[4].Value.ToString();
            }
        }
        #endregion

        private void BookReturn_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet.Iss”中。您可以根据需要移动或删除它。
            //this.issTableAdapter.Fill(this.libraryDataSet.Iss);
            try
            {
                this.textBox1.Text = Students.value;
                IssDataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //点击查询
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                IssDataBind();
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

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                Iss iss = new Iss();
                iss.IssBookId = Convert.ToInt32(this.tbReturnBookId.Text.Trim());
                iss.IssBookName = this.tbReturnBookName.Text.Trim();
                iss.IssUserId = Convert.ToInt32(this.tbReturnUserId.Text.Trim());
                iss.IssBeginTime = Convert.ToDateTime(this.dtpBeginTime.Text.Trim());
                iss.IssEndTime = this.dtpReturnEndTime.Text.Trim();
                iss.IssStatus = "已归还";
                iss.IssId= Convert.ToInt32(this.tbIssId.Text.Trim());

                int ret = new IssManager().UpdateIss(iss);
                if (ret > 0)
                {
                    MessageBox.Show(RETURNSUCCEED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IssDataBind();
                }
                else
                {
                    MessageBox.Show(RETURNFAILED, OPERATIONWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, OPERATIONFAILSED, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
