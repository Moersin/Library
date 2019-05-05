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
    public partial class UserTypeAdd : Form
    {
        public const string INPUTWARN = "输入提示";
        public const string INPUTBOOKTYPE = "请输入读者类别";
        public const string INSERTSUCCEED = "添加成功";
        public const string INSERTFAILED = "添加失败";
        public const string OPERATIONWARN = "操作提示";
        public const string OPERATIONFAILSED = "操作失败";
        public UserTypeAdd()
        {
            InitializeComponent();
        }

        //非空验证
        public bool CheckInputNotEmpty()
        {
            if (this.tbUserTypeAdd.Text.Trim() == " ")
            {
                MessageBox.Show(INPUTBOOKTYPE, INPUTWARN, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbUserTypeAdd.Focus();
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
                uType uType = new uType();
                uType.UserType = this.tbUserTypeAdd.Text.Trim();
                int ret = new uTypeManager().AddUserType(uType);
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

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
