using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Filmoteka
{
    [Serializable]
    [XmlType("movie")]
    public class Movie
    {
        [XmlElement(ElementName = "Tytuł")]
        public string title { get; set; }
        [XmlElement(ElementName = "Ocena")]
        public int rating { get; set; }
        [XmlElement(ElementName = "RokProdukcji")]
        public int year { get; set; }
        [XmlElement(ElementName = "Kategoria")]
        public Category category { get; set; }
        [XmlElement(ElementName = "Komentarz")]
        public string comment { get; set; }
        public Movie() {
            category = new Category();
        }
        public Movie(string _title,int _rating,int _year, Category _category,string _comment)
        {
            title = _title;
            rating = _rating;
            year = _year;
            category = _category;
            comment = _comment;
        }

        public void showMe()
        {
            MessageBox.Show("Tytul: " + title.ToString() + " rok: " + year.ToString() + " kategoria: " + category.ToString());
        }
    }
}
