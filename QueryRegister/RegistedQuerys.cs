using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;


namespace QueryRegister
{
    public class RegistedQuerys
    {
        [XmlArrayItem(typeof(QueryDefine))]
        public List<QueryDefine> Querys;
    }

    public class QueryDefine
    {
        public string Title { get; set; }
        public string Query { get; set; }
        public string Description { get; set; }
        public bool FavoriteFlg { get; set; }

        public QueryDefine()
        {

        }

        public QueryDefine(string title, string query, string description, bool favoriteFlg)
        {
            Title = title;
            Query = query;
            Description = description;
            FavoriteFlg = favoriteFlg;
        }
    }
}
