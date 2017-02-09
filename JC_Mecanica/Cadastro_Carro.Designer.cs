namespace JC_Mecanica {
    partial class Cadastro_Carro {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Carro));
            this.placa_label = new System.Windows.Forms.Label();
            this.modelo_label = new System.Windows.Forms.Label();
            this.chassi_label = new System.Windows.Forms.Label();
            this.ano_label = new System.Windows.Forms.Label();
            this.placa_edit = new System.Windows.Forms.TextBox();
            this.modelo_edit = new System.Windows.Forms.TextBox();
            this.chassi_edit = new System.Windows.Forms.TextBox();
            this.salvar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.ano_edit = new System.Windows.Forms.NumericUpDown();
            this.km_edit = new System.Windows.Forms.TextBox();
            this.km_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ano_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // placa_label
            // 
            this.placa_label.AutoSize = true;
            this.placa_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa_label.Location = new System.Drawing.Point(12, 18);
            this.placa_label.Name = "placa_label";
            this.placa_label.Size = new System.Drawing.Size(53, 15);
            this.placa_label.TabIndex = 0;
            this.placa_label.Text = "Placa*:";
            // 
            // modelo_label
            // 
            this.modelo_label.AutoSize = true;
            this.modelo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_label.Location = new System.Drawing.Point(12, 63);
            this.modelo_label.Name = "modelo_label";
            this.modelo_label.Size = new System.Drawing.Size(59, 15);
            this.modelo_label.TabIndex = 1;
            this.modelo_label.Text = "Modelo:";
            // 
            // chassi_label
            // 
            this.chassi_label.AutoSize = true;
            this.chassi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassi_label.Location = new System.Drawing.Point(181, 18);
            this.chassi_label.Name = "chassi_label";
            this.chassi_label.Size = new System.Drawing.Size(54, 15);
            this.chassi_label.TabIndex = 2;
            this.chassi_label.Text = "Chassi:";
            // 
            // ano_label
            // 
            this.ano_label.AutoSize = true;
            this.ano_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano_label.Location = new System.Drawing.Point(113, 18);
            this.ano_label.Name = "ano_label";
            this.ano_label.Size = new System.Drawing.Size(35, 15);
            this.ano_label.TabIndex = 3;
            this.ano_label.Text = "Ano:";
            // 
            // placa_edit
            // 
            this.placa_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa_edit.Location = new System.Drawing.Point(29, 36);
            this.placa_edit.MaxLength = 7;
            this.placa_edit.Name = "placa_edit";
            this.placa_edit.Size = new System.Drawing.Size(83, 24);
            this.placa_edit.TabIndex = 4;
            // 
            // modelo_edit
            // 
            this.modelo_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_edit.Location = new System.Drawing.Point(29, 81);
            this.modelo_edit.Name = "modelo_edit";
            this.modelo_edit.Size = new System.Drawing.Size(217, 24);
            this.modelo_edit.TabIndex = 6;
            // 
            // chassi_edit
            // 
            this.chassi_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassi_edit.Location = new System.Drawing.Point(193, 36);
            this.chassi_edit.MaxLength = 17;
            this.chassi_edit.Name = "chassi_edit";
            this.chassi_edit.Size = new System.Drawing.Size(159, 24);
            this.chassi_edit.TabIndex = 7;
            // 
            // salvar_button
            // 
            this.salvar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar_button.Location = new System.Drawing.Point(277, 111);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(75, 29);
            this.salvar_button.TabIndex = 8;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.salvar_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_button.Location = new System.Drawing.Point(183, 111);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(88, 29);
            this.cancelar_button.TabIndex = 9;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // ano_edit
            // 
            this.ano_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano_edit.Location = new System.Drawing.Point(118, 36);
            this.ano_edit.Name = "ano_edit";
            this.ano_edit.Size = new System.Drawing.Size(69, 24);
            this.ano_edit.TabIndex = 10;
            // 
            // km_edit
            // 
            this.km_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.km_edit.Location = new System.Drawing.Point(252, 81);
            this.km_edit.Name = "km_edit";
            this.km_edit.Size = new System.Drawing.Size(100, 24);
            this.km_edit.TabIndex = 11;
            this.km_edit.Text = "0";
            this.km_edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.km_edit_KeyPress);
            // 
            // km_label
            // 
            this.km_label.AutoSize = true;
            this.km_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.km_label.Location = new System.Drawing.Point(242, 63);
            this.km_label.Name = "km_label";
            this.km_label.Size = new System.Drawing.Size(32, 15);
            this.km_label.TabIndex = 12;
            this.km_label.Text = "KM:";
            // 
            // Cadastro_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 150);
            this.Controls.Add(this.km_label);
            this.Controls.Add(this.km_edit);
            this.Controls.Add(this.ano_edit);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.salvar_button);
            this.Controls.Add(this.chassi_edit);
            this.Controls.Add(this.modelo_edit);
            this.Controls.Add(this.placa_edit);
            this.Controls.Add(this.ano_label);
            this.Controls.Add(this.chassi_label);
            this.Controls.Add(this.modelo_label);
            this.Controls.Add(this.placa_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Carro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de carro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Carro_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_Carro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ano_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placa_label;
        private System.Windows.Forms.Label modelo_label;
        private System.Windows.Forms.Label chassi_label;
        private System.Windows.Forms.Label ano_label;
        private System.Windows.Forms.TextBox placa_edit;
        private System.Windows.Forms.TextBox modelo_edit;
        private System.Windows.Forms.TextBox chassi_edit;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.NumericUpDown ano_edit;
        private System.Windows.Forms.TextBox km_edit;
        private System.Windows.Forms.Label km_label;
    }
}