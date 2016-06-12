using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Filmoteka
{
    /// <summary>
    /// Interaction logic for ViewMovies.xaml
    /// </summary>
    public partial class ViewMovies : Window
    {
        private List<Movie> myMovie;
        private string[] categories = { "Akcja", "Komedia", "Dramat","Animowany","Familijny","Fantasy"
                ,"Horror","Komedia rom.","Kryminał","Przygodowy","Romans","Thriller","Western","Wojenny" };
        private enum searchC
        {
            Tytul,
            Ocena,
            Rok_produkcji,
            Kategoria
        }
        public ViewMovies()
        {
            InitializeComponent();
            comboBox.ItemsSource = Enum.GetValues(typeof(searchC)); 
            comboBoxCategory.ItemsSource = categories;
        }
        public ViewMovies(double _left, double _top, ref List<Movie> _myMovie)
        {
            InitializeComponent();
            Left = _left;
            Top = _top;
            myMovie = _myMovie;
            ShowAll();
            comboBox.ItemsSource = Enum.GetValues(typeof(searchC));
            comboBoxCategory.ItemsSource = categories;
        }

        private void but_return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow(this.Left, this.Top, ref myMovie);
            window.Show();
            this.Close();
        }

        private void ShowAll()
        {
            var results = from x in myMovie
                          select x;
            dataGridMovies.ItemsSource = myMovie.Intersect(results).ToList();
        }
        private bool parseIn()
        {
            bool ok = true;
            textBoxName.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            comboBoxCategory.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            int number;
            try
            {
                searchC choice = (searchC)comboBox.SelectedValue;
                switch (choice)
                {
                    case searchC.Tytul:
                        if (textBoxName.Text == "")
                        {
                            textBoxName.Background = new SolidColorBrush(Color.FromArgb(255, 255, 55, 55));
                        }
                        break;
                    case searchC.Ocena:
                        if (textBoxName.Text == "" || !Int32.TryParse(textBoxName.Text, out number))
                        {
                            textBoxName.Background = new SolidColorBrush(Color.FromArgb(255, 255, 55, 55));
                            ok = false;
                        }
                        break;
                    case searchC.Rok_produkcji:
                        if (textBoxName.Text == "" || !Int32.TryParse(textBoxName.Text, out number))
                        {
                            textBoxName.Background = new SolidColorBrush(Color.FromArgb(255, 255, 55, 55));
                            ok = false;
                        }
                        break;
                    case searchC.Kategoria:
                        if (comboBoxCategory.SelectedItem == null)
                        {
                            comboBoxCategory.Background = new SolidColorBrush(Color.FromArgb(255, 255, 55, 55));
                            ok = false;
                        }
                        break;
                }
            }
            catch
            {
                ok = false;
            }
            return ok;
        }
        private void but_search_Click(object sender, RoutedEventArgs e)
        {
            show();
        }

        private void show()
        {
            dataGridMovies.ItemsSource = null;
            if (!parseIn()) return;
            IEnumerable<Movie> results;
            try
            {
                searchC choice = (searchC)comboBox.SelectedValue;
                switch (choice)
                {
                    case searchC.Tytul:
                        results = from x in myMovie
                                      where x.title.ToLower().Contains(textBoxName.Text.ToLower())
                                      select x;
                        dataGridMovies.ItemsSource = myMovie.Intersect(results).ToList();
                        break;
                    case searchC.Ocena:
                        results = from x in myMovie
                                      where x.rating == Int32.Parse(textBoxName.Text)
                                      select x;
                        dataGridMovies.ItemsSource = myMovie.Intersect(results).ToList();
                        break;
                    case searchC.Rok_produkcji:
                        results = from x in myMovie
                                      where x.year == Int32.Parse(textBoxName.Text)
                                      select x;
                        dataGridMovies.ItemsSource = myMovie.Intersect(results).ToList();
                        break;
                    case searchC.Kategoria:
                        string str = comboBoxCategory.SelectedItem.ToString();
                        results = from x in myMovie
                                      where x.category.ToString().Contains(str)
                                      select x;
                        dataGridMovies.ItemsSource = myMovie.Intersect(results).ToList();
                        break;
                    default:
                        ShowAll();
                        break;
                }
            }
            catch
            {

            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBox.SelectedValue.Equals(searchC.Kategoria))
            {
                textBoxName.Visibility = Visibility.Hidden;
                comboBoxCategory.Visibility = Visibility.Visible;
            }
            else
            {
                textBoxName.Visibility = Visibility.Visible;
                comboBoxCategory.Visibility = Visibility.Hidden;
            }
        }

        private void but_showAll_Click(object sender, RoutedEventArgs e)
        {
            ShowAll();
        }

        private void MenuItem_Edit(object sender, System.Windows.RoutedEventArgs  e)
        {
            if ((Movie)dataGridMovies.SelectedItem == null) return;
            EditMovie window = new EditMovie(this.Left, this.Top, ref myMovie, (Movie)dataGridMovies.SelectedItem);
            window.Show();
            this.Close();
        }
        private void MenuItem_Delete(object sender, System.Windows.RoutedEventArgs e)
        {
            if ((Movie)dataGridMovies.SelectedItem == null) return;
            myMovie.Remove((Movie)dataGridMovies.SelectedItem);
            show();
        }
    }
}
