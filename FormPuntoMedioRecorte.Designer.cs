namespace Algoritmos_Graficacion
{
    partial class FormPuntoMedioRecorte
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
            this.groupBoxLine = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.groupBoxWindow = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRecortar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxLine.SuspendLayout();
            this.groupBoxWindow.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLine (Datos de Línea)
            // 
            this.groupBoxLine.Controls.Add(this.label4);
            this.groupBoxLine.Controls.Add(this.label3);
            this.groupBoxLine.Controls.Add(this.label2);
            this.groupBoxLine.Controls.Add(this.label1);
            this.groupBoxLine.Controls.Add(this.txtY2);
            this.groupBoxLine.Controls.Add(this.txtX2);
            this.groupBoxLine.Controls.Add(this.txtY1);
            this.groupBoxLine.Controls.Add(this.txtX1);
            this.groupBoxLine.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLine.Name = "groupBoxLine";
            this.groupBoxLine.Size = new System.Drawing.Size(200, 130);
            this.groupBoxLine.TabIndex = 0;
            this.groupBoxLine.TabStop = false;
            this.groupBoxLine.Text = "Línea a Recortar";
            // 
            // Labels Linea
            // 
            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(105, 80); this.label4.Text = "Y2";
            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(15, 80); this.label3.Text = "X2";
            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(105, 30); this.label2.Text = "Y1";
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(15, 30); this.label1.Text = "X1";
            // Inputs Linea
            this.txtY2.Location = new System.Drawing.Point(130, 77); this.txtY2.Size = new System.Drawing.Size(50, 23);
            this.txtX2.Location = new System.Drawing.Point(40, 77); this.txtX2.Size = new System.Drawing.Size(50, 23);
            this.txtY1.Location = new System.Drawing.Point(130, 27); this.txtY1.Size = new System.Drawing.Size(50, 23);
            this.txtX1.Location = new System.Drawing.Point(40, 27); this.txtX1.Size = new System.Drawing.Size(50, 23);

            // 
            // groupBoxWindow (Datos Ventana de Recorte)
            // 
            this.groupBoxWindow.Controls.Add(this.label5);
            this.groupBoxWindow.Controls.Add(this.label6);
            this.groupBoxWindow.Controls.Add(this.label7);
            this.groupBoxWindow.Controls.Add(this.label8);
            this.groupBoxWindow.Controls.Add(this.txtH);
            this.groupBoxWindow.Controls.Add(this.txtW);
            this.groupBoxWindow.Controls.Add(this.txtYMin);
            this.groupBoxWindow.Controls.Add(this.txtXMin);
            this.groupBoxWindow.Location = new System.Drawing.Point(220, 12);
            this.groupBoxWindow.Name = "groupBoxWindow";
            this.groupBoxWindow.Size = new System.Drawing.Size(200, 130);
            this.groupBoxWindow.TabIndex = 1;
            this.groupBoxWindow.TabStop = false;
            this.groupBoxWindow.Text = "Ventana de Recorte";
            // 
            // Labels Ventana
            // 
            this.label5.AutoSize = true; this.label5.Location = new System.Drawing.Point(105, 80); this.label5.Text = "Alto";
            this.label6.AutoSize = true; this.label6.Location = new System.Drawing.Point(15, 80); this.label6.Text = "Ancho";
            this.label7.AutoSize = true; this.label7.Location = new System.Drawing.Point(105, 30); this.label7.Text = "Ymin";
            this.label8.AutoSize = true; this.label8.Location = new System.Drawing.Point(15, 30); this.label8.Text = "Xmin";
            // Inputs Ventana
            this.txtH.Location = new System.Drawing.Point(140, 77); this.txtH.Size = new System.Drawing.Size(50, 23); this.txtH.Text = "150";
            this.txtW.Location = new System.Drawing.Point(60, 77); this.txtW.Size = new System.Drawing.Size(40, 23); this.txtW.Text = "200";
            this.txtYMin.Location = new System.Drawing.Point(140, 27); this.txtYMin.Size = new System.Drawing.Size(50, 23); this.txtYMin.Text = "100";
            this.txtXMin.Location = new System.Drawing.Point(60, 27); this.txtXMin.Size = new System.Drawing.Size(40, 23); this.txtXMin.Text = "150";

            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.lblMsg);
            this.groupBoxControls.Controls.Add(this.numSpeed);
            this.groupBoxControls.Controls.Add(this.lblSpeed);
            this.groupBoxControls.Controls.Add(this.btnSalir);
            this.groupBoxControls.Controls.Add(this.btnClear);
            this.groupBoxControls.Controls.Add(this.btnRecortar);
            this.groupBoxControls.Location = new System.Drawing.Point(430, 12);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(350, 130);
            this.groupBoxControls.TabIndex = 2;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controles";
            // 
            // lblMsg (Para mostrar estado actual del algoritmo)
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg.Location = new System.Drawing.Point(15, 95);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(16, 15);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.Text = "...";
            // 
            // Controls
            // 
            this.lblSpeed.AutoSize = true; this.lblSpeed.Location = new System.Drawing.Point(15, 30); this.lblSpeed.Text = "Delay(ms)";
            this.numSpeed.Location = new System.Drawing.Point(80, 28); this.numSpeed.Maximum = new decimal(new int[] { 2000, 0, 0, 0 }); this.numSpeed.Value = new decimal(new int[] { 500, 0, 0, 0 });

            this.btnRecortar.Location = new System.Drawing.Point(15, 60); this.btnRecortar.Size = new System.Drawing.Size(100, 30); this.btnRecortar.Text = "Recortar"; this.btnRecortar.BackColor = System.Drawing.SystemColors.MenuHighlight; this.btnRecortar.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(130, 60); this.btnClear.Size = new System.Drawing.Size(80, 30); this.btnClear.Text = "Limpiar";
            this.btnSalir.Location = new System.Drawing.Point(220, 60); this.btnSalir.Size = new System.Drawing.Size(80, 30); this.btnSalir.Text = "Salir"; this.btnSalir.BackColor = System.Drawing.Color.Red; this.btnSalir.ForeColor = System.Drawing.Color.White;

            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 400);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;

            // 
            // FormCohenSutherland
            // 
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxWindow);
            this.Controls.Add(this.groupBoxLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Text = "Algoritmo Cohen-Sutherland (Recorte de Líneas)";
            this.groupBoxLine.ResumeLayout(false); this.groupBoxLine.PerformLayout();
            this.groupBoxWindow.ResumeLayout(false); this.groupBoxWindow.PerformLayout();
            this.groupBoxControls.ResumeLayout(false); this.groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
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
    }
}