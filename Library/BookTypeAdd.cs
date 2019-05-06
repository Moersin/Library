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
    public partial class BookTypeAdd : Form
    {
        public const string INPUTWARN = "输入提示";
        public const string INPUTBOOKTYPE = "请输入书籍类别";
        public const string INSERTSUCCEED = "添加成功";
        public const string INSERTFAILED = "添加失败";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILSED = "操作失败";

        public BookTypeAdd()
        {
            InitializeComponent();
        }

        //非空验证
        public bool CheckInputNotEmpty()
        {
            if (this.tbBookTypeAdd.Text.Trim()==" ")
            {
                MessageBox.Show(INPUTBOOKTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbBookTypeAdd.Focus();
                return false;
            }
            return true;
        }

        //添加
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

        //返回
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbBookTypeAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
