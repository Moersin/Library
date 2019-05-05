namespace Library
{
    partial class StudentsAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textStudentId = new System.Windows.Forms.TextBox();
            this.textStudentPwd = new System.Windows.Forms.TextBox();
            this.textStudentName = new System.Windows.Forms.TextBox();
            this.textStudentTell = new System.Windows.Forms.TextBox();
            this.textStudentAddress = new System.Windows.Forms.TextBox();
            this.textStudentEmail = new System.Windows.Forms.TextBox();
            this.comboStudentType = new System.Windows.Forms.ComboBox();
            this.userTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet2 = new Library.LibraryDataSet2();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.radioBtnF = new System.Windows.Forms.RadioButton();
            this.radioBtnM = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userTypeTableAdapter = new Library.LibraryDataSet2TableAdapters.UserTypeTableAdapter();
            this.userTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "账号密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓    名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "性    别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "读者类别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "联系方式";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "家庭住址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "电子邮件";
            // 
            // textStudentId
            // 
            this.textStudentId.Location = new System.Drawing.Point(88, 28);
            this.textStudentId.Name = "textStudentId";
            this.textStudentId.Size = new System.Drawing.Size(124, 21);
            this.textStudentId.TabIndex = 1;
            // 
            // textStudentPwd
            // 
            this.textStudentPwd.Location = new System.Drawing.Point(88, 63);
            this.textStudentPwd.Name = "textStudentPwd";
            this.textStudentPwd.PasswordChar = '*';
            this.textStudentPwd.Size = new System.Drawing.Size(124, 21);
            this.textStudentPwd.TabIndex = 1;
            // 
            // textStudentName
            // 
            this.textStudentName.Location = new System.Drawing.Point(88, 98);
            this.textStudentName.Name = "textStudentName";
            this.textStudentName.Size = new System.Drawing.Size(124, 21);
            this.textStudentName.TabIndex = 1;
            // 
            // textStudentTell
            // 
            this.textStudentTell.Location = new System.Drawing.Point(88, 211);
            this.textStudentTell.Name = "textStudentTell";
            this.textStudentTell.Size = new System.Drawing.Size(124, 21);
            this.textStudentTell.TabIndex = 1;
            // 
            // textStudentAddress
            // 
            this.textStudentAddress.Location = new System.Drawing.Point(88, 250);
            this.textStudentAddress.Name = "textStudentAddress";
            this.textStudentAddress.Size = new System.Drawing.Size(124, 21);
            this.textStudentAddress.TabIndex = 1;
            // 
            // textStudentEmail
            // 
            this.textStudentEmail.Location = new System.Drawing.Point(88, 288);
            this.textStudentEmail.Name = "textStudentEmail";
            this.textStudentEmail.Size = new System.Drawing.Size(124, 21);
            this.textStudentEmail.TabIndex = 1;
            // 
            // comboStudentType
            // 
            this.comboStudentType.DataSource = this.userTypeBindingSource1;
            this.comboStudentType.DisplayMember = "userType";
            this.comboStudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStudentType.FormattingEnabled = true;
            this.comboStudentType.Location = new System.Drawing.Point(88, 171);
            this.comboStudentType.Name = "comboStudentType";
            this.comboStudentType.Size = new System.Drawing.Size(121, 20);
            this.comboStudentType.TabIndex = 2;
            this.comboStudentType.ValueMember = "userType";
            // 
            // userTypeBindingSource
            // 
            this.userTypeBindingSource.DataMember = "UserType";
            this.userTypeBindingSource.DataSource = this.libraryDataSet2;
            // 
            // libraryDataSet2
            // 
            this.libraryDataSet2.DataSetName = "LibraryDataSet2";
            this.libraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(146, 354);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // radioBtnF
            // 
            this.radioBtnF.AutoSize = true;
            this.radioBtnF.Checked = true;
            this.radioBtnF.Location = new System.Drawing.Point(3, 9);
            this.radioBtnF.Name = "radioBtnF";
            this.radioBtnF.Size = new System.Drawing.Size(35, 16);
            this.radioBtnF.TabIndex = 4;
            this.radioBtnF.TabStop = true;
            this.radioBtnF.Text = "男";
            this.radioBtnF.UseVisualStyleBackColor = true;
            // 
            // radioBtnM
            // 
            this.radioBtnM.AutoSize = true;
            this.radioBtnM.Location = new System.Drawing.Point(58, 9);
            this.radioBtnM.Name = "radioBtnM";
            this.radioBtnM.Size = new System.Drawing.Size(35, 16);
            this.radioBtnM.TabIndex = 4;
            this.radioBtnM.Text = "女";
            this.radioBtnM.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnF);
            this.panel1.Controls.Add(this.radioBtnM);
            this.panel1.Location = new System.Drawing.Point(91, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 28);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // userTypeTableAdapter
            // 
            this.userTypeTableAdapter.ClearBeforeFill = true;
            // 
            // userTypeBindingSource1
            // 
            this.userTypeBindingSource1.DataMember = "UserType";
            this.userTypeBindingSource1.DataSource = this.libraryDataSet2;
            // 
            // StudentsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.textStudentName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboStudentType);
            this.Controls.Add(this.textStudentEmail);
            this.Controls.Add(this.textStudentAddress);
            this.Controls.Add(this.textStudentTell);
            this.Controls.Add(this.textStudentPwd);
            this.Controls.Add(this.textStudentId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读者添加";
            this.Load += new System.EventHandler(this.StudentsAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textStudentId;
        private System.Windows.Forms.TextBox textStudentPwd;
        private System.Windows.Forms.TextBox textStudentName;
        private System.Windows.Forms.TextBox textStudentTell;
        private System.Windows.Forms.TextBox textStudentAddress;
        private System.Windows.Forms.TextBox textStudentEmail;
        private System.Windows.Forms.ComboBox comboStudentType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.RadioButton radioBtnF;
        private System.Windows.Forms.RadioButton radioBtnM;
        private System.Windows.Forms.Panel panel1;
        private LibraryDataSet2 libraryDataSet2;
        private System.Windows.Forms.BindingSource userTypeBindingSource;
        private LibraryDataSet2TableAdapters.UserTypeTableAdapter userTypeTableAdapter;
        private System.Windows.Forms.BindingSource userTypeBindingSource1;
    }
}