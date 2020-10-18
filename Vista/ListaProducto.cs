using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class ListaProducto : Form
    {
        int posX = 0;
        int posY = 0;
        NegocioProducto N_producto = new NegocioProducto();
        public ListaProducto()
        {
            InitializeComponent();
        }

        //Funcion del Load
        private void Form1_Load(object sender, EventArgs e)
        {
            btnRefrescar.PerformClick();
        }

        //Funcion de los Botones
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Tabla.DataSource = N_producto.ListarProducto();
            Tabla.ForeColor = Color.Black;
            DisenarTabla();
        }

        private void DisenarTabla()
        {
            DataGridViewCellStyle style = Tabla.ColumnHeadersDefaultCellStyle;
            style.Font = new Font(Tabla.Font, FontStyle.Bold);
            Tabla.Columns[0].Width = 50;
            Tabla.Columns[1].Width = 80;
            Tabla.Columns[2].Width = 70;
            Tabla.Columns[3].Width = 70;
            Tabla.Columns[4].Width = 100;
            Tabla.Columns[5].Width = 150;
            Tabla.Columns[6].Width = 100;
            Tabla.Columns[7].Width = 70;
        }

        //Funciones del Formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MoverFormulario(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
