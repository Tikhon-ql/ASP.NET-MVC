using HomeTask1.Factory.Interface;
using HomeTask1.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Xml;

namespace HomeTask1.Factory.Models
{
    public class OneRowFactory : IFactory<List<OneRow>>
    {

        public List<OneRow> CreatObject(params object[] _params)
        {
            List<OneRow> res = new List<OneRow>();
            string filePath = _params[0].ToString();
            XmlDocument xml = new XmlDocument();
            xml.Load(filePath);
            var root = xml.DocumentElement;
            foreach (XmlElement item in root.ChildNodes)
            {
                res.Add(CreateInstance(Convert.ToInt32(item.ChildNodes[0].InnerText), item.ChildNodes[1].InnerText, item.ChildNodes[2].InnerText, item.ChildNodes[3].InnerText));
            }
            return res;
        }
        private static OneRow CreateInstance(int id,string dateT,string firstCom,string secComd)
        {
            return new OneRow(id, Convert.ToDateTime(dateT),firstCom,secComd);
        }
    }
}