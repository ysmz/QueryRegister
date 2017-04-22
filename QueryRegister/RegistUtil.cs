using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace QueryRegister
{
    public static class RegistUtil
    {
        public static string FolderPath = Directory.GetCurrentDirectory();
        public static string QuerysFolderPath = FolderPath + "/Querys/";
        static XmlSerializer Serializer = new XmlSerializer(typeof(QueryDefine));

        public static void Delete(String title)
        {
            File.Delete(QuerysFolderPath + title + ".xml");
        }

        public static QueryDefine Read(string file)
        {

            // デシリアライズ（読み込み）
            using (FileStream fs = new FileStream(QuerysFolderPath + file, FileMode.Open, FileAccess.Read))
            {
                return (QueryDefine)Serializer.Deserialize(fs);
            }
            
        }

        public static void Save(QueryDefine qd)
        {
            string targetQueryPath = QuerysFolderPath + qd.Title + ".xml";

            // シリアライズ（書き込み）
            using (FileStream fs = new FileStream(QuerysFolderPath + qd.Title + ".xml", FileMode.Create, FileAccess.Write))
            {
                Serializer.Serialize(fs, qd);
            }
        }

        public static void RegistFavoriteQuery(string title)
        {
            StringCollection favoriteQuerys = Properties.Settings.Default.FavoriteQuerys;
            if (favoriteQuerys.Contains(title)) return;
            favoriteQuerys.Add(title);
            Properties.Settings.Default.FavoriteQuerys = favoriteQuerys;
        }

        public static void DisplayErrorMessage(string message)
        {
            //メッセージボックスを表示する
            MessageBox.Show(message,
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static bool JudgeSelectMessage(string message)
        {
            return MessageBox.Show(message,
                    "質問",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }

        public static void RemoveFavoriteQuery(string title)
        {
            StringCollection favoriteQuerys = Properties.Settings.Default.FavoriteQuerys;
            if (!favoriteQuerys.Contains(title)) return;
            favoriteQuerys.Remove(title);
            Properties.Settings.Default.FavoriteQuerys = favoriteQuerys;
        }
    }
}
