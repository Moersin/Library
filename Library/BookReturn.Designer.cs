namespace Library
{
    partial class BookReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbReturnStuId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.issBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.issBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btReturn = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpBeginTime = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnEndTime = new System.Windows.Forms.DateTimePicker();
            this.tbReturnUserId = new System.Windows.Forms.TextBox();
            this.tbReturnBookName = new System.Windows.Forms.TextBox();
            this.tbIssId = new System.Windows.Forms.TextBox();
            this.tbReturnBookId = new System.Windows.Forms.TextBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.issBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issTableAdapter = new Library.LibraryDataSetTableAdapters.IssTableAdapter();
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issBookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issBookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issBeginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbReturnStuId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbReturnStuId
            // 
            this.tbReturnStuId.Location = new System.Drawing.Point(76, 27);
            this.tbReturnStuId.Name = "tbReturnStuId";
            this.tbReturnStuId.Size = new System.Drawing.Size(125, 21);
            this.tbReturnStuId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issId,
            this.issStatus,
            this.issBookIdDataGridViewTextBoxColumn,
            this.issBookNameDataGridViewTextBoxColumn,
            this.issUserIdDataGridViewTextBoxColumn,
            this.issBeginTimeDataGridViewTextBoxColumn,
            this.issEndTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.issBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(637, 158);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // issBindingSource1
            // 
            this.issBindingSource1.DataMember = "Iss";
            this.issBindingSource1.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btReturn);
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(436, 25);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(75, 23);
            this.btReturn.TabIndex = 2;
            this.btReturn.Text = "返回";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(325, 25);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "账号";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpBeginTime);
            this.groupBox3.Controls.Add(this.dtpReturnEndTime);
            this.groupBox3.Controls.Add(this.tbReturnUserId);
            this.groupBox3.Controls.Add(this.tbReturnBookName);
            this.groupBox3.Controls.Add(this.tbIssId);
            this.groupBox3.Controls.Add(this.tbReturnBookId);
            this.groupBox3.Controls.Add(this.btnReturnBook);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 117);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "还书";
            // 
            // dtpBeginTime
            // 
            this.dtpBeginTime.CustomFormat = "yyyy-MM-dd";
            this.dtpBeginTime.Enabled = false;
            this.dtpBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginTime.Location = new System.Drawing.Point(100, 59);
            this.dtpBeginTime.Name = "dtpBeginTime";
            this.dtpBeginTime.Size = new System.Drawing.Size(124, 21);
            this.dtpBeginTime.TabIndex = 5;
            // 
            // dtpReturnEndTime
            // 
            this.dtpReturnEndTime.CustomFormat = "yyyy-MM-dd";
            this.dtpReturnEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnEndTime.Location = new System.Drawing.Point(100, 90);
            this.dtpReturnEndTime.Name = "dtpReturnEndTime";
            this.dtpReturnEndTime.Size = new System.Drawing.Size(124, 21);
            this.dtpReturnEndTime.TabIndex = 5;
            // 
            // tbReturnUserId
            // 
            this.tbReturnUserId.Location = new System.Drawing.Point(316, 59);
            this.tbReturnUserId.Name = "tbReturnUserId";
            this.tbReturnUserId.ReadOnly = true;
            this.tbReturnUserId.Size = new System.Drawing.Size(100, 21);
            this.tbReturnUserId.TabIndex = 4;
            // 
            // tbReturnBookName
            // 
            this.tbReturnBookName.Location = new System.Drawing.Point(481, 20);
            this.tbReturnBookName.Name = "tbReturnBookName";
            this.tbReturnBookName.ReadOnly = true;
            this.tbReturnBookName.Size = new System.Drawing.Size(100, 21);
            this.tbReturnBookName.TabIndex = 4;
            // 
            // tbIssId
            // 
            this.tbIssId.Location = new System.Drawing.Point(100, 20);
            this.tbIssId.Name = "tbIssId";
            this.tbIssId.ReadOnly = true;
            this.tbIssId.Size = new System.Drawing.Size(112, 21);
            this.tbIssId.TabIndex = 4;
            // 
            // tbReturnBookId
            // 
            this.tbReturnBookId.Location = new System.Drawing.Point(316, 20);
            this.tbReturnBookId.Name = "tbReturnBookId";
            this.tbReturnBookId.ReadOnly = true;
            this.tbReturnBookId.Size = new System.Drawing.Size(100, 21);
            this.tbReturnBookId.TabIndex = 4;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(546, 85);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(75, 23);
            this.btnReturnBook.TabIndex = 3;
            this.btnReturnBook.Text = "还书";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "读者账号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "书名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "归还时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "借阅时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "借阅单号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "书籍编号";
            // 
            // issBindingSource
            // 
            this.issBindingSource.DataMember = "Iss";
            this.issBindingSource.DataSource = this.libraryDataSet;
            // 
            // issTableAdapter
            // 
            this.issTableAdapter.ClearBeforeFill = true;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // issId
            // 
            this.issId.DataPropertyName = "issId";
            this.issId.HeaderText = "借阅单号";
            this.issId.Name = "issId";
            this.issId.ReadOnly = true;
            // 
            // issStatus
            // 
            this.issStatus.DataPropertyName = "issStatus";
            this.issStatus.HeaderText = "借阅状态";
            this.issStatus.Name = "issStatus";
            this.issStatus.ReadOnly = true;
            // 
            // issBookIdDataGridViewTextBoxColumn
            // 
            this.issBookIdDataGridViewTextBoxColumn.DataPropertyName = "issBookId";
            this.issBookIdDataGridViewTextBoxColumn.HeaderText = "书籍编号";
            this.issBookIdDataGridViewTextBoxColumn.Name = "issBookIdDataGridViewTextBoxColumn";
            this.issBookIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issBookNameDataGridViewTextBoxColumn
            // 
            this.issBookNameDataGridViewTextBoxColumn.DataPropertyName = "issBookName";
            this.issBookNameDataGridViewTextBoxColumn.HeaderText = "书名";
            this.issBookNameDataGridViewTextBoxColumn.Name = "issBookNameDataGridViewTextBoxColumn";
            this.issBookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issUserIdDataGridViewTextBoxColumn
            // 
            this.issUserIdDataGridViewTextBoxColumn.DataPropertyName = "issUserId";
            this.issUserIdDataGridViewTextBoxColumn.HeaderText = "读者账号";
            this.issUserIdDataGridViewTextBoxColumn.Name = "issUserIdDataGridViewTextBoxColumn";
            this.issUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issBeginTimeDataGridViewTextBoxColumn
            // 
            this.issBeginTimeDataGridViewTextBoxColumn.DataPropertyName = "issBeginTime";
            this.issBeginTimeDataGridViewTextBoxColumn.HeaderText = "借阅时间";
            this.issBeginTimeDataGridViewTextBoxColumn.Name = "issBeginTimeDataGridViewTextBoxColumn";
            this.issBeginTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issEndTimeDataGridViewTextBoxColumn
            // 
            this.issEndTimeDataGridViewTextBoxColumn.DataPropertyName = "issEndTime";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.issEndTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.issEndTimeDataGridViewTextBoxColumn.HeaderText = "归还时间";
            this.issEndTimeDataGridViewTextBoxColumn.Name = "issEndTimeDataGridViewTextBoxColumn";
            this.issEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 382);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookReturn";
            this.Text = "图书归还";
            this.Load += new System.EventHandler(this.BookReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbReturnStuId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource issBindingSource;
        private LibraryDataSetTableAdapters.IssTableAdapter issTableAdapter;
        private System.Windows.Forms.BindingSource issBindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReturnUserId;
        private System.Windows.Forms.TextBox tbReturnBookName;
        private System.Windows.Forms.TextBox tbReturnBookId;
        private System.Windows.Forms.DateTimePicker dtpReturnEndTime;
        private System.Windows.Forms.DateTimePicker dtpBeginTime;
        private System.Windows.Forms.TextBox tbIssId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource issBindingSource2;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn issId;
        private System.Windows.Forms.DataGridViewTextBoxColumn issStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn issBookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issBookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issBeginTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issEndTimeDataGridViewTextBoxColumn;
    }
}