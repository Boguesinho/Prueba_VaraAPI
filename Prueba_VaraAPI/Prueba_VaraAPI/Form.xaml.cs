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
using System.Net.Http;
using System.Net.Http.Headers;


namespace Prueba_VaraAPI
{
    /// <summary>
    /// Lógica de interacción para Form.xaml
    /// </summary>
    public partial class Form : Window
    {
        

        public Form()
        {
            InitializeComponent();
        }

        bool facilAccesso = false;
        bool acantilado = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void addVaramiento()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://ec2-3-137-222-34.us-east-2.compute.amazonaws.com/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJmcmVzaCI6dHJ1ZSwiaWF0IjoxNjM3NDUxOTc3LCJqdGkiOiI1YmRlNTJkZC0zMGM4LTQyOTctYjA3MS00MDI4NzI4ZDJjYTIiLCJ0eXBlIjoiYWNjZXNzIiwic3ViIjoiNGVhMGU4YjAtMWVmYy00ZjIyLWFjZDAtN2IzODE2YzkxMDg2IiwibmJmIjoxNjM3NDUxOTc3LCJleHAiOjE2Mzc0NzM1Nzd9.8RrpFsJY3e3IVTA3YTnG86ifkvzeGxzidzPQqkGdUyc");

            var varamiento = new Varamiento
            {
                finalizado = false,
                nombreInformante = infoNom.Text,
                telefonoInformante = infoTel.Text,
                direccioninformante = infoDir.Text,
                ordenAnimal = ordenAnimal.Text,
                condicionAnimal = condicionAnimal.Text,
                numeroAnimales = Int32.Parse(numAnimales.Text),
                observaciones = observaciones.Text,
                facilAcceso = facilAccesso,
                acantilado = acantilado,
                sustrato = sustrato.Text,
                primeraVezVisto = primeraVisto.Text,
                fechaAvistamiento = fechaAvistamiento.Text,
                pais = pais.Text,
                estado = estado.Text,
                ciudad = ciudad.Text,
                localidad = localidad.Text,
                informacionAdicionalUbicacion = infoAdicional.Text,
                latitud = latitud.Text,
                longitud = longitud.Text
            };

            var response = client.PostAsJsonAsync("/yo/varamientos", varamiento).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Varamiento registrado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
        private void facilAcChb_Checked(object sender, RoutedEventArgs e)
        {
            if (facilAccessoCB.IsChecked == true)
            {
                facilAccesso = true;
            }
            else
            {
                facilAccesso = false;
            }

        }

        private void acantiladoChb_Checked(object sender, RoutedEventArgs e)
        {
            if (acantiladoCB.IsChecked == true)
            {
                acantilado = true;
            }
            else
            {
                acantilado = false;
            }

        }

        private void Button_Click_guardar(object sender, RoutedEventArgs e)
        {
        addVaramiento();
        }
    }
}
