namespace CandysChristmas
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.over = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baston1 = new System.Windows.Forms.PictureBox();
            this.baston2 = new System.Windows.Forms.PictureBox();
            this.caramelo1 = new System.Windows.Forms.PictureBox();
            this.caramelo2 = new System.Windows.Forms.PictureBox();
            this.baston3 = new System.Windows.Forms.PictureBox();
            this.caramelo3 = new System.Windows.Forms.PictureBox();
            this.enemigo2 = new System.Windows.Forms.PictureBox();
            this.enemigo3 = new System.Windows.Forms.PictureBox();
            this.enemigo = new System.Windows.Forms.PictureBox();
            this.noel = new System.Windows.Forms.PictureBox();
            this.obstaculo6 = new System.Windows.Forms.PictureBox();
            this.obstaculo5 = new System.Windows.Forms.PictureBox();
            this.obstaculo4 = new System.Windows.Forms.PictureBox();
            this.obstaculo3 = new System.Windows.Forms.PictureBox();
            this.obstaculo2 = new System.Windows.Forms.PictureBox();
            this.obstaculo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.baston1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baston2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caramelo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caramelo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baston3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caramelo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Yellow;
            this.over.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Location = new System.Drawing.Point(285, 253);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(227, 48);
            this.over.TabIndex = 10;
            this.over.Text = "GAME OVER";
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 35);
            this.label1.TabIndex = 32;
            this.label1.Text = "CARAMELOS=0";
            // 
            // baston1
            // 
            this.baston1.Image = global::CandysChristmas.Properties.Resources._222;
            this.baston1.Location = new System.Drawing.Point(571, 203);
            this.baston1.Name = "baston1";
            this.baston1.Size = new System.Drawing.Size(155, 149);
            this.baston1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baston1.TabIndex = 33;
            this.baston1.TabStop = false;
            this.baston1.Click += new System.EventHandler(this.baston1_Click);
            // 
            // baston2
            // 
            this.baston2.Image = global::CandysChristmas.Properties.Resources._222;
            this.baston2.Location = new System.Drawing.Point(209, 67);
            this.baston2.Name = "baston2";
            this.baston2.Size = new System.Drawing.Size(117, 86);
            this.baston2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baston2.TabIndex = 31;
            this.baston2.TabStop = false;
            // 
            // caramelo1
            // 
            this.caramelo1.Image = global::CandysChristmas.Properties.Resources._111;
            this.caramelo1.Location = new System.Drawing.Point(665, 51);
            this.caramelo1.Name = "caramelo1";
            this.caramelo1.Size = new System.Drawing.Size(79, 71);
            this.caramelo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caramelo1.TabIndex = 17;
            this.caramelo1.TabStop = false;
            // 
            // caramelo2
            // 
            this.caramelo2.Image = global::CandysChristmas.Properties.Resources._111;
            this.caramelo2.Location = new System.Drawing.Point(444, 381);
            this.caramelo2.Name = "caramelo2";
            this.caramelo2.Size = new System.Drawing.Size(149, 78);
            this.caramelo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caramelo2.TabIndex = 15;
            this.caramelo2.TabStop = false;
            // 
            // baston3
            // 
            this.baston3.Image = global::CandysChristmas.Properties.Resources._222;
            this.baston3.Location = new System.Drawing.Point(206, 360);
            this.baston3.Name = "baston3";
            this.baston3.Size = new System.Drawing.Size(120, 90);
            this.baston3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baston3.TabIndex = 12;
            this.baston3.TabStop = false;
            // 
            // caramelo3
            // 
            this.caramelo3.Image = global::CandysChristmas.Properties.Resources._111;
            this.caramelo3.Location = new System.Drawing.Point(32, 234);
            this.caramelo3.Name = "caramelo3";
            this.caramelo3.Size = new System.Drawing.Size(68, 71);
            this.caramelo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caramelo3.TabIndex = 11;
            this.caramelo3.TabStop = false;
            // 
            // enemigo2
            // 
            this.enemigo2.BackColor = System.Drawing.Color.Transparent;
            this.enemigo2.Image = global::CandysChristmas.Properties.Resources.aaaaa;
            this.enemigo2.Location = new System.Drawing.Point(137, 234);
            this.enemigo2.Name = "enemigo2";
            this.enemigo2.Size = new System.Drawing.Size(100, 78);
            this.enemigo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemigo2.TabIndex = 9;
            this.enemigo2.TabStop = false;
            // 
            // enemigo3
            // 
            this.enemigo3.BackColor = System.Drawing.Color.Transparent;
            this.enemigo3.Image = global::CandysChristmas.Properties.Resources.aaaaa;
            this.enemigo3.Location = new System.Drawing.Point(504, 86);
            this.enemigo3.Name = "enemigo3";
            this.enemigo3.Size = new System.Drawing.Size(104, 90);
            this.enemigo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemigo3.TabIndex = 8;
            this.enemigo3.TabStop = false;
            // 
            // enemigo
            // 
            this.enemigo.BackColor = System.Drawing.Color.Transparent;
            this.enemigo.Image = global::CandysChristmas.Properties.Resources.aaaaa;
            this.enemigo.Location = new System.Drawing.Point(45, 86);
            this.enemigo.Name = "enemigo";
            this.enemigo.Size = new System.Drawing.Size(100, 90);
            this.enemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemigo.TabIndex = 7;
            this.enemigo.TabStop = false;
            // 
            // noel
            // 
            this.noel.BackColor = System.Drawing.Color.Transparent;
            this.noel.Image = global::CandysChristmas.Properties.Resources._333;
            this.noel.Location = new System.Drawing.Point(32, 464);
            this.noel.Name = "noel";
            this.noel.Size = new System.Drawing.Size(113, 95);
            this.noel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noel.TabIndex = 6;
            this.noel.TabStop = false;
            // 
            // obstaculo6
            // 
            this.obstaculo6.BackColor = System.Drawing.Color.Ivory;
            this.obstaculo6.Location = new System.Drawing.Point(800, 1);
            this.obstaculo6.Name = "obstaculo6";
            this.obstaculo6.Size = new System.Drawing.Size(10, 581);
            this.obstaculo6.TabIndex = 5;
            this.obstaculo6.TabStop = false;
            // 
            // obstaculo5
            // 
            this.obstaculo5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.obstaculo5.Location = new System.Drawing.Point(1, 1);
            this.obstaculo5.Name = "obstaculo5";
            this.obstaculo5.Size = new System.Drawing.Size(10, 582);
            this.obstaculo5.TabIndex = 4;
            this.obstaculo5.TabStop = false;
            // 
            // obstaculo4
            // 
            this.obstaculo4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.obstaculo4.Location = new System.Drawing.Point(377, 474);
            this.obstaculo4.Name = "obstaculo4";
            this.obstaculo4.Size = new System.Drawing.Size(10, 111);
            this.obstaculo4.TabIndex = 3;
            this.obstaculo4.TabStop = false;
            // 
            // obstaculo3
            // 
            this.obstaculo3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.obstaculo3.Location = new System.Drawing.Point(377, 299);
            this.obstaculo3.Name = "obstaculo3";
            this.obstaculo3.Size = new System.Drawing.Size(10, 111);
            this.obstaculo3.TabIndex = 2;
            this.obstaculo3.TabStop = false;
            // 
            // obstaculo2
            // 
            this.obstaculo2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.obstaculo2.Location = new System.Drawing.Point(377, 145);
            this.obstaculo2.Name = "obstaculo2";
            this.obstaculo2.Size = new System.Drawing.Size(10, 111);
            this.obstaculo2.TabIndex = 1;
            this.obstaculo2.TabStop = false;
            // 
            // obstaculo
            // 
            this.obstaculo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.obstaculo.Location = new System.Drawing.Point(377, 1);
            this.obstaculo.Name = "obstaculo";
            this.obstaculo.Size = new System.Drawing.Size(10, 111);
            this.obstaculo.TabIndex = 0;
            this.obstaculo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(813, 583);
            this.Controls.Add(this.baston1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baston2);
            this.Controls.Add(this.caramelo1);
            this.Controls.Add(this.caramelo2);
            this.Controls.Add(this.baston3);
            this.Controls.Add(this.caramelo3);
            this.Controls.Add(this.over);
            this.Controls.Add(this.enemigo2);
            this.Controls.Add(this.enemigo3);
            this.Controls.Add(this.enemigo);
            this.Controls.Add(this.noel);
            this.Controls.Add(this.obstaculo6);
            this.Controls.Add(this.obstaculo5);
            this.Controls.Add(this.obstaculo4);
            this.Controls.Add(this.obstaculo3);
            this.Controls.Add(this.obstaculo2);
            this.Controls.Add(this.obstaculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.baston1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baston2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caramelo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caramelo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baston3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caramelo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstaculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obstaculo;
        private System.Windows.Forms.PictureBox obstaculo2;
        private System.Windows.Forms.PictureBox obstaculo3;
        private System.Windows.Forms.PictureBox obstaculo4;
        private System.Windows.Forms.PictureBox obstaculo5;
        private System.Windows.Forms.PictureBox obstaculo6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox noel;
        private System.Windows.Forms.PictureBox enemigo;
        private System.Windows.Forms.PictureBox enemigo3;
        private System.Windows.Forms.PictureBox enemigo2;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox caramelo3;
        private System.Windows.Forms.PictureBox baston3;
        private System.Windows.Forms.PictureBox caramelo2;
        private System.Windows.Forms.PictureBox caramelo1;
        private System.Windows.Forms.PictureBox baston2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox baston1;
    }
}

