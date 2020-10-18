using System;
using System.Collections;
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
    public partial class MantenimientoProducto : Form
    {
        int posX = 0;
        int posY = 0;
        int id = 0;

        NegocioProducto N_producto = new NegocioProducto();
        NegocioCategoria N_categoria = new NegocioCategoria();

        public MantenimientoProducto()
        {
            InitializeComponent();
        }

        //Funcion Load
        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        //Botones de funciones del CRUD
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "Nombre" && txtCodigo.Text != "Codigo" && txtExistencia.Text != "Existencia" && txtDescripcion.Text != "Descripcion" && cbCategoria.Text != "Categoria")
            {
                string nombre = txtNombre.Text;
                string codigo = txtCodigo.Text;
                int existencia = Convert.ToInt32(txtExistencia.Text);
                DateTime fecha = dtpFecha.Value;
                string descripcion = txtDescripcion.Text;
                string categoria = cbCategoria.Text;
                bool estado = true;

                try
                {
                    if (N_producto.AgregarProducto(nombre, codigo, existencia, fecha, descripcion, categoria, estado))
                    {
                        MessageBox.Show("El registro se guardo de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else { MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "ID")
            {
                id = Convert.ToInt32(txtId.Text);

                try
                {
                    ArrayList datos = N_producto.BuscarProducto(id);

                    if (datos.Count > 0)
                    {
                        txtNombre.Text = (string)datos[1];
                        txtCodigo.Text = (string)datos[2];
                        txtExistencia.Text = ((int)datos[3]).ToString();
                        dtpFecha.Value = (DateTime)datos[4];
                        txtDescripcion.Text = (string)datos[5];
                        cbCategoria.SelectedItem = (string)datos[6];
                        if ((bool)datos[7] == true) { rdbActivo.Checked = true; }
                        else { rdbInactivo.Checked = true; }

                        btnBuscar.Height = 82;
                        btnAgregar.Visible = false;
                        grpEstado.Enabled = true;
                        txtId.ForeColor = Color.Black;
                        txtNombre.ForeColor = Color.Black;
                        txtCodigo.ForeColor = Color.Black;
                        txtExistencia.ForeColor = Color.Black;
                        txtDescripcion.ForeColor = Color.Black;
                        cbCategoria.ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtId.Text = "ID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "Nombre" && txtCodigo.Text != "Codigo" && txtExistencia.Text != "Existencia" && txtDescripcion.Text != "Descripcion" && cbCategoria.Text != "Categoria")
            {
                string nombre = txtNombre.Text;
                string codigo = txtCodigo.Text;
                int existencia = Convert.ToInt32(txtExistencia.Text);
                DateTime fecha = dtpFecha.Value;
                string descripcion = txtDescripcion.Text;
                string categoria = cbCategoria.Text;
                bool estado = true;
                if (rdbActivo.Checked == true) { estado = true; }
                else { estado = false; }

                try
                {
                    if (N_producto.ModificarProducto(id, nombre, codigo, existencia, fecha, descripcion, categoria, estado))
                    {
                        MessageBox.Show("El registro se edito de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else { MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (N_producto.EliminarProducto(id))
                {
                    MessageBox.Show("El registro se elimino de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void CargarCategoria()
        {
            ArrayList datos = N_categoria.CargarCategoria();

            cbCategoria.Items.Clear();
            cbCategoria.Items.Add("Categoria");
            cbCategoria.SelectedIndex = 0;
            cbCategoria.ForeColor = Color.Silver;

            if (datos.Count > 0)
            {
                foreach (string cat in datos)
                { cbCategoria.Items.Add(cat); }
            }
            else
            {
                MessageBox.Show("No hay ninguna categoria registrada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Botones y Funciones del Formulario
        private void btnExit_Click(object sender, EventArgs e)
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCategoria();
        }
        public void LimpiarForm()
        {
            txtId.Text = "ID";
            txtId.ForeColor = Color.Silver;
            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.Silver;
            txtCodigo.Text = "Codigo";
            txtCodigo.ForeColor = Color.Silver;
            txtExistencia.Text = "Existencia";
            txtExistencia.ForeColor = Color.Silver;
            txtDescripcion.Text = "Descripcion";
            txtDescripcion.ForeColor = Color.Silver;

            CargarCategoria();
            dtpFecha.Value = DateTime.Today;

            rdbActivo.Checked = false;
            rdbInactivo.Checked = false;
            btnAgregar.Visible = true;
            grpEstado.Enabled = false;
            btnBuscar.Height = 123;
        }

        //Funciones de formato de los elementos
        private void txtId_MouseClick(object sender, MouseEventArgs e)
        {
            txtId.SelectAll();
        }
        private void txtId_Enter(object sender, EventArgs e)
        {
            txtId.SelectAll();
        }
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID";
                txtId.ForeColor = Color.Silver;
            }
            else if (txtId.Text != "ID")
            { txtId.ForeColor = Color.Black; }
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = txtId.Text;
            if (texto.Contains("D") || texto.Contains("I"))
            {
                txtId.Text = texto.Replace("D", "").Replace("I", "");
            }
            if (Char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else
            { e.Handled = true; }
        }
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtId.Text != "ID") { txtId.ForeColor = Color.Black; }
            if (e.KeyCode == Keys.Enter)
            { txtNombre.Focus(); }
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.SelectAll();
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.SelectAll();
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
            else if (txtNombre.Text != "Nombre")
            { txtNombre.ForeColor = Color.Black; }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = txtNombre.Text;
            if (texto.Contains("Nombre"))
            {
                txtNombre.Text = texto.Replace("Nombre", "");
            }
            if (txtNombre.Text != "Nombre") { txtNombre.ForeColor = Color.Black; }
        }

        private void txtCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            txtCodigo.SelectAll();
        }
        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            txtCodigo.SelectAll();
        }
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = "Nombre";
                txtCodigo.ForeColor = Color.Silver;
            }
            else if (txtCodigo.Text != "Nombre")
            { txtCodigo.ForeColor = Color.Black; }
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = txtCodigo.Text;
            if (texto.Contains("Codigo"))
            {
                txtCodigo.Text = texto.Replace("Codigo", "");
            }
            if (txtCodigo.Text != "Codigo") { txtCodigo.ForeColor = Color.Black; }
        }

        private void txtExistencia_MouseClick(object sender, MouseEventArgs e)
        {
            txtExistencia.SelectAll();
        }
        private void txtExistencia_Enter(object sender, EventArgs e)
        {
            txtExistencia.SelectAll();
        }
        private void txtExistencia_Leave(object sender, EventArgs e)
        {
            if (txtExistencia.Text == "")
            {
                txtExistencia.Text = "Existencia";
                txtExistencia.ForeColor = Color.Silver;
            }
            if (txtExistencia.Text != "Existencia")
            { txtExistencia.ForeColor = Color.Black; }
        }
        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = txtExistencia.Text;
            if (texto.Contains("Existencia"))
            {
                txtExistencia.Text = texto.Replace("Existencia", "");
            }
            if (txtExistencia.Text != "Existencia") { txtExistencia.ForeColor = Color.Black; }
            if (Char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else
            { e.Handled = true; }
        }

        private void txtDescripcion_MouseClick(object sender, MouseEventArgs e)
        {
            txtDescripcion.SelectAll();
        }
        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            txtDescripcion.SelectAll();
        }
        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion";
                txtDescripcion.ForeColor = Color.Silver;
            }
            if (txtDescripcion.Text != "Descripcion")
            { txtDescripcion.ForeColor = Color.Black; }
        }
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto = txtDescripcion.Text;
            if (texto.Contains("Descripcion"))
            {
                txtDescripcion.Text = texto.Replace("Descripcion", "");
            }
            if (txtDescripcion.Text != "Descripcion") { txtDescripcion.ForeColor = Color.Black; }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem.ToString() != "Categoria")
            {
                cbCategoria.Items.Remove("Categoria");
            }
            cbCategoria.ForeColor = Color.Black;
        }
        private void cbCategoria_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Font font = cbCategoria.Font;
                Brush brush = new SolidBrush(cbCategoria.ForeColor);
                string text = (string)cbCategoria.Items[e.Index];

                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;

                e.Graphics.DrawString(text, font, brush, e.Bounds, sf);
            }
        }
    }
}
