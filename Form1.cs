using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad.EzePractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int entero))
            {
                MessageBox.Show("Por favor ingrese un valor numerico");
                return;
            }

            if(!DateTime.TryParse(txtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("Por favor ingrese una fecha valida");
                return;
            }

            if (txtCadenaDeTexto.Text.Length < 10 || txtCadenaDeTexto.Text.Length > 20)
            {
                MessageBox.Show("Debe ingresar una cadena de texto entre 10 y 20 caracteres");
                return;
            }           

            int num = entero;
            DateTime fec = fecha;
            string tx = txtCadenaDeTexto.Text;
            MessageBox.Show($"Su numero es {num}, con la fecha {fec}, y la cadena {tx}");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int NumAnterior = int.MinValue;
        private void btnSerie_Click(object sender, EventArgs e)
        {
            
            
            if (!int.TryParse(txtSerie.Text, out int NumActual))
            {
                MessageBox.Show("Por favor ingrese un valor numerico");
                return;
            }

            if(!(NumActual > NumAnterior))
            {
                MessageBox.Show("Debe ingresar un numeor mayor al anterior");
                return;
            }

            NumAnterior = NumActual;
            txtSerie.Clear();
        }
    }
}
