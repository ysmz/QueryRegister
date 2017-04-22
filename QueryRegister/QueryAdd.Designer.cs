namespace QueryRegister
{
    partial class QueryAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryAdd));
            this.OK = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.IsFavorite = new System.Windows.Forms.CheckBox();
            this.Format = new System.Windows.Forms.Button();
            this.Query = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(425, 6);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(506, 6);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(16, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(561, 25);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title";
            this.Title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Description.Location = new System.Drawing.Point(16, 41);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(561, 64);
            this.Description.TabIndex = 4;
            this.Description.Text = "Description";
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // IsFavorite
            // 
            this.IsFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IsFavorite.AutoSize = true;
            this.IsFavorite.Location = new System.Drawing.Point(145, 6);
            this.IsFavorite.Name = "IsFavorite";
            this.IsFavorite.Size = new System.Drawing.Size(72, 22);
            this.IsFavorite.TabIndex = 5;
            this.IsFavorite.Text = "favorite";
            this.IsFavorite.UseVisualStyleBackColor = true;
            // 
            // Format
            // 
            this.Format.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Format.Location = new System.Drawing.Point(344, 6);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(75, 23);
            this.Format.TabIndex = 7;
            this.Format.Text = "Format";
            this.Format.UseVisualStyleBackColor = true;
            this.Format.Click += new System.EventHandler(this.Format_Click);
            // 
            // Query
            // 
            this.Query.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Query.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Query.Location = new System.Drawing.Point(16, 111);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(561, 403);
            this.Query.TabIndex = 8;
            this.Query.Text = "Query";
            this.Query.TextChanged += new System.EventHandler(this.Query_TextChanged);
            this.Query.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Query_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.Query, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Title, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Description, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.61794F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.38206F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 517);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IsFavorite);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.Format);
            this.panel1.Controls.Add(this.OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 35);
            this.panel1.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // QueryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 555);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryAdd";
            this.Text = "QueryAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryAdd_FormClosing);
            this.Load += new System.EventHandler(this.QueryAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QueryAdd_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Description;
        public System.Windows.Forms.CheckBox IsFavorite;
        private System.Windows.Forms.Button Format;
        private System.Windows.Forms.RichTextBox Query;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
    }
}