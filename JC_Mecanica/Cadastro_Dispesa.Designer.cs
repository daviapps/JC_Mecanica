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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Dispesa));
            this.produto_label = new System.Windows.Forms.Label();
            this.valor_label = new System.Windows.Forms.Label();
            this.produto_edit = new System.Windows.Forms.TextBox();
            this.moeda_label = new System.Windows.Forms.Label();
            this.valor_edit = new System.Windows.Forms.TextBox();
            this.salvar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.data_timePicker = new System.Windows.Forms.DateTimePicker();
            this.data_label = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.count_edit = new System.Windows.Forms.NumericUpDown();
            this.apagar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.count_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // produto_label
            // 
            this.produto_label.AutoSize = true;
            this.produto_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto_label.Location = new System.Drawing.Point(12, 9);
            this.produto_label.Name = "produto_label";
            this.produto_label.Size = new System.Drawing.Size(61, 15);
            this.produto_label.TabIndex = 0;
            this.produto_label.Text = "Produto:";
            // 
            // valor_label
            // 
            this.valor_label.AutoSize = true;
            this.valor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_label.Location = new System.Drawing.Point(310, 9);
            this.valor_label.Name = "valor_label";
            this.valor_label.Size = new System.Drawing.Size(44, 15);
            this.valor_label.TabIndex = 1;
            this.valor_label.Text = "Valor:";
            // 
            // produto_edit
            // 
            this.produto_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto_edit.Location = new System.Drawing.Point(24, 27);
            this.produto_edit.Name = "produto_edit";
            this.produto_edit.Size = new System.Drawing.Size(255, 26);
            this.produto_edit.TabIndex = 1;
            this.produto_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valor_edit_KeyDown);
            // 
            // moeda_label
            // 
            this.moeda_label.AutoSize = true;
            this.moeda_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moeda_label.Location = new System.Drawing.Point(285, 30);
            this.moeda_label.Name = "moeda_label";
            this.moeda_label.Size = new System.Drawing.Size(32, 20);
            this.moeda_label.TabIndex = 4;
            this.moeda_label.Text = "R$";
            // 
            // valor_edit
            // 
            this.valor_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_edit.Location = new System.Drawing.Point(323, 27);
            this.valor_edit.Name = "valor_edit";
            this.valor_edit.Size = new System.Drawing.Size(100, 26);
            this.valor_edit.TabIndex = 2;
            this.valor_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valor_edit_KeyDown);
            this.valor_edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_edit_KeyPress);
            // 
            // salvar_button
            // 
            this.salvar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar_button.Location = new System.Drawing.Point(351, 106);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(72, 29);
            this.salvar_button.TabIndex = 5;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.salvar_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_button.Location = new System.Drawing.Point(262, 106);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(83, 29);
            this.cancelar_button.TabIndex = 7;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // data_timePicker
            // 
            this.data_timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_timePicker.Location = new System.Drawing.Point(119, 76);
            this.data_timePicker.Name = "data_timePicker";
            this.data_timePicker.Size = new System.Drawing.Size(304, 26);
            this.data_timePicker.TabIndex = 4;
            this.data_timePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valor_edit_KeyDown);
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_label.Location = new System.Drawing.Point(110, 56);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(41, 15);
            this.data_label.TabIndex = 9;
            this.data_label.Text = "Data:";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_label.Location = new System.Drawing.Point(12, 56);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(85, 15);
            this.count_label.TabIndex = 10;
            this.count_label.Text = "Quantidade:";
            // 
            // count_edit
            // 
            this.count_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_edit.Location = new System.Drawing.Point(24, 76);
            this.count_edit.Name = "count_edit";
            this.count_edit.Size = new System.Drawing.Size(89, 26);
            this.count_edit.TabIndex = 3;
            this.count_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.count_edit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valor_edit_KeyDown);
            // 
            // apagar_button
            // 
            this.apagar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apagar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar_button.Location = new System.Drawing.Point(182, 106);
            this.apagar_button.Name = "apagar_button";
            this.apagar_button.Size = new System.Drawing.Size(74, 29);
            this.apagar_button.TabIndex = 6;
            this.apagar_button.Text = "Apagar";
            this.apagar_button.UseVisualStyleBackColor = true;
            this.apagar_button.Click += new System.EventHandler(this.apagar_button_Click);
            // 
            // Cadastro_Dispesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 147);
            this.Controls.Add(this.apagar_button);
            this.Controls.Add(this.count_edit);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.data_label);
            this.Controls.Add(this.data_timePicker);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.salvar_button);
            this.Controls.Add(this.valor_edit);
            this.Controls.Add(this.moeda_label);
            this.Controls.Add(this.produto_edit);
            this.Controls.Add(this.valor_label);
            this.Controls.Add(this.produto_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Dispesa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova dispesa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nova_Dispesa_FormClosing);
            this.Load += new System.EventHandler(this.Nova_Dispesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.count_edit)).EndInit();
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
        private System.Windows.Forms.DateTimePicker data_timePicker;
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.NumericUpDown count_edit;
        private System.Windows.Forms.Button apagar_button;
    }
}