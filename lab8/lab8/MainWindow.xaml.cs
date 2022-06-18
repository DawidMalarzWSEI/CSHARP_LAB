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

namespace lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// using System;
    using System.IO;
    using System.Net;
    using System.Net.Mime;
    using System.Text.Json;


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //< Button Height = "20" Margin = "10 0 0 0" Content = "Text" Click = "textBtn_Click" />
            //foreach
            //this.pnlTypes.Children.Add(Button.)


            int pageNumber = 1;
            int pageSize = 5;
            string snippetsType = "cs"; // C#

            PageReposne reponse = FetchSnippets(pageNumber, pageSize, snippetsType);

            dataGrid.ItemsSource = reponse.Batches;

        }

        public static string FetchData(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                ContentType type = new ContentType(response.ContentType ?? "text/plain;charset=" + Encoding.UTF8.WebName);
                Encoding encoding = Encoding.GetEncoding(type.CharSet ?? Encoding.UTF8.WebName);

                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public static PageReposne FetchSnippets(int pageNumber, int pageSize, string snippetsType)
        {
            string url = $"https://dirask.com/api/snippets?pageNumber={pageNumber}&pageSize={pageSize}&dataOrder=newest&dataGroup=batches&snippetsType={Uri.EscapeUriString(snippetsType)}";
            string data = FetchData(url);

            return JsonSerializer.Deserialize<PageReposne>(data);
        }

        private void textBtn_Click(object sender, RoutedEventArgs e)
        {
            string snippetsType = "text"; // C#

            PageReposne reponse = FetchSnippets(1, 5, snippetsType);

            dataGrid.ItemsSource = reponse.Batches;
        }

        private void bashBtn_Click(object sender, RoutedEventArgs e)
        {
            string snippetsType = "bash"; // C#

            PageReposne reponse = FetchSnippets(1, 5, snippetsType);

            dataGrid.ItemsSource = reponse.Batches;
        }

        private void cppBtn_Click(object sender, RoutedEventArgs e)
        {
            string snippetsType = "cpp"; // C#

            PageReposne reponse = FetchSnippets(1, 5, snippetsType);

            dataGrid.ItemsSource = reponse.Batches;
        }

        private void csharpBtn_Click(object sender, RoutedEventArgs e)
        {
            string snippetsType = "c#"; // C#

            PageReposne reponse = FetchSnippets(1, 5, snippetsType);

            dataGrid.ItemsSource = reponse.Batches;
        }

        private void javaBtn_Click(object sender, RoutedEventArgs e)
        {
            string snippetsType = "java"; // C#

            PageReposne reponse = FetchSnippets(1, 5, snippetsType);

            dataGrid.ItemsSource = reponse.Batches;
        }

        private void cssBtn_Click(object sender, RoutedEventArgs e)
        {
            string snippetsType = "css"; // C#

            PageReposne reponse = FetchSnippets(1, 5, snippetsType);

            dataGrid.ItemsSource = reponse.Batches;
        }

        private void htmlBtn_Click(object sender, RoutedEventArgs e)
        {
            string snippetsType = "html"; // C#

            PageReposne reponse = FetchSnippets(1, 5, snippetsType);

            dataGrid.ItemsSource = reponse.Batches;
        }
    }
}
