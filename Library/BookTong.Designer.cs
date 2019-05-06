namespace Library
{
    partial class BookTong
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
            this.btnNumByType = new System.Windows.Forms.Button();
            this.tbNumBytype = new System.Windows.Forms.TextBox();
            this.cboBookType = new System.Windows.Forms.ComboBox();
            this.bookTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new Library.LibraryDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookTypeTableAdapter = new Library.LibraryDataSet1TableAdapters.BookTypeTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpReturnTime = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrowTime = new System.Windows.Forms.DateTimePicker();
            this.tbBookNum = new System.Windows.Forms.TextBox();
            this.btnNumByTime = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.tbNumByUserid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnByUserName = new System.Windows.Forms.Button();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.booksTableAdapter = new Library.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.bookNumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet3 = new Library.LibraryDataSet3();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookNumTableAdapter = new Library.LibraryDataSet3TableAdapters.bookNumTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNumByType);
            this.groupBox1.Controls.Add(this.tbNumBytype);
            this.groupBox1.Controls.Add(this.cboBookType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "每种类别有几本书";
            // 
            // btnNumByType
            // 
            this.btnNumByType.Location = new System.Drawing.Point(226, 48);
            this.btnNumByType.Name = "btnNumByType";
            this.btnNumByType.Size = new System.Drawing.Size(75, 23);
            this.btnNumByType.TabIndex = 3;
            this.btnNumByType.Text = "查询";
            this.btnNumByType.UseVisualStyleBackColor = true;
            this.btnNumByType.Click += new System.EventHandler(this.BtnNumByType_Click);
            // 
            // tbNumBytype
            // 
            this.tbNumBytype.Location = new System.Drawing.Point(50, 73);
            this.tbNumBytype.Name = "tbNumBytype";
            this.tbNumBytype.ReadOnly = true;
            this.tbNumBytype.Size = new System.Drawing.Size(69, 21);
            this.tbNumBytype.TabIndex = 2;
            // 
            // cboBookType
            // 
            this.cboBookType.DataSource = this.bookTypeBindingSource;
            this.cboBookType.DisplayMember = "bookType";
            this.cboBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookType.FormattingEnabled = true;
            this.cboBookType.Location = new System.Drawing.Point(50, 35);
            this.cboBookType.Name = "cboBookType";
            this.cboBookType.Size = new System.Drawing.Size(109, 20);
            this.cboBookType.TabIndex = 1;
            this.cboBookType.ValueMember = "bookType";
            // 
            // bookTypeBindingSource
            // 
            this.bookTypeBindingSource.DataMember = "BookType";
            this.bookTypeBindingSource.DataSource = this.libraryDataSet1;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别";
            // 
            // bookTypeTableAdapter
            // 
            this.bookTypeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpReturnTime);
            this.groupBox2.Controls.Add(this.dtpBorrowTime);
            this.groupBox2.Controls.Add(this.tbBookNum);
            this.groupBox2.Controls.Add(this.btnNumByTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "时间段内借出书的数量";
            // 
            // dtpReturnTime
            // 
            this.dtpReturnTime.CustomFormat = "yyyy-MM-dd";
            this.dtpReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnTime.Location = new System.Drawing.Point(223, 26);
            this.dtpReturnTime.Name = "dtpReturnTime";
            this.dtpReturnTime.Size = new System.Drawing.Size(87, 21);
            this.dtpReturnTime.TabIndex = 7;
            // 
            // dtpBorrowTime
            // 
            this.dtpBorrowTime.CustomFormat = "yyyy-MM-dd";
            this.dtpBorrowTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrowTime.Location = new System.Drawing.Point(65, 26);
            this.dtpBorrowTime.Name = "dtpBorrowTime";
            this.dtpBorrowTime.Size = new System.Drawing.Size(87, 21);
            this.dtpBorrowTime.TabIndex = 6;
            // 
            // tbBookNum
            // 
            this.tbBookNum.Location = new System.Drawing.Point(71, 66);
            this.tbBookNum.Name = "tbBookNum";
            this.tbBookNum.ReadOnly = true;
            this.tbBookNum.Size = new System.Drawing.Size(69, 21);
            this.tbBookNum.TabIndex = 5;
            // 
            // btnNumByTime
            // 
            this.btnNumByTime.Location = new System.Drawing.Point(226, 64);
            this.btnNumByTime.Name = "btnNumByTime";
            this.btnNumByTime.Size = new System.Drawing.Size(75, 23);
            this.btnNumByTime.TabIndex = 4;
            this.btnNumByTime.Text = "查询";
            this.btnNumByTime.UseVisualStyleBackColor = true;
            this.btnNumByTime.Click += new System.EventHandler(this.BtnNumByTime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "归还时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "借出时间";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbUserId);
            this.groupBox3.Controls.Add(this.tbNumByUserid);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnByUserName);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "读者借书数量";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(71, 31);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(100, 21);
            this.tbUserId.TabIndex = 9;
            // 
            // tbNumByUserid
            // 
            this.tbNumByUserid.Location = new System.Drawing.Point(226, 31);
            this.tbNumByUserid.Name = "tbNumByUserid";
            this.tbNumByUserid.ReadOnly = true;
            this.tbNumByUserid.Size = new System.Drawing.Size(69, 21);
            this.tbNumByUserid.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "读者账号";
            // 
            // btnByUserName
            // 
            this.btnByUserName.Location = new System.Drawing.Point(226, 71);
            this.btnByUserName.Name = "btnByUserName";
            this.btnByUserName.Size = new System.Drawing.Size(75, 23);
            this.btnByUserName.TabIndex = 5;
            this.btnByUserName.Text = "查询";
            this.btnByUserName.UseVisualStyleBackColor = true;
            this.btnByUserName.Click += new System.EventHandler(this.BtnByUserName_Click);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // bookNumBindingSource
            // 
            this.bookNumBindingSource.DataMember = "bookNum";
            this.bookNumBindingSource.DataSource = this.libraryDataSet3;
            // 
            // libraryDataSet3
            // 
            this.libraryDataSet3.DataSetName = "LibraryDataSet3";
            this.libraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryDataSetBindingSource;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // bookNumTableAdapter
            // 
            this.bookNumTableAdapter.ClearBeforeFill = true;
            // 
            // BookTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 331);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookTong";
            this.Text = "图书统计";
            this.Load += new System.EventHandler(this.BookTong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookNumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumBytype;
        private System.Windows.Forms.ComboBox cboBookType;
        private System.Windows.Forms.Button btnNumByType;
        private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource bookTypeBindingSource;
        private LibraryDataSet1TableAdapters.BookTypeTableAdapter bookTypeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpBorrowTime;
        private System.Windows.Forms.TextBox tbBookNum;
        private System.Windows.Forms.Button btnNumByTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReturnTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnByUserName;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.TextBox tbNumByUserid;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private LibraryDataSet3 libraryDataSet3;
        private System.Windows.Forms.BindingSource bookNumBindingSource;
        private LibraryDataSet3TableAdapters.bookNumTableAdapter bookNumTableAdapter;
    }
}