namespace JC_Mecanica {
    partial class Cadastro_Orcamento {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Orcamento));
            this.servico_label = new System.Windows.Forms.Label();
            this.cliente_label = new System.Windows.Forms.Label();
            this.carro_label = new System.Windows.Forms.Label();
            this.detalhes_label = new System.Windows.Forms.Label();
            this.data_label = new System.Windows.Forms.Label();
            this.valor_label = new System.Windows.Forms.Label();
            this.valor_edit = new System.Windows.Forms.TextBox();
            this.servico_edit = new System.Windows.Forms.TextBox();
            this.carro_edit = new System.Windows.Forms.TextBox();
            this.detalhes_edit = new System.Windows.Forms.TextBox();
            this.cliente_edit = new System.Windows.Forms.TextBox();
            this.data_timePicker = new System.Windows.Forms.DateTimePicker();
            this.servico_escolher_button = new System.Windows.Forms.Button();
            this.cliente_escolher_button = new System.Windows.Forms.Button();
            this.carro_escolher_button = new System.Windows.Forms.Button();
            this.salvar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.apagar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servico_label
            // 
            this.servico_label.AutoSize = true;
            this.servico_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servico_label.Location = new System.Drawing.Point(12, 9);
            this.servico_label.Name = "servico_label";
            this.servico_label.Size = new System.Drawing.Size(58, 15);
            this.servico_label.TabIndex = 0;
            this.servico_label.Text = "Serviço:";
            // 
            // cliente_label
            // 
            this.cliente_label.AutoSize = true;
            this.cliente_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_label.Location = new System.Drawing.Point(12, 56);
            this.cliente_label.Name = "cliente_label";
            this.cliente_label.Size = new System.Drawing.Size(56, 15);
            this.cliente_label.TabIndex = 1;
            this.cliente_label.Text = "Cliente:";
            // 
            // carro_label
            // 
            this.carro_label.AutoSize = true;
            this.carro_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carro_label.Location = new System.Drawing.Point(12, 103);
            this.carro_label.Name = "carro_label";
            this.carro_label.Size = new System.Drawing.Size(46, 15);
            this.carro_label.TabIndex = 2;
            this.carro_label.Text = "Carro:";
            // 
            // detalhes_label
            // 
            this.detalhes_label.AutoSize = true;
            this.detalhes_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalhes_label.Location = new System.Drawing.Point(248, 57);
            this.detalhes_label.Name = "detalhes_label";
            this.detalhes_label.Size = new System.Drawing.Size(68, 15);
            this.detalhes_label.TabIndex = 3;
            this.detalhes_label.Text = "Detalhes:";
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_label.Location = new System.Drawing.Point(248, 9);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(41, 15);
            this.data_label.TabIndex = 4;
            this.data_label.Text = "Data:";
            // 
            // valor_label
            // 
            this.valor_label.AutoSize = true;
            this.valor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_label.Location = new System.Drawing.Point(142, 103);
            this.valor_label.Name = "valor_label";
            this.valor_label.Size = new System.Drawing.Size(76, 15);
            this.valor_label.TabIndex = 5;
            this.valor_label.Text = "Valor (R$):";
            // 
            // valor_edit
            // 
            this.valor_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_edit.Location = new System.Drawing.Point(153, 121);
            this.valor_edit.Name = "valor_edit";
            this.valor_edit.Size = new System.Drawing.Size(89, 26);
            this.valor_edit.TabIndex = 6;
            this.valor_edit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_edit_KeyPress);
            // 
            // servico_edit
            // 
            this.servico_edit.Enabled = false;
            this.servico_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servico_edit.Location = new System.Drawing.Point(26, 27);
            this.servico_edit.Name = "servico_edit";
            this.servico_edit.Size = new System.Drawing.Size(184, 26);
            this.servico_edit.TabIndex = 7;
            this.servico_edit.Text = "Selecione o serviço >>";
            this.servico_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // carro_edit
            // 
            this.carro_edit.Enabled = false;
            this.carro_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carro_edit.Location = new System.Drawing.Point(26, 121);
            this.carro_edit.Name = "carro_edit";
            this.carro_edit.Size = new System.Drawing.Size(86, 26);
            this.carro_edit.TabIndex = 8;
            this.carro_edit.Text = "Selec. >>";
            this.carro_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detalhes_edit
            // 
            this.detalhes_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalhes_edit.Location = new System.Drawing.Point(256, 75);
            this.detalhes_edit.Multiline = true;
            this.detalhes_edit.Name = "detalhes_edit";
            this.detalhes_edit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detalhes_edit.Size = new System.Drawing.Size(324, 72);
            this.detalhes_edit.TabIndex = 9;
            // 
            // cliente_edit
            // 
            this.cliente_edit.Enabled = false;
            this.cliente_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_edit.Location = new System.Drawing.Point(26, 74);
            this.cliente_edit.Name = "cliente_edit";
            this.cliente_edit.Size = new System.Drawing.Size(184, 26);
            this.cliente_edit.TabIndex = 10;
            this.cliente_edit.Text = "Selecione o cliente >>";
            this.cliente_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data_timePicker
            // 
            this.data_timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_timePicker.Location = new System.Drawing.Point(256, 28);
            this.data_timePicker.Name = "data_timePicker";
            this.data_timePicker.Size = new System.Drawing.Size(324, 26);
            this.data_timePicker.TabIndex = 11;
            // 
            // servico_escolher_button
            // 
            this.servico_escolher_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.servico_escolher_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servico_escolher_button.Location = new System.Drawing.Point(216, 27);
            this.servico_escolher_button.Name = "servico_escolher_button";
            this.servico_escolher_button.Size = new System.Drawing.Size(26, 26);
            this.servico_escolher_button.TabIndex = 12;
            this.servico_escolher_button.Text = "...";
            this.servico_escolher_button.UseVisualStyleBackColor = true;
            this.servico_escolher_button.Click += new System.EventHandler(this.servico_escolher_button_Click);
            // 
            // cliente_escolher_button
            // 
            this.cliente_escolher_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cliente_escolher_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_escolher_button.Location = new System.Drawing.Point(216, 74);
            this.cliente_escolher_button.Name = "cliente_escolher_button";
            this.cliente_escolher_button.Size = new System.Drawing.Size(26, 26);
            this.cliente_escolher_button.TabIndex = 13;
            this.cliente_escolher_button.Text = "...";
            this.cliente_escolher_button.UseVisualStyleBackColor = true;
            this.cliente_escolher_button.Click += new System.EventHandler(this.cliente_escolher_button_Click);
            // 
            // carro_escolher_button
            // 
            this.carro_escolher_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.carro_escolher_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carro_escolher_button.Location = new System.Drawing.Point(118, 122);
            this.carro_escolher_button.Name = "carro_escolher_button";
            this.carro_escolher_button.Size = new System.Drawing.Size(29, 26);
            this.carro_escolher_button.TabIndex = 14;
            this.carro_escolher_button.Text = "...";
            this.carro_escolher_button.UseVisualStyleBackColor = true;
            this.carro_escolher_button.Click += new System.EventHandler(this.carro_escolher_button_Click);
            // 
            // salvar_button
            // 
            this.salvar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar_button.Location = new System.Drawing.Point(505, 155);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(75, 29);
            this.salvar_button.TabIndex = 15;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.salvar_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_button.Location = new System.Drawing.Point(409, 155);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(90, 29);
            this.cancelar_button.TabIndex = 16;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // id_label
            // 
            this.id_label.BackColor = System.Drawing.SystemColors.Control;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.DimGray;
            this.id_label.Location = new System.Drawing.Point(12, 155);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(309, 29);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "Código do orçamento: 000001";
            this.id_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apagar_button
            // 
            this.apagar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apagar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar_button.Location = new System.Drawing.Point(327, 155);
            this.apagar_button.Name = "apagar_button";
            this.apagar_button.Size = new System.Drawing.Size(76, 29);
            this.apagar_button.TabIndex = 17;
            this.apagar_button.Text = "Apagar";
            this.apagar_button.UseVisualStyleBackColor = true;
            this.apagar_button.Visible = false;
            // 
            // Cadastro_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 194);
            this.Controls.Add(this.apagar_button);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.salvar_button);
            this.Controls.Add(this.carro_escolher_button);
            this.Controls.Add(this.cliente_escolher_button);
            this.Controls.Add(this.servico_escolher_button);
            this.Controls.Add(this.data_timePicker);
            this.Controls.Add(this.cliente_edit);
            this.Controls.Add(this.detalhes_edit);
            this.Controls.Add(this.carro_edit);
            this.Controls.Add(this.servico_edit);
            this.Controls.Add(this.valor_edit);
            this.Controls.Add(this.valor_label);
            this.Controls.Add(this.data_label);
            this.Controls.Add(this.detalhes_label);
            this.Controls.Add(this.carro_label);
            this.Controls.Add(this.cliente_label);
            this.Controls.Add(this.servico_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Orcamento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo orçamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Orcamento_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_Orcamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label servico_label;
        private System.Windows.Forms.Label cliente_label;
        private System.Windows.Forms.Label carro_label;
        private System.Windows.Forms.Label detalhes_label;
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.Label valor_label;
        private System.Windows.Forms.TextBox valor_edit;
        private System.Windows.Forms.TextBox servico_edit;
        private System.Windows.Forms.TextBox carro_edit;
        private System.Windows.Forms.TextBox detalhes_edit;
        private System.Windows.Forms.TextBox cliente_edit;
        private System.Windows.Forms.DateTimePicker data_timePicker;
        private System.Windows.Forms.Button servico_escolher_button;
        private System.Windows.Forms.Button cliente_escolher_button;
        private System.Windows.Forms.Button carro_escolher_button;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button apagar_button;
    }
}