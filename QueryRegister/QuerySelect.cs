using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryRegister
{
    public partial class QuerySelect : Form
    {
        private List<QueryDefine> QueryList { get; set; }
        private List<string> FavoriteQueryTitles { get; set; }
        BindingSource ListSource = new BindingSource();

        public QuerySelect(List<QueryDefine> queryList, List<string> favoriteQueryTitles)
        {
            InitializeComponent();
            QueryList = queryList;
            FavoriteQueryTitles = favoriteQueryTitles;
            QueryList.Sort(delegate (QueryDefine qd1, QueryDefine qd2) { return string.Compare(qd1.Title, qd2.Title); });
        }

        private void QuerySelect_Load(object sender, EventArgs e)
        {
            MakeSelectQuerys();
        }

        private void MakeSelectQuerys()
        {
            this.SuspendLayout();

            ListSource.DataSource = QueryList;
            SelectQuerys.DisplayMember = "Title";
            SelectQuerys.ValueMember = "Query";
            SelectQuerys.DataSource = ListSource;

            this.Controls.Add(this.SelectQuerys);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void QueryDisplay(QueryDefine qd)
        {
            this.Title.Text = qd.Title + "(作成:" + qd.Author + ")";
            this.Description.Text = qd.Description;
            this.Query.Text = qd.Query;
        }

        private void SelectQuerys_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.QueryDisplay((QueryDefine)SelectQuerys.SelectedItem);
        }

        private void 編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryDefine tmp = (QueryDefine)SelectQuerys.SelectedItem;
            QueryAdd addForm = new QueryAdd(tmp, FavoriteQueryTitles.Contains(tmp.Title));
            addForm.ShowDialog(this);
            if (addForm.DialogResult == DialogResult.OK)
            {
                QueryList.Remove(tmp);
                QueryList.Add(addForm.editQuery);
                ListSource.ResetBindings(false);
            }
        }

        private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryDefine tmp = (QueryDefine)SelectQuerys.SelectedItem;
            RegistUtil.Delete(tmp.Title);
            ListSource.Remove(tmp);
        }

        private void Query_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectQuerys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F11)
            {
                Clipboard.SetText(SelectQuerys.SelectedValue.ToString());
            }
        }

        private void ClickMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void お気に入りに追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryDefine tmp = (QueryDefine)SelectQuerys.SelectedItem;
            RegistUtil.RegistFavoriteQuery(tmp.Title);
        }
    }
}
