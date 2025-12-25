namespace Ejercicio2
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
            label1 = new Label();
            tbDNI = new TextBox();
            groupBox1 = new GroupBox();
            rbDenuncia = new RadioButton();
            rbNuevoCliente = new RadioButton();
            tbPatente = new TextBox();
            cmbTipo = new ComboBox();
            btnTicket = new Button();
            lsbTurnos = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAtenderDenuncia = new Button();
            btnAtenderNuevoCliente = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(48, 16);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(140, 23);
            tbDNI.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbTipo);
            groupBox1.Controls.Add(tbPatente);
            groupBox1.Controls.Add(rbNuevoCliente);
            groupBox1.Controls.Add(rbDenuncia);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 104);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Consulta";
            // 
            // rbDenuncia
            // 
            rbDenuncia.AutoSize = true;
            rbDenuncia.Location = new Point(6, 32);
            rbDenuncia.Name = "rbDenuncia";
            rbDenuncia.Size = new Size(75, 19);
            rbDenuncia.TabIndex = 0;
            rbDenuncia.TabStop = true;
            rbDenuncia.Text = "Denuncia";
            rbDenuncia.UseVisualStyleBackColor = true;
            // 
            // rbNuevoCliente
            // 
            rbNuevoCliente.AutoSize = true;
            rbNuevoCliente.Location = new Point(6, 66);
            rbNuevoCliente.Name = "rbNuevoCliente";
            rbNuevoCliente.Size = new Size(100, 19);
            rbNuevoCliente.TabIndex = 1;
            rbNuevoCliente.TabStop = true;
            rbNuevoCliente.Text = "Nuevo Cliente";
            rbNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(126, 31);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(108, 23);
            tbPatente.TabIndex = 3;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(126, 65);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(108, 23);
            cmbTipo.TabIndex = 4;
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(280, 88);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(75, 57);
            btnTicket.TabIndex = 3;
            btnTicket.Text = "Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            // 
            // lsbTurnos
            // 
            lsbTurnos.FormattingEnabled = true;
            lsbTurnos.ItemHeight = 15;
            lsbTurnos.Location = new Point(12, 197);
            lsbTurnos.Name = "lsbTurnos";
            lsbTurnos.Size = new Size(343, 109);
            lsbTurnos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 179);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Turnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 328);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Denuncia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 328);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 7;
            label4.Text = "Nuevos Clientes";
            // 
            // btnAtenderDenuncia
            // 
            btnAtenderDenuncia.Location = new Point(12, 346);
            btnAtenderDenuncia.Name = "btnAtenderDenuncia";
            btnAtenderDenuncia.Size = new Size(75, 34);
            btnAtenderDenuncia.TabIndex = 8;
            btnAtenderDenuncia.Text = "Atender";
            btnAtenderDenuncia.UseVisualStyleBackColor = true;
            // 
            // btnAtenderNuevoCliente
            // 
            btnAtenderNuevoCliente.Location = new Point(280, 346);
            btnAtenderNuevoCliente.Name = "btnAtenderNuevoCliente";
            btnAtenderNuevoCliente.Size = new Size(75, 34);
            btnAtenderNuevoCliente.TabIndex = 9;
            btnAtenderNuevoCliente.Text = "Atender";
            btnAtenderNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 402);
            Controls.Add(btnAtenderNuevoCliente);
            Controls.Add(btnAtenderDenuncia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lsbTurnos);
            Controls.Add(btnTicket);
            Controls.Add(groupBox1);
            Controls.Add(tbDNI);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresa de Seguros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbDNI;
        private GroupBox groupBox1;
        private ComboBox cmbTipo;
        private TextBox tbPatente;
        private RadioButton rbNuevoCliente;
        private RadioButton rbDenuncia;
        private Button btnTicket;
        private ListBox lsbTurnos;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAtenderDenuncia;
        private Button btnAtenderNuevoCliente;
    }
}
