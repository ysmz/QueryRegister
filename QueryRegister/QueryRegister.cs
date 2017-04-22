using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
//using log4net;
using System.Text.RegularExpressions;
using QueryRegister.Searcher;


namespace QueryRegister
{
    public partial class QueryRegister : Form
    {
        //お気に入りのクエリリスト
        List<QueryDefine> FavoriteQuerysList = new List<QueryDefine>();
        BindingSource ListSource = new BindingSource();

        public QueryRegister()
        {
            InitializeComponent();
        }

        private void QueryRegister_Load(object sender, EventArgs e)
        {
            GetFavoriteQuery();
            MakeFavoriteQuerys();
        }

        private void GetFavoriteQuery()
        {
            FavoriteQuerysList = LoadFavoriteQuery();
            FavoriteQuerysList.Sort(delegate (QueryDefine qd1, QueryDefine qd2) { return string.Compare(qd1.Title, qd2.Title); });
        }

        private void Add_Click(object sender, EventArgs e)
        {
            QueryAdd addForm = new QueryAdd();
            addForm.ShowDialog(this);
            if (addForm.DialogResult == DialogResult.OK && addForm.IsFavorite.Checked)
            {
                FavoriteQuerysList.Add(addForm.editQuery);
                ListSource.ResetBindings(false);
            }
        }

        private void titleSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            List<QueryDefine> selectQueryList;
            if(SearchWord.Text == "")
            {
                if (!RegistUtil.JudgeSelectMessage("全て表示しますがよろしいですか？"))
                {
                    RegistUtil.DisplayErrorMessage("検索項目を選択してください。");
                    return;
                }
                selectQueryList = SearchAll();
            }
            else
            {
                if(Type.Text == "")
                {
                    RegistUtil.DisplayErrorMessage("検索項目を選択してください。");
                    return;
                }
                selectQueryList = SearchQuerys(Type.Text, SearchWord.Text);
                if (selectQueryList.Count == 0)
                {
                    RegistUtil.DisplayErrorMessage("一致するものがありません。");
                    return;
                }
            }
            List<string> favoriteQueryTitles = new List<string>();
            foreach(QueryDefine fqd in FavoriteQuerysList)
            {
                favoriteQueryTitles.Add(fqd.Title);
            }
            QuerySelect selectForm = new QuerySelect(selectQueryList, favoriteQueryTitles);

            selectForm.ShowDialog(this);
        }

        private void MakeFavoriteQuerys()
        {
            this.SuspendLayout();
            ListSource.DataSource = FavoriteQuerysList;
            FavoriteQuerys.DisplayMember = "Title";
            FavoriteQuerys.ValueMember = "Query";
            FavoriteQuerys.DataSource = ListSource;

            this.Controls.Add(this.FavoriteQuerys);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void object_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QueryDisplay(QueryDefine qd)
        {
            this.Title.Text = qd.Title + "(作成:" + qd.Author + ")";
            this.Query.Text = qd.Query;
            this.Description.Text = qd.Description;
        }

        private void Query_TextChanged(object sender, EventArgs e)
        {

        }

        private void FavoriteQuerys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FavoriteQuerys.SelectedItem == null)
            {
                this.Query.Text = "";
                return;
            }
            QueryDefine qd = (QueryDefine)FavoriteQuerys.SelectedItem;
            this.QueryDisplay(qd);
        }

        private void queryMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void お気に入りから外すToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryDefine qd = (QueryDefine)FavoriteQuerys.SelectedItem;
            RegistUtil.RemoveFavoriteQuery(qd.Title);
            ListSource.Remove(qd);
        }

        private void 編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryDefine initialQuery = (QueryDefine)FavoriteQuerys.SelectedItem;
            QueryAdd addForm = new QueryAdd(initialQuery, true);
            addForm.ShowDialog(this);
            if (addForm.DialogResult == DialogResult.OK) {
                FavoriteQuerysList.Remove(initialQuery);
                FavoriteQuerysList.Add(addForm.editQuery);
                ListSource.ResetBindings(false);
            }
        }

        private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryDefine qd = (QueryDefine)FavoriteQuerys.SelectedItem;
            RegistUtil.Delete(qd.Title);
            RegistUtil.RemoveFavoriteQuery(qd.Title);
            ListSource.Remove(qd);
        }

        private List<QueryDefine> LoadFavoriteQuery()
        {
            List<QueryDefine> favoriteQuerys = new List<QueryDefine>();

            foreach (string title in Properties.Settings.Default.FavoriteQuerys)
            {
                if (string.IsNullOrEmpty(title)) continue;
                try
                {
                    favoriteQuerys.Add(RegistUtil.Read(title + ".xml"));
                }
                catch (Exception ex)
                {
                    RegistUtil.DisplayErrorMessage(title + "の読み込みでエラーが発生しました。:" + ex);
                }
            }
            return favoriteQuerys;
        }

        private List<QueryDefine> SearchAll()
        {
            List<QueryDefine> qds = new List<QueryDefine>();
            string[] files = Directory.GetFiles(RegistUtil.QuerysFolderPath, "*");
            foreach (string f in files)
            {
                qds.Add(RegistUtil.Read(Path.GetFileName(f)));
            }
            return qds;
        }

        private List<QueryDefine> SearchQuerys(string type, string text)
        {
            AbstractSearcher searcher;

            switch (type)
            {
                case "title":
                    searcher = new TitleSercher();
                    break;
                case "query":
                    searcher = new QuerySearcher();
                    break;
                case "description":
                    searcher = new DescriptionSearcher();
                    break;
                case "author":
                    searcher = new AuthorSearcher();
                    break;
                default:
                    return null;
            }

            return searcher.ReadQuerys(text);
        }

        private void Favorite_Click(object sender, EventArgs e)
        {

        }

        private void QueryRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F11)
            {
                Clipboard.SetText(FavoriteQuerys.SelectedValue.ToString());
            }
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void QueryRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
