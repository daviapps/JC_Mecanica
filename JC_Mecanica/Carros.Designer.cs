namespace JC_Mecanica {
    partial class Carros {
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
            this.main_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.carros_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infos_groupBox = new System.Windows.Forms.GroupBox();
            this.placa_edit = new System.Windows.Forms.TextBox();
            this.placa_label = new System.Windows.Forms.Label();
            this.ano_edit = new System.Windows.Forms.NumericUpDown();
            this.chassi_edit = new System.Windows.Forms.TextBox();
            this.modelo_edit = new System.Windows.Forms.TextBox();
            this.ano_label = new System.Windows.Forms.Label();
            this.chassi_label = new System.Windows.Forms.Label();
            this.modelo_label = new System.Windows.Forms.Label();
            this.button_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ok_button = new System.Windows.Forms.Button();
            this.novo_button = new System.Windows.Forms.Button();
            this.busca_edit = new System.Windows.Forms.ComboBox();
            this.busca_button = new System.Windows.Forms.Button();
            this.editar_salvar_panel = new System.Windows.Forms.Panel();
            this.editar_button = new System.Windows.Forms.Button();
            this.salvar_button = new System.Windows.Forms.Button();
            this.apagar_button = new System.Windows.Forms.Button();
            this.main_tableLayout.SuspendLayout();
            this.carros_tableLayout.SuspendLayout();
            this.infos_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ano_edit)).BeginInit();
            this.button_tableLayout.SuspendLayout();
            this.editar_salvar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tableLayout
            // 
            this.main_tableLayout.ColumnCount = 1;
            this.main_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tableLayout.Controls.Add(this.carros_tableLayout, 0, 0);
            this.main_tableLayout.Controls.Add(this.button_tableLayout, 0, 1);
            this.main_tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tableLayout.Location = new System.Drawing.Point(0, 0);
            this.main_tableLayout.Name = "main_tableLayout";
            this.main_tableLayout.Padding = new System.Windows.Forms.Padding(10);
            this.main_tableLayout.RowCount = 2;
            this.main_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.main_tableLayout.Size = new System.Drawing.Size(671, 267);
            this.main_tableLayout.TabIndex = 0;
            // 
            // carros_tableLayout
            // 
            this.carros_tableLayout.ColumnCount = 2;
            this.carros_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.56818F));
            this.carros_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.43182F));
            this.carros_tableLayout.Controls.Add(this.listView, 0, 0);
            this.carros_tableLayout.Controls.Add(this.infos_groupBox, 1, 0);
            this.carros_tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carros_tableLayout.Location = new System.Drawing.Point(10, 10);
            this.carros_tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.carros_tableLayout.Name = "carros_tableLayout";
            this.carros_tableLayout.RowCount = 1;
            this.carros_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.carros_tableLayout.Size = new System.Drawing.Size(651, 211);
            this.carros_tableLayout.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.placa,
            this.modelo});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(323, 205);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // placa
            // 
            this.placa.Text = "Placa";
            this.placa.Width = 85;
            // 
            // modelo
            // 
            this.modelo.Text = "Modelo";
            this.modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modelo.Width = 219;
            // 
            // infos_groupBox
            // 
            this.infos_groupBox.Controls.Add(this.placa_edit);
            this.infos_groupBox.Controls.Add(this.placa_label);
            this.infos_groupBox.Controls.Add(this.ano_edit);
            this.infos_groupBox.Controls.Add(this.chassi_edit);
            this.infos_groupBox.Controls.Add(this.modelo_edit);
            this.infos_groupBox.Controls.Add(this.ano_label);
            this.infos_groupBox.Controls.Add(this.chassi_label);
            this.infos_groupBox.Controls.Add(this.modelo_label);
            this.infos_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infos_groupBox.Location = new System.Drawing.Point(332, 3);
            this.infos_groupBox.Name = "infos_groupBox";
            this.infos_groupBox.Size = new System.Drawing.Size(316, 205);
            this.infos_groupBox.TabIndex = 1;
            this.infos_groupBox.TabStop = false;
            this.infos_groupBox.Text = "Dados do carro";
            // 
            // placa_edit
            // 
            this.placa_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa_edit.Location = new System.Drawing.Point(25, 34);
            this.placa_edit.MaxLength = 7;
            this.placa_edit.Name = "placa_edit";
            this.placa_edit.Size = new System.Drawing.Size(285, 40);
            this.placa_edit.TabIndex = 22;
            this.placa_edit.Text = "ABC1234";
            this.placa_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // placa_label
            // 
            this.placa_label.AutoSize = true;
            this.placa_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa_label.Location = new System.Drawing.Point(14, 16);
            this.placa_label.Name = "placa_label";
            this.placa_label.Size = new System.Drawing.Size(53, 15);
            this.placa_label.TabIndex = 21;
            this.placa_label.Text = "Placa*:";
            // 
            // ano_edit
            // 
            this.ano_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano_edit.Location = new System.Drawing.Point(25, 100);
            this.ano_edit.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.ano_edit.Name = "ano_edit";
            this.ano_edit.Size = new System.Drawing.Size(72, 29);
            this.ano_edit.TabIndex = 20;
            this.ano_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ano_edit.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // chassi_edit
            // 
            this.chassi_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassi_edit.Location = new System.Drawing.Point(103, 99);
            this.chassi_edit.MaxLength = 17;
            this.chassi_edit.Name = "chassi_edit";
            this.chassi_edit.Size = new System.Drawing.Size(207, 29);
            this.chassi_edit.TabIndex = 17;
            this.chassi_edit.Text = "12345678901234567";
            this.chassi_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modelo_edit
            // 
            this.modelo_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_edit.Location = new System.Drawing.Point(25, 159);
            this.modelo_edit.Name = "modelo_edit";
            this.modelo_edit.Size = new System.Drawing.Size(285, 29);
            this.modelo_edit.TabIndex = 16;
            // 
            // ano_label
            // 
            this.ano_label.AutoSize = true;
            this.ano_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano_label.Location = new System.Drawing.Point(14, 82);
            this.ano_label.Name = "ano_label";
            this.ano_label.Size = new System.Drawing.Size(35, 15);
            this.ano_label.TabIndex = 14;
            this.ano_label.Text = "Ano:";
            // 
            // chassi_label
            // 
            this.chassi_label.AutoSize = true;
            this.chassi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassi_label.Location = new System.Drawing.Point(82, 81);
            this.chassi_label.Name = "chassi_label";
            this.chassi_label.Size = new System.Drawing.Size(54, 15);
            this.chassi_label.TabIndex = 13;
            this.chassi_label.Text = "Chassi:";
            // 
            // modelo_label
            // 
            this.modelo_label.AutoSize = true;
            this.modelo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_label.Location = new System.Drawing.Point(14, 141);
            this.modelo_label.Name = "modelo_label";
            this.modelo_label.Size = new System.Drawing.Size(59, 15);
            this.modelo_label.TabIndex = 12;
            this.modelo_label.Text = "Modelo:";
            // 
            // button_tableLayout
            // 
            this.button_tableLayout.ColumnCount = 7;
            this.button_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.button_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.button_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.button_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.button_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.button_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.button_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.button_tableLayout.Controls.Add(this.ok_button, 6, 0);
            this.button_tableLayout.Controls.Add(this.novo_button, 5, 0);
            this.button_tableLayout.Controls.Add(this.busca_edit, 0, 0);
            this.button_tableLayout.Controls.Add(this.busca_button, 1, 0);
            this.button_tableLayout.Controls.Add(this.editar_salvar_panel, 4, 0);
            this.button_tableLayout.Controls.Add(this.apagar_button, 3, 0);
            this.button_tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_tableLayout.Location = new System.Drawing.Point(10, 221);
            this.button_tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.button_tableLayout.Name = "button_tableLayout";
            this.button_tableLayout.RowCount = 1;
            this.button_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.button_tableLayout.Size = new System.Drawing.Size(651, 36);
            this.button_tableLayout.TabIndex = 1;
            // 
            // ok_button
            // 
            this.ok_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(584, 3);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(64, 30);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // novo_button
            // 
            this.novo_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.novo_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.novo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novo_button.Location = new System.Drawing.Point(514, 3);
            this.novo_button.Name = "novo_button";
            this.novo_button.Size = new System.Drawing.Size(64, 30);
            this.novo_button.TabIndex = 1;
            this.novo_button.Text = "Novo";
            this.novo_button.UseVisualStyleBackColor = true;
            this.novo_button.Click += new System.EventHandler(this.novo_button_Click);
            // 
            // busca_edit
            // 
            this.busca_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busca_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_edit.FormattingEnabled = true;
            this.busca_edit.Location = new System.Drawing.Point(3, 3);
            this.busca_edit.Name = "busca_edit";
            this.busca_edit.Size = new System.Drawing.Size(248, 28);
            this.busca_edit.TabIndex = 2;
            this.busca_edit.TextChanged += new System.EventHandler(this.busca_edit_TextChanged);
            this.busca_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.busca_edit_KeyDown);
            // 
            // busca_button
            // 
            this.busca_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busca_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.busca_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_button.Location = new System.Drawing.Point(257, 3);
            this.busca_button.Name = "busca_button";
            this.busca_button.Size = new System.Drawing.Size(69, 30);
            this.busca_button.TabIndex = 3;
            this.busca_button.Text = "Buscar";
            this.busca_button.UseVisualStyleBackColor = true;
            this.busca_button.Click += new System.EventHandler(this.busca_button_Click);
            // 
            // editar_salvar_panel
            // 
            this.editar_salvar_panel.Controls.Add(this.editar_button);
            this.editar_salvar_panel.Controls.Add(this.salvar_button);
            this.editar_salvar_panel.Location = new System.Drawing.Point(435, 3);
            this.editar_salvar_panel.Name = "editar_salvar_panel";
            this.editar_salvar_panel.Size = new System.Drawing.Size(73, 30);
            this.editar_salvar_panel.TabIndex = 4;
            // 
            // editar_button
            // 
            this.editar_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_button.Location = new System.Drawing.Point(0, 0);
            this.editar_button.Name = "editar_button";
            this.editar_button.Size = new System.Drawing.Size(73, 30);
            this.editar_button.TabIndex = 1;
            this.editar_button.Text = "Editar";
            this.editar_button.UseVisualStyleBackColor = true;
            this.editar_button.Click += new System.EventHandler(this.editar_button_Click);
            // 
            // salvar_button
            // 
            this.salvar_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salvar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar_button.Location = new System.Drawing.Point(0, 0);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(73, 30);
            this.salvar_button.TabIndex = 0;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Click += new System.EventHandler(this.salvar_button_Click);
            // 
            // apagar_button
            // 
            this.apagar_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apagar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apagar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar_button.Location = new System.Drawing.Point(360, 3);
            this.apagar_button.Name = "apagar_button";
            this.apagar_button.Size = new System.Drawing.Size(69, 30);
            this.apagar_button.TabIndex = 5;
            this.apagar_button.Text = "Apagar";
            this.apagar_button.UseVisualStyleBackColor = true;
            this.apagar_button.Click += new System.EventHandler(this.apagar_button_Click);
            // 
            // Carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 267);
            this.Controls.Add(this.main_tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carros";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Carros_FormClosing);
            this.Load += new System.EventHandler(this.Carros_Load);
            this.main_tableLayout.ResumeLayout(false);
            this.carros_tableLayout.ResumeLayout(false);
            this.infos_groupBox.ResumeLayout(false);
            this.infos_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ano_edit)).EndInit();
            this.button_tableLayout.ResumeLayout(false);
            this.editar_salvar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel main_tableLayout;
        private System.Windows.Forms.TableLayoutPanel carros_tableLayout;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TableLayoutPanel button_tableLayout;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button novo_button;
        private System.Windows.Forms.GroupBox infos_groupBox;
        private System.Windows.Forms.NumericUpDown ano_edit;
        private System.Windows.Forms.TextBox chassi_edit;
        private System.Windows.Forms.TextBox modelo_edit;
        private System.Windows.Forms.Label ano_label;
        private System.Windows.Forms.Label chassi_label;
        private System.Windows.Forms.Label modelo_label;
        private System.Windows.Forms.TextBox placa_edit;
        private System.Windows.Forms.Label placa_label;
        private System.Windows.Forms.ComboBox busca_edit;
        private System.Windows.Forms.Button busca_button;
        private System.Windows.Forms.Panel editar_salvar_panel;
        private System.Windows.Forms.Button editar_button;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.Button apagar_button;
        private System.Windows.Forms.ColumnHeader placa;
        private System.Windows.Forms.ColumnHeader modelo;
    }
}