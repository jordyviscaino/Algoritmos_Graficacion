namespace Algoritmos_Graficacion
{
    partial class FormSutherlandTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSutherlandTriangulo));
            groupBoxDibujo = new GroupBox();
            btnReiniciar = new Button();
            btnCerrarPoligono = new Button();
            lblInstruccion = new Label();
            groupBoxRecorte = new GroupBox();
            btnRecortar = new Button();
            txtH = new TextBox();
            txtW = new TextBox();
            txtY = new TextBox();
            txtX = new TextBox();
            labelViewport = new Label();
            groupBoxRelleno = new GroupBox();
            btnRellenar = new Button();
            rbScanline = new RadioButton();
            rbFlood8 = new RadioButton();
            rbFlood4 = new RadioButton();
            btnColor = new Button();
            groupBoxConfig = new GroupBox();
            lblSpeed = new Label();
            numSpeed = new NumericUpDown();
            lblPixel = new Label();
            numPixelSize = new NumericUpDown();
            chkGrid = new CheckBox();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            lblEstado = new Label();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            groupBoxDibujo.SuspendLayout();
            groupBoxRecorte.SuspendLayout();
            groupBoxRelleno.SuspendLayout();
            groupBoxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPixelSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDibujo
            // 
            groupBoxDibujo.Controls.Add(btnReiniciar);
            groupBoxDibujo.Controls.Add(btnCerrarPoligono);
            groupBoxDibujo.Controls.Add(lblInstruccion);
            groupBoxDibujo.Location = new Point(12, 12);
            groupBoxDibujo.Name = "groupBoxDibujo";
            groupBoxDibujo.Size = new Size(200, 100);
            groupBoxDibujo.TabIndex = 5;
            groupBoxDibujo.TabStop = false;
            groupBoxDibujo.Text = "1. Dibujo";
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(90, 45);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(75, 23);
            btnReiniciar.TabIndex = 0;
            btnReiniciar.Text = "Reiniciar";
            // 
            // btnCerrarPoligono
            // 
            btnCerrarPoligono.BackColor = Color.LightGreen;
            btnCerrarPoligono.Location = new Point(10, 45);
            btnCerrarPoligono.Name = "btnCerrarPoligono";
            btnCerrarPoligono.Size = new Size(75, 23);
            btnCerrarPoligono.TabIndex = 1;
            btnCerrarPoligono.Text = "Cerrar";
            btnCerrarPoligono.UseVisualStyleBackColor = false;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Location = new Point(10, 20);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(119, 15);
            lblInstruccion.TabIndex = 2;
            lblInstruccion.Text = "Click: Agregar Vértice";
            // 
            // groupBoxRecorte
            // 
            groupBoxRecorte.Controls.Add(btnRecortar);
            groupBoxRecorte.Controls.Add(txtH);
            groupBoxRecorte.Controls.Add(txtW);
            groupBoxRecorte.Controls.Add(txtY);
            groupBoxRecorte.Controls.Add(txtX);
            groupBoxRecorte.Controls.Add(labelViewport);
            groupBoxRecorte.Location = new Point(220, 12);
            groupBoxRecorte.Name = "groupBoxRecorte";
            groupBoxRecorte.Size = new Size(220, 100);
            groupBoxRecorte.TabIndex = 4;
            groupBoxRecorte.TabStop = false;
            groupBoxRecorte.Text = "2. Recorte (Sutherland)";
            // 
            // btnRecortar
            // 
            btnRecortar.BackColor = Color.Orange;
            btnRecortar.Location = new Point(10, 70);
            btnRecortar.Name = "btnRecortar";
            btnRecortar.Size = new Size(175, 23);
            btnRecortar.TabIndex = 0;
            btnRecortar.Text = "RECORTAR";
            btnRecortar.UseVisualStyleBackColor = false;
            // 
            // txtH
            // 
            txtH.Location = new Point(145, 40);
            txtH.Name = "txtH";
            txtH.Size = new Size(40, 23);
            txtH.TabIndex = 1;
            txtH.Text = "200";
            // 
            // txtW
            // 
            txtW.Location = new Point(100, 40);
            txtW.Name = "txtW";
            txtW.Size = new Size(40, 23);
            txtW.TabIndex = 2;
            txtW.Text = "300";
            // 
            // txtY
            // 
            txtY.Location = new Point(55, 40);
            txtY.Name = "txtY";
            txtY.Size = new Size(40, 23);
            txtY.TabIndex = 3;
            txtY.Text = "80";
            // 
            // txtX
            // 
            txtX.Location = new Point(10, 40);
            txtX.Name = "txtX";
            txtX.Size = new Size(40, 23);
            txtX.TabIndex = 4;
            txtX.Text = "100";
            // 
            // labelViewport
            // 
            labelViewport.AutoSize = true;
            labelViewport.Location = new Point(10, 20);
            labelViewport.Name = "labelViewport";
            labelViewport.Size = new Size(106, 15);
            labelViewport.TabIndex = 5;
            labelViewport.Text = "Ventana (X,Y,W,H):";
            // 
            // groupBoxRelleno
            // 
            groupBoxRelleno.Controls.Add(btnRellenar);
            groupBoxRelleno.Controls.Add(rbScanline);
            groupBoxRelleno.Controls.Add(rbFlood8);
            groupBoxRelleno.Controls.Add(rbFlood4);
            groupBoxRelleno.Controls.Add(btnColor);
            groupBoxRelleno.Location = new Point(450, 12);
            groupBoxRelleno.Name = "groupBoxRelleno";
            groupBoxRelleno.Size = new Size(250, 100);
            groupBoxRelleno.TabIndex = 3;
            groupBoxRelleno.TabStop = false;
            groupBoxRelleno.Text = "3. Relleno";
            // 
            // btnRellenar
            // 
            btnRellenar.BackColor = Color.DeepSkyBlue;
            btnRellenar.Location = new Point(120, 60);
            btnRellenar.Name = "btnRellenar";
            btnRellenar.Size = new Size(75, 23);
            btnRellenar.TabIndex = 0;
            btnRellenar.Text = "RELLENAR";
            btnRellenar.UseVisualStyleBackColor = false;
            // 
            // rbScanline
            // 
            rbScanline.AutoSize = true;
            rbScanline.Location = new Point(10, 60);
            rbScanline.Name = "rbScanline";
            rbScanline.Size = new Size(69, 19);
            rbScanline.TabIndex = 1;
            rbScanline.Text = "Scanline";
            // 
            // rbFlood8
            // 
            rbFlood8.AutoSize = true;
            rbFlood8.Location = new Point(10, 40);
            rbFlood8.Name = "rbFlood8";
            rbFlood8.Size = new Size(90, 19);
            rbFlood8.TabIndex = 2;
            rbFlood8.Text = "Flood Fill (8)";
            // 
            // rbFlood4
            // 
            rbFlood4.AutoSize = true;
            rbFlood4.Checked = true;
            rbFlood4.Location = new Point(10, 20);
            rbFlood4.Name = "rbFlood4";
            rbFlood4.Size = new Size(90, 19);
            rbFlood4.TabIndex = 3;
            rbFlood4.TabStop = true;
            rbFlood4.Text = "Flood Fill (4)";
            // 
            // btnColor
            // 
            btnColor.BackColor = Color.Tomato;
            btnColor.Location = new Point(120, 20);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 4;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = false;
            // 
            // groupBoxConfig
            // 
            groupBoxConfig.Controls.Add(lblSpeed);
            groupBoxConfig.Controls.Add(numSpeed);
            groupBoxConfig.Controls.Add(lblPixel);
            groupBoxConfig.Controls.Add(numPixelSize);
            groupBoxConfig.Controls.Add(chkGrid);
            groupBoxConfig.Controls.Add(btnSalir);
            groupBoxConfig.Location = new Point(710, 12);
            groupBoxConfig.Name = "groupBoxConfig";
            groupBoxConfig.Size = new Size(292, 100);
            groupBoxConfig.TabIndex = 2;
            groupBoxConfig.TabStop = false;
            groupBoxConfig.Text = "Configuración";
            // 
            // lblSpeed
            // 
            lblSpeed.Location = new Point(10, 20);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(63, 23);
            lblSpeed.TabIndex = 0;
            lblSpeed.Text = "Delay(ms)";
            // 
            // numSpeed
            // 
            numSpeed.Location = new Point(100, 18);
            numSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSpeed.Name = "numSpeed";
            numSpeed.Size = new Size(90, 23);
            numSpeed.TabIndex = 1;
            numSpeed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblPixel
            // 
            lblPixel.Location = new Point(10, 45);
            lblPixel.Name = "lblPixel";
            lblPixel.Size = new Size(74, 23);
            lblPixel.TabIndex = 2;
            lblPixel.Text = "Pixel(px)";
            // 
            // numPixelSize
            // 
            numPixelSize.Location = new Point(100, 43);
            numPixelSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPixelSize.Name = "numPixelSize";
            numPixelSize.Size = new Size(90, 23);
            numPixelSize.TabIndex = 3;
            numPixelSize.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // chkGrid
            // 
            chkGrid.Checked = true;
            chkGrid.CheckState = CheckState.Checked;
            chkGrid.Location = new Point(196, 18);
            chkGrid.Name = "chkGrid";
            chkGrid.Size = new Size(90, 24);
            chkGrid.TabIndex = 4;
            chkGrid.Text = "Ver Grid";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(135, 70);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(67, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1279, 410);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.ForeColor = Color.Blue;
            lblEstado.Location = new Point(12, 120);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(163, 15);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado: Dibujando polígono...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1008, 20);
            label1.Name = "label1";
            label1.Size = new Size(400, 75);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // FormSutherlandTriangulo
            // 
            ClientSize = new Size(1409, 561);
            Controls.Add(label1);
            Controls.Add(lblEstado);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxConfig);
            Controls.Add(groupBoxRelleno);
            Controls.Add(groupBoxRecorte);
            Controls.Add(groupBoxDibujo);
            Name = "FormSutherlandTriangulo";
            Text = "Recorte y Relleno de Polígonos";
            groupBoxDibujo.ResumeLayout(false);
            groupBoxDibujo.PerformLayout();
            groupBoxRecorte.ResumeLayout(false);
            groupBoxRecorte.PerformLayout();
            groupBoxRelleno.ResumeLayout(false);
            groupBoxRelleno.PerformLayout();
            groupBoxConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPixelSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Componentes
        private System.Windows.Forms.GroupBox groupBoxDibujo;
        private System.Windows.Forms.GroupBox groupBoxRecorte;
        private System.Windows.Forms.GroupBox groupBoxRelleno;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnCerrarPoligono;
        private System.Windows.Forms.Label lblInstruccion;

        private System.Windows.Forms.Button btnRecortar;
        private System.Windows.Forms.Label labelViewport;
        private System.Windows.Forms.TextBox txtH, txtW, txtY, txtX;

        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RadioButton rbScanline, rbFlood8, rbFlood4;

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkGrid;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown numPixelSize;
        private System.Windows.Forms.Label lblPixel;
        private Label label1;
    }
}