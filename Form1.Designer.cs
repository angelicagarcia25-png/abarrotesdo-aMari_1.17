namespace abarrotesdoñaMari_1._17
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblExistencia = new Label();
            btnGuardar = new Button();
            btnExportar = new Button();
            dgvProductos = new DataGridView();
            TabControl1 = new TabControl();
            TabIngresar = new TabPage();
            txtExistencia = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            TabTabla = new TabPage();
            TabCompras = new TabPage();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            lblAviso = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            TabControl1.SuspendLayout();
            TabIngresar.SuspendLayout();
            TabTabla.SuspendLayout();
            TabCompras.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(119, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(692, 61);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Farmacias Similares Inventario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Sylfaen", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(6, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(155, 48);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Sylfaen", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(6, 97);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(129, 48);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // lblExistencia
            // 
            lblExistencia.AutoSize = true;
            lblExistencia.Font = new Font("Sylfaen", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExistencia.Location = new Point(6, 172);
            lblExistencia.Name = "lblExistencia";
            lblExistencia.Size = new Size(187, 48);
            lblExistencia.TabIndex = 3;
            lblExistencia.Text = "Existencia:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(474, 238);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 47);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(275, 258);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(218, 47);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Exportar a Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(40, 21);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(707, 216);
            dgvProductos.TabIndex = 6;
            dgvProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabIngresar);
            TabControl1.Controls.Add(TabTabla);
            TabControl1.Controls.Add(TabCompras);
            TabControl1.Location = new Point(51, 120);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(809, 356);
            TabControl1.TabIndex = 7;
            TabControl1.Tag = "Productos";
            // 
            // TabIngresar
            // 
            TabIngresar.Controls.Add(txtExistencia);
            TabIngresar.Controls.Add(txtPrecio);
            TabIngresar.Controls.Add(txtNombre);
            TabIngresar.Controls.Add(lblNombre);
            TabIngresar.Controls.Add(lblPrecio);
            TabIngresar.Controls.Add(btnGuardar);
            TabIngresar.Controls.Add(lblExistencia);
            TabIngresar.Location = new Point(4, 24);
            TabIngresar.Name = "TabIngresar";
            TabIngresar.Padding = new Padding(3);
            TabIngresar.Size = new Size(801, 328);
            TabIngresar.TabIndex = 0;
            TabIngresar.Text = "Registrar";
            TabIngresar.UseVisualStyleBackColor = true;
            TabIngresar.Click += tabPage1_Click;
            // 
            // txtExistencia
            // 
            txtExistencia.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExistencia.Location = new Point(187, 183);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(213, 34);
            txtExistencia.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(128, 108);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(213, 34);
            txtPrecio.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(156, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 34);
            txtNombre.TabIndex = 5;
            // 
            // TabTabla
            // 
            TabTabla.Controls.Add(btnExportar);
            TabTabla.Controls.Add(dgvProductos);
            TabTabla.Location = new Point(4, 24);
            TabTabla.Name = "TabTabla";
            TabTabla.Padding = new Padding(3);
            TabTabla.Size = new Size(801, 328);
            TabTabla.TabIndex = 1;
            TabTabla.Text = "Inventario";
            TabTabla.UseVisualStyleBackColor = true;
            // 
            // TabCompras
            // 
            TabCompras.Controls.Add(maskedTextBox2);
            TabCompras.Controls.Add(maskedTextBox1);
            TabCompras.Controls.Add(label2);
            TabCompras.Controls.Add(label1);
            TabCompras.Controls.Add(button1);
            TabCompras.Location = new Point(4, 24);
            TabCompras.Name = "TabCompras";
            TabCompras.Padding = new Padding(3);
            TabCompras.Size = new Size(801, 328);
            TabCompras.TabIndex = 2;
            TabCompras.Text = "Venta";
            TabCompras.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(254, 125);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(254, 40);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 133);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 43);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(306, 241);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Location = new Point(300, 102);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(36, 15);
            lblAviso.TabIndex = 8;
            lblAviso.Text = "Aviso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 519);
            Controls.Add(lblAviso);
            Controls.Add(TabControl1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            TabControl1.ResumeLayout(false);
            TabIngresar.ResumeLayout(false);
            TabIngresar.PerformLayout();
            TabTabla.ResumeLayout(false);
            TabCompras.ResumeLayout(false);
            TabCompras.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblExistencia;
        private Button btnGuardar;
        private Button btnExportar;
        private DataGridView dgvProductos;
        private TabControl TabControl1;
        private TabPage TabIngresar;
        private TabPage TabTabla;
        private TextBox txtExistencia;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label lblAviso;
        private TabPage TabCompras;
        private Button button1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label1;
    }
}
