namespace Algoritmos_Graficacion
{
    partial class FormBresenhamCirculos
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
            txtRadio = new TextBox();
            label1 = new Label();
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
            pictureBox1.TabIndex = 11;
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
            groupBox2.TabIndex = 10;
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
            groupBox1.Controls.Add(txtRadio);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 100);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresa tus valores";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(71, 44);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 47);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Radio";
            // 
            // FormBresenhamCirculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 451);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormBresenhamCirculos";
            Text = "FormBresenhamCirculos";
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
        private TextBox txtRadio;
        private Label label1;
    }
}