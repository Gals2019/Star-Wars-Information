namespace AppInfoStarWars
{
    partial class frmPeliculas
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPeliculas = new System.Windows.Forms.ComboBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblProductor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.lstNaves = new System.Windows.Forms.ListBox();
            this.lstEspecies = new System.Windows.Forms.ListBox();
            this.lstPlanetas = new System.Windows.Forms.ListBox();
            this.lstPersonajes = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEpisodio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTituloFilm = new System.Windows.Forms.Label();
            this.lblOpening = new System.Windows.Forms.TextBox();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Pelicula";
            // 
            // cboPeliculas
            // 
            this.cboPeliculas.FormattingEnabled = true;
            this.cboPeliculas.Location = new System.Drawing.Point(331, 39);
            this.cboPeliculas.Name = "cboPeliculas";
            this.cboPeliculas.Size = new System.Drawing.Size(279, 21);
            this.cboPeliculas.TabIndex = 1;
            this.cboPeliculas.SelectedIndexChanged += new System.EventHandler(this.CboPeliculas_SelectedIndexChanged);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblOpening);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.lblFechaEstreno);
            this.pnlDatos.Controls.Add(this.label14);
            this.pnlDatos.Controls.Add(this.lblProductor);
            this.pnlDatos.Controls.Add(this.label12);
            this.pnlDatos.Controls.Add(this.lstVehiculos);
            this.pnlDatos.Controls.Add(this.lstNaves);
            this.pnlDatos.Controls.Add(this.lstEspecies);
            this.pnlDatos.Controls.Add(this.lstPlanetas);
            this.pnlDatos.Controls.Add(this.lstPersonajes);
            this.pnlDatos.Controls.Add(this.label10);
            this.pnlDatos.Controls.Add(this.label9);
            this.pnlDatos.Controls.Add(this.label8);
            this.pnlDatos.Controls.Add(this.label7);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Controls.Add(this.lblEpisodio);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.lblDirector);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.lblTituloFilm);
            this.pnlDatos.Location = new System.Drawing.Point(12, 66);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(916, 599);
            this.pnlDatos.TabIndex = 2;
            this.pnlDatos.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Opening:";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(694, 61);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(100, 13);
            this.lblFechaEstreno.TabIndex = 21;
            this.lblFechaEstreno.Text = "Seleccione Pelicula";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(596, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Fecha Estreno";
            // 
            // lblProductor
            // 
            this.lblProductor.AutoSize = true;
            this.lblProductor.Location = new System.Drawing.Point(286, 61);
            this.lblProductor.Name = "lblProductor";
            this.lblProductor.Size = new System.Drawing.Size(100, 13);
            this.lblProductor.TabIndex = 19;
            this.lblProductor.Text = "Seleccione Pelicula";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(213, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Productor";
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.Location = new System.Drawing.Point(757, 138);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(146, 225);
            this.lstVehiculos.TabIndex = 17;
            // 
            // lstNaves
            // 
            this.lstNaves.FormattingEnabled = true;
            this.lstNaves.Location = new System.Drawing.Point(568, 138);
            this.lstNaves.Name = "lstNaves";
            this.lstNaves.Size = new System.Drawing.Size(146, 225);
            this.lstNaves.TabIndex = 16;
            // 
            // lstEspecies
            // 
            this.lstEspecies.FormattingEnabled = true;
            this.lstEspecies.Location = new System.Drawing.Point(394, 138);
            this.lstEspecies.Name = "lstEspecies";
            this.lstEspecies.Size = new System.Drawing.Size(146, 225);
            this.lstEspecies.TabIndex = 15;
            // 
            // lstPlanetas
            // 
            this.lstPlanetas.FormattingEnabled = true;
            this.lstPlanetas.Location = new System.Drawing.Point(206, 138);
            this.lstPlanetas.Name = "lstPlanetas";
            this.lstPlanetas.Size = new System.Drawing.Size(146, 225);
            this.lstPlanetas.TabIndex = 14;
            // 
            // lstPersonajes
            // 
            this.lstPersonajes.FormattingEnabled = true;
            this.lstPersonajes.Location = new System.Drawing.Point(28, 138);
            this.lstPersonajes.Name = "lstPersonajes";
            this.lstPersonajes.Size = new System.Drawing.Size(146, 225);
            this.lstPersonajes.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(792, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Vehiculos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(615, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Naves";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(431, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Especies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Planetas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Personajes";
            // 
            // lblEpisodio
            // 
            this.lblEpisodio.AutoSize = true;
            this.lblEpisodio.Location = new System.Drawing.Point(669, 28);
            this.lblEpisodio.Name = "lblEpisodio";
            this.lblEpisodio.Size = new System.Drawing.Size(100, 13);
            this.lblEpisodio.TabIndex = 7;
            this.lblEpisodio.Text = "Seleccione Pelicula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Episodio";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(72, 61);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(100, 13);
            this.lblDirector.TabIndex = 5;
            this.lblDirector.Text = "Seleccione Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Director";
            // 
            // lblTituloFilm
            // 
            this.lblTituloFilm.AutoSize = true;
            this.lblTituloFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFilm.Location = new System.Drawing.Point(397, 25);
            this.lblTituloFilm.Name = "lblTituloFilm";
            this.lblTituloFilm.Size = new System.Drawing.Size(146, 16);
            this.lblTituloFilm.TabIndex = 3;
            this.lblTituloFilm.Text = "Seleccione Pelicula";
            // 
            // lblOpening
            // 
            this.lblOpening.Location = new System.Drawing.Point(335, 391);
            this.lblOpening.Multiline = true;
            this.lblOpening.Name = "lblOpening";
            this.lblOpening.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblOpening.Size = new System.Drawing.Size(169, 205);
            this.lblOpening.TabIndex = 24;
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 677);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.cboPeliculas);
            this.Controls.Add(this.label1);
            this.Name = "frmPeliculas";
            this.Text = "frmPeliculas";
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPeliculas;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.ListBox lstNaves;
        private System.Windows.Forms.ListBox lstEspecies;
        private System.Windows.Forms.ListBox lstPlanetas;
        private System.Windows.Forms.ListBox lstPersonajes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEpisodio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTituloFilm;
        private System.Windows.Forms.Label lblProductor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblOpening;
    }
}