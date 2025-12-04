namespace Algoritmos_Graficacion
{
    partial class FormBresenham
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
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnSalir = new Button();
            btnClear = new Button();
            btnDraw = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtX0 = new TextBox();
            txtY1 = new TextBox();
            txtY0 = new TextBox();
            txtX1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(12, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 304);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSalir);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDraw);
            groupBox2.Location = new Point(371, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 100);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opciones";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(183, 47);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 31);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(102, 47);
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
            btnDraw.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDraw.Location = new Point(6, 47);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(90, 31);
            btnDraw.TabIndex = 0;
            btnDraw.Text = "Dibujar";
            btnDraw.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtX0);
            groupBox1.Controls.Add(txtY1);
            groupBox1.Controls.Add(txtY0);
            groupBox1.Controls.Add(txtX1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresa tus valores";
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
            // txtX0
            // 
            txtX0.Location = new Point(63, 67);
            txtX0.Name = "txtX0";
            txtX0.Size = new Size(100, 23);
            txtX0.TabIndex = 3;
            // 
            // txtY1
            // 
            txtY1.Location = new Point(237, 67);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(100, 23);
            txtY1.TabIndex = 2;
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
            // FormBresenham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(653, 440);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormBresenham";
            Text = "FormBresenham";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnSalir;
        private Button btnClear;
        private Button btnDraw;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtX0;
        private TextBox txtY1;
        private TextBox txtY0;
        private TextBox txtX1;
    }
}