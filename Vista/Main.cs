using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Vista
{
    public partial class Main : Form
    {
        MantenimientoCategoria frmCategoria = null;
        MantenimientoProducto frmProducto = null;
        ListaProducto frmLista = null;
        public Main()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(28, 31, 41);
        }

        private void btnMantenimientoCategorias_Click(object sender, EventArgs e)
        {
            if (frmCategoria == null)
            {
                frmCategoria = new MantenimientoCategoria();
                frmCategoria.MdiParent = this;
                frmCategoria.FormClosed += new FormClosedEventHandler(CerrarCategorias);
                frmCategoria.Show();
            }
            else if (frmCategoria.WindowState == FormWindowState.Minimized)
            { frmCategoria.WindowState = FormWindowState.Normal; }
            else { frmCategoria.Focus(); }
        }

        private void btnMantenimientoProductos_Click(object sender, EventArgs e)
        {
            if (frmProducto == null)
            {
                frmProducto = new MantenimientoProducto();
                frmProducto.MdiParent = this;
                frmProducto.FormClosed += new FormClosedEventHandler(CerrarProductos);
                frmProducto.Show();
            }
            else if (frmProducto.WindowState == FormWindowState.Minimized)
            { frmProducto.WindowState = FormWindowState.Normal; }
            else { frmProducto.Focus(); }
        }

        private void btnListaProductos_Click(object sender, EventArgs e)
        {
            if (frmLista == null)
            {
                frmLista = new ListaProducto();
                frmLista.MdiParent = this;
                frmLista.FormClosed += new FormClosedEventHandler(CerrarLista);
                frmLista.Show();
            }
            else if (frmLista.WindowState == FormWindowState.Minimized)
            { frmLista.WindowState = FormWindowState.Normal; }
            else { frmLista.Focus(); }
        }

        private void CerrarCategorias(object Sender, FormClosedEventArgs e)
        { frmCategoria = null; }
        private void CerrarProductos(object Sender, FormClosedEventArgs e)
        { frmProducto = null; }
        private void CerrarLista(object Sender, FormClosedEventArgs e)
        { frmLista = null; }
    }
}
