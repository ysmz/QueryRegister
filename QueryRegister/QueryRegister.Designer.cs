using System.Collections.Generic;

namespace QueryRegister
{
    partial class QueryRegister
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryRegister));
            this.Add = new System.Windows.Forms.Button();
            this.SearchWord = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Favorite = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Query = new System.Windows.Forms.RichTextBox();
            this.FavoriteQuerys = new System.Windows.Forms.ListBox();
            this.queryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.お気に入りから外すToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.queryMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Location = new System.Drawing.Point(147, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(70, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SearchWord
            // 
            this.SearchWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchWord.Location = new System.Drawing.Point(164, 4);
            this.SearchWord.Name = "SearchWord";
            this.SearchWord.Size = new System.Drawing.Size(256, 19);
            this.SearchWord.TabIndex = 3;
            this.SearchWord.TextChanged += new System.EventHandler(this.titleSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(426, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 22);
            this.Search.TabIndex = 4;
            this.Search.Text = "search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Favorite
            // 
            this.Favorite.AutoSize = true;
            this.Favorite.Location = new System.Drawing.Point(9, 8);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(47, 12);
            this.Favorite.TabIndex = 5;
            this.Favorite.Text = "Favorite";
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // Type
            // 
            this.Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "title",
            "query",
            "description",
            "author"});
            this.Type.Location = new System.Drawing.Point(72, 3);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(86, 20);
            this.Type.TabIndex = 6;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.object_SelectedIndexChanged);
            // 
            // Query
            // 
            this.Query.BackColor = System.Drawing.Color.White;
            this.Query.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Query.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Query.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Query.Location = new System.Drawing.Point(3, 106);
            this.Query.Name = "Query";
            this.Query.ReadOnly = true;
            this.Query.Size = new System.Drawing.Size(541, 232);
            this.Query.TabIndex = 7;
            this.Query.Text = "";
            this.Query.TextChanged += new System.EventHandler(this.Query_TextChanged);
            // 
            // FavoriteQuerys
            // 
            this.FavoriteQuerys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FavoriteQuerys.ContextMenuStrip = this.queryMenu;
            this.FavoriteQuerys.FormattingEnabled = true;
            this.FavoriteQuerys.ItemHeight = 12;
            this.FavoriteQuerys.Location = new System.Drawing.Point(12, 50);
            this.FavoriteQuerys.Name = "FavoriteQuerys";
            this.FavoriteQuerys.Size = new System.Drawing.Size(220, 304);
            this.FavoriteQuerys.TabIndex = 8;
            this.FavoriteQuerys.SelectedIndexChanged += new System.EventHandler(this.FavoriteQuerys_SelectedIndexChanged);
            this.FavoriteQuerys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QueryRegister_KeyDown);
            // 
            // queryMenu
            // 
            this.queryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集ToolStripMenuItem,
            this.削除ToolStripMenuItem,
            this.お気に入りから外すToolStripMenuItem});
            this.queryMenu.Name = "queryMenu";
            this.queryMenu.Size = new System.Drawing.Size(185, 70);
            this.queryMenu.Opening += new System.ComponentModel.CancelEventHandler(this.queryMenu_Opening);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.編集ToolStripMenuItem.Text = "編集";
            this.編集ToolStripMenuItem.Click += new System.EventHandler(this.編集ToolStripMenuItem_Click);
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.削除ToolStripMenuItem.Text = "削除";
            this.削除ToolStripMenuItem.Click += new System.EventHandler(this.削除ToolStripMenuItem_Click);
            // 
            // お気に入りから外すToolStripMenuItem
            // 
            this.お気に入りから外すToolStripMenuItem.Name = "お気に入りから外すToolStripMenuItem";
            this.お気に入りから外すToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.お気に入りから外すToolStripMenuItem.Text = "お気に入りから外す";
            this.お気に入りから外すToolStripMenuItem.Click += new System.EventHandler(this.お気に入りから外すToolStripMenuItem_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Title.Location = new System.Drawing.Point(3, 37);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(541, 19);
            this.Title.TabIndex = 9;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(3, 60);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(541, 40);
            this.Description.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Description, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Query, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(248, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.34615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.65385F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 341);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchWord);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 28);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.Favorite);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 28);
            this.panel2.TabIndex = 9;
            // 
            // QueryRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 370);
            this.Controls.Add(this.FavoriteQuerys);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryRegister";
            this.Padding = new System.Windows.Forms.Padding(13);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "QueryRegister";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QueryRegister_FormClosed);
            this.Load += new System.EventHandler(this.QueryRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QueryRegister_KeyDown);
            this.queryMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox SearchWord;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Favorite;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.RichTextBox Query;
        private System.Windows.Forms.ListBox FavoriteQuerys;
        private System.Windows.Forms.ContextMenuStrip queryMenu;
        private System.Windows.Forms.ToolStripMenuItem お気に入りから外すToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

