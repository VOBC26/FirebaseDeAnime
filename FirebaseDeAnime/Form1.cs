using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirebaseDeAnime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "6NWLKDGntCmp6O8LnxTua3b0vnrFEX8RavOSX6FI",
            BasePath = "https://fir-anime-48918-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Existe un problema en la conexion de la internet");
            }
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            Animes std = new Animes
            {
                Nombre = txtNombre.Text,
                Tipo = txtTipo.Text,
                Genero = txtGenero.Text,
                Episodios = txtEpisodio.Text,
                Duracion = txtDuracion.Text,
                Emitido = txtEmitido.Text
            };
            var setter = client.Set("Lista de animes/" + txtGenero.Text, std);
            txtNombre.Text = "";
            txtTipo.Text = "";
            txtGenero.Text = "";
            txtEpisodio.Text = "";
            txtDuracion.Text = "";
            txtEmitido.Text = "";
            MessageBox.Show("Datos insertados correctamente");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            var resultado = client.Get("Lista de animes/" + txtGenero.Text);
            Animes std = resultado.ResultAs<Animes>();
            txtNombre.Text = std.Nombre;
            txtTipo.Text = std.Tipo;
            txtEpisodio.Text = std.Episodios;
            txtDuracion.Text = std.Duracion;
            txtEmitido.Text = std.Emitido;
            MessageBox.Show("Datos encontrados en la base de datos.");
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Animes std = new Animes
            {
                Nombre = txtNombre.Text,
                Tipo = txtTipo.Text,
                Genero = txtGenero.Text,
                Episodios = txtEpisodio.Text,
                Duracion = txtDuracion.Text,
                Emitido = txtEmitido.Text
            };
            var setter = client.Set("Lista de animes/" + txtGenero.Text, std);
            MessageBox.Show("Datos actualizados correctamente");
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            var resultado = client.Delete("Lista de animes/" + txtGenero.Text);
            txtNombre.Text = "";
            txtTipo.Text = "";
            txtGenero.Text = "";
            txtEpisodio.Text = "";
            txtDuracion.Text = "";
            txtEmitido.Text = "";
            MessageBox.Show("Datos borrados correctamente");
        }
    }
}
