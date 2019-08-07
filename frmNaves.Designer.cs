namespace AppInfoStarWars
{
    partial class frmNaves
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
            this.cboNave = new System.Windows.Forms.ComboBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lstPilotos = new System.Windows.Forms.ListBox();
            this.lstPeliculas = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblVelMaxAtm = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblHiperVelocidad = new System.Windows.Forms.Label();
            this.lblTripulacion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTiempoFabr = new System.Windows.Forms.Label();
            this.lblCapCarga = new System.Windows.Forms.Label();
            this.lblmglt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboNave
            // 
            this.cboNave.FormattingEnabled = true;
            this.cboNave.Location = new System.Drawing.Point(324, 38);
            this.cboNave.Name = "cboNave";
            this.cboNave.Size = new System.Drawing.Size(191, 21);
            this.cboNave.TabIndex = 0;
            this.cboNave.SelectedIndexChanged += new System.EventHandler(this.CboNave_SelectedIndexChanged);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lstPilotos);
            this.pnlDatos.Controls.Add(this.lstPeliculas);
            this.pnlDatos.Controls.Add(this.label15);
            this.pnlDatos.Controls.Add(this.label14);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.lblClase);
            this.pnlDatos.Controls.Add(this.lblPasajeros);
            this.pnlDatos.Controls.Add(this.lblModelo);
            this.pnlDatos.Controls.Add(this.lblVelMaxAtm);
            this.pnlDatos.Controls.Add(this.lblFabricante);
            this.pnlDatos.Controls.Add(this.lblLargo);
            this.pnlDatos.Controls.Add(this.lblHiperVelocidad);
            this.pnlDatos.Controls.Add(this.lblTripulacion);
            this.pnlDatos.Controls.Add(this.lblPrecio);
            this.pnlDatos.Controls.Add(this.lblTiempoFabr);
            this.pnlDatos.Controls.Add(this.lblCapCarga);
            this.pnlDatos.Controls.Add(this.lblmglt);
            this.pnlDatos.Controls.Add(this.label10);
            this.pnlDatos.Controls.Add(this.label11);
            this.pnlDatos.Controls.Add(this.label12);
            this.pnlDatos.Controls.Add(this.label13);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Controls.Add(this.label7);
            this.pnlDatos.Controls.Add(this.label8);
            this.pnlDatos.Controls.Add(this.label9);
            this.pnlDatos.Controls.Add(this.label5);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Location = new System.Drawing.Point(12, 65);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(776, 373);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.Visible = false;
            // 
            // lstPilotos
            // 
            this.lstPilotos.FormattingEnabled = true;
            this.lstPilotos.Location = new System.Drawing.Point(454, 219);
            this.lstPilotos.Name = "lstPilotos";
            this.lstPilotos.Size = new System.Drawing.Size(229, 147);
            this.lstPilotos.TabIndex = 30;
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.FormattingEnabled = true;
            this.lstPeliculas.Location = new System.Drawing.Point(79, 219);
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(229, 147);
            this.lstPeliculas.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(550, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Pilotos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(175, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Peliculas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(344, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Selecione Nave";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(674, 148);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(83, 13);
            this.lblClase.TabIndex = 26;
            this.lblClase.Text = "Selecione Nave";
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(674, 121);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(83, 13);
            this.lblPasajeros.TabIndex = 25;
            this.lblPasajeros.Text = "Selecione Nave";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(674, 91);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 13);
            this.lblModelo.TabIndex = 24;
            this.lblModelo.Text = "Selecione Nave";
            // 
            // lblVelMaxAtm
            // 
            this.lblVelMaxAtm.AutoSize = true;
            this.lblVelMaxAtm.Location = new System.Drawing.Point(674, 61);
            this.lblVelMaxAtm.Name = "lblVelMaxAtm";
            this.lblVelMaxAtm.Size = new System.Drawing.Size(83, 13);
            this.lblVelMaxAtm.TabIndex = 23;
            this.lblVelMaxAtm.Text = "Selecione Nave";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(424, 148);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(83, 13);
            this.lblFabricante.TabIndex = 22;
            this.lblFabricante.Text = "Selecione Nave";
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(424, 121);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(83, 13);
            this.lblLargo.TabIndex = 21;
            this.lblLargo.Text = "Selecione Nave";
            // 
            // lblHiperVelocidad
            // 
            this.lblHiperVelocidad.AutoSize = true;
            this.lblHiperVelocidad.Location = new System.Drawing.Point(424, 91);
            this.lblHiperVelocidad.Name = "lblHiperVelocidad";
            this.lblHiperVelocidad.Size = new System.Drawing.Size(83, 13);
            this.lblHiperVelocidad.TabIndex = 20;
            this.lblHiperVelocidad.Text = "Selecione Nave";
            // 
            // lblTripulacion
            // 
            this.lblTripulacion.AutoSize = true;
            this.lblTripulacion.Location = new System.Drawing.Point(424, 61);
            this.lblTripulacion.Name = "lblTripulacion";
            this.lblTripulacion.Size = new System.Drawing.Size(83, 13);
            this.lblTripulacion.TabIndex = 19;
            this.lblTripulacion.Text = "Selecione Nave";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(137, 148);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(83, 13);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Selecione Nave";
            // 
            // lblTiempoFabr
            // 
            this.lblTiempoFabr.AutoSize = true;
            this.lblTiempoFabr.Location = new System.Drawing.Point(137, 121);
            this.lblTiempoFabr.Name = "lblTiempoFabr";
            this.lblTiempoFabr.Size = new System.Drawing.Size(83, 13);
            this.lblTiempoFabr.TabIndex = 17;
            this.lblTiempoFabr.Text = "Selecione Nave";
            // 
            // lblCapCarga
            // 
            this.lblCapCarga.AutoSize = true;
            this.lblCapCarga.Location = new System.Drawing.Point(137, 91);
            this.lblCapCarga.Name = "lblCapCarga";
            this.lblCapCarga.Size = new System.Drawing.Size(83, 13);
            this.lblCapCarga.TabIndex = 16;
            this.lblCapCarga.Text = "Selecione Nave";
            // 
            // lblmglt
            // 
            this.lblmglt.AutoSize = true;
            this.lblmglt.Location = new System.Drawing.Point(137, 61);
            this.lblmglt.Name = "lblmglt";
            this.lblmglt.Size = new System.Drawing.Size(83, 13);
            this.lblmglt.TabIndex = 15;
            this.lblmglt.Text = "Selecione Nave";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(553, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Clase";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Pasajeros";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(553, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Modelo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Vel. Max. Atmosférica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fabricante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Largo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hipervelocidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tripulación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiempo Fab.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cap. Carga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MGLT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione Nave";
            // 
            // frmNaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.cboNave);
            this.Name = "frmNaves";
            this.Text = "frmNaves";
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNave;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPilotos;
        private System.Windows.Forms.ListBox lstPeliculas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblVelMaxAtm;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label lblHiperVelocidad;
        private System.Windows.Forms.Label lblTripulacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTiempoFabr;
        private System.Windows.Forms.Label lblCapCarga;
        private System.Windows.Forms.Label lblmglt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
    }
}