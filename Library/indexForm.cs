using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class indexForm : Form
    {
        public indexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet.Iss”中。您可以根据需要移动或删除它。
            //this.issTableAdapter.Fill(this.libraryDataSet.Iss);

        }

        #region 退出
        //退出事件
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 读者添加事件
        //读者添加事件
        private void ToolStripButtonStuAdd_Click(object sender, EventArgs e)
        {
            StudentsAdd stuAdd = new StudentsAdd();
            stuAdd.MdiParent = this;
            stuAdd.Show();
        }
        #endregion

        //读者管理事件
        private void ToolStripButtonStuGuan_Click(object sender, EventArgs e)
        {
            StudentGuan studentGuan = new StudentGuan();
            studentGuan.MdiParent = this;
            studentGuan.Show();
        }

        //书籍添加事件
        private void ToolStripButtonBookAdd_Click(object sender, EventArgs e)
        {
            BookAdd bookAdd = new BookAdd();
            bookAdd.MdiParent = this;
            bookAdd.Show();
        }
        //书籍管理事件
        private void ToolStripButtonBookGuan_Click(object sender, EventArgs e)
        {
            BookGuan bookGuan = new BookGuan();
            bookGuan.MdiParent = this;
            bookGuan.Show();
        }

        private void ToolHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员");
        }

        //图书类别添加
        private void ToolStripButtonBookTypeAdd_Click(object sender, EventArgs e)
        {
            BookTypeAdd bookTypeAdd = new BookTypeAdd();
            bookTypeAdd.MdiParent = this;
            bookTypeAdd.Show();
        }

        //图书统计
        private void ToolStripButtonBookCount_Click(object sender, EventArgs e)
        {
            BookTong bookTong = new BookTong();
            bookTong.MdiParent = this;
            bookTong.Show();
        }

        //图书类别管理
        private void ToolStripBtnBookTypeG_Click(object sender, EventArgs e)
        {
            BookTypeGuan bookTypeGuan = new BookTypeGuan();
            bookTypeGuan.MdiParent = this;
            bookTypeGuan.Show();
        }

        //读者类别添加
        private void ToolStripBtnStuTypeAdd_Click(object sender, EventArgs e)
        {
            UserTypeAdd userTypeAdd = new UserTypeAdd();
            userTypeAdd.MdiParent = this;
            userTypeAdd.Show();
        }

        /// <summary>
        /// 读者类别管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripBtnStuTypeG_Click(object sender, EventArgs e)
        {
            UserTypeGuan userTypeGuan=new UserTypeGuan();
            userTypeGuan.MdiParent = this;
            userTypeGuan.Show();
        }
    }
}
