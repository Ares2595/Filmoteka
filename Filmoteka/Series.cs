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
    class Series : Movie
    {
        [XmlElement(ElementName = "Numer odcinka")]
        public int episode { get; set; }

        public Series(string _title, int _rating, int _year, Category _category, string _comment, int _episode):base(_title,_rating,_year,_category,_comment)
        {
            episode = _episode;
        }
        public new void showMe()
        {
            MessageBox.Show("Tytul: " + title.ToString() + " rok: " + year.ToString() + " nr odcinka" + episode.ToString() + " kategoria: " + category.ToString());
        }
    }
}
