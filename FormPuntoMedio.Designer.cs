namespace Algoritmos_Graficacion
{
    partial class FormPuntoMedio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPuntoMedio));
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRadio = new TextBox();
            txtYC = new TextBox();
            txtXC = new TextBox();
            groupBox2 = new GroupBox();
            lblPixel = new Label();
            numPixelSize = new NumericUpDown();
            lblSpeed = new Label();
            numSpeed = new NumericUpDown();
            chkOctantes = new CheckBox();
            chkGrid = new CheckBox();
            btnSalir = new Button();
            btnClear = new Button();
            btnDraw = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPixelSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRadio);
            groupBox1.Controls.Add(txtYC);
            groupBox1.Controls.Add(txtXC);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Círculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 77);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 29);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 4;
            label2.Text = "YC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 3;
            label1.Text = "XC";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(81, 74);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 2;
            // 
            // txtYC
            // 
            txtYC.Location = new Point(172, 26);
            txtYC.Name = "txtYC";
            txtYC.Size = new Size(68, 23);
            txtYC.TabIndex = 1;
            // 
            // txtXC
            // 
            txtXC.Location = new Point(48, 26);
            txtXC.Name = "txtXC";
            txtXC.Size = new Size(68, 23);
            txtXC.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPixel);
            groupBox2.Controls.Add(numPixelSize);
            groupBox2.Controls.Add(lblSpeed);
            groupBox2.Controls.Add(numSpeed);
            groupBox2.Controls.Add(chkOctantes);
            groupBox2.Controls.Add(chkGrid);
            groupBox2.Controls.Add(btnSalir);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDraw);
            groupBox2.Location = new Point(289, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control y Visualización";
            // 
            // lblPixel
            // 
            lblPixel.AutoSize = true;
            lblPixel.Location = new Point(141, 30);
            lblPixel.Name = "lblPixel";
            lblPixel.Size = new Size(50, 15);
            lblPixel.TabIndex = 8;
            lblPixel.Text = "Tamaño";
            // 
            // numPixelSize
            // 
            numPixelSize.Location = new Point(193, 27);
            numPixelSize.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numPixelSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPixelSize.Name = "numPixelSize";
            numPixelSize.Size = new Size(45, 23);
            numPixelSize.TabIndex = 7;
            numPixelSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(15, 30);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(36, 15);
            lblSpeed.TabIndex = 6;
            lblSpeed.Text = "Delay";
            // 
            // numSpeed
            // 
            numSpeed.Location = new Point(57, 27);
            numSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSpeed.Name = "numSpeed";
            numSpeed.Size = new Size(55, 23);
            numSpeed.TabIndex = 5;
            numSpeed.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // chkOctantes
            // 
            chkOctantes.AutoSize = true;
            chkOctantes.Checked = true;
            chkOctantes.CheckState = CheckState.Checked;
            chkOctantes.Location = new Point(298, 49);
            chkOctantes.Name = "chkOctantes";
            chkOctantes.Size = new Size(76, 19);
            chkOctantes.TabIndex = 4;
            chkOctantes.Text = "Ver 8 Oct.";
            chkOctantes.UseVisualStyleBackColor = true;
            // 
            // chkGrid
            // 
            chkGrid.AutoSize = true;
            chkGrid.Checked = true;
            chkGrid.CheckState = CheckState.Checked;
            chkGrid.Location = new Point(298, 24);
            chkGrid.Name = "chkGrid";
            chkGrid.Size = new Size(48, 19);
            chkGrid.TabIndex = 3;
            chkGrid.Text = "Grid";
            chkGrid.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(193, 67);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(102, 67);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            btnDraw.BackColor = SystemColors.Highlight;
            btnDraw.ForeColor = SystemColors.ButtonHighlight;
            btnDraw.Location = new Point(15, 67);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(75, 29);
            btnDraw.TabIndex = 0;
            btnDraw.Text = "Animar";
            btnDraw.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(21, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 301);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(682, 165);
            label5.Name = "label5";
            label5.Size = new Size(323, 140);
            label5.TabIndex = 11;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(708, 54);
            label6.Name = "label6";
            label6.Size = new Size(257, 50);
            label6.TabIndex = 10;
            label6.Text = "Algoritmo de Punto Medio \r\n(Midpoint)";
            // 
            // FormPuntoMedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(997, 450);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormPuntoMedio";
            Text = "Círculo Bresenham (Simetría 8 Octantes)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPixelSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label5;
        private Label label6;
    }
}