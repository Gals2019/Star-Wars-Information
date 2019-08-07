namespace AppInfoStarWars
{
    partial class frmEspecies
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.lstPeliculas = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLengua = new System.Windows.Forms.Label();
            this.lblMundo = new System.Windows.Forms.Label();
            this.lblTiempoVida = new System.Windows.Forms.Label();
            this.lblOjos = new System.Windows.Forms.Label();
            this.lblPelo = new System.Windows.Forms.Label();
            this.lblPiel = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblClas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreEspecie = new System.Windows.Forms.Label();
            this.lstPersonajes = new System.Windows.Forms.ListBox();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Especie";
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lstPersonajes);
            this.pnl.Controls.Add(this.lstPeliculas);
            this.pnl.Controls.Add(this.label12);
            this.pnl.Controls.Add(this.label11);
            this.pnl.Controls.Add(this.lblLengua);
            this.pnl.Controls.Add(this.lblMundo);
            this.pnl.Controls.Add(this.lblTiempoVida);
            this.pnl.Controls.Add(this.lblOjos);
            this.pnl.Controls.Add(this.lblPelo);
            this.pnl.Controls.Add(this.lblPiel);
            this.pnl.Controls.Add(this.lblAltura);
            this.pnl.Controls.Add(this.lblDesign);
            this.pnl.Controls.Add(this.lblClas);
            this.pnl.Controls.Add(this.label8);
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.lblNombreEspecie);
            this.pnl.Location = new System.Drawing.Point(12, 92);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(776, 346);
            this.pnl.TabIndex = 2;
            this.pnl.Visible = false;
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.FormattingEnabled = true;
            this.lstPeliculas.Location = new System.Drawing.Point(39, 198);
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(282, 147);
            this.lstPeliculas.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(522, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 27);
            this.label12.TabIndex = 20;
            this.label12.Text = "Personajes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(130, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 27);
            this.label11.TabIndex = 19;
            this.label11.Text = "Películas";
            // 
            // lblLengua
            // 
            this.lblLengua.AutoSize = true;
            this.lblLengua.Location = new System.Drawing.Point(420, 135);
            this.lblLengua.Name = "lblLengua";
            this.lblLengua.Size = new System.Drawing.Size(41, 13);
            this.lblLengua.TabIndex = 18;
            this.lblLengua.Text = "label17";
            // 
            // lblMundo
            // 
            this.lblMundo.AutoSize = true;
            this.lblMundo.Location = new System.Drawing.Point(688, 95);
            this.lblMundo.Name = "lblMundo";
            this.lblMundo.Size = new System.Drawing.Size(41, 13);
            this.lblMundo.TabIndex = 17;
            this.lblMundo.Text = "label18";
            // 
            // lblTiempoVida
            // 
            this.lblTiempoVida.AutoSize = true;
            this.lblTiempoVida.Location = new System.Drawing.Point(688, 54);
            this.lblTiempoVida.Name = "lblTiempoVida";
            this.lblTiempoVida.Size = new System.Drawing.Size(41, 13);
            this.lblTiempoVida.TabIndex = 16;
            this.lblTiempoVida.Text = "label19";
            // 
            // lblOjos
            // 
            this.lblOjos.AutoSize = true;
            this.lblOjos.Location = new System.Drawing.Point(688, 135);
            this.lblOjos.Name = "lblOjos";
            this.lblOjos.Size = new System.Drawing.Size(41, 13);
            this.lblOjos.TabIndex = 15;
            this.lblOjos.Text = "label14";
            // 
            // lblPelo
            // 
            this.lblPelo.AutoSize = true;
            this.lblPelo.Location = new System.Drawing.Point(420, 95);
            this.lblPelo.Name = "lblPelo";
            this.lblPelo.Size = new System.Drawing.Size(41, 13);
            this.lblPelo.TabIndex = 14;
            this.lblPelo.Text = "label15";
            // 
            // lblPiel
            // 
            this.lblPiel.AutoSize = true;
            this.lblPiel.Location = new System.Drawing.Point(420, 54);
            this.lblPiel.Name = "lblPiel";
            this.lblPiel.Size = new System.Drawing.Size(41, 13);
            this.lblPiel.TabIndex = 13;
            this.lblPiel.Text = "label16";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(188, 135);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(41, 13);
            this.lblAltura.TabIndex = 12;
            this.lblAltura.Text = "label13";
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.Location = new System.Drawing.Point(188, 95);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(41, 13);
            this.lblDesign.TabIndex = 11;
            this.lblDesign.Text = "label12";
            // 
            // lblClas
            // 
            this.lblClas.AutoSize = true;
            this.lblClas.Location = new System.Drawing.Point(188, 54);
            this.lblClas.Name = "lblClas";
            this.lblClas.Size = new System.Drawing.Size(41, 13);
            this.lblClas.TabIndex = 10;
            this.lblClas.Text = "label11";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(557, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mundo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lengua";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(557, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 27);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tiempo Vida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ojos";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "Piel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Designación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura Promedio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clasificación";
            // 
            // lblNombreEspecie
            // 
            this.lblNombreEspecie.AutoSize = true;
            this.lblNombreEspecie.Font = new System.Drawing.Font("Myanmar Text", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEspecie.Location = new System.Drawing.Point(353, 4);
            this.lblNombreEspecie.Name = "lblNombreEspecie";
            this.lblNombreEspecie.Size = new System.Drawing.Size(70, 27);
            this.lblNombreEspecie.TabIndex = 0;
            this.lblNombreEspecie.Text = "Nombre";
            // 
            // lstPersonajes
            // 
            this.lstPersonajes.FormattingEnabled = true;
            this.lstPersonajes.Location = new System.Drawing.Point(445, 201);
            this.lstPersonajes.Name = "lstPersonajes";
            this.lstPersonajes.Size = new System.Drawing.Size(284, 147);
            this.lstPersonajes.TabIndex = 24;
            // 
            // frmEspecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmEspecies";
            this.Text = "frmEspecies";
            this.Load += new System.EventHandler(this.FrmEspecies_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblNombreEspecie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLengua;
        private System.Windows.Forms.Label lblMundo;
        private System.Windows.Forms.Label lblTiempoVida;
        private System.Windows.Forms.Label lblOjos;
        private System.Windows.Forms.Label lblPelo;
        private System.Windows.Forms.Label lblPiel;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblClas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstPeliculas;
        private System.Windows.Forms.ListBox lstPersonajes;
    }
}