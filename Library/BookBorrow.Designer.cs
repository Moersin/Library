namespace Library
{
    partial class BookBorrow
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
            this.btnBorrowQuery = new System.Windows.Forms.Button();
            this.textBorrowBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.issBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issTableAdapter = new Library.LibraryDataSetTableAdapters.IssTableAdapter();
            this.booksTableAdapter = new Library.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeBorrow = new System.Windows.Forms.DateTimePicker();
            this.btnBorrowreturn = new System.Windows.Forms.Button();
            this.tbBorrowBName = new System.Windows.Forms.TextBox();
            this.tbBorrowSId = new System.Windows.Forms.TextBox();
            this.tbBorrowBId = new System.Windows.Forms.TextBox();
            this.btnBorrowSub = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrowQuery);
            this.groupBox1.Controls.Add(this.textBorrowBookName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "书籍查询";
            // 
            // btnBorrowQuery
            // 
            this.btnBorrowQuery.Location = new System.Drawing.Point(363, 24);
            this.btnBorrowQuery.Name = "btnBorrowQuery";
            this.btnBorrowQuery.Size = new System.Drawing.Size(75, 23);
            this.btnBorrowQuery.TabIndex = 2;
            this.btnBorrowQuery.Text = "查询";
            this.btnBorrowQuery.UseVisualStyleBackColor = true;
            this.btnBorrowQuery.Click += new System.EventHandler(this.BtnBorrowQuery_Click);
            // 
            // textBorrowBookName
            // 
            this.textBorrowBookName.Location = new System.Drawing.Point(147, 26);
            this.textBorrowBookName.Name = "textBorrowBookName";
            this.textBorrowBookName.Size = new System.Drawing.Size(147, 21);
            this.textBorrowBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要查询的书籍";
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            this.dgvBorrow.AutoGenerateColumns = false;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookTypeDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookPublishDataGridViewTextBoxColumn});
            this.dgvBorrow.DataSource = this.booksBindingSource;
            this.dgvBorrow.Location = new System.Drawing.Point(12, 82);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.RowTemplate.Height = 23;
            this.dgvBorrow.Size = new System.Drawing.Size(457, 156);
            this.dgvBorrow.TabIndex = 1;
            this.dgvBorrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBorrow_CellClick);
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "编号";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "书名";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookTypeDataGridViewTextBoxColumn
            // 
            this.bookTypeDataGridViewTextBoxColumn.DataPropertyName = "bookType";
            this.bookTypeDataGridViewTextBoxColumn.HeaderText = "类型";
            this.bookTypeDataGridViewTextBoxColumn.Name = "bookTypeDataGridViewTextBoxColumn";
            this.bookTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "bookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            this.bookAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookPublishDataGridViewTextBoxColumn
            // 
            this.bookPublishDataGridViewTextBoxColumn.DataPropertyName = "bookPublish";
            this.bookPublishDataGridViewTextBoxColumn.HeaderText = "出版社";
            this.bookPublishDataGridViewTextBoxColumn.Name = "bookPublishDataGridViewTextBoxColumn";
            this.bookPublishDataGridViewTextBoxColumn.ReadOnly = true;
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
            // issBindingSource
            // 
            this.issBindingSource.DataMember = "Iss";
            this.issBindingSource.DataSource = this.libraryDataSet;
            // 
            // issTableAdapter
            // 
            this.issTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeBorrow);
            this.groupBox2.Controls.Add(this.btnBorrowreturn);
            this.groupBox2.Controls.Add(this.tbBorrowBName);
            this.groupBox2.Controls.Add(this.tbBorrowSId);
            this.groupBox2.Controls.Add(this.tbBorrowBId);
            this.groupBox2.Controls.Add(this.btnBorrowSub);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "借阅办理";
            // 
            // timeBorrow
            // 
            this.timeBorrow.CustomFormat = "yyyy-MM-dd";
            this.timeBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeBorrow.Location = new System.Drawing.Point(284, 67);
            this.timeBorrow.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.timeBorrow.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.timeBorrow.Name = "timeBorrow";
            this.timeBorrow.Size = new System.Drawing.Size(124, 21);
            this.timeBorrow.TabIndex = 5;
            this.timeBorrow.ValueChanged += new System.EventHandler(this.TimeBorrow_ValueChanged);
            // 
            // btnBorrowreturn
            // 
            this.btnBorrowreturn.Location = new System.Drawing.Point(376, 102);
            this.btnBorrowreturn.Name = "btnBorrowreturn";
            this.btnBorrowreturn.Size = new System.Drawing.Size(75, 23);
            this.btnBorrowreturn.TabIndex = 4;
            this.btnBorrowreturn.Text = "返回";
            this.btnBorrowreturn.UseVisualStyleBackColor = true;
            this.btnBorrowreturn.Click += new System.EventHandler(this.BtnBorrowreturn_Click);
            // 
            // tbBorrowBName
            // 
            this.tbBorrowBName.Location = new System.Drawing.Point(284, 27);
            this.tbBorrowBName.Name = "tbBorrowBName";
            this.tbBorrowBName.ReadOnly = true;
            this.tbBorrowBName.Size = new System.Drawing.Size(100, 21);
            this.tbBorrowBName.TabIndex = 2;
            // 
            // tbBorrowSId
            // 
            this.tbBorrowSId.Location = new System.Drawing.Point(87, 67);
            this.tbBorrowSId.Name = "tbBorrowSId";
            this.tbBorrowSId.ReadOnly = true;
            this.tbBorrowSId.Size = new System.Drawing.Size(100, 21);
            this.tbBorrowSId.TabIndex = 2;
            // 
            // tbBorrowBId
            // 
            this.tbBorrowBId.Location = new System.Drawing.Point(87, 27);
            this.tbBorrowBId.Name = "tbBorrowBId";
            this.tbBorrowBId.ReadOnly = true;
            this.tbBorrowBId.Size = new System.Drawing.Size(100, 21);
            this.tbBorrowBId.TabIndex = 2;
            // 
            // btnBorrowSub
            // 
            this.btnBorrowSub.Location = new System.Drawing.Point(218, 102);
            this.btnBorrowSub.Name = "btnBorrowSub";
            this.btnBorrowSub.Size = new System.Drawing.Size(116, 23);
            this.btnBorrowSub.TabIndex = 1;
            this.btnBorrowSub.Text = "选择书籍并借阅";
            this.btnBorrowSub.UseVisualStyleBackColor = true;
            this.btnBorrowSub.Click += new System.EventHandler(this.BtnBorrowSub_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "书名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "借阅时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "读者账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "书籍编号";
            // 
            // BookBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookBorrow";
            this.Text = "图书借阅";
            this.Load += new System.EventHandler(this.BookBorrow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrowQuery;
        private System.Windows.Forms.TextBox textBorrowBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource issBindingSource;
        private LibraryDataSetTableAdapters.IssTableAdapter issTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublishDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrowSub;
        private System.Windows.Forms.TextBox tbBorrowBName;
        private System.Windows.Forms.TextBox tbBorrowSId;
        private System.Windows.Forms.TextBox tbBorrowBId;
        private System.Windows.Forms.Button btnBorrowreturn;
        private System.Windows.Forms.DateTimePicker timeBorrow;
    }
}