namespace Library
{
    partial class StudentGuan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textQueryStuName = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboQueryStuType = new System.Windows.Forms.ComboBox();
            this.userTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet2 = new Library.LibraryDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.studentsTableAdapter = new Library.LibraryDataSetTableAdapters.StudentsTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbUpdateSexBoy = new System.Windows.Forms.RadioButton();
            this.rbUpdateSexGirl = new System.Windows.Forms.RadioButton();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboUpdateStuType = new System.Windows.Forms.ComboBox();
            this.userTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textUpdateStuTell = new System.Windows.Forms.TextBox();
            this.textUpdateStuEmail = new System.Windows.Forms.TextBox();
            this.textUpdateStuPwd = new System.Windows.Forms.TextBox();
            this.textUpdateStuAddress = new System.Windows.Forms.TextBox();
            this.textUpdateStuName = new System.Windows.Forms.TextBox();
            this.textUpdateStuId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userTypeTableAdapter = new Library.LibraryDataSet2TableAdapters.UserTypeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textQueryStuName);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboQueryStuType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // textQueryStuName
            // 
            this.textQueryStuName.Location = new System.Drawing.Point(276, 28);
            this.textQueryStuName.Name = "textQueryStuName";
            this.textQueryStuName.Size = new System.Drawing.Size(100, 21);
            this.textQueryStuName.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(463, 26);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            // 
            // cboQueryStuType
            // 
            this.cboQueryStuType.DataSource = this.userTypeBindingSource;
            this.cboQueryStuType.DisplayMember = "userType";
            this.cboQueryStuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQueryStuType.FormattingEnabled = true;
            this.cboQueryStuType.Location = new System.Drawing.Point(76, 26);
            this.cboQueryStuType.Name = "cboQueryStuType";
            this.cboQueryStuType.Size = new System.Drawing.Size(121, 20);
            this.cboQueryStuType.TabIndex = 3;
            this.cboQueryStuType.ValueMember = "userType";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者类别";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginIdDataGridViewTextBoxColumn,
            this.loginPwd,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.tellDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(574, 161);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // loginIdDataGridViewTextBoxColumn
            // 
            this.loginIdDataGridViewTextBoxColumn.DataPropertyName = "loginId";
            this.loginIdDataGridViewTextBoxColumn.HeaderText = "账号";
            this.loginIdDataGridViewTextBoxColumn.Name = "loginIdDataGridViewTextBoxColumn";
            this.loginIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // loginPwd
            // 
            this.loginPwd.DataPropertyName = "loginPwd";
            this.loginPwd.HeaderText = "密码";
            this.loginPwd.Name = "loginPwd";
            this.loginPwd.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "类型";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tellDataGridViewTextBoxColumn
            // 
            this.tellDataGridViewTextBoxColumn.DataPropertyName = "tell";
            this.tellDataGridViewTextBoxColumn.HeaderText = "联系方式";
            this.tellDataGridViewTextBoxColumn.Name = "tellDataGridViewTextBoxColumn";
            this.tellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "家庭地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "电子邮件";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmDelete.Text = "删除";
            this.tsmDelete.Click += new System.EventHandler(this.TsmDelete_Click);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btnReturn);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.cboUpdateStuType);
            this.groupBox2.Controls.Add(this.textUpdateStuTell);
            this.groupBox2.Controls.Add(this.textUpdateStuEmail);
            this.groupBox2.Controls.Add(this.textUpdateStuPwd);
            this.groupBox2.Controls.Add(this.textUpdateStuAddress);
            this.groupBox2.Controls.Add(this.textUpdateStuName);
            this.groupBox2.Controls.Add(this.textUpdateStuId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUpdateSexBoy);
            this.panel1.Controls.Add(this.rbUpdateSexGirl);
            this.panel1.Location = new System.Drawing.Point(393, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 25);
            this.panel1.TabIndex = 5;
            // 
            // rbUpdateSexBoy
            // 
            this.rbUpdateSexBoy.AutoSize = true;
            this.rbUpdateSexBoy.Checked = true;
            this.rbUpdateSexBoy.Location = new System.Drawing.Point(15, 5);
            this.rbUpdateSexBoy.Name = "rbUpdateSexBoy";
            this.rbUpdateSexBoy.Size = new System.Drawing.Size(35, 16);
            this.rbUpdateSexBoy.TabIndex = 2;
            this.rbUpdateSexBoy.TabStop = true;
            this.rbUpdateSexBoy.Text = "男";
            this.rbUpdateSexBoy.UseVisualStyleBackColor = true;
            // 
            // rbUpdateSexGirl
            // 
            this.rbUpdateSexGirl.AutoSize = true;
            this.rbUpdateSexGirl.Location = new System.Drawing.Point(65, 5);
            this.rbUpdateSexGirl.Name = "rbUpdateSexGirl";
            this.rbUpdateSexGirl.Size = new System.Drawing.Size(35, 16);
            this.rbUpdateSexGirl.TabIndex = 2;
            this.rbUpdateSexGirl.Text = "女";
            this.rbUpdateSexGirl.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(462, 106);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(353, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cboUpdateStuType
            // 
            this.cboUpdateStuType.DataSource = this.userTypeBindingSource1;
            this.cboUpdateStuType.DisplayMember = "userType";
            this.cboUpdateStuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateStuType.FormattingEnabled = true;
            this.cboUpdateStuType.Location = new System.Drawing.Point(198, 65);
            this.cboUpdateStuType.Name = "cboUpdateStuType";
            this.cboUpdateStuType.Size = new System.Drawing.Size(121, 20);
            this.cboUpdateStuType.TabIndex = 3;
            this.cboUpdateStuType.ValueMember = "userType";
            // 
            // userTypeBindingSource1
            // 
            this.userTypeBindingSource1.DataMember = "UserType";
            this.userTypeBindingSource1.DataSource = this.libraryDataSet2;
            // 
            // textUpdateStuTell
            // 
            this.textUpdateStuTell.Location = new System.Drawing.Point(393, 65);
            this.textUpdateStuTell.Name = "textUpdateStuTell";
            this.textUpdateStuTell.Size = new System.Drawing.Size(100, 21);
            this.textUpdateStuTell.TabIndex = 1;
            // 
            // textUpdateStuEmail
            // 
            this.textUpdateStuEmail.Location = new System.Drawing.Point(198, 108);
            this.textUpdateStuEmail.Name = "textUpdateStuEmail";
            this.textUpdateStuEmail.Size = new System.Drawing.Size(100, 21);
            this.textUpdateStuEmail.TabIndex = 1;
            // 
            // textUpdateStuPwd
            // 
            this.textUpdateStuPwd.Location = new System.Drawing.Point(198, 24);
            this.textUpdateStuPwd.Name = "textUpdateStuPwd";
            this.textUpdateStuPwd.Size = new System.Drawing.Size(100, 21);
            this.textUpdateStuPwd.TabIndex = 1;
            // 
            // textUpdateStuAddress
            // 
            this.textUpdateStuAddress.Location = new System.Drawing.Point(51, 108);
            this.textUpdateStuAddress.Name = "textUpdateStuAddress";
            this.textUpdateStuAddress.Size = new System.Drawing.Size(100, 21);
            this.textUpdateStuAddress.TabIndex = 1;
            // 
            // textUpdateStuName
            // 
            this.textUpdateStuName.Location = new System.Drawing.Point(51, 65);
            this.textUpdateStuName.Name = "textUpdateStuName";
            this.textUpdateStuName.Size = new System.Drawing.Size(100, 21);
            this.textUpdateStuName.TabIndex = 1;
            // 
            // textUpdateStuId
            // 
            this.textUpdateStuId.Location = new System.Drawing.Point(51, 24);
            this.textUpdateStuId.Name = "textUpdateStuId";
            this.textUpdateStuId.Size = new System.Drawing.Size(100, 21);
            this.textUpdateStuId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "联系方式";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "类型";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "邮件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "账号";
            // 
            // userTypeTableAdapter
            // 
            this.userTypeTableAdapter.ClearBeforeFill = true;
            // 
            // StudentGuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentGuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读者管理";
            this.Load += new System.EventHandler(this.StudentGuan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textQueryStuName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private LibraryDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboUpdateStuType;
        private System.Windows.Forms.RadioButton rbUpdateSexGirl;
        private System.Windows.Forms.RadioButton rbUpdateSexBoy;
        private System.Windows.Forms.TextBox textUpdateStuTell;
        private System.Windows.Forms.TextBox textUpdateStuEmail;
        private System.Windows.Forms.TextBox textUpdateStuPwd;
        private System.Windows.Forms.TextBox textUpdateStuAddress;
        private System.Windows.Forms.TextBox textUpdateStuName;
        private System.Windows.Forms.TextBox textUpdateStuId;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboQueryStuType;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private LibraryDataSet2 libraryDataSet2;
        private System.Windows.Forms.BindingSource userTypeBindingSource;
        private LibraryDataSet2TableAdapters.UserTypeTableAdapter userTypeTableAdapter;
        private System.Windows.Forms.BindingSource userTypeBindingSource1;
    }
}