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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.status = new System.Windows.Forms.StatusStrip();
            this.cadastro_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_dispesas_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_servicos_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_clientes_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_carro_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.cliente_name_label = new System.Windows.Forms.Label();
            this.cliente_logo_panel = new System.Windows.Forms.Panel();
            this.contato_corp_label = new System.Windows.Forms.Label();
            this.cliente_cel_label = new System.Windows.Forms.Label();
            this.contato_cel_label = new System.Windows.Forms.Label();
            this.contato_email_label = new System.Windows.Forms.Label();
            this.contato_panel = new System.Windows.Forms.Panel();
            this.main_help_button = new System.Windows.Forms.Button();
            this.main_contato_button = new System.Windows.Forms.Button();
            this.main_sobre_button = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.contato_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 489);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(805, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            this.status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // cadastro_menu
            // 
            this.cadastro_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastro_dispesas_menu,
            this.cadastro_servicos_menu,
            this.cadastro_clientes_menu,
            this.cadastro_carro_menu});
            this.cadastro_menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cadastro_menu.Name = "cadastro_menu";
            this.cadastro_menu.Size = new System.Drawing.Size(76, 23);
            this.cadastro_menu.Text = "Cadastro";
            // 
            // cadastro_dispesas_menu
            // 
            this.cadastro_dispesas_menu.Name = "cadastro_dispesas_menu";
            this.cadastro_dispesas_menu.Size = new System.Drawing.Size(158, 24);
            this.cadastro_dispesas_menu.Text = "Dispesas [F5]";
            this.cadastro_dispesas_menu.Click += new System.EventHandler(this.cadastro_dispesas_menu_Click);
            // 
            // cadastro_servicos_menu
            // 
            this.cadastro_servicos_menu.Name = "cadastro_servicos_menu";
            this.cadastro_servicos_menu.Size = new System.Drawing.Size(158, 24);
            this.cadastro_servicos_menu.Text = "Serviços [F6]";
            this.cadastro_servicos_menu.Click += new System.EventHandler(this.cadastro_servicos_menu_Click);
            // 
            // cadastro_clientes_menu
            // 
            this.cadastro_clientes_menu.Name = "cadastro_clientes_menu";
            this.cadastro_clientes_menu.Size = new System.Drawing.Size(158, 24);
            this.cadastro_clientes_menu.Text = "Clientes [F7]";
            this.cadastro_clientes_menu.Click += new System.EventHandler(this.cadastro_clientes_menu_Click);
            // 
            // cadastro_carro_menu
            // 
            this.cadastro_carro_menu.Name = "cadastro_carro_menu";
            this.cadastro_carro_menu.Size = new System.Drawing.Size(158, 24);
            this.cadastro_carro_menu.Text = "Carros [F8]";
            this.cadastro_carro_menu.Click += new System.EventHandler(this.cadastro_carro_menu_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DarkKhaki;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastro_menu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(805, 27);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            this.menu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // cliente_name_label
            // 
            this.cliente_name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cliente_name_label.AutoSize = true;
            this.cliente_name_label.BackColor = System.Drawing.Color.Transparent;
            this.cliente_name_label.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_name_label.Location = new System.Drawing.Point(161, 27);
            this.cliente_name_label.Name = "cliente_name_label";
            this.cliente_name_label.Size = new System.Drawing.Size(486, 90);
            this.cliente_name_label.TabIndex = 2;
            this.cliente_name_label.Text = "JC Mecânica";
            this.cliente_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cliente_logo_panel
            // 
            this.cliente_logo_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cliente_logo_panel.BackColor = System.Drawing.Color.Transparent;
            this.cliente_logo_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cliente_logo_panel.BackgroundImage")));
            this.cliente_logo_panel.Location = new System.Drawing.Point(176, 124);
            this.cliente_logo_panel.Name = "cliente_logo_panel";
            this.cliente_logo_panel.Size = new System.Drawing.Size(448, 260);
            this.cliente_logo_panel.TabIndex = 3;
            // 
            // contato_corp_label
            // 
            this.contato_corp_label.AutoSize = true;
            this.contato_corp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contato_corp_label.Location = new System.Drawing.Point(17, 0);
            this.contato_corp_label.Name = "contato_corp_label";
            this.contato_corp_label.Size = new System.Drawing.Size(76, 16);
            this.contato_corp_label.TabIndex = 4;
            this.contato_corp_label.Text = "DaviApps";
            // 
            // cliente_cel_label
            // 
            this.cliente_cel_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cliente_cel_label.AutoSize = true;
            this.cliente_cel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_cel_label.Location = new System.Drawing.Point(333, 409);
            this.cliente_cel_label.Name = "cliente_cel_label";
            this.cliente_cel_label.Size = new System.Drawing.Size(132, 20);
            this.cliente_cel_label.TabIndex = 5;
            this.cliente_cel_label.Text = "(32) 3426-0000";
            // 
            // contato_cel_label
            // 
            this.contato_cel_label.AutoSize = true;
            this.contato_cel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contato_cel_label.Location = new System.Drawing.Point(7, 16);
            this.contato_cel_label.Name = "contato_cel_label";
            this.contato_cel_label.Size = new System.Drawing.Size(99, 15);
            this.contato_cel_label.TabIndex = 6;
            this.contato_cel_label.Text = "(21) 98016-1945";
            // 
            // contato_email_label
            // 
            this.contato_email_label.AutoSize = true;
            this.contato_email_label.Location = new System.Drawing.Point(3, 31);
            this.contato_email_label.Name = "contato_email_label";
            this.contato_email_label.Size = new System.Drawing.Size(111, 13);
            this.contato_email_label.TabIndex = 7;
            this.contato_email_label.Text = "aazz6850@gmail.com";
            // 
            // contato_panel
            // 
            this.contato_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.contato_panel.Controls.Add(this.contato_corp_label);
            this.contato_panel.Controls.Add(this.contato_email_label);
            this.contato_panel.Controls.Add(this.contato_cel_label);
            this.contato_panel.Location = new System.Drawing.Point(689, 434);
            this.contato_panel.Name = "contato_panel";
            this.contato_panel.Size = new System.Drawing.Size(116, 48);
            this.contato_panel.TabIndex = 8;
            // 
            // main_help_button
            // 
            this.main_help_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.main_help_button.BackColor = System.Drawing.Color.DarkKhaki;
            this.main_help_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_help_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_help_button.Location = new System.Drawing.Point(742, 0);
            this.main_help_button.Name = "main_help_button";
            this.main_help_button.Size = new System.Drawing.Size(63, 27);
            this.main_help_button.TabIndex = 9;
            this.main_help_button.Text = "Ajuda";
            this.main_help_button.UseVisualStyleBackColor = false;
            this.main_help_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // main_contato_button
            // 
            this.main_contato_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.main_contato_button.BackColor = System.Drawing.SystemColors.Control;
            this.main_contato_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_contato_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_contato_button.Location = new System.Drawing.Point(709, 489);
            this.main_contato_button.Name = "main_contato_button";
            this.main_contato_button.Size = new System.Drawing.Size(73, 23);
            this.main_contato_button.TabIndex = 10;
            this.main_contato_button.Text = "Contato";
            this.main_contato_button.UseVisualStyleBackColor = false;
            this.main_contato_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // main_sobre_button
            // 
            this.main_sobre_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.main_sobre_button.BackColor = System.Drawing.SystemColors.Control;
            this.main_sobre_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_sobre_button.Location = new System.Drawing.Point(637, 489);
            this.main_sobre_button.Name = "main_sobre_button";
            this.main_sobre_button.Size = new System.Drawing.Size(75, 23);
            this.main_sobre_button.TabIndex = 11;
            this.main_sobre_button.Text = "Sobre";
            this.main_sobre_button.UseVisualStyleBackColor = false;
            this.main_sobre_button.Click += new System.EventHandler(this.main_sobre_button_Click);
            this.main_sobre_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(805, 511);
            this.Controls.Add(this.main_sobre_button);
            this.Controls.Add(this.main_contato_button);
            this.Controls.Add(this.main_help_button);
            this.Controls.Add(this.contato_panel);
            this.Controls.Add(this.cliente_cel_label);
            this.Controls.Add(this.cliente_logo_panel);
            this.Controls.Add(this.cliente_name_label);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(821, 549);
            this.Name = "MainForm";
            this.Text = "JC Mecânica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contato_panel.ResumeLayout(false);
            this.contato_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem cadastro_menu;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_dispesas_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_servicos_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_clientes_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_carro_menu;
        private System.Windows.Forms.Label cliente_name_label;
        private System.Windows.Forms.Panel cliente_logo_panel;
        private System.Windows.Forms.Label contato_corp_label;
        private System.Windows.Forms.Label cliente_cel_label;
        private System.Windows.Forms.Label contato_cel_label;
        private System.Windows.Forms.Label contato_email_label;
        private System.Windows.Forms.Panel contato_panel;
        private System.Windows.Forms.Button main_help_button;
        private System.Windows.Forms.Button main_contato_button;
        private System.Windows.Forms.Button main_sobre_button;

    }
}

