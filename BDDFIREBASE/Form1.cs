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

namespace BDDFIREBASE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "LCpXI12mV9HhCtCeyIOBVv7xElwT4OaRVqUII3eU",
            BasePath = "https://demobd-acbad-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }catch
            {
                MessageBox.Show("Existe un problema en la conexion de la internet");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante std = new Estudiante
            {
                Nombre = textBox1.Text,
                Cuenta = textBox2.Text,
                Semestre = textBox3.Text,
                Grupo = textBox4.Text
            };
            var setter = client.Set("ListaEstudiantes/" + textBox2.Text, std);
            MessageBox.Show("Datos insertados correctamente");
        }
    }
}
