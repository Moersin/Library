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
    public partial class indexFormStu : Form
    {
        public indexFormStu()
        {
            InitializeComponent();
        }

        private void IndexFormStu_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libraryDataSet.Books”中。您可以根据需要移动或删除它。
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
        }

        private void TsmHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员");
        }

        private void TsmExits_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void TsbBookBorrow_Click(object sender, EventArgs e)
        {
            BookBorrow bookBorrow = new BookBorrow();
            bookBorrow.MdiParent = this;
            bookBorrow.Show();
        }

        private void TsbBookReturn_Click(object sender, EventArgs e)
        {
            BookReturn bookReturn = new BookReturn();
            bookReturn.MdiParent = this;
            bookReturn.Show();
        }
        //定义一个全局变量获取登陆id和name
        /*private int uId = 0;
        private string uName = string.Empty;

        public int UId { get => uId; set => uId = value; }
        public string UName { get => uName; set => uName = value; }*/

    }
}
