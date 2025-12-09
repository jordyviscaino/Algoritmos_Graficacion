namespace Algoritmos_Graficacion
{
    partial class FormCohenSutherland
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCohenSutherland));
            groupBoxLine = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtY2 = new TextBox();
            txtX2 = new TextBox();
            txtY1 = new TextBox();
            txtX1 = new TextBox();
            groupBoxWindow = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtH = new TextBox();
            txtW = new TextBox();
            txtYMin = new TextBox();
            txtXMin = new TextBox();
            groupBoxControls = new GroupBox();
            lblMsg = new Label();
            numSpeed = new NumericUpDown();
            lblSpeed = new Label();
            btnSalir = new Button();
            btnClear = new Button();
            btnRecortar = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            groupBoxLine.SuspendLayout();
            groupBoxWindow.SuspendLayout();
            groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxLine
            // 
            groupBoxLine.Controls.Add(label4);
            groupBoxLine.Controls.Add(label3);
            groupBoxLine.Controls.Add(label2);
            groupBoxLine.Controls.Add(label1);
            groupBoxLine.Controls.Add(txtY2);
            groupBoxLine.Controls.Add(txtX2);
            groupBoxLine.Controls.Add(txtY1);
            groupBoxLine.Controls.Add(txtX1);
            groupBoxLine.Location = new Point(14, 126);
            groupBoxLine.Name = "groupBoxLine";
            groupBoxLine.Size = new Size(200, 130);
            groupBoxLine.TabIndex = 0;
            groupBoxLine.TabStop = false;
            groupBoxLine.Text = "Línea a Recortar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 80);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 0;
            label4.Text = "Y2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 80);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 1;
            label3.Text = "X2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 30);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 2;
            label2.Text = "Y1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 3;
            label1.Text = "X1";
            // 
            // txtY2
            // 
            txtY2.Location = new Point(130, 77);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(50, 23);
            txtY2.TabIndex = 4;
            // 
            // txtX2
            // 
            txtX2.Location = new Point(40, 77);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(50, 23);
            txtX2.TabIndex = 5;
            // 
            // txtY1
            // 
            txtY1.Location = new Point(130, 27);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(50, 23);
            txtY1.TabIndex = 6;
            // 
            // txtX1
            // 
            txtX1.Location = new Point(40, 27);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(50, 23);
            txtX1.TabIndex = 7;
            // 
            // groupBoxWindow
            // 
            groupBoxWindow.Controls.Add(label5);
            groupBoxWindow.Controls.Add(label6);
            groupBoxWindow.Controls.Add(label7);
            groupBoxWindow.Controls.Add(label8);
            groupBoxWindow.Controls.Add(txtH);
            groupBoxWindow.Controls.Add(txtW);
            groupBoxWindow.Controls.Add(txtYMin);
            groupBoxWindow.Controls.Add(txtXMin);
            groupBoxWindow.Location = new Point(222, 126);
            groupBoxWindow.Name = "groupBoxWindow";
            groupBoxWindow.Size = new Size(200, 130);
            groupBoxWindow.TabIndex = 1;
            groupBoxWindow.TabStop = false;
            groupBoxWindow.Text = "Ventana de Recorte";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 80);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 0;
            label5.Text = "Alto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 80);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 1;
            label6.Text = "Ancho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 30);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 2;
            label7.Text = "Ymin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 30);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 3;
            label8.Text = "Xmin";
            // 
            // txtH
            // 
            txtH.Location = new Point(140, 77);
            txtH.Name = "txtH";
            txtH.Size = new Size(50, 23);
            txtH.TabIndex = 4;
            txtH.Text = "150";
            // 
            // txtW
            // 
            txtW.Location = new Point(60, 77);
            txtW.Name = "txtW";
            txtW.Size = new Size(40, 23);
            txtW.TabIndex = 5;
            txtW.Text = "200";
            // 
            // txtYMin
            // 
            txtYMin.Location = new Point(140, 27);
            txtYMin.Name = "txtYMin";
            txtYMin.Size = new Size(50, 23);
            txtYMin.TabIndex = 6;
            txtYMin.Text = "100";
            // 
            // txtXMin
            // 
            txtXMin.Location = new Point(60, 27);
            txtXMin.Name = "txtXMin";
            txtXMin.Size = new Size(40, 23);
            txtXMin.TabIndex = 7;
            txtXMin.Text = "150";
            // 
            // groupBoxControls
            // 
            groupBoxControls.Controls.Add(lblMsg);
            groupBoxControls.Controls.Add(numSpeed);
            groupBoxControls.Controls.Add(lblSpeed);
            groupBoxControls.Controls.Add(btnSalir);
            groupBoxControls.Controls.Add(btnClear);
            groupBoxControls.Controls.Add(btnRecortar);
            groupBoxControls.Location = new Point(432, 126);
            groupBoxControls.Name = "groupBoxControls";
            groupBoxControls.Size = new Size(350, 130);
            groupBoxControls.TabIndex = 2;
            groupBoxControls.TabStop = false;
            groupBoxControls.Text = "Controles";
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.ForeColor = Color.Blue;
            lblMsg.Location = new Point(15, 95);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(16, 15);
            lblMsg.TabIndex = 6;
            lblMsg.Text = "...";
            // 
            // numSpeed
            // 
            numSpeed.Location = new Point(80, 28);
            numSpeed.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numSpeed.Name = "numSpeed";
            numSpeed.Size = new Size(120, 23);
            numSpeed.TabIndex = 7;
            numSpeed.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(15, 30);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(60, 15);
            lblSpeed.TabIndex = 8;
            lblSpeed.Text = "Delay(ms)";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(220, 60);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 30);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(130, 60);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 30);
            btnClear.TabIndex = 10;
            btnClear.Text = "Limpiar";
            // 
            // btnRecortar
            // 
            btnRecortar.BackColor = SystemColors.MenuHighlight;
            btnRecortar.ForeColor = Color.White;
            btnRecortar.Location = new Point(15, 60);
            btnRecortar.Name = "btnRecortar";
            btnRecortar.Size = new Size(100, 30);
            btnRecortar.TabIndex = 11;
            btnRecortar.Text = "Recortar";
            btnRecortar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(12, 284);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(770, 400);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(270, 24);
            label9.Name = "label9";
            label9.Size = new Size(553, 80);
            label9.TabIndex = 13;
            label9.Text = resources.GetString("label9.Text");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(22, 36);
            label10.Name = "label10";
            label10.Size = new Size(253, 50);
            label10.TabIndex = 12;
            label10.Text = "Recorte Cohen-Sutherland \r\n(Regiones)";
            // 
            // FormCohenSutherland
            // 
            BackColor = Color.LightCyan;
            ClientSize = new Size(822, 696);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxControls);
            Controls.Add(groupBoxWindow);
            Controls.Add(groupBoxLine);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormCohenSutherland";
            Text = "Algoritmo Cohen-Sutherland (Recorte de Líneas)";
            groupBoxLine.ResumeLayout(false);
            groupBoxLine.PerformLayout();
            groupBoxWindow.ResumeLayout(false);
            groupBoxWindow.PerformLayout();
            groupBoxControls.ResumeLayout(false);
            groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLine;
        private System.Windows.Forms.GroupBox groupBoxWindow;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.TextBox txtY2; private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY1; private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label4; private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2; private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txtH; private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtYMin; private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.Label label5; private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7; private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Button btnSalir; private System.Windows.Forms.Button btnClear; private System.Windows.Forms.Button btnRecortar;
        private System.Windows.Forms.NumericUpDown numSpeed; private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblMsg;
        private Label label9;
        private Label label10;
    }
}