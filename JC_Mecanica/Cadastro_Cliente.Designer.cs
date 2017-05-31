namespace JC_Mecanica {
    partial class Cadastro_Cliente {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Cliente));
            this.nome_label = new System.Windows.Forms.Label();
            this.cpf_label = new System.Windows.Forms.Label();
            this.rg_label = new System.Windows.Forms.Label();
            this.rua_label = new System.Windows.Forms.Label();
            this.nome_edit = new System.Windows.Forms.TextBox();
            this.cpf_edit = new System.Windows.Forms.TextBox();
            this.rg_edit = new System.Windows.Forms.TextBox();
            this.rua_edit = new System.Windows.Forms.TextBox();
            this.numero_label = new System.Windows.Forms.Label();
            this.bairro_label = new System.Windows.Forms.Label();
            this.endereco_group = new System.Windows.Forms.GroupBox();
            this.numero_edit = new System.Windows.Forms.NumericUpDown();
            this.estado_comboBox = new System.Windows.Forms.ComboBox();
            this.bairro_edit = new System.Windows.Forms.TextBox();
            this.cidade_edit = new System.Windows.Forms.TextBox();
            this.estado_label = new System.Windows.Forms.Label();
            this.cidade_label = new System.Windows.Forms.Label();
            this.celular_label = new System.Windows.Forms.Label();
            this.celular_edit = new System.Windows.Forms.TextBox();
            this.salvar_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.endereco_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numero_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_label.Location = new System.Drawing.Point(14, 14);
            this.nome_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(55, 15);
            this.nome_label.TabIndex = 0;
            this.nome_label.Text = "Nome*:";
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf_label.Location = new System.Drawing.Point(14, 61);
            this.cpf_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(43, 15);
            this.cpf_label.TabIndex = 1;
            this.cpf_label.Text = "CPF*:";
            // 
            // rg_label
            // 
            this.rg_label.AutoSize = true;
            this.rg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg_label.Location = new System.Drawing.Point(172, 61);
            this.rg_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rg_label.Name = "rg_label";
            this.rg_label.Size = new System.Drawing.Size(31, 15);
            this.rg_label.TabIndex = 2;
            this.rg_label.Text = "RG:";
            // 
            // rua_label
            // 
            this.rua_label.AutoSize = true;
            this.rua_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rua_label.Location = new System.Drawing.Point(8, 19);
            this.rua_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rua_label.Name = "rua_label";
            this.rua_label.Size = new System.Drawing.Size(43, 15);
            this.rua_label.TabIndex = 3;
            this.rua_label.Text = "Rua*:";
            // 
            // nome_edit
            // 
            this.nome_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_edit.Location = new System.Drawing.Point(30, 31);
            this.nome_edit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nome_edit.Name = "nome_edit";
            this.nome_edit.Size = new System.Drawing.Size(420, 26);
            this.nome_edit.TabIndex = 1;
            // 
            // cpf_edit
            // 
            this.cpf_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf_edit.Location = new System.Drawing.Point(30, 78);
            this.cpf_edit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cpf_edit.MaxLength = 14;
            this.cpf_edit.Name = "cpf_edit";
            this.cpf_edit.Size = new System.Drawing.Size(148, 26);
            this.cpf_edit.TabIndex = 2;
            this.cpf_edit.Text = "___.___.___-__";
            // 
            // rg_edit
            // 
            this.rg_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg_edit.Location = new System.Drawing.Point(181, 80);
            this.rg_edit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rg_edit.MaxLength = 13;
            this.rg_edit.Name = "rg_edit";
            this.rg_edit.Size = new System.Drawing.Size(128, 26);
            this.rg_edit.TabIndex = 3;
            this.rg_edit.Text = "__-__.___.___";
            // 
            // rua_edit
            // 
            this.rua_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rua_edit.Location = new System.Drawing.Point(18, 36);
            this.rua_edit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rua_edit.Name = "rua_edit";
            this.rua_edit.Size = new System.Drawing.Size(337, 26);
            this.rua_edit.TabIndex = 5;
            // 
            // numero_label
            // 
            this.numero_label.AutoSize = true;
            this.numero_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_label.Location = new System.Drawing.Point(355, 19);
            this.numero_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.numero_label.Name = "numero_label";
            this.numero_label.Size = new System.Drawing.Size(33, 15);
            this.numero_label.TabIndex = 8;
            this.numero_label.Text = "N°*:";
            // 
            // bairro_label
            // 
            this.bairro_label.AutoSize = true;
            this.bairro_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro_label.Location = new System.Drawing.Point(205, 66);
            this.bairro_label.Name = "bairro_label";
            this.bairro_label.Size = new System.Drawing.Size(60, 16);
            this.bairro_label.TabIndex = 10;
            this.bairro_label.Text = "Bairro*:";
            // 
            // endereco_group
            // 
            this.endereco_group.Controls.Add(this.numero_edit);
            this.endereco_group.Controls.Add(this.estado_comboBox);
            this.endereco_group.Controls.Add(this.bairro_edit);
            this.endereco_group.Controls.Add(this.cidade_edit);
            this.endereco_group.Controls.Add(this.estado_label);
            this.endereco_group.Controls.Add(this.cidade_label);
            this.endereco_group.Controls.Add(this.rua_label);
            this.endereco_group.Controls.Add(this.bairro_label);
            this.endereco_group.Controls.Add(this.numero_label);
            this.endereco_group.Controls.Add(this.rua_edit);
            this.endereco_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco_group.Location = new System.Drawing.Point(12, 111);
            this.endereco_group.Name = "endereco_group";
            this.endereco_group.Size = new System.Drawing.Size(451, 119);
            this.endereco_group.TabIndex = 11;
            this.endereco_group.TabStop = false;
            this.endereco_group.Text = "Endereço:";
            // 
            // numero_edit
            // 
            this.numero_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_edit.Location = new System.Drawing.Point(362, 37);
            this.numero_edit.Name = "numero_edit";
            this.numero_edit.Size = new System.Drawing.Size(76, 26);
            this.numero_edit.TabIndex = 6;
            // 
            // estado_comboBox
            // 
            this.estado_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.estado_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_comboBox.FormattingEnabled = true;
            this.estado_comboBox.Location = new System.Drawing.Point(380, 82);
            this.estado_comboBox.MaxLength = 2;
            this.estado_comboBox.Name = "estado_comboBox";
            this.estado_comboBox.Size = new System.Drawing.Size(58, 28);
            this.estado_comboBox.TabIndex = 9;
            // 
            // bairro_edit
            // 
            this.bairro_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro_edit.Location = new System.Drawing.Point(213, 84);
            this.bairro_edit.Name = "bairro_edit";
            this.bairro_edit.Size = new System.Drawing.Size(161, 26);
            this.bairro_edit.TabIndex = 8;
            // 
            // cidade_edit
            // 
            this.cidade_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade_edit.Location = new System.Drawing.Point(18, 85);
            this.cidade_edit.Name = "cidade_edit";
            this.cidade_edit.Size = new System.Drawing.Size(189, 26);
            this.cidade_edit.TabIndex = 7;
            // 
            // estado_label
            // 
            this.estado_label.AutoSize = true;
            this.estado_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_label.Location = new System.Drawing.Point(371, 65);
            this.estado_label.Name = "estado_label";
            this.estado_label.Size = new System.Drawing.Size(67, 16);
            this.estado_label.TabIndex = 9;
            this.estado_label.Text = "Estado*:";
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade_label.Location = new System.Drawing.Point(8, 66);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(68, 16);
            this.cidade_label.TabIndex = 8;
            this.cidade_label.Text = "Cidade*:";
            // 
            // celular_label
            // 
            this.celular_label.AutoSize = true;
            this.celular_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular_label.Location = new System.Drawing.Point(310, 61);
            this.celular_label.Name = "celular_label";
            this.celular_label.Size = new System.Drawing.Size(57, 15);
            this.celular_label.TabIndex = 12;
            this.celular_label.Text = "Celular:";
            // 
            // celular_edit
            // 
            this.celular_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular_edit.Location = new System.Drawing.Point(319, 80);
            this.celular_edit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.celular_edit.MaxLength = 15;
            this.celular_edit.Name = "celular_edit";
            this.celular_edit.Size = new System.Drawing.Size(131, 26);
            this.celular_edit.TabIndex = 4;
            this.celular_edit.Text = "(__)____-____";
            // 
            // salvar_button
            // 
            this.salvar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar_button.Location = new System.Drawing.Point(388, 236);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(75, 29);
            this.salvar_button.TabIndex = 20;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.salvar_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar_button.Location = new System.Drawing.Point(297, 236);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(85, 29);
            this.cancelar_button.TabIndex = 21;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 275);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.salvar_button);
            this.Controls.Add(this.celular_edit);
            this.Controls.Add(this.celular_label);
            this.Controls.Add(this.endereco_group);
            this.Controls.Add(this.rg_edit);
            this.Controls.Add(this.cpf_edit);
            this.Controls.Add(this.nome_edit);
            this.Controls.Add(this.rg_label);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.nome_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Cliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Cliente_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_Cliente_Load);
            this.endereco_group.ResumeLayout(false);
            this.endereco_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numero_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.Label rg_label;
        private System.Windows.Forms.Label rua_label;
        private System.Windows.Forms.TextBox nome_edit;
        private System.Windows.Forms.TextBox cpf_edit;
        private System.Windows.Forms.TextBox rg_edit;
        private System.Windows.Forms.TextBox rua_edit;
        private System.Windows.Forms.Label numero_label;
        private System.Windows.Forms.Label bairro_label;
        private System.Windows.Forms.GroupBox endereco_group;
        private System.Windows.Forms.TextBox cidade_edit;
        private System.Windows.Forms.Label estado_label;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.Label celular_label;
        private System.Windows.Forms.TextBox celular_edit;
        private System.Windows.Forms.ComboBox estado_comboBox;
        private System.Windows.Forms.TextBox bairro_edit;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.NumericUpDown numero_edit;
    }
}