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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace how_much
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string homework2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog bbb = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = bbb.ShowDialog();

            if (result == true)
            {
                homework2 = bbb.FileName;

                string[] lines = System.IO.File.ReadAllLines(homework2);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');

                    no2 item = new no2();

                    item.Day.Text = parts[0];
                    item.ItemName.Text = parts[1];
                    item.ItemPrice.Text = parts[2];

                    ToDoList.Children.Add(item);
                }
            }
        }



        private void Window_Closed(object sender, EventArgs e)
        {
            List<string> homework2s = new List<string>();

            foreach (no2 item in ToDoList.Children)
            {
                string homework2 = "";

                homework2 += item.Day.Text + "|" + item.ItemName.Text + "|" + item.ItemPrice.Text;

                homework2s.Add(homework2);
            }

            try
            {
                System.IO.File.WriteAllLines(homework2, homework2s);
            }
            catch
            {
                Microsoft.Win32.SaveFileDialog bbb = new Microsoft.Win32.SaveFileDialog();

                Nullable<bool> result = bbb.ShowDialog();

                if (result == true)
                {
                    homework2 = bbb.FileName;

                    System.IO.File.WriteAllLines(homework2, homework2s);
                }
            }

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int all = 0;

            foreach (no2 item in ToDoList.Children)
            {
                all += item.itemPriceValue;
            }

            total.Text = all.ToString();

        }

        private void plus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            no2 item = new no2();
            item.Delete += new EventHandler(Delete);

            ToDoList.Children.Add(item);
        }
        private void Delete(object sender, EventArgs e)
        {
            ToDoList.Children.Remove((no2)sender);
        }
    }
}
