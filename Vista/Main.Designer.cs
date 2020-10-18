namespace Vista
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMantenimientoCategorias = new System.Windows.Forms.Button();
            this.btnMantenimientoProductos = new System.Windows.Forms.Button();
            this.btnListaProducto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(90)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnMantenimientoCategorias);
            this.panel1.Controls.Add(this.btnMantenimientoProductos);
            this.panel1.Controls.Add(this.btnListaProducto);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(90)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT\r\nMANAGER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.list_64px;
            this.pictureBox1.Location = new System.Drawing.Point(206, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Vista.Properties.Resources.exit_25px;
            this.btnSalir.Location = new System.Drawing.Point(1143, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 63);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMantenimientoCategorias
            // 
            this.btnMantenimientoCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMantenimientoCategorias.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoCategorias.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoCategorias.Image = global::Vista.Properties.Resources.maintenance_date_25px;
            this.btnMantenimientoCategorias.Location = new System.Drawing.Point(750, 22);
            this.btnMantenimientoCategorias.Name = "btnMantenimientoCategorias";
            this.btnMantenimientoCategorias.Size = new System.Drawing.Size(214, 63);
            this.btnMantenimientoCategorias.TabIndex = 2;
            this.btnMantenimientoCategorias.Text = "Mantenimiento de Categorias";
            this.btnMantenimientoCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMantenimientoCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMantenimientoCategorias.UseVisualStyleBackColor = true;
            this.btnMantenimientoCategorias.Click += new System.EventHandler(this.btnMantenimientoCategorias_Click);
            // 
            // btnMantenimientoProductos
            // 
            this.btnMantenimientoProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMantenimientoProductos.FlatAppearance.BorderSize = 0;
            this.btnMantenimientoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientoProductos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoProductos.ForeColor = System.Drawing.Color.White;
            this.btnMantenimientoProductos.Image = global::Vista.Properties.Resources.maintenance_25px;
            this.btnMantenimientoProductos.Location = new System.Drawing.Point(530, 22);
            this.btnMantenimientoProductos.Name = "btnMantenimientoProductos";
            this.btnMantenimientoProductos.Size = new System.Drawing.Size(214, 63);
            this.btnMantenimientoProductos.TabIndex = 2;
            this.btnMantenimientoProductos.Text = "Mantenimiento de Productos";
            this.btnMantenimientoProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMantenimientoProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMantenimientoProductos.UseVisualStyleBackColor = true;
            this.btnMantenimientoProductos.Click += new System.EventHandler(this.btnMantenimientoProductos_Click);
            // 
            // btnListaProducto
            // 
            this.btnListaProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListaProducto.FlatAppearance.BorderSize = 0;
            this.btnListaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaProducto.ForeColor = System.Drawing.Color.White;
            this.btnListaProducto.Image = global::Vista.Properties.Resources.list_25px;
            this.btnListaProducto.Location = new System.Drawing.Point(310, 22);
            this.btnListaProducto.Name = "btnListaProducto";
            this.btnListaProducto.Size = new System.Drawing.Size(214, 63);
            this.btnListaProducto.TabIndex = 1;
            this.btnListaProducto.Text = "Lista de productos";
            this.btnListaProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListaProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListaProducto.UseVisualStyleBackColor = true;
            this.btnListaProducto.Click += new System.EventHandler(this.btnListaProductos_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1266, 584);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMantenimientoCategorias;
        private System.Windows.Forms.Button btnMantenimientoProductos;
        private System.Windows.Forms.Button btnListaProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}