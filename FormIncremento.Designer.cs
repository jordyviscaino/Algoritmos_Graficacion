namespace Algoritmos_Graficacion
{
    partial class FormIncremento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncremento));
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtY1 = new TextBox();
            txtX0 = new TextBox();
            txtY0 = new TextBox();
            txtX1 = new TextBox();
            groupBox2 = new GroupBox();
            lblPixel = new Label();
            numPixelSize = new NumericUpDown();
            lblSpeed = new Label();
            numSpeed = new NumericUpDown();
            chkGrid = new CheckBox();
            btnSalir = new Button();
            btnClear = new Button();
            btnDraw = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPixelSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtY1);
            groupBox1.Controls.Add(txtX0);
            groupBox1.Controls.Add(txtY0);
            groupBox1.Controls.Add(txtX1);
            groupBox1.Location = new Point(21, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Coordenadas (Incremental)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 75);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 7;
            label4.Text = "Y2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 75);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 6;
            label3.Text = "X2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 25);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 5;
            label2.Text = "Y1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 4;
            label1.Text = "X1";
            // 
            // txtY1
            // 
            txtY1.Location = new Point(237, 67);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(100, 23);
            txtY1.TabIndex = 3;
            // 
            // txtX0
            // 
            txtX0.Location = new Point(63, 67);
            txtX0.Name = "txtX0";
            txtX0.Size = new Size(100, 23);
            txtX0.TabIndex = 2;
            // 
            // txtY0
            // 
            txtY0.Location = new Point(237, 22);
            txtY0.Name = "txtY0";
            txtY0.Size = new Size(100, 23);
            txtY0.TabIndex = 1;
            // 
            // txtX1
            // 
            txtX1.Location = new Point(63, 22);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(100, 23);
            txtX1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPixel);
            groupBox2.Controls.Add(numPixelSize);
            groupBox2.Controls.Add(lblSpeed);
            groupBox2.Controls.Add(numSpeed);
            groupBox2.Controls.Add(chkGrid);
            groupBox2.Controls.Add(btnSalir);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDraw);
            groupBox2.Location = new Point(380, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visualización y Control";
            // 
            // lblPixel
            // 
            lblPixel.AutoSize = true;
            lblPixel.Location = new Point(145, 25);
            lblPixel.Name = "lblPixel";
            lblPixel.Size = new Size(53, 15);
            lblPixel.TabIndex = 7;
            lblPixel.Text = "Tamaño:";
            // 
            // numPixelSize
            // 
            numPixelSize.Location = new Point(197, 22);
            numPixelSize.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numPixelSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPixelSize.Name = "numPixelSize";
            numPixelSize.Size = new Size(45, 23);
            numPixelSize.TabIndex = 6;
            numPixelSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(6, 25);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(63, 15);
            lblSpeed.TabIndex = 5;
            lblSpeed.Text = "Delay(ms):";
            // 
            // numSpeed
            // 
            numSpeed.Location = new Point(73, 22);
            numSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSpeed.Name = "numSpeed";
            numSpeed.Size = new Size(55, 23);
            numSpeed.TabIndex = 4;
            numSpeed.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // chkGrid
            // 
            chkGrid.AutoSize = true;
            chkGrid.Checked = true;
            chkGrid.CheckState = CheckState.Checked;
            chkGrid.Location = new Point(248, 24);
            chkGrid.Name = "chkGrid";
            chkGrid.Size = new Size(48, 19);
            chkGrid.TabIndex = 3;
            chkGrid.Text = "Grid";
            chkGrid.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(183, 65);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 31);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(102, 65);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 31);
            btnClear.TabIndex = 1;
            btnClear.Text = "Borrar";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            btnDraw.BackColor = SystemColors.MenuHighlight;
            btnDraw.FlatStyle = FlatStyle.Flat;
            btnDraw.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDraw.Location = new Point(6, 65);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(90, 31);
            btnDraw.TabIndex = 0;
            btnDraw.Text = "Animar";
            btnDraw.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(21, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 304);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(682, 32);
            label6.Name = "label6";
            label6.Size = new Size(219, 50);
            label6.TabIndex = 5;
            label6.Text = "Algoritmo Incremental \r\n(Ecuación Explícita)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(682, 133);
            label5.Name = "label5";
            label5.Size = new Size(248, 220);
            label5.TabIndex = 6;
            label5.Text = resources.GetString("label5.Text");
            label5.Click += label5_Click;
            // 
            // FormIncremento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(937, 449);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormIncremento";
            Text = "Algoritmo Incremental (Animado)";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.CheckBox chkGrid;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPixel;
        private System.Windows.Forms.NumericUpDown numPixelSize;
        private Label label6;
        private Label label5;
    }
}