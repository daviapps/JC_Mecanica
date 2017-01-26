namespace JC_Mecanica {
    partial class Cadastro_Servicos {
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
            this.servico_label = new System.Windows.Forms.Label();
            this.codigo_label = new System.Windows.Forms.Label();
            this.detalhe_label = new System.Windows.Forms.Label();
            this.servico_edit = new System.Windows.Forms.TextBox();
            this.detalhe_edit = new System.Windows.Forms.TextBox();
            this.salvar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.codigo_edit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // servico_label
            // 
            this.servico_label.AutoSize = true;
            this.servico_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servico_label.Location = new System.Drawing.Point(12, 9);
            this.servico_label.Name = "servico_label";
            this.servico_label.Size = new System.Drawing.Size(65, 16);
            this.servico_label.TabIndex = 0;
            this.servico_label.Text = "Serviço:";
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_label.Location = new System.Drawing.Point(380, 9);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(62, 16);
            this.codigo_label.TabIndex = 1;
            this.codigo_label.Text = "Código:";
            // 
            // detalhe_label
            // 
            this.detalhe_label.AutoSize = true;
            this.detalhe_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalhe_label.Location = new System.Drawing.Point(12, 57);
            this.detalhe_label.Name = "detalhe_label";
            this.detalhe_label.Size = new System.Drawing.Size(74, 16);
            this.detalhe_label.TabIndex = 2;
            this.detalhe_label.Text = "Detalhes:";
            // 
            // servico_edit
            // 
            this.servico_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servico_edit.Location = new System.Drawing.Point(24, 28);
            this.servico_edit.Name = "servico_edit";
            this.servico_edit.Size = new System.Drawing.Size(352, 26);
            this.servico_edit.TabIndex = 3;
            // 
            // detalhe_edit
            // 
            this.detalhe_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalhe_edit.Location = new System.Drawing.Point(24, 76);
            this.detalhe_edit.Multiline = true;
            this.detalhe_edit.Name = "detalhe_edit";
            this.detalhe_edit.Size = new System.Drawing.Size(465, 106);
            this.detalhe_edit.TabIndex = 5;
            // 
            // salvar_button
            // 
            this.salvar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar_button.Location = new System.Drawing.Point(414, 188);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(75, 29);
            this.salvar_button.TabIndex = 7;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.salvar_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_button.Location = new System.Drawing.Point(318, 188);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(90, 29);
            this.cancelar_button.TabIndex = 8;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // codigo_edit
            // 
            this.codigo_edit.Enabled = false;
            this.codigo_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_edit.Location = new System.Drawing.Point(389, 28);
            this.codigo_edit.Name = "codigo_edit";
            this.codigo_edit.Size = new System.Drawing.Size(100, 26);
            this.codigo_edit.TabIndex = 9;
            this.codigo_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cadastro_Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 225);
            this.Controls.Add(this.codigo_edit);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.salvar_button);
            this.Controls.Add(this.detalhe_edit);
            this.Controls.Add(this.servico_edit);
            this.Controls.Add(this.detalhe_label);
            this.Controls.Add(this.codigo_label);
            this.Controls.Add(this.servico_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Servicos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de servicos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Servicos_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_Servicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label servico_label;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.Label detalhe_label;
        private System.Windows.Forms.TextBox servico_edit;
        private System.Windows.Forms.TextBox detalhe_edit;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.TextBox codigo_edit;
    }
}