using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Filmoteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Movie> myMovie;
        private string filename;
        public MainWindow()
        {
            InitializeComponent();
            myMovie =LoadMovies( "default.xml");
            ShowLastWatched();
            ShowTheBest();
            filename = "default.xml";
        }

        public MainWindow(double _left, double _top,ref List<Movie> _myMovie)
        {
            InitializeComponent();
            Left = _left;
            Top = _top;
            myMovie = _myMovie;
            ShowLastWatched();
            ShowTheBest();
            filename = "default.xml";
        }
        private void ShowLastWatched()
        {
            int countLastMovie = 10;
            var results = from x in myMovie
                          select x;
            dataGridLastWatched.ItemsSource = results.Skip(Math.Max(0, results.Count() - countLastMovie));
        }
        private void ShowTheBest()
        {
            int countMovie = 10;
            var results = (from x in myMovie
                          orderby x.rating descending
                          select x).Take(countMovie);
            dataGridTheBest.ItemsSource = results;
        }
        public List<Movie> LoadMovies(string path)
        {
            try
            {
                using (Stream inputStream = File.OpenRead(path))
                {
                    Type type = typeof(List<Movie>);
                    XmlSerializer deserializer = new XmlSerializer(type, new XmlRootAttribute("Filmoteka"));
                    List<Movie> temp = (List<Movie>)deserializer.Deserialize(inputStream);
                    return temp;
                }
            }
            catch
            {
                MessageBox.Show("Nieudana próba wczytania pliku bazy.");
                List<Movie> temp = new List<Movie>();
                return temp;
            }
            
        }
        public void SaveMovies(string path)
        {
            try
            {
                File.Delete(path);
            
            using (Stream outputStream = File.OpenWrite(path))
            {
                Type type = typeof(List<Movie>);
                XmlSerializer serializer = new XmlSerializer(type, new XmlRootAttribute("Filmoteka"));
                serializer.Serialize(outputStream, myMovie);
            }
            }
            catch 
            {
                MessageBox.Show("Nieudana próba zapisu pliku bazy.");
            }
        }

        public void SaveMovies()
        {
            try
            {
                File.Delete(filename);

                using (Stream outputStream = File.OpenWrite(filename))
                {
                    Type type = typeof(List<Movie>);
                    XmlSerializer serializer = new XmlSerializer(type, new XmlRootAttribute("Filmoteka"));
                    serializer.Serialize(outputStream, myMovie);
                }
            }
            catch
            {
                MessageBox.Show("Nieudana próba zapisu pliku bazy.");
            }
        }

        private void addingMovie_Click(object sender, RoutedEventArgs e)
        {
            AddingMovie add = new AddingMovie(this.Left, this.Top,ref myMovie);
            add.Show();
            this.Close();
        }
        private void but_viewMovies_Click(object sender, RoutedEventArgs e)
        {
            ViewMovies add = new ViewMovies(this.Left, this.Top, ref myMovie);
            add.Show();
            this.Close();
        }

        private void but_save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                filename = dlg.FileName;
            }
            else return;
            SaveMovies(filename);
        }

        private void but_load_Click(object sender, RoutedEventArgs e)
        {
            myMovie.Clear();
            
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                 filename = dlg.FileName;
            }
            else return;
            myMovie = LoadMovies(filename);
            ShowLastWatched();
            ShowTheBest();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            SaveMovies();
        }
    }
    
}
