using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Filmoteka
{
    [Serializable]
    public class Category : IComparable
    {
        [XmlElement(ElementName = "Nazwa")]
        public List<string> names { get; set; }
        public Category() {
            names = new List<string>();
        }
        public Category(List<string> _name)
        {
            names = _name;
        }

        public int CompareTo(object obj)
        {
            Category temp = obj as Category;
            return this.names[0].CompareTo(temp.names[0]);
        }

        public override string ToString()
        {
            if (names == null) return "";
            string str="";
            int index=0;
            foreach (var item in names)
            {
                str += item;
                if (names.Count() > 1 && index!= names.Count()-1)
                    str += ",";
                index++;
            }
            return str;
        }

        public static Category Parse(string s)
        {
            List<string> temp = s.Split(',').ToList();
            return new Category(temp);
        }
    }
}
