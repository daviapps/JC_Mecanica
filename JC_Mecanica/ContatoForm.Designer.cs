namespace JC_Mecanica {
    partial class ContatoForm {
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
            this.daviapps_label = new System.Windows.Forms.Label();
            this.contactUs_panel = new System.Windows.Forms.Panel();
            this.mensagem_edit = new System.Windows.Forms.TextBox();
            this.email_edit = new System.Windows.Forms.TextBox();
            this.nome_edit = new System.Windows.Forms.TextBox();
            this.mensagem_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.voltar_button = new System.Windows.Forms.Button();
            this.enviar_button = new System.Windows.Forms.Button();
            this.contactUs_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // daviapps_label
            // 
            this.daviapps_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.daviapps_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daviapps_label.Location = new System.Drawing.Point(12, 9);
            this.daviapps_label.Name = "daviapps_label";
            this.daviapps_label.Size = new System.Drawing.Size(343, 39);
            this.daviapps_label.TabIndex = 0;
            this.daviapps_label.Text = "Davi Apps";
            this.daviapps_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactUs_panel
            // 
            this.contactUs_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactUs_panel.Controls.Add(this.enviar_button);
            this.contactUs_panel.Controls.Add(this.voltar_button);
            this.contactUs_panel.Controls.Add(this.mensagem_edit);
            this.contactUs_panel.Controls.Add(this.email_edit);
            this.contactUs_panel.Controls.Add(this.nome_edit);
            this.contactUs_panel.Controls.Add(this.mensagem_label);
            this.contactUs_panel.Controls.Add(this.email_label);
            this.contactUs_panel.Controls.Add(this.nome_label);
            this.contactUs_panel.Location = new System.Drawing.Point(12, 51);
            this.contactUs_panel.Name = "contactUs_panel";
            this.contactUs_panel.Size = new System.Drawing.Size(343, 211);
            this.contactUs_panel.TabIndex = 1;
            // 
            // mensagem_edit
            // 
            this.mensagem_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mensagem_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem_edit.Location = new System.Drawing.Point(9, 112);
            this.mensagem_edit.Multiline = true;
            this.mensagem_edit.Name = "mensagem_edit";
            this.mensagem_edit.Size = new System.Drawing.Size(326, 53);
            this.mensagem_edit.TabIndex = 12;
            // 
            // email_edit
            // 
            this.email_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_edit.Location = new System.Drawing.Point(9, 65);
            this.email_edit.Name = "email_edit";
            this.email_edit.Size = new System.Drawing.Size(326, 26);
            this.email_edit.TabIndex = 11;
            // 
            // nome_edit
            // 
            this.nome_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nome_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_edit.Location = new System.Drawing.Point(9, 18);
            this.nome_edit.Name = "nome_edit";
            this.nome_edit.Size = new System.Drawing.Size(326, 26);
            this.nome_edit.TabIndex = 10;
            // 
            // mensagem_label
            // 
            this.mensagem_label.AutoSize = true;
            this.mensagem_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem_label.Location = new System.Drawing.Point(6, 94);
            this.mensagem_label.Name = "mensagem_label";
            this.mensagem_label.Size = new System.Drawing.Size(82, 15);
            this.mensagem_label.TabIndex = 9;
            this.mensagem_label.Text = "Mensagem:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(6, 47);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(53, 15);
            this.email_label.TabIndex = 8;
            this.email_label.Text = "E-mail:";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_label.Location = new System.Drawing.Point(4, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(49, 15);
            this.nome_label.TabIndex = 7;
            this.nome_label.Text = "Nome:";
            // 
            // voltar_button
            // 
            this.voltar_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voltar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar_button.Location = new System.Drawing.Point(179, 171);
            this.voltar_button.Name = "voltar_button";
            this.voltar_button.Size = new System.Drawing.Size(75, 29);
            this.voltar_button.TabIndex = 13;
            this.voltar_button.Text = "Voltar";
            this.voltar_button.UseVisualStyleBackColor = true;
            this.voltar_button.Click += new System.EventHandler(this.voltar_button_Click);
            // 
            // enviar_button
            // 
            this.enviar_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enviar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enviar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar_button.Location = new System.Drawing.Point(260, 171);
            this.enviar_button.Name = "enviar_button";
            this.enviar_button.Size = new System.Drawing.Size(75, 29);
            this.enviar_button.TabIndex = 14;
            this.enviar_button.Text = "Enviar";
            this.enviar_button.UseVisualStyleBackColor = true;
            // 
            // ContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 274);
            this.Controls.Add(this.contactUs_panel);
            this.Controls.Add(this.daviapps_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContatoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contato";
            this.Load += new System.EventHandler(this.Contato_Load);
            this.contactUs_panel.ResumeLayout(false);
            this.contactUs_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label daviapps_label;
        private System.Windows.Forms.Panel contactUs_panel;
        private System.Windows.Forms.Button enviar_button;
        private System.Windows.Forms.Button voltar_button;
        private System.Windows.Forms.TextBox mensagem_edit;
        private System.Windows.Forms.TextBox email_edit;
        private System.Windows.Forms.TextBox nome_edit;
        private System.Windows.Forms.Label mensagem_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label nome_label;



    }
}