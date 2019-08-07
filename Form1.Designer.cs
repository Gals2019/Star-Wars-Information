namespace AppInfoStarWars
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPeliculas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNaves = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboPersonajes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblpnlPersonaje = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHogar = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAñoNacimiento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOjos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPiel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPelo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblpnlPersonaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstPeliculas.Location = new System.Drawing.Point(96, 219);
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(246, 213);
            this.lstPeliculas.TabIndex = 8;
            this.lstPeliculas.UseCompatibleStateImageBehavior = false;
            this.lstPeliculas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Película";
            this.columnHeader1.Width = 216;
            // 
            // lstNaves
            // 
            this.lstNaves.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstNaves.Location = new System.Drawing.Point(470, 219);
            this.lstNaves.Name = "lstNaves";
            this.lstNaves.Size = new System.Drawing.Size(246, 213);
            this.lstNaves.TabIndex = 9;
            this.lstNaves.UseCompatibleStateImageBehavior = false;
            this.lstNaves.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naves";
            this.columnHeader2.Width = 216;
            // 
            // cboPersonajes
            // 
            this.cboPersonajes.FormattingEnabled = true;
            this.cboPersonajes.Location = new System.Drawing.Point(340, 38);
            this.cboPersonajes.Name = "cboPersonajes";
            this.cboPersonajes.Size = new System.Drawing.Size(166, 21);
            this.cboPersonajes.TabIndex = 10;
            this.cboPersonajes.SelectedIndexChanged += new System.EventHandler(this.CboPersonajes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione Personaje";
            // 
            // tblpnlPersonaje
            // 
            this.tblpnlPersonaje.Controls.Add(this.label5);
            this.tblpnlPersonaje.Controls.Add(this.label3);
            this.tblpnlPersonaje.Controls.Add(this.lblNombre);
            this.tblpnlPersonaje.Controls.Add(this.lblHogar);
            this.tblpnlPersonaje.Controls.Add(this.label15);
            this.tblpnlPersonaje.Controls.Add(this.lblGenero);
            this.tblpnlPersonaje.Controls.Add(this.label17);
            this.tblpnlPersonaje.Controls.Add(this.lblAñoNacimiento);
            this.tblpnlPersonaje.Controls.Add(this.label9);
            this.tblpnlPersonaje.Controls.Add(this.lblOjos);
            this.tblpnlPersonaje.Controls.Add(this.label11);
            this.tblpnlPersonaje.Controls.Add(this.lblPiel);
            this.tblpnlPersonaje.Controls.Add(this.label13);
            this.tblpnlPersonaje.Controls.Add(this.lblPelo);
            this.tblpnlPersonaje.Controls.Add(this.label6);
            this.tblpnlPersonaje.Controls.Add(this.lblPeso);
            this.tblpnlPersonaje.Controls.Add(this.label4);
            this.tblpnlPersonaje.Controls.Add(this.lblAltura);
            this.tblpnlPersonaje.Controls.Add(this.label2);
            this.tblpnlPersonaje.Controls.Add(this.lstPeliculas);
            this.tblpnlPersonaje.Controls.Add(this.lstNaves);
            this.tblpnlPersonaje.Location = new System.Drawing.Point(12, 71);
            this.tblpnlPersonaje.Name = "tblpnlPersonaje";
            this.tblpnlPersonaje.Size = new System.Drawing.Size(822, 456);
            this.tblpnlPersonaje.TabIndex = 13;
            this.tblpnlPersonaje.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Naves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Peliculas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(442, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Personaje";
            // 
            // lblHogar
            // 
            this.lblHogar.AutoSize = true;
            this.lblHogar.Location = new System.Drawing.Point(711, 100);
            this.lblHogar.Name = "lblHogar";
            this.lblHogar.Size = new System.Drawing.Size(54, 13);
            this.lblHogar.TabIndex = 45;
            this.lblHogar.Text = "Personaje";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(641, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 44;
            this.label15.Text = "Hogar";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(711, 61);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(54, 13);
            this.lblGenero.TabIndex = 43;
            this.lblGenero.Text = "Personaje";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(641, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 42;
            this.label17.Text = "Genero";
            // 
            // lblAñoNacimiento
            // 
            this.lblAñoNacimiento.AutoSize = true;
            this.lblAñoNacimiento.Location = new System.Drawing.Point(422, 139);
            this.lblAñoNacimiento.Name = "lblAñoNacimiento";
            this.lblAñoNacimiento.Size = new System.Drawing.Size(54, 13);
            this.lblAñoNacimiento.TabIndex = 41;
            this.lblAñoNacimiento.Text = "Personaje";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(316, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nacimiento";
            // 
            // lblOjos
            // 
            this.lblOjos.AutoSize = true;
            this.lblOjos.Location = new System.Drawing.Point(422, 99);
            this.lblOjos.Name = "lblOjos";
            this.lblOjos.Size = new System.Drawing.Size(54, 13);
            this.lblOjos.TabIndex = 39;
            this.lblOjos.Text = "Personaje";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(362, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Ojos";
            // 
            // lblPiel
            // 
            this.lblPiel.AutoSize = true;
            this.lblPiel.Location = new System.Drawing.Point(422, 60);
            this.lblPiel.Name = "lblPiel";
            this.lblPiel.Size = new System.Drawing.Size(54, 13);
            this.lblPiel.TabIndex = 37;
            this.lblPiel.Text = "Personaje";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(362, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Piel";
            // 
            // lblPelo
            // 
            this.lblPelo.AutoSize = true;
            this.lblPelo.Location = new System.Drawing.Point(93, 139);
            this.lblPelo.Name = "lblPelo";
            this.lblPelo.Size = new System.Drawing.Size(54, 13);
            this.lblPelo.TabIndex = 35;
            this.lblPelo.Text = "Personaje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Pelo";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(93, 99);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(54, 13);
            this.lblPeso.TabIndex = 33;
            this.lblPeso.Text = "Personaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(93, 60);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(54, 13);
            this.lblAltura.TabIndex = 31;
            this.lblAltura.Text = "Personaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Altura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 536);
            this.Controls.Add(this.tblpnlPersonaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPersonajes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblpnlPersonaje.ResumeLayout(false);
            this.tblpnlPersonaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstPeliculas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstNaves;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cboPersonajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel tblpnlPersonaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHogar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblAñoNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOjos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPiel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label2;
    }
}

