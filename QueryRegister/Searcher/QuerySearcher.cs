using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QueryRegister.Searcher
{
    class QuerySearcher : AbstractSearcher
    {
        public override List<QueryDefine> ReadQuerys(string text)
        {
            foreach (string f in files)
            {
                QueryDefine qd = RegistUtil.Read(Path.GetFileName(f));
                if (!Regex.IsMatch(qd.Query, text, RegexOptions.IgnoreCase)) continue;
                qds.Add(qd);
            }
            return qds;
        }
    }
}
