using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace QueryRegister
{
    public partial class QueryAdd : Form
    {
        QueryDefine InitialQuery;
        public QueryDefine editQuery;
        bool InitialFavoriteFlg = false;
        bool IsAdd = false;
        bool IsSuccess = false;
        public static StringCollection IndentWords = Properties.Settings.Default.IndentWords;
        public static int SpaceCount = Properties.Settings.Default.SpaceCount;

        public QueryAdd()
        {
            InitializeComponent();
            IsAdd = true;
        }

        public QueryAdd(QueryDefine editQuery, bool isFavorite)
        {
            InitializeComponent();
            Set(editQuery, isFavorite);
        }

        private void Set(QueryDefine editQuery, bool isFavorite)
        {
            InitialQuery = new QueryDefine(editQuery.Title, editQuery.Query, editQuery.Description);
            InitialFavoriteFlg = isFavorite;
            this.Title.Text = InitialQuery.Title;
            this.Query.Text = InitialQuery.Query;
            this.Description.Text = InitialQuery.Description;
            this.IsFavorite.Checked = InitialFavoriteFlg;
        }

        private void QueryAdd_Load(object sender, EventArgs e)
        {
        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                editQuery = new QueryDefine(this.Title.Text, this.Query.Text, this.Description.Text);
                if (IsAdd) {
                    RegistQuery(editQuery);
                } else {
                    UpdateQuery(editQuery);
                }
                IsSuccess = true;
            }
            catch (Exception ex)
            {
                RegistUtil.DisplayErrorMessage("登録に失敗しました。:" + ex)
;           }
        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            IsSuccess = true;
        }

        private void Format_Click(object sender, EventArgs e)
        {
            List<string> formatQuery = new List<string>();

            for (int i = 0; i < Query.Lines.Length; i++){
                string line = Query.Lines[i];
            }
        }

        private void RegistQuery(QueryDefine editQuery)
        {
            RegistUtil.Save(editQuery);

            if (IsFavorite.Checked) RegistUtil.RegistFavoriteQuery(editQuery.Title);
        }

        private void UpdateQuery(QueryDefine editQuery)
        {
            if (InitialFavoriteFlg) RegistUtil.RemoveFavoriteQuery(editQuery.Title);
            // タイトルが変更された場合は元のクエリを消去して登録
            if (InitialQuery.Title != editQuery.Title) RegistUtil.Delete(InitialQuery.Title);
            RegistQuery(editQuery);
        }

        private void QueryAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsSuccess && !RegistUtil.JudgeSelectMessage("編集を終了しますか？"))
            {
                e.Cancel = true;
            }
        }

        private void QueryAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F11)
            {
                FormatQuery();
            }
        }

        private void Query_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F11)
            {
                FormatQuery();
            }
        }

        private void FormatQuery()
        {
            
            //TODO:インデント
            string query = string.Empty;
            string indent = new string(' ', SpaceCount);
            int i = 0;
            StringReader sr = new StringReader(Query.Text);
            while (sr.Peek() > -1) {
                string line = sr.ReadLine();

                //query += indent + line.Replace(",", ",\r\n");
                //if (!line.EndsWith(",")) query += "\r\n";

            }

            Query.Text = query;
              
        }

        private void Query_TextChanged(object sender, EventArgs e)
        {
            try {
                //Query.SelectAll();
                //Query.SelectionLength = Query.Lines[Query.GetLineFromCharIndex(Query.SelectionStart)].Length;
                //Query.Select(Query.SelectionStart, Query.Lines[Query.GetLineFromCharIndex(Query.SelectionStart)].Length);
                //Console.WriteLine(Query.SelectedText + Query.SelectionLength + Query.SelectionStart + Query.GetLineFromCharIndex(Query.SelectionStart) + Query.Lines[Query.GetLineFromCharIndex(Query.SelectionStart)] + Query.Lines[Query.GetLineFromCharIndex(Query.SelectionStart)].Length);
                //if (Query.SelectedText.Contains("select")) Query.SelectionColor = Color.Blue;
                //Query.Select(Query.SelectionStart,0);
            }
            catch
            {

            }
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config configForm = new Config();
            configForm.ShowDialog();
            if(configForm.DialogResult == DialogResult.OK)
            {
                SpaceCount = Properties.Settings.Default.SpaceCount;
                IndentWords = Properties.Settings.Default.IndentWords;
            }
        }
    }
}
