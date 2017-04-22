using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace QueryRegister.Searcher
{
    abstract class AbstractSearcher
    {
        protected string[] files = Directory.GetFiles(RegistUtil.QuerysFolderPath, "*");
        protected List<QueryDefine> qds = new List<QueryDefine>();
        
        public abstract List<QueryDefine> ReadQuerys(string text);
    }
}
