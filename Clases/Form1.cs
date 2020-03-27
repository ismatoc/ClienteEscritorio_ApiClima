using Clases.ApiRest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        DBApi dBApi = new DBApi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrueba_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textpais.Text))
            {
                
                MessageBox.Show("Ingrese Pais a consultar..!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtresppais.Text = "";
                textresptemperatura.Text = "";
                textresplatitud.Text = "";
                textresplong.Text = "";
                textresphumedad.Text = "";
                textresppresion.Text = "";
                textrespdescripcion.Text = "";
            }
            else
            {
                string apiKey = "2fdf9393f1999ef93037da58ae454505";
                dynamic respuesta = dBApi.Get("http://api.weatherstack.com/current?access_key=" + apiKey + "&query=" + textpais.Text);
                txtresppais.Text = respuesta.request.query;
                textresptemperatura.Text = "Temperatura: " + respuesta.current.temperature;
                textresplatitud.Text = "Latitud: " + respuesta.location.lat;
                textresplong.Text = "Longitud: " + respuesta.location.lon;
                textresphumedad.Text = "Humedad: " + respuesta.current.humidity;
                textresppresion.Text = "Presion: " + respuesta.current.pressure;
                textrespdescripcion.Text = "Descripcion: " + respuesta.current.weather_descriptions[0];
                textpais.Text = "";
                
            }

            textpais.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textpais.Focus();
        }
    }

  
}

