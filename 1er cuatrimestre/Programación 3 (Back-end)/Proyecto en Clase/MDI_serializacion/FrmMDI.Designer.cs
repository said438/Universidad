namespace MDI_serializacion
{
    partial class FrmMDI
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
            personaToolStripMenuItem = new ToolStripMenuItem();
            aBMPersonaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { personaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // personaToolStripMenuItem
            // 
            personaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aBMPersonaToolStripMenuItem });
            personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            personaToolStripMenuItem.Size = new Size(61, 20);
            personaToolStripMenuItem.Text = "Persona";
            // 
            // aBMPersonaToolStripMenuItem
            // 
            aBMPersonaToolStripMenuItem.Name = "aBMPersonaToolStripMenuItem";
            aBMPersonaToolStripMenuItem.Size = new Size(180, 22);
            aBMPersonaToolStripMenuItem.Text = "ABM Persona";
            aBMPersonaToolStripMenuItem.Click += aBMPersonaToolStripMenuItem_Click;
            // 
            // FrmMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMDI";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem personaToolStripMenuItem;
        private ToolStripMenuItem aBMPersonaToolStripMenuItem;
    }
}