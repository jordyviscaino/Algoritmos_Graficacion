namespace Algoritmos_Graficacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lineasToolStripMenuItem, circulosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lineasToolStripMenuItem
            // 
            lineasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dDAToolStripMenuItem, bresenhamToolStripMenuItem, incrementoToolStripMenuItem });
            lineasToolStripMenuItem.Name = "lineasToolStripMenuItem";
            lineasToolStripMenuItem.Size = new Size(52, 20);
            lineasToolStripMenuItem.Text = "Lineas";
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
            circulosToolStripMenuItem.Text = "Circulos";
            // 
            // octantesToolStripMenuItem
            // 
            octantesToolStripMenuItem.Name = "octantesToolStripMenuItem";
            octantesToolStripMenuItem.Size = new Size(180, 22);
            octantesToolStripMenuItem.Text = "Punto Medio";
            octantesToolStripMenuItem.Click += octantesToolStripMenuItem_Click;
            // 
            // bresenhamToolStripMenuItem1
            // 
            bresenhamToolStripMenuItem1.Name = "bresenhamToolStripMenuItem1";
            bresenhamToolStripMenuItem1.Size = new Size(180, 22);
            bresenhamToolStripMenuItem1.Text = "Bresenham";
            bresenhamToolStripMenuItem1.Click += bresenhamToolStripMenuItem1_Click;
            // 
            // parametricoToolStripMenuItem
            // 
            parametricoToolStripMenuItem.Name = "parametricoToolStripMenuItem";
            parametricoToolStripMenuItem.Size = new Size(180, 22);
            parametricoToolStripMenuItem.Text = "Paramétrico";
            parametricoToolStripMenuItem.Click += parametricoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lineasToolStripMenuItem;
        private ToolStripMenuItem dDAToolStripMenuItem;
        private ToolStripMenuItem bresenhamToolStripMenuItem;
        private ToolStripMenuItem incrementoToolStripMenuItem;
        private ToolStripMenuItem circulosToolStripMenuItem;
        private ToolStripMenuItem octantesToolStripMenuItem;
        private ToolStripMenuItem bresenhamToolStripMenuItem1;
        private ToolStripMenuItem parametricoToolStripMenuItem;
    }
}
