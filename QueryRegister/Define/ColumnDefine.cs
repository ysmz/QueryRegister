using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryRegister.Define
{

    public class Columns
    {
        public List<ColumnDefine> ColumnsList { get; set; }
    }

    public class ColumnDefine
    {
        public string Type { get; set; }
        public List<string> Columns { get; set; }

        public ColumnDefine()
        {

        }
    }
}
