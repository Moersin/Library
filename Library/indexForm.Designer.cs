namespace Library
{
    partial class indexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indexForm));
            this.issBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.issTableAdapter = new Library.LibraryDataSetTableAdapters.IssTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStuAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStuGuan = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBookAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBookGuan = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBookTypeAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBookCount = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBookTypeG = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStuTypeAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStuTypeG = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExits = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // issBindingSource
            // 
            this.issBindingSource.DataMember = "Iss";
            this.issBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issTableAdapter
            // 
            this.issTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStuAdd,
            this.toolStripButtonStuGuan,
            this.toolStripButtonBookAdd,
            this.toolStripButtonBookGuan,
            this.toolStripButtonBookTypeAdd,
            this.toolStripButtonBookCount,
            this.toolStripBtnBookTypeG,
            this.toolStripBtnStuTypeAdd,
            this.toolStripBtnStuTypeG});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripButtonStuAdd
            // 
            this.toolStripButtonStuAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStuAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStuAdd.Image")));
            this.toolStripButtonStuAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStuAdd.Name = "toolStripButtonStuAdd";
            this.toolStripButtonStuAdd.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonStuAdd.Text = "读者添加";
            this.toolStripButtonStuAdd.Click += new System.EventHandler(this.ToolStripButtonStuAdd_Click);
            // 
            // toolStripButtonStuGuan
            // 
            this.toolStripButtonStuGuan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStuGuan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStuGuan.Image")));
            this.toolStripButtonStuGuan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStuGuan.Name = "toolStripButtonStuGuan";
            this.toolStripButtonStuGuan.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonStuGuan.Text = "读者管理";
            this.toolStripButtonStuGuan.Click += new System.EventHandler(this.ToolStripButtonStuGuan_Click);
            // 
            // toolStripButtonBookAdd
            // 
            this.toolStripButtonBookAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBookAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBookAdd.Image")));
            this.toolStripButtonBookAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBookAdd.Name = "toolStripButtonBookAdd";
            this.toolStripButtonBookAdd.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonBookAdd.Text = "书籍添加";
            this.toolStripButtonBookAdd.Click += new System.EventHandler(this.ToolStripButtonBookAdd_Click);
            // 
            // toolStripButtonBookGuan
            // 
            this.toolStripButtonBookGuan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBookGuan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBookGuan.Image")));
            this.toolStripButtonBookGuan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBookGuan.Name = "toolStripButtonBookGuan";
            this.toolStripButtonBookGuan.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonBookGuan.Text = "书籍管理";
            this.toolStripButtonBookGuan.Click += new System.EventHandler(this.ToolStripButtonBookGuan_Click);
            // 
            // toolStripButtonBookTypeAdd
            // 
            this.toolStripButtonBookTypeAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBookTypeAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBookTypeAdd.Image")));
            this.toolStripButtonBookTypeAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBookTypeAdd.Name = "toolStripButtonBookTypeAdd";
            this.toolStripButtonBookTypeAdd.Size = new System.Drawing.Size(84, 22);
            this.toolStripButtonBookTypeAdd.Text = "图书类别添加";
            this.toolStripButtonBookTypeAdd.Click += new System.EventHandler(this.ToolStripButtonBookTypeAdd_Click);
            // 
            // toolStripButtonBookCount
            // 
            this.toolStripButtonBookCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBookCount.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBookCount.Image")));
            this.toolStripButtonBookCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBookCount.Name = "toolStripButtonBookCount";
            this.toolStripButtonBookCount.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonBookCount.Text = "图书统计";
            this.toolStripButtonBookCount.Click += new System.EventHandler(this.ToolStripButtonBookCount_Click);
            // 
            // toolStripBtnBookTypeG
            // 
            this.toolStripBtnBookTypeG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnBookTypeG.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBookTypeG.Image")));
            this.toolStripBtnBookTypeG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBookTypeG.Name = "toolStripBtnBookTypeG";
            this.toolStripBtnBookTypeG.Size = new System.Drawing.Size(84, 22);
            this.toolStripBtnBookTypeG.Text = "图书类别管理";
            this.toolStripBtnBookTypeG.Click += new System.EventHandler(this.ToolStripBtnBookTypeG_Click);
            // 
            // toolStripBtnStuTypeAdd
            // 
            this.toolStripBtnStuTypeAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnStuTypeAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStuTypeAdd.Image")));
            this.toolStripBtnStuTypeAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStuTypeAdd.Name = "toolStripBtnStuTypeAdd";
            this.toolStripBtnStuTypeAdd.Size = new System.Drawing.Size(84, 22);
            this.toolStripBtnStuTypeAdd.Text = "读者类别添加";
            this.toolStripBtnStuTypeAdd.Click += new System.EventHandler(this.ToolStripBtnStuTypeAdd_Click);
            // 
            // toolStripBtnStuTypeG
            // 
            this.toolStripBtnStuTypeG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnStuTypeG.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStuTypeG.Image")));
            this.toolStripBtnStuTypeG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStuTypeG.Name = "toolStripBtnStuTypeG";
            this.toolStripBtnStuTypeG.Size = new System.Drawing.Size(84, 22);
            this.toolStripBtnStuTypeG.Text = "读者类别管理";
            this.toolStripBtnStuTypeG.Click += new System.EventHandler(this.ToolStripBtnStuTypeG_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHelp,
            this.toolExits});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolHelp
            // 
            this.toolHelp.Name = "toolHelp";
            this.toolHelp.Size = new System.Drawing.Size(44, 21);
            this.toolHelp.Text = "帮助";
            this.toolHelp.Click += new System.EventHandler(this.ToolHelp_Click);
            // 
            // toolExits
            // 
            this.toolExits.Name = "toolExits";
            this.toolExits.Size = new System.Drawing.Size(44, 21);
            this.toolExits.Text = "退出";
            this.toolExits.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // indexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 371);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "indexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统-管理员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource issBindingSource;
        private LibraryDataSetTableAdapters.IssTableAdapter issTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStuAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonStuGuan;
        private System.Windows.Forms.ToolStripButton toolStripButtonBookAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonBookGuan;
        private System.Windows.Forms.ToolStripButton toolStripButtonBookTypeAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonBookCount;
        private System.Windows.Forms.ToolStripButton toolStripBtnBookTypeG;
        private System.Windows.Forms.ToolStripButton toolStripBtnStuTypeAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnStuTypeG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolHelp;
        private System.Windows.Forms.ToolStripMenuItem toolExits;
    }
}