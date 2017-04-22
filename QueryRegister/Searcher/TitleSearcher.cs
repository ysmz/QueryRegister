using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryRegister.Searcher;
using System.IO;
using System.Text.RegularExpressions;

namespace QueryRegister
{
    class TitleSercher : AbstractSearcher
    {
        public override List<QueryDefine> ReadQuerys(string text)
        {
            string fileName = text + ".xml";
            if (File.Exists(fileName))
            {
                qds.Add(RegistUtil.Read(fileName));
                return qds;
            }

            foreach (string f in files)
            {
                if (!Regex.IsMatch(f, text, RegexOptions.IgnoreCase)) continue;
                qds.Add(RegistUtil.Read(Path.GetFileName(f)));
            }
            return qds;
        }
    }
}
