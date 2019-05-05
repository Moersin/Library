namespace Library
{
    partial class indexFormStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indexFormStu));
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.booksTableAdapter = new Library.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExits = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBookBorrow = new System.Windows.Forms.ToolStripButton();
            this.tsbBookReturn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHelp,
            this.tsmExits});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmHelp
            // 
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(44, 21);
            this.tsmHelp.Text = "帮助";
            this.tsmHelp.Click += new System.EventHandler(this.TsmHelp_Click);
            // 
            // tsmExits
            // 
            this.tsmExits.Name = "tsmExits";
            this.tsmExits.Size = new System.Drawing.Size(44, 21);
            this.tsmExits.Text = "退出";
            this.tsmExits.Click += new System.EventHandler(this.TsmExits_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBookBorrow,
            this.tsbBookReturn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(515, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBookBorrow
            // 
            this.tsbBookBorrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBookBorrow.Image = ((System.Drawing.Image)(resources.GetObject("tsbBookBorrow.Image")));
            this.tsbBookBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBookBorrow.Name = "tsbBookBorrow";
            this.tsbBookBorrow.Size = new System.Drawing.Size(60, 22);
            this.tsbBookBorrow.Text = "图书借阅";
            this.tsbBookBorrow.Click += new System.EventHandler(this.TsbBookBorrow_Click);
            // 
            // tsbBookReturn
            // 
            this.tsbBookReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBookReturn.Image = ((System.Drawing.Image)(resources.GetObject("tsbBookReturn.Image")));
            this.tsbBookReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBookReturn.Name = "tsbBookReturn";
            this.tsbBookReturn.Size = new System.Drawing.Size(60, 22);
            this.tsbBookReturn.Text = "图书归还";
            this.tsbBookReturn.Click += new System.EventHandler(this.TsbBookReturn_Click);
            // 
            // indexFormStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 328);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "indexFormStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统-读者";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IndexFormStu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmExits;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBookBorrow;
        private System.Windows.Forms.ToolStripButton tsbBookReturn;
    }
}