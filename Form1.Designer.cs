namespace Algoritmos_Graficacion
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            lineasToolStripMenuItem = new ToolStripMenuItem();
            dDAToolStripMenuItem = new ToolStripMenuItem();
            bresenhamToolStripMenuItem = new ToolStripMenuItem();
            incrementoToolStripMenuItem = new ToolStripMenuItem();
            circulosToolStripMenuItem = new ToolStripMenuItem();
            octantesToolStripMenuItem = new ToolStripMenuItem();
            bresenhamToolStripMenuItem1 = new ToolStripMenuItem();
            parametricoToolStripMenuItem = new ToolStripMenuItem();
            recorteDeLinasToolStripMenuItem = new ToolStripMenuItem();
            cohenShuterlandToolStripMenuItem = new ToolStripMenuItem();
            puntoMedioToolStripMenuItem = new ToolStripMenuItem();
            liangBarskyToolStripMenuItem = new ToolStripMenuItem();
            poligonosToolStripMenuItem = new ToolStripMenuItem();
            shuterlandHodgmanToolStripMenuItem = new ToolStripMenuItem();
            sutherlandTrainguloToolStripMenuItem = new ToolStripMenuItem();
            liangBarskyToolStripMenuItem1 = new ToolStripMenuItem();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelCentral = new Panel();
            lblFooter = new Label();
            menuStrip1.SuspendLayout();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Items.AddRange(new ToolStripItem[] { lineasToolStripMenuItem, circulosToolStripMenuItem, recorteDeLinasToolStripMenuItem, poligonosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1031, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lineasToolStripMenuItem
            // 
            lineasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dDAToolStripMenuItem, bresenhamToolStripMenuItem, incrementoToolStripMenuItem });
            lineasToolStripMenuItem.Name = "lineasToolStripMenuItem";
            lineasToolStripMenuItem.Size = new Size(52, 20);
            lineasToolStripMenuItem.Text = "Líneas";
            // 
            // dDAToolStripMenuItem
            // 
            dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            dDAToolStripMenuItem.Size = new Size(135, 22);
            dDAToolStripMenuItem.Text = "DDA";
            dDAToolStripMenuItem.Click += dDAToolStripMenuItem_Click;
            // 
            // bresenhamToolStripMenuItem
            // 
            bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            bresenhamToolStripMenuItem.Size = new Size(135, 22);
            bresenhamToolStripMenuItem.Text = "Bresenham";
            bresenhamToolStripMenuItem.Click += bresenhamToolStripMenuItem_Click;
            // 
            // incrementoToolStripMenuItem
            // 
            incrementoToolStripMenuItem.Name = "incrementoToolStripMenuItem";
            incrementoToolStripMenuItem.Size = new Size(135, 22);
            incrementoToolStripMenuItem.Text = "Incremento";
            incrementoToolStripMenuItem.Click += incrementoToolStripMenuItem_Click;
            // 
            // circulosToolStripMenuItem
            // 
            circulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { octantesToolStripMenuItem, bresenhamToolStripMenuItem1, parametricoToolStripMenuItem });
            circulosToolStripMenuItem.Name = "circulosToolStripMenuItem";
            circulosToolStripMenuItem.Size = new Size(62, 20);
            circulosToolStripMenuItem.Text = "Círculos";
            // 
            // octantesToolStripMenuItem
            // 
            octantesToolStripMenuItem.Name = "octantesToolStripMenuItem";
            octantesToolStripMenuItem.Size = new Size(143, 22);
            octantesToolStripMenuItem.Text = "Punto Medio";
            octantesToolStripMenuItem.Click += octantesToolStripMenuItem_Click;
            // 
            // bresenhamToolStripMenuItem1
            // 
            bresenhamToolStripMenuItem1.Name = "bresenhamToolStripMenuItem1";
            bresenhamToolStripMenuItem1.Size = new Size(143, 22);
            bresenhamToolStripMenuItem1.Text = "Bresenham";
            bresenhamToolStripMenuItem1.Click += bresenhamToolStripMenuItem1_Click;
            // 
            // parametricoToolStripMenuItem
            // 
            parametricoToolStripMenuItem.Name = "parametricoToolStripMenuItem";
            parametricoToolStripMenuItem.Size = new Size(143, 22);
            parametricoToolStripMenuItem.Text = "Paramétrico";
            parametricoToolStripMenuItem.Click += parametricoToolStripMenuItem_Click;
            // 
            // recorteDeLinasToolStripMenuItem
            // 
            recorteDeLinasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cohenShuterlandToolStripMenuItem, puntoMedioToolStripMenuItem, liangBarskyToolStripMenuItem });
            recorteDeLinasToolStripMenuItem.Name = "recorteDeLinasToolStripMenuItem";
            recorteDeLinasToolStripMenuItem.Size = new Size(111, 20);
            recorteDeLinasToolStripMenuItem.Text = "Recorte de Líneas";
            // 
            // cohenShuterlandToolStripMenuItem
            // 
            cohenShuterlandToolStripMenuItem.Name = "cohenShuterlandToolStripMenuItem";
            cohenShuterlandToolStripMenuItem.Size = new Size(171, 22);
            cohenShuterlandToolStripMenuItem.Text = "Cohen-Sutherland";
            cohenShuterlandToolStripMenuItem.Click += cohenShuterlandToolStripMenuItem_Click;
            // 
            // puntoMedioToolStripMenuItem
            // 
            puntoMedioToolStripMenuItem.Name = "puntoMedioToolStripMenuItem";
            puntoMedioToolStripMenuItem.Size = new Size(171, 22);
            puntoMedioToolStripMenuItem.Text = "Punto Medio";
            puntoMedioToolStripMenuItem.Click += puntoMedioToolStripMenuItem_Click;
            // 
            // liangBarskyToolStripMenuItem
            // 
            liangBarskyToolStripMenuItem.Name = "liangBarskyToolStripMenuItem";
            liangBarskyToolStripMenuItem.Size = new Size(171, 22);
            liangBarskyToolStripMenuItem.Text = "Liang-Barsky";
            liangBarskyToolStripMenuItem.Click += liangBarskyToolStripMenuItem_Click;
            // 
            // poligonosToolStripMenuItem
            // 
            poligonosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shuterlandHodgmanToolStripMenuItem, sutherlandTrainguloToolStripMenuItem, liangBarskyToolStripMenuItem1 });
            poligonosToolStripMenuItem.Name = "poligonosToolStripMenuItem";
            poligonosToolStripMenuItem.Size = new Size(72, 20);
            poligonosToolStripMenuItem.Text = "Polígonos";
            // 
            // shuterlandHodgmanToolStripMenuItem
            // 
            shuterlandHodgmanToolStripMenuItem.Name = "shuterlandHodgmanToolStripMenuItem";
            shuterlandHodgmanToolStripMenuItem.Size = new Size(190, 22);
            shuterlandHodgmanToolStripMenuItem.Text = "Sutherland-Hodgman";
            shuterlandHodgmanToolStripMenuItem.Click += shuterlandHodgmanToolStripMenuItem_Click;
            // 
            // sutherlandTrainguloToolStripMenuItem
            // 
            sutherlandTrainguloToolStripMenuItem.Name = "sutherlandTrainguloToolStripMenuItem";
            sutherlandTrainguloToolStripMenuItem.Size = new Size(190, 22);
            sutherlandTrainguloToolStripMenuItem.Text = "Sutherland Triángulo";
            sutherlandTrainguloToolStripMenuItem.Click += sutherlandTrainguloToolStripMenuItem_Click;
            // 
            // liangBarskyToolStripMenuItem1
            // 
            liangBarskyToolStripMenuItem1.Name = "liangBarskyToolStripMenuItem1";
            liangBarskyToolStripMenuItem1.Size = new Size(190, 22);
            liangBarskyToolStripMenuItem1.Text = "Liang-Barsky (Poly)";
            liangBarskyToolStripMenuItem1.Click += liangBarskyToolStripMenuItem1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(158, 138);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(670, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "ALGORITMOS DE COMPUTACIÓN GRÁFICA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(268, 208);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(440, 21);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Seleccione una herramienta del menú superior para comenzar";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.White;
            panelCentral.Controls.Add(lblFooter);
            panelCentral.Controls.Add(lblTitulo);
            panelCentral.Controls.Add(lblSubtitulo);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 24);
            panelCentral.Margin = new Padding(4, 3, 4, 3);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1031, 623);
            panelCentral.TabIndex = 3;
            // 
            // lblFooter
            // 
            lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = Color.Silver;
            lblFooter.Location = new Point(875, 595);
            lblFooter.Margin = new Padding(4, 0, 4, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(148, 15);
            lblFooter.TabIndex = 3;
            lblFooter.Text = "Versión: Final - Graficación";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 647);
            Controls.Add(panelCentral);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio de Graficación";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parametricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorteDeLinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cohenShuterlandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoMedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liangBarskyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuterlandHodgmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sutherlandTrainguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liangBarskyToolStripMenuItem1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label lblFooter;
    }
}