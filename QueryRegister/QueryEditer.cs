using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueryRegister.Define;
using System.IO;
using System.Xml.Serialization;

namespace QueryRegister
{
    public partial class QueryEditer : Form
    {

        private List<ColumnDefine> ColumnsList = new List<ColumnDefine>();
        private static XmlSerializer Serializer = new XmlSerializer(typeof(Columns));

        public QueryEditer()
        {
            InitializeComponent();
            LoadSetting();
        }

        public void LoadSetting()
        {
            Columns columns;
            // デシリアライズ（読み込み）
            using (FileStream fs = new FileStream("Setting/Columns.xml", FileMode.Open, FileAccess.Read))
            {
                columns = (Columns)Serializer.Deserialize(fs);
            }
            ColumnsList = columns.ColumnsList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(ColumnsList.Find(c => c.Type == comboBox1.Text).Columns.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select\r\rn";
            // カラム追加
            foreach (string column in checkedListBox1.SelectedItems)
            {
                query += column + ",\r\n";
            }

            query += "from\r\n" + new string();

            query += "where\r\rb";
        }
    }
}
