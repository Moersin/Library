namespace Library
{
    partial class BookAdd
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
            this.textBookId = new System.Windows.Forms.TextBox();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.textBookAuthor = new System.Windows.Forms.TextBox();
            this.textBookPublish = new System.Windows.Forms.TextBox();
            this.comboBookType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.libraryDataSet1 = new Library.LibraryDataSet1();
            this.bookTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTypeTableAdapter = new Library.LibraryDataSet1TableAdapters.BookTypeTableAdapter();
            this.bookTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编  号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "书  名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "类  别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "作  者";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "出版社";
            // 
            // textBookId
            // 
            this.textBookId.Location = new System.Drawing.Point(82, 23);
            this.textBookId.Name = "textBookId";
            this.textBookId.Size = new System.Drawing.Size(112, 21);
            this.textBookId.TabIndex = 1;
            // 
            // textBookName
            // 
            this.textBookName.Location = new System.Drawing.Point(82, 59);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(112, 21);
            this.textBookName.TabIndex = 1;
            // 
            // textBookAuthor
            // 
            this.textBookAuthor.Location = new System.Drawing.Point(82, 133);
            this.textBookAuthor.Name = "textBookAuthor";
            this.textBookAuthor.Size = new System.Drawing.Size(112, 21);
            this.textBookAuthor.TabIndex = 1;
            // 
            // textBookPublish
            // 
            this.textBookPublish.Location = new System.Drawing.Point(82, 175);
            this.textBookPublish.Name = "textBookPublish";
            this.textBookPublish.Size = new System.Drawing.Size(112, 21);
            this.textBookPublish.TabIndex = 1;
            // 
            // comboBookType
            // 
            this.comboBookType.DataSource = this.bookTypeBindingSource1;
            this.comboBookType.DisplayMember = "bookType";
            this.comboBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBookType.FormattingEnabled = true;
            this.comboBookType.Location = new System.Drawing.Point(82, 99);
            this.comboBookType.Name = "comboBookType";
            this.comboBookType.Size = new System.Drawing.Size(121, 20);
            this.comboBookType.TabIndex = 2;
            this.comboBookType.ValueMember = "bookType";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(128, 266);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTypeBindingSource
            // 
            this.bookTypeBindingSource.DataMember = "BookType";
            this.bookTypeBindingSource.DataSource = this.libraryDataSet1;
            // 
            // bookTypeTableAdapter
            // 
            this.bookTypeTableAdapter.ClearBeforeFill = true;
            // 
            // bookTypeBindingSource1
            // 
            this.bookTypeBindingSource1.DataMember = "BookType";
            this.bookTypeBindingSource1.DataSource = this.libraryDataSet1;
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 325);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBookType);
            this.Controls.Add(this.textBookPublish);
            this.Controls.Add(this.textBookAuthor);
            this.Controls.Add(this.textBookName);
            this.Controls.Add(this.textBookId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书添加";
            this.Load += new System.EventHandler(this.BookAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBookId;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.TextBox textBookAuthor;
        private System.Windows.Forms.TextBox textBookPublish;
        private System.Windows.Forms.ComboBox comboBookType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource bookTypeBindingSource;
        private LibraryDataSet1TableAdapters.BookTypeTableAdapter bookTypeTableAdapter;
        private System.Windows.Forms.BindingSource bookTypeBindingSource1;
    }
}