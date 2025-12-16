namespace Estructura_de_datos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbEstructura;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbEstructura = new ComboBox();
            txtDato = new TextBox();
            txtSalida = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnConectarGrafos = new Button();
            txtDestino = new TextBox();
            txtOrigen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnPreOrden = new Button();
            btnInOrden = new Button();
            btnPostOrden = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbEstructura
            // 
            cmbEstructura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstructura.Location = new Point(20, 20);
            cmbEstructura.Name = "cmbEstructura";
            cmbEstructura.Size = new Size(200, 23);
            cmbEstructura.TabIndex = 0;
            cmbEstructura.SelectedIndexChanged += cmbEstructura_SelectedIndexChanged;
            // 
            // txtDato
            // 
            txtDato.Location = new Point(240, 20);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(100, 23);
            txtDato.TabIndex = 1;
            // 
            // txtSalida
            // 
            txtSalida.Location = new Point(12, 120);
            txtSalida.Multiline = true;
            txtSalida.Name = "txtSalida";
            txtSalida.ReadOnly = true;
            txtSalida.ScrollBars = ScrollBars.Vertical;
            txtSalida.Size = new Size(500, 250);
            txtSalida.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Silver;
            btnAgregar.Location = new Point(360, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 28);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Location = new Point(460, 20);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 28);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Silver;
            btnBuscar.Location = new Point(560, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.Location = new Point(665, 20);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 28);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnConectarGrafos
            // 
            btnConectarGrafos.BackColor = Color.Silver;
            btnConectarGrafos.Location = new Point(616, 135);
            btnConectarGrafos.Name = "btnConectarGrafos";
            btnConectarGrafos.Size = new Size(100, 50);
            btnConectarGrafos.TabIndex = 7;
            btnConectarGrafos.UseVisualStyleBackColor = false;
            btnConectarGrafos.Click += btnConectarGrafos_Click;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(692, 106);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(80, 23);
            txtDestino.TabIndex = 8;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(562, 106);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(73, 23);
            txtOrigen.TabIndex = 9;
            txtOrigen.TextChanged += txtOrigen_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(562, 79);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(692, 79);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            // 
            // btnPreOrden
            // 
            btnPreOrden.BackColor = Color.Silver;
            btnPreOrden.Location = new Point(714, 209);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(75, 49);
            btnPreOrden.TabIndex = 12;
            btnPreOrden.Text = "Pre Orden";
            btnPreOrden.UseVisualStyleBackColor = false;
            btnPreOrden.Click += btnPreOrden_Click;
            // 
            // btnInOrden
            // 
            btnInOrden.BackColor = Color.Silver;
            btnInOrden.Location = new Point(517, 209);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(80, 49);
            btnInOrden.TabIndex = 13;
            btnInOrden.Text = "In Orden";
            btnInOrden.UseVisualStyleBackColor = false;
            btnInOrden.Click += btnInOrden_Click;
            // 
            // btnPostOrden
            // 
            btnPostOrden.BackColor = Color.Silver;
            btnPostOrden.Location = new Point(616, 209);
            btnPostOrden.Name = "btnPostOrden";
            btnPostOrden.Size = new Size(75, 49);
            btnPostOrden.TabIndex = 14;
            btnPostOrden.Text = "Post Orden";
            btnPostOrden.UseVisualStyleBackColor = false;
            btnPostOrden.Click += btnPostOrden_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, -3);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 15;
            // 
            // Form1
            // 
            BackColor = Color.SeaShell;
            ClientSize = new Size(860, 400);
            Controls.Add(label3);
            Controls.Add(btnPostOrden);
            Controls.Add(btnInOrden);
            Controls.Add(btnPreOrden);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOrigen);
            Controls.Add(txtDestino);
            Controls.Add(btnConectarGrafos);
            Controls.Add(cmbEstructura);
            Controls.Add(txtDato);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtSalida);
            Name = "Form1";
            Text = "Estructuras de Datos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnConectarGrafos;
        private TextBox txtDestino;
        private TextBox txtOrigen;
        private Label label1;
        private Label label2;
        private Button btnPreOrden;
        private Button btnInOrden;
        private Button btnPostOrden;
        private Label label3;
    }
}
