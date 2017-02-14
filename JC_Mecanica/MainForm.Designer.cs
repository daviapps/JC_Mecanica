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
            this.main_version_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.cadastro_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_orcamento_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_dispesas_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastro_clientes_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastro_separator_menu = new System.Windows.Forms.ToolStripSeparator();
            this.cadastro_fechar_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.dados_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.dados_orcamentos_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.dados_dispesa_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dados_servicos_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.dados_cliente_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.dados_carros_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ajuda_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cliente_name_label = new System.Windows.Forms.Label();
            this.contato_corp_label = new System.Windows.Forms.Label();
            this.cliente_cel_label = new System.Windows.Forms.Label();
            this.contato_cel_label = new System.Windows.Forms.Label();
            this.contato_email_label = new System.Windows.Forms.Label();
            this.contato_panel = new System.Windows.Forms.Panel();
            this.cliente_logo_panel = new System.Windows.Forms.Panel();
            this.main_sobre_button = new System.Windows.Forms.Button();
            this.status.SuspendLayout();
            this.menu.SuspendLayout();
            this.contato_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main_version_label});
            this.status.Location = new System.Drawing.Point(0, 489);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(805, 22);
            this.status.TabIndex = 0;
            this.status.Text = "statusStrip1";
            this.status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // main_version_label
            // 
            this.main_version_label.BackColor = System.Drawing.SystemColors.Control;
            this.main_version_label.Name = "main_version_label";
            this.main_version_label.Size = new System.Drawing.Size(49, 17);
            this.main_version_label.Text = "Verção: ";
            // 
            // cadastro_menu
            // 
            this.cadastro_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastro_orcamento_menu,
            this.cadastro_dispesas_menu,
            this.toolStripSeparator2,
            this.cadastro_clientes_menu,
            this.cadastro_separator_menu,
            this.cadastro_fechar_menu});
            this.cadastro_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_menu.ForeColor = System.Drawing.SystemColors.Window;
            this.cadastro_menu.Name = "cadastro_menu";
            this.cadastro_menu.Size = new System.Drawing.Size(74, 21);
            this.cadastro_menu.Text = "Cadastro";
            this.cadastro_menu.DropDownClosed += new System.EventHandler(this.menu_DropDownClosed);
            this.cadastro_menu.DropDownOpened += new System.EventHandler(this.menu_DropDownOpened);
            // 
            // cadastro_orcamento_menu
            // 
            this.cadastro_orcamento_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_orcamento_menu.Name = "cadastro_orcamento_menu";
            this.cadastro_orcamento_menu.Size = new System.Drawing.Size(166, 22);
            this.cadastro_orcamento_menu.Text = "Orçamento [F5]";
            this.cadastro_orcamento_menu.Click += new System.EventHandler(this.cadastro_orcamento_menu_Click);
            // 
            // cadastro_dispesas_menu
            // 
            this.cadastro_dispesas_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_dispesas_menu.Name = "cadastro_dispesas_menu";
            this.cadastro_dispesas_menu.Size = new System.Drawing.Size(166, 22);
            this.cadastro_dispesas_menu.Text = "Dispesa [F6]";
            this.cadastro_dispesas_menu.Click += new System.EventHandler(this.cadastro_dispesas_menu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // cadastro_clientes_menu
            // 
            this.cadastro_clientes_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_clientes_menu.Name = "cadastro_clientes_menu";
            this.cadastro_clientes_menu.Size = new System.Drawing.Size(166, 22);
            this.cadastro_clientes_menu.Text = "Cliente [F7]";
            this.cadastro_clientes_menu.Click += new System.EventHandler(this.cadastro_clientes_menu_Click);
            // 
            // cadastro_separator_menu
            // 
            this.cadastro_separator_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cadastro_separator_menu.Name = "cadastro_separator_menu";
            this.cadastro_separator_menu.Size = new System.Drawing.Size(163, 6);
            // 
            // cadastro_fechar_menu
            // 
            this.cadastro_fechar_menu.BackColor = System.Drawing.Color.Salmon;
            this.cadastro_fechar_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_fechar_menu.ForeColor = System.Drawing.SystemColors.Window;
            this.cadastro_fechar_menu.Name = "cadastro_fechar_menu";
            this.cadastro_fechar_menu.Size = new System.Drawing.Size(166, 22);
            this.cadastro_fechar_menu.Text = "Fechar";
            this.cadastro_fechar_menu.Click += new System.EventHandler(this.cadastro_fechar_menu_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(55)))));
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastro_menu,
            this.dados_menu,
            this.ajuda_menu});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(805, 25);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            this.menu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // dados_menu
            // 
            this.dados_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dados_orcamentos_menu,
            this.dados_dispesa_menu,
            this.toolStripSeparator1,
            this.dados_servicos_menu,
            this.dados_cliente_menu,
            this.dados_carros_menu});
            this.dados_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dados_menu.ForeColor = System.Drawing.SystemColors.Window;
            this.dados_menu.Name = "dados_menu";
            this.dados_menu.Size = new System.Drawing.Size(59, 21);
            this.dados_menu.Text = "Dados";
            this.dados_menu.DropDownClosed += new System.EventHandler(this.menu_DropDownClosed);
            this.dados_menu.DropDownOpened += new System.EventHandler(this.menu_DropDownOpened);
            // 
            // dados_orcamentos_menu
            // 
            this.dados_orcamentos_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dados_orcamentos_menu.Name = "dados_orcamentos_menu";
            this.dados_orcamentos_menu.Size = new System.Drawing.Size(172, 22);
            this.dados_orcamentos_menu.Text = "Orçamentos [F8]";
            this.dados_orcamentos_menu.Click += new System.EventHandler(this.dados_orcamentos_menu_Click);
            // 
            // dados_dispesa_menu
            // 
            this.dados_dispesa_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dados_dispesa_menu.Name = "dados_dispesa_menu";
            this.dados_dispesa_menu.Size = new System.Drawing.Size(172, 22);
            this.dados_dispesa_menu.Text = "Dispesas [F9]";
            this.dados_dispesa_menu.Click += new System.EventHandler(this.dados_dispesa_menu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // dados_servicos_menu
            // 
            this.dados_servicos_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dados_servicos_menu.Name = "dados_servicos_menu";
            this.dados_servicos_menu.Size = new System.Drawing.Size(172, 22);
            this.dados_servicos_menu.Text = "Serviços [F10]";
            this.dados_servicos_menu.Click += new System.EventHandler(this.dados_servicos_menu_Click);
            // 
            // dados_cliente_menu
            // 
            this.dados_cliente_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dados_cliente_menu.Name = "dados_cliente_menu";
            this.dados_cliente_menu.Size = new System.Drawing.Size(172, 22);
            this.dados_cliente_menu.Text = "Clientes [F11]";
            this.dados_cliente_menu.Click += new System.EventHandler(this.dados_cliente_menu_Click);
            // 
            // dados_carros_menu
            // 
            this.dados_carros_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dados_carros_menu.Name = "dados_carros_menu";
            this.dados_carros_menu.Size = new System.Drawing.Size(172, 22);
            this.dados_carros_menu.Text = "Carros [F12]";
            this.dados_carros_menu.Click += new System.EventHandler(this.dados_carros_menu_Click);
            // 
            // ajuda_menu
            // 
            this.ajuda_menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajuda_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajuda_menu.ForeColor = System.Drawing.SystemColors.Window;
            this.ajuda_menu.Name = "ajuda_menu";
            this.ajuda_menu.Size = new System.Drawing.Size(56, 21);
            this.ajuda_menu.Text = "Ajuda";
            this.ajuda_menu.Click += new System.EventHandler(this.main_help_button_Click);
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
            this.cliente_cel_label.Text = "(32) 9942-8373";
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
            // main_sobre_button
            // 
            this.main_sobre_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.main_sobre_button.BackColor = System.Drawing.SystemColors.Control;
            this.main_sobre_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.main_sobre_button.Location = new System.Drawing.Point(709, 489);
            this.main_sobre_button.Name = "main_sobre_button";
            this.main_sobre_button.Size = new System.Drawing.Size(75, 22);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(210)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(805, 511);
            this.Controls.Add(this.main_sobre_button);
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
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem cadastro_dispesas_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_clientes_menu;
        private System.Windows.Forms.Label cliente_name_label;
        private System.Windows.Forms.Panel cliente_logo_panel;
        private System.Windows.Forms.Label contato_corp_label;
        private System.Windows.Forms.Label cliente_cel_label;
        private System.Windows.Forms.Label contato_cel_label;
        private System.Windows.Forms.Label contato_email_label;
        private System.Windows.Forms.Panel contato_panel;
        private System.Windows.Forms.ToolStripSeparator cadastro_separator_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_fechar_menu;
        private System.Windows.Forms.ToolStripMenuItem dados_menu;
        private System.Windows.Forms.ToolStripMenuItem dados_dispesa_menu;
        private System.Windows.Forms.ToolStripMenuItem dados_servicos_menu;
        private System.Windows.Forms.ToolStripMenuItem dados_cliente_menu;
        private System.Windows.Forms.ToolStripMenuItem cadastro_orcamento_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem dados_orcamentos_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dados_carros_menu;
        private System.Windows.Forms.ToolStripStatusLabel main_version_label;
        private System.Windows.Forms.ToolStripMenuItem ajuda_menu;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Button main_sobre_button;

    }
}

