namespace JC_Mecanica {
    partial class Cadastro_Dispesa {
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
            this.produto_label = new System.Windows.Forms.Label();
            this.valor_label = new System.Windows.Forms.Label();
            this.produto_edit = new System.Windows.Forms.TextBox();
            this.moeda_label = new System.Windows.Forms.Label();
            this.valor_edit = new System.Windows.Forms.TextBox();
            this.salvar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produto_label
            // 
            this.produto_label.AutoSize = true;
            this.produto_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto_label.Location = new System.Drawing.Point(12, 9);
            this.produto_label.Name = "produto_label";
            this.produto_label.Size = new System.Drawing.Size(73, 18);
            this.produto_label.TabIndex = 0;
            this.produto_label.Text = "Produto:";
            // 
            // valor_label
            // 
            this.valor_label.AutoSize = true;
            this.valor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_label.Location = new System.Drawing.Point(300, 9);
            this.valor_label.Name = "valor_label";
            this.valor_label.Size = new System.Drawing.Size(52, 18);
            this.valor_label.TabIndex = 1;
            this.valor_label.Text = "Valor:";
            // 
            // produto_edit
            // 
            this.produto_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto_edit.Location = new System.Drawing.Point(25, 30);
            this.produto_edit.Name = "produto_edit";
            this.produto_edit.Size = new System.Drawing.Size(248, 29);
            this.produto_edit.TabIndex = 2;
            // 
            // moeda_label
            // 
            this.moeda_label.AutoSize = true;
            this.moeda_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moeda_label.Location = new System.Drawing.Point(290, 30);
            this.moeda_label.Name = "moeda_label";
            this.moeda_label.Size = new System.Drawing.Size(33, 24);
            this.moeda_label.TabIndex = 4;
            this.moeda_label.Text = "R$";
            // 
            // valor_edit
            // 
            this.valor_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_edit.Location = new System.Drawing.Point(321, 30);
            this.valor_edit.Name = "valor_edit";
            this.valor_edit.Size = new System.Drawing.Size(100, 29);
            this.valor_edit.TabIndex = 5;
            // 
            // salvar_button
            // 
            this.salvar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar_button.Location = new System.Drawing.Point(339, 76);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(85, 35);
            this.salvar_button.TabIndex = 6;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.salvar_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_button.Location = new System.Drawing.Point(226, 76);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(107, 35);
            this.cancelar_button.TabIndex = 7;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // Nova_Dispesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 117);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.salvar_button);
            this.Controls.Add(this.valor_edit);
            this.Controls.Add(this.moeda_label);
            this.Controls.Add(this.produto_edit);
            this.Controls.Add(this.valor_label);
            this.Controls.Add(this.produto_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nova_Dispesa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova dispesa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nova_Dispesa_FormClosing);
            this.Load += new System.EventHandler(this.Nova_Dispesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label produto_label;
        private System.Windows.Forms.Label valor_label;
        private System.Windows.Forms.TextBox produto_edit;
        private System.Windows.Forms.Label moeda_label;
        private System.Windows.Forms.TextBox valor_edit;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.Button cancelar_button;
    }
}