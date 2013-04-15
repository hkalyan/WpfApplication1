using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridTextColumn c1 = new DataGridTextColumn();
            c1.Header = "Name";
            c1.Binding = new Binding("Name");
            c1.Width = 80;
            dataGrid1.Columns.Add(c1);
            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Email";
            c2.Width = 120;
            c2.Binding = new Binding("Email");
            dataGrid1.Columns.Add(c2);
            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "UIN";
            c3.Width = 80;
            c3.Binding = new Binding("UIN");
            dataGrid1.Columns.Add(c3);

            dataGrid1.Items.Add(new Item() { Name = "Sherni Minu", Email = "srajaram", UIN = "00905111" });
            dataGrid1.Items.Add(new Item() { Name = "Hari Phaneendra", Email = "hkalyan", UIN = "00901369" });
            //Add Items to the dropdown box
            comboBox1.Items.Add("Manual");
            comboBox1.Items.Add("Automatic");
            comboBox1.SelectedIndex = 0;
         
        }
        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Window1().Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.ShowDialog();
            //if(openfiledialog.FileOk)
           // System.IO.Stream fileStream = openfiledialog.FileOk;


        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string UIN { get; set; }
    }
}
