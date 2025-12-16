namespace Ejercicio1
{
    partial class FormPrincipal
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
            groupBox1 = new GroupBox();
            btnDescargar = new Button();
            btnCargar = new Button();
            btnCerrarCamion = new Button();
            btnCrearCamion = new Button();
            dateTimePicker1 = new DateTimePicker();
            tbCapacidad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lsbAutos = new ListBox();
            groupBox2 = new GroupBox();
            btnDescargarCamion = new Button();
            btnRecibirCamion = new Button();
            label4 = new Label();
            lsbAutosRecibidos = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDescargar);
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(btnCerrarCamion);
            groupBox1.Controls.Add(btnCrearCamion);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(tbCapacidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lsbAutos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cargas";
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(253, 313);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(75, 41);
            btnDescargar.TabIndex = 8;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(253, 245);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 41);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnCerrarCamion
            // 
            btnCerrarCamion.Location = new Point(253, 379);
            btnCerrarCamion.Name = "btnCerrarCamion";
            btnCerrarCamion.Size = new Size(75, 41);
            btnCerrarCamion.TabIndex = 6;
            btnCerrarCamion.Text = "Cerrar Camión";
            btnCerrarCamion.UseVisualStyleBackColor = true;
            btnCerrarCamion.Click += btnCerrarCamion_Click;
            // 
            // btnCrearCamion
            // 
            btnCrearCamion.Location = new Point(253, 178);
            btnCrearCamion.Name = "btnCrearCamion";
            btnCrearCamion.Size = new Size(75, 41);
            btnCrearCamion.TabIndex = 5;
            btnCrearCamion.Text = "Crear Camión";
            btnCrearCamion.UseVisualStyleBackColor = true;
            btnCrearCamion.Click += btnCrearCamion_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(227, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(101, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // tbCapacidad
            // 
            tbCapacidad.Location = new Point(253, 89);
            tbCapacidad.Name = "tbCapacidad";
            tbCapacidad.Size = new Size(75, 23);
            tbCapacidad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 71);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Capacidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de autos";
            // 
            // lsbAutos
            // 
            lsbAutos.FormattingEnabled = true;
            lsbAutos.ItemHeight = 15;
            lsbAutos.Location = new Point(6, 71);
            lsbAutos.Name = "lsbAutos";
            lsbAutos.Size = new Size(237, 349);
            lsbAutos.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDescargarCamion);
            groupBox2.Controls.Add(btnRecibirCamion);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lsbAutosRecibidos);
            groupBox2.Location = new Point(400, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 426);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descargas";
            // 
            // btnDescargarCamion
            // 
            btnDescargarCamion.Location = new Point(249, 245);
            btnDescargarCamion.Name = "btnDescargarCamion";
            btnDescargarCamion.Size = new Size(75, 41);
            btnDescargarCamion.TabIndex = 8;
            btnDescargarCamion.Text = "Descargar Camión";
            btnDescargarCamion.UseVisualStyleBackColor = true;
            btnDescargarCamion.Click += btnDescargarCamion_Click;
            // 
            // btnRecibirCamion
            // 
            btnRecibirCamion.Location = new Point(249, 178);
            btnRecibirCamion.Name = "btnRecibirCamion";
            btnRecibirCamion.Size = new Size(75, 41);
            btnRecibirCamion.TabIndex = 5;
            btnRecibirCamion.Text = "Recibir Camión";
            btnRecibirCamion.UseVisualStyleBackColor = true;
            btnRecibirCamion.Click += btnRecibirCamion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 53);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 1;
            label4.Text = "Lista de autos recibidos";
            // 
            // lsbAutosRecibidos
            // 
            lsbAutosRecibidos.FormattingEnabled = true;
            lsbAutosRecibidos.ItemHeight = 15;
            lsbAutosRecibidos.Location = new Point(6, 71);
            lsbAutosRecibidos.Name = "lsbAutosRecibidos";
            lsbAutosRecibidos.Size = new Size(237, 349);
            lsbAutosRecibidos.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Distribuidora de Vehiculos";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCrearCamion;
        private DateTimePicker dateTimePicker1;
        private TextBox tbCapacidad;
        private Label label2;
        private Label label1;
        private ListBox lsbAutos;
        private Button btnDescargar;
        private Button btnCargar;
        private Button btnCerrarCamion;
        private GroupBox groupBox2;
        private Button btnDescargarCamion;
        private Button btnRecibirCamion;
        private Label label4;
        private ListBox lsbAutosRecibidos;
        private OpenFileDialog openFileDialog1;
    }
}
