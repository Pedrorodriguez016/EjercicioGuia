using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace ServidorEjercicio_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            Socket server;
            //Crear el IPEndPoint de nuestro cliente al servidor por el puerto al que nos queremos conectar
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9051);

            //crear el socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;
                if (NombrePalindro.Checked)
                {
                    string nombre = "1/" + Datos.Text;
                    //enviamos al servidor el nombre introducido
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(nombre);
                    server.Send(msg);

                    //recibimos el resultado
                    byte[] msg2 = new byte[512];
                    server.Receive(msg2);
                    nombre = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    if (nombre == "NO")
                        MessageBox.Show("Tu nombre no es palindro");
                    else
                        MessageBox.Show("El nombre"  +nombre+  " es palindro");

                }
                
                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close();
            }
            catch(SocketException)
            {
                MessageBox.Show("No se pudo conectar al servidor");
            }


        }
    }
}
