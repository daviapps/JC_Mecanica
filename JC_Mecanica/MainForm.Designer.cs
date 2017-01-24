namespace JC_Mecanica {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.status = new System.Windows.Forms.StatusStrip();
            this.cadastro_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_dispesas_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_servicos_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_clientes_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_carro_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 409);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(667, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            // 
            // cadastro_menu
            // 
            this.cadastro_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastro_dispesas_menu,
            this.cadastro_servicos_menu,
            this.cadastro_clientes_menu,
            this.cadastro_carro_menu});
            this.cadastro_menu.Name = "cadastro_menu";
            this.cadastro_menu.Size = new System.Drawing.Size(66, 20);
            this.cadastro_menu.Text = "Cadastro";
            // 
            // cadastro_dispesas_menu
            // 
            this.cadastro_dispesas_menu.Name = "cadastro_dispesas_menu";
            this.cadastro_dispesas_menu.Size = new System.Drawing.Size(142, 22);
            this.cadastro_dispesas_menu.Text = "Dispesas [F5]";
            // 
            // cadastro_servicos_menu
            // 
            this.cadastro_servicos_menu.Name = "cadastro_servicos_menu";
            this.cadastro_servicos_menu.Size = new System.Drawing.Size(142, 22);
            this.cadastro_servicos_menu.Text = "Serviços [F6]";
            // 
            // cadastro_clientes_menu
            // 
            this.cadastro_clientes_menu.Name = "cadastro_clientes_menu";
            this.cadastro_clientes_menu.Size = new System.Drawing.Size(142, 22);
            this.cadastro_clientes_menu.Text = "Clientes [F7]";
            this.cadastro_clientes_menu.Click += new System.EventHandler(this.cadastro_clientes_menu_Click);
            // 
            // cadastro_carro_menu
            // 
            this.cadastro_carro_menu.Name = "cadastro_carro_menu";
            this.cadastro_carro_menu.Size = new System.Drawing.Size(142, 22);
            this.cadastro_carro_menu.Text = "Carros [F8]";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastro_menu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(667, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 431);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "JC Mecânica";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem cadastro_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_dispesas_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_servicos_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_clientes_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_carro_menu;
        private System.Windows.Forms.MenuStrip menu;

    }
}

