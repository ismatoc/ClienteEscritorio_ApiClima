namespace Clases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textpais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.txtresppais = new System.Windows.Forms.TextBox();
            this.textresptemperatura = new System.Windows.Forms.TextBox();
            this.textresplatitud = new System.Windows.Forms.TextBox();
            this.textresplong = new System.Windows.Forms.TextBox();
            this.textresphumedad = new System.Windows.Forms.TextBox();
            this.textresppresion = new System.Windows.Forms.TextBox();
            this.textrespdescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.textpais);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrueba);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.splitContainer1.Panel2.Controls.Add(this.textrespdescripcion);
            this.splitContainer1.Panel2.Controls.Add(this.textresppresion);
            this.splitContainer1.Panel2.Controls.Add(this.textresphumedad);
            this.splitContainer1.Panel2.Controls.Add(this.textresplong);
            this.splitContainer1.Panel2.Controls.Add(this.textresplatitud);
            this.splitContainer1.Panel2.Controls.Add(this.textresptemperatura);
            this.splitContainer1.Panel2.Controls.Add(this.txtresppais);
            this.splitContainer1.Size = new System.Drawing.Size(1021, 594);
            this.splitContainer1.SplitterDistance = 497;
            this.splitContainer1.TabIndex = 7;
            // 
            // textpais
            // 
            this.textpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpais.Location = new System.Drawing.Point(95, 488);
            this.textpais.Multiline = true;
            this.textpais.Name = "textpais";
            this.textpais.Size = new System.Drawing.Size(281, 36);
            this.textpais.TabIndex = 11;
            this.textpais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AccessibleName = "Pais";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 463);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresa el Pais que deseas consultar el clima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(102, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consulta del Clima";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 438);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(95, 534);
            this.btnPrueba.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(281, 46);
            this.btnPrueba.TabIndex = 9;
            this.btnPrueba.Text = "Consultar Clima";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click_1);
            // 
            // txtresppais
            // 
            this.txtresppais.AccessibleName = "Pais";
            this.txtresppais.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtresppais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtresppais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresppais.Location = new System.Drawing.Point(70, 46);
            this.txtresppais.Margin = new System.Windows.Forms.Padding(4);
            this.txtresppais.Multiline = true;
            this.txtresppais.Name = "txtresppais";
            this.txtresppais.Size = new System.Drawing.Size(398, 51);
            this.txtresppais.TabIndex = 11;
            this.txtresppais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textresptemperatura
            // 
            this.textresptemperatura.AccessibleName = "Pais";
            this.textresptemperatura.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textresptemperatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textresptemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textresptemperatura.Location = new System.Drawing.Point(70, 97);
            this.textresptemperatura.Margin = new System.Windows.Forms.Padding(4);
            this.textresptemperatura.Multiline = true;
            this.textresptemperatura.Name = "textresptemperatura";
            this.textresptemperatura.Size = new System.Drawing.Size(398, 38);
            this.textresptemperatura.TabIndex = 12;
            // 
            // textresplatitud
            // 
            this.textresplatitud.AccessibleName = "Pais";
            this.textresplatitud.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textresplatitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textresplatitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textresplatitud.Location = new System.Drawing.Point(70, 143);
            this.textresplatitud.Margin = new System.Windows.Forms.Padding(4);
            this.textresplatitud.Multiline = true;
            this.textresplatitud.Name = "textresplatitud";
            this.textresplatitud.Size = new System.Drawing.Size(398, 38);
            this.textresplatitud.TabIndex = 13;
            // 
            // textresplong
            // 
            this.textresplong.AccessibleName = "Pais";
            this.textresplong.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textresplong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textresplong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textresplong.Location = new System.Drawing.Point(70, 189);
            this.textresplong.Margin = new System.Windows.Forms.Padding(4);
            this.textresplong.Multiline = true;
            this.textresplong.Name = "textresplong";
            this.textresplong.Size = new System.Drawing.Size(398, 38);
            this.textresplong.TabIndex = 14;
            // 
            // textresphumedad
            // 
            this.textresphumedad.AccessibleName = "Pais";
            this.textresphumedad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textresphumedad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textresphumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textresphumedad.Location = new System.Drawing.Point(70, 235);
            this.textresphumedad.Margin = new System.Windows.Forms.Padding(4);
            this.textresphumedad.Multiline = true;
            this.textresphumedad.Name = "textresphumedad";
            this.textresphumedad.Size = new System.Drawing.Size(398, 38);
            this.textresphumedad.TabIndex = 15;
            // 
            // textresppresion
            // 
            this.textresppresion.AccessibleName = "Pais";
            this.textresppresion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textresppresion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textresppresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textresppresion.Location = new System.Drawing.Point(70, 281);
            this.textresppresion.Margin = new System.Windows.Forms.Padding(4);
            this.textresppresion.Multiline = true;
            this.textresppresion.Name = "textresppresion";
            this.textresppresion.Size = new System.Drawing.Size(398, 38);
            this.textresppresion.TabIndex = 16;
            // 
            // textrespdescripcion
            // 
            this.textrespdescripcion.AccessibleName = "Pais";
            this.textrespdescripcion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textrespdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textrespdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrespdescripcion.Location = new System.Drawing.Point(70, 327);
            this.textrespdescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textrespdescripcion.Multiline = true;
            this.textrespdescripcion.Name = "textrespdescripcion";
            this.textrespdescripcion.Size = new System.Drawing.Size(398, 38);
            this.textrespdescripcion.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 618);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Clima";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.TextBox txtresppais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textpais;
        private System.Windows.Forms.TextBox textresptemperatura;
        private System.Windows.Forms.TextBox textresplatitud;
        private System.Windows.Forms.TextBox textresplong;
        private System.Windows.Forms.TextBox textrespdescripcion;
        private System.Windows.Forms.TextBox textresppresion;
        private System.Windows.Forms.TextBox textresphumedad;
    }
}

