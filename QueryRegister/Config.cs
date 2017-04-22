using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace QueryRegister
{
    public partial class Config : Form
    {
        private bool IsSuccess = true;
        private int SpaceCount = Properties.Settings.Default.SpaceCount;

        public Config()
        {
            InitializeComponent();
            IndentWords.Text = string.Join("\r\n",Properties.Settings.Default.IndentWords);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            StringCollection sc = new StringCollection();
            sc.AddRange(IndentWords.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries));
            Properties.Settings.Default.IndentWords = sc;
            IsSuccess = int.TryParse(SpaceNumber.Text, out SpaceCount);
            if(IsSuccess) Properties.Settings.Default.SpaceCount = SpaceCount;
        }

        private void IndentWords_TextChanged(object sender, EventArgs e)
        {

        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsSuccess && RegistUtil.JudgeSelectMessage("編集を終了しますか？"))
            {
                RegistUtil.DisplayErrorMessage("スペース数は整数で入力してください。");
                e.Cancel = true;
                return;
            }
        }
    }
}
