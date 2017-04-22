namespace QueryRegister
{
    partial class QuerySelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuerySelect));
            this.Query = new System.Windows.Forms.RichTextBox();
            this.ClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.お気に入りに追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectQuerys = new System.Windows.Forms.ListBox();
            this.ClickMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Query
            // 
            this.Query.BackColor = System.Drawing.Color.White;
            this.Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Query.Location = new System.Drawing.Point(3, 85);
            this.Query.Name = "Query";
            this.Query.ReadOnly = true;
            this.Query.Size = new System.Drawing.Size(554, 221);
            this.Query.TabIndex = 8;
            this.Query.Text = "";
            this.Query.TextChanged += new System.EventHandler(this.Query_TextChanged);
            // 
            // ClickMenu
            // 
            this.ClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集ToolStripMenuItem,
            this.削除ToolStripMenuItem,
            this.お気に入りに追加ToolStripMenuItem});
            this.ClickMenu.Name = "Menu";
            this.ClickMenu.Size = new System.Drawing.Size(173, 70);
            this.ClickMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ClickMenu_Opening);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.編集ToolStripMenuItem.Text = "編集";
            this.編集ToolStripMenuItem.Click += new System.EventHandler(this.編集ToolStripMenuItem_Click);
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.削除ToolStripMenuItem.Text = "削除";
            this.削除ToolStripMenuItem.Click += new System.EventHandler(this.削除ToolStripMenuItem_Click);
            // 
            // お気に入りに追加ToolStripMenuItem
            // 
            this.お気に入りに追加ToolStripMenuItem.Name = "お気に入りに追加ToolStripMenuItem";
            this.お気に入りに追加ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.お気に入りに追加ToolStripMenuItem.Text = "お気に入りに追加";
            this.お気に入りに追加ToolStripMenuItem.Click += new System.EventHandler(this.お気に入りに追加ToolStripMenuItem_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(554, 19);
            this.Title.TabIndex = 13;
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(3, 27);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(554, 52);
            this.Description.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Description, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Query, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(238, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.44439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.55561F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 309);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // SelectQuerys
            // 
            this.SelectQuerys.ContextMenuStrip = this.ClickMenu;
            this.SelectQuerys.Dock = System.Windows.Forms.DockStyle.Left;
            this.SelectQuerys.FormattingEnabled = true;
            this.SelectQuerys.IntegralHeight = false;
            this.SelectQuerys.ItemHeight = 12;
            this.SelectQuerys.Location = new System.Drawing.Point(13, 13);
            this.SelectQuerys.Margin = new System.Windows.Forms.Padding(13);
            this.SelectQuerys.Name = "SelectQuerys";
            this.SelectQuerys.Size = new System.Drawing.Size(212, 309);
            this.SelectQuerys.TabIndex = 12;
            this.SelectQuerys.SelectedIndexChanged += new System.EventHandler(this.SelectQuerys_SelectedIndexChanged);
            this.SelectQuerys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectQuerys_KeyDown);
            // 
            // QuerySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 335);
            this.Controls.Add(this.SelectQuerys);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuerySelect";
            this.Padding = new System.Windows.Forms.Padding(13);
            this.Text = "QuerySelect";
            this.Load += new System.EventHandler(this.QuerySelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectQuerys_KeyDown);
            this.ClickMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.RichTextBox Query;
        private System.Windows.Forms.ContextMenuStrip ClickMenu;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox SelectQuerys;
        private System.Windows.Forms.ToolStripMenuItem お気に入りに追加ToolStripMenuItem;
    }
}