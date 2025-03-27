using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;
using System.Net.Http;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json.Linq;

namespace API_REST {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Crear vuestra APIkey para comprobar que funciona
            string apikey = "a285be9e83300f50a8a42ffbd0da297a";
            string ciudad = txt_ciudad1.Text;
            string unidades = "metric";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q=" + ciudad + "&appid=" + apikey + "&units=" + unidades;

            using (HttpClient client = new HttpClient())

            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                string datociudad = await response.Content.ReadAsStringAsync();
                dynamic objDatosCiudad = JValue.Parse(datociudad);
                this.lb_temp1.Text = objDatosCiudad.main.temp + "ºC";
                this.lb_tiempo1.Text = objDatosCiudad.weather[0].description ;
                txt_consulta.Text = datociudad;
                

            }
            
        }

        //Crear vuestra APIkey para comprobar que funciona
        private async void button2_Click(object sender, EventArgs e)
        {
            this.txt_consulta.Clear();

            //crea tus propias credenciales para que funcione.
            string apikey = "a285be9e83300f50a8a42ffbd0da297a";
            string ciudad = txt_ciudad2.Text;
            string unidades = "metric";

            string url = $"https://api.openweathermap.org/data/2.5/weather?q=" + ciudad + "&appid=" + apikey + "&units=" + unidades;

            using (HttpClient client = new HttpClient())

            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                string datociudad = await response.Content.ReadAsStringAsync();
                ResultadoTiempo datosTiempo = JsonConvert.DeserializeObject<ResultadoTiempo>(datociudad);
                this.lb_temp2.Text = datosTiempo.Main.Temp.ToString() + "ºC";
                this.lb_tiempo2.Text = datosTiempo.Weather[0].Description ;
                txt_consulta.Text = datociudad;
            }
        }
    }
    public class Coord
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Feels_like { get; set; }
        public double Temp_min { get; set; }
        public double Temp_max { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
        public int Deg { get; set; }
    }

    public class Clouds
    {
        public int All { get; set; }
    }

    public class Sys
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }

    public class ResultadoTiempo
    {
        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }

}
