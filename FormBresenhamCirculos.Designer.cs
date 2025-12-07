namespace Algoritmos_Graficacion
{
    partial class FormBresenhamCirculos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtYC = new System.Windows.Forms.TextBox();
            this.txtXC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPixel = new System.Windows.Forms.Label();
            this.numPixelSize = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.chkOctantes = new System.Windows.Forms.CheckBox();
            this.chkGrid = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPixelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRadio);
            this.groupBox1.Controls.Add(this.txtYC);
            this.groupBox1.Controls.Add(this.txtXC);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Círculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Radio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "YC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "XC";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(81, 74);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 23);
            this.txtRadio.TabIndex = 2;
            // 
            // txtYC
            // 
            this.txtYC.Location = new System.Drawing.Point(172, 26);
            this.txtYC.Name = "txtYC";
            this.txtYC.Size = new System.Drawing.Size(68, 23);
            this.txtYC.TabIndex = 1;
            // 
            // txtXC
            // 
            this.txtXC.Location = new System.Drawing.Point(48, 26);
            this.txtXC.Name = "txtXC";
            this.txtXC.Size = new System.Drawing.Size(68, 23);
            this.txtXC.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPixel);
            this.groupBox2.Controls.Add(this.numPixelSize);
            this.groupBox2.Controls.Add(this.lblSpeed);
            this.groupBox2.Controls.Add(this.numSpeed);
            this.groupBox2.Controls.Add(this.chkOctantes);
            this.groupBox2.Controls.Add(this.chkGrid);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDraw);
            this.groupBox2.Location = new System.Drawing.Point(289, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control y Visualización";
            // 
            // lblPixel
            // 
            this.lblPixel.AutoSize = true;
            this.lblPixel.Location = new System.Drawing.Point(141, 30);
            this.lblPixel.Name = "lblPixel";
            this.lblPixel.Size = new System.Drawing.Size(46, 15);
            this.lblPixel.TabIndex = 8;
            this.lblPixel.Text = "Tamaño";
            // 
            // numPixelSize
            // 
            this.numPixelSize.Location = new System.Drawing.Point(193, 27);
            this.numPixelSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPixelSize.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numPixelSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            this.numPixelSize.Name = "numPixelSize";
            this.numPixelSize.Size = new System.Drawing.Size(45, 23);
            this.numPixelSize.TabIndex = 7;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(15, 30);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(36, 15);
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "Delay";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(57, 27);
            this.numSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Value = new decimal(new int[] { 50, 0, 0, 0 });
            this.numSpeed.Size = new System.Drawing.Size(55, 23);
            this.numSpeed.TabIndex = 5;
            // 
            // chkOctantes
            // 
            this.chkOctantes.AutoSize = true;
            this.chkOctantes.Checked = true;
            this.chkOctantes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOctantes.Location = new System.Drawing.Point(298, 49);
            this.chkOctantes.Name = "chkOctantes";
            this.chkOctantes.Size = new System.Drawing.Size(83, 19);
            this.chkOctantes.TabIndex = 4;
            this.chkOctantes.Text = "Ver 8 Oct.";
            this.chkOctantes.UseVisualStyleBackColor = true;
            // 
            // chkGrid
            // 
            this.chkGrid.AutoSize = true;
            this.chkGrid.Checked = true;
            this.chkGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGrid.Location = new System.Drawing.Point(298, 24);
            this.chkGrid.Name = "chkGrid";
            this.chkGrid.Size = new System.Drawing.Size(48, 19);
            this.chkGrid.TabIndex = 3;
            this.chkGrid.Text = "Grid";
            this.chkGrid.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(193, 67);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(102, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDraw.Location = new System.Drawing.Point(15, 67);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 29);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Animar";
            this.btnDraw.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(21, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 301);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormBresenhamCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBresenhamCirculo";
            this.Text = "Círculo Bresenham (Simetría 8 Octantes)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPixelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtYC;
        private System.Windows.Forms.TextBox txtXC;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.CheckBox chkGrid;
        private System.Windows.Forms.CheckBox chkOctantes;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPixel;
        private System.Windows.Forms.NumericUpDown numPixelSize;
    }
}