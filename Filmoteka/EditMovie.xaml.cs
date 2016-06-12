using System;
using System.Collections.Generic;
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
    /// Interaction logic for EditMovie.xaml
    /// </summary>
    public partial class EditMovie : Window
    {
        private List<Movie> myMovie;
        private Movie editMovie;
        private string[] categories = { "Akcja", "Komedia", "Dramat","Animowany","Familijny","Fantasy"
                ,"Horror","Komedia rom.","Kryminał","Przygodowy","Romans","Thriller","Western","Wojenny" };

        public EditMovie()
        {
            InitializeComponent();
            comboBox.ItemsSource = categories;
        }
        public EditMovie(double _left, double _top, ref List<Movie> _myMovie, Movie _edit)
        {
            InitializeComponent();
            Left = _left;
            Top = _top;
            myMovie = _myMovie;
            comboBox.ItemsSource = categories;
            editMovie = _edit;
            FillForm();
        }

        private void FillForm()
        {
            textBoxTitle.Text=editMovie.title;
            sliderRating.Value = editMovie.rating;
            textBoxYear.Text = editMovie.year.ToString();

            foreach (var item in editMovie.category.names)
            {
                System.Windows.Controls.Button newBtn = new Button();
                newBtn.Content = item;
                newBtn.Name = "But_" + item;
                newBtn.Click += new RoutedEventHandler(ButtonCategory_Click);
                toolBar.Items.Add(newBtn);
            }
            textBoxComment.Text = editMovie.comment;
        }

        private void but_return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow(this.Left, this.Top, ref myMovie);
            window.Show();
            this.Close();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in toolBar.Items)
            {
                System.Windows.Controls.Button but = item as System.Windows.Controls.Button;
                if (but != null && but.Content.Equals(comboBox.SelectedValue))
                {
                    return;
                }
            }

            System.Windows.Controls.Button newBtn = new Button();
            newBtn.Content = comboBox.SelectedValue;
            newBtn.Name = "But_" + comboBox.SelectedValue;
            newBtn.Click += new RoutedEventHandler(ButtonCategory_Click);

            toolBar.Items.Add(newBtn);
        }

        void ButtonCategory_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button obj = sender as System.Windows.Controls.Button;
            toolBar.Items.Remove(obj);
        }
        private bool parseIn()
        {
            bool ok = true;
            textBoxTitle.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            textBoxYear.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            toolBar.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            if (textBoxTitle.Text == "")
            {
                textBoxTitle.Background = new SolidColorBrush(Color.FromArgb(255, 255, 55, 55));
                ok = false;
            }
            int number;
            if (textBoxYear.Text == "" || !Int32.TryParse(textBoxYear.Text, out number))
            {
                textBoxYear.Background = new SolidColorBrush(Color.FromArgb(255, 255, 55, 55));
                ok = false;
            }
            if (toolBar.Items.Count == 0)
            {
                toolBar.Background = new SolidColorBrush(Color.FromArgb(255, 255, 55, 55));
                ok = false;
            }
            return ok;
        }
        private void but_saveMovie_Click(object sender, RoutedEventArgs e)
        {
            if (!parseIn()) return;


            string title = textBoxTitle.Text;
            int rating = (int)sliderRating.Value;
            int year = Int32.Parse(textBoxYear.Text);
            List<string> category = new List<string>();
            int index = 0;
            foreach (var item in toolBar.Items)
            {
                System.Windows.Controls.Button but = item as System.Windows.Controls.Button;
                if (but != null)
                {
                    category.Add((string)but.Content);
                    index++;
                }
            }
            string comment = textBoxComment.Text;
            var i = myMovie.FindIndex(x => x.Equals(editMovie));
            myMovie[i] = new Movie(title, rating, year, new Category(category), comment);


            MainWindow window = new MainWindow(this.Left, this.Top, ref myMovie);
            window.Show();
            this.Close();
        }
    }
}

