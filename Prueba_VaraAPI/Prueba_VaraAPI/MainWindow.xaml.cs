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
using System.Net.Http;
using System.Net.Http.Headers;

namespace Prueba_VaraAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            getMisVaramientos();
        }
        public List<Varamiento> resultado { get; set; }

        public void getMisVaramientos ()
        {
            HttpClient client= new HttpClient();
            client.BaseAddress = new Uri("http://ec2-3-137-222-34.us-east-2.compute.amazonaws.com/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJmcmVzaCI6dHJ1ZSwiaWF0IjoxNjM3NDUxOTc3LCJqdGkiOiI1YmRlNTJkZC0zMGM4LTQyOTctYjA3MS00MDI4NzI4ZDJjYTIiLCJ0eXBlIjoiYWNjZXNzIiwic3ViIjoiNGVhMGU4YjAtMWVmYy00ZjIyLWFjZDAtN2IzODE2YzkxMDg2IiwibmJmIjoxNjM3NDUxOTc3LCJleHAiOjE2Mzc0NzM1Nzd9.8RrpFsJY3e3IVTA3YTnG86ifkvzeGxzidzPQqkGdUyc");
            HttpResponseMessage response = client.GetAsync("yo/varamientos").Result;
            
            if (response.IsSuccessStatusCode)
            {
                var varamientos = response.Content.ReadAsAsync<IEnumerable<Varamiento>>().Result;
                dg_varamientos.ItemsSource= varamientos;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Form form = new Form();
            form.Show();
            this.Close();
        }
    }
}
