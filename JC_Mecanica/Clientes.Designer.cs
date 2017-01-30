namespace JC_Mecanica {
    partial class Clientes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button_panel = new System.Windows.Forms.Panel();
            this.apagar_button = new System.Windows.Forms.Button();
            this.salvar_button = new System.Windows.Forms.Button();
            this.editar_button = new System.Windows.Forms.Button();
            this.novo_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cliente_group = new System.Windows.Forms.GroupBox();
            this.endereco_group = new System.Windows.Forms.GroupBox();
            this.estado_comboBox = new System.Windows.Forms.ComboBox();
            this.bairro_edit = new System.Windows.Forms.TextBox();
            this.cidade_edit = new System.Windows.Forms.TextBox();
            this.estado_label = new System.Windows.Forms.Label();
            this.numero_edit = new System.Windows.Forms.NumericUpDown();
            this.rua_edit = new System.Windows.Forms.TextBox();
            this.bairro_label = new System.Windows.Forms.Label();
            this.cidade_label = new System.Windows.Forms.Label();
            this.numero_label = new System.Windows.Forms.Label();
            this.rua_label = new System.Windows.Forms.Label();
            this.telefone_edit = new System.Windows.Forms.TextBox();
            this.celular_edit = new System.Windows.Forms.TextBox();
            this.cpf_edit = new System.Windows.Forms.TextBox();
            this.nome_edit = new System.Windows.Forms.TextBox();
            this.celular_label = new System.Windows.Forms.Label();
            this.telefone_label = new System.Windows.Forms.Label();
            this.cpf_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.busca_edit = new System.Windows.Forms.ComboBox();
            this.busca_button = new System.Windows.Forms.Button();
            this.error_panel = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.button_panel.SuspendLayout();
            this.cliente_group.SuspendLayout();
            this.endereco_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numero_edit)).BeginInit();
            this.panel2.SuspendLayout();
            this.error_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.36488F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.63512F));
            this.tableLayout.Controls.Add(this.button_panel, 1, 1);
            this.tableLayout.Controls.Add(this.listView, 0, 0);
            this.tableLayout.Controls.Add(this.cliente_group, 1, 0);
            this.tableLayout.Controls.Add(this.panel2, 0, 1);
            this.tableLayout.Location = new System.Drawing.Point(12, 12);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.90164F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.09836F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(729, 305);
            this.tableLayout.TabIndex = 1;
            // 
            // button_panel
            // 
            this.button_panel.Controls.Add(this.apagar_button);
            this.button_panel.Controls.Add(this.salvar_button);
            this.button_panel.Controls.Add(this.editar_button);
            this.button_panel.Controls.Add(this.novo_button);
            this.button_panel.Controls.Add(this.ok_button);
            this.button_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_panel.Location = new System.Drawing.Point(340, 265);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(386, 37);
            this.button_panel.TabIndex = 0;
            // 
            // apagar_button
            // 
            this.apagar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.apagar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar_button.Location = new System.Drawing.Point(62, 4);
            this.apagar_button.Name = "apagar_button";
            this.apagar_button.Size = new System.Drawing.Size(75, 29);
            this.apagar_button.TabIndex = 5;
            this.apagar_button.Text = "Apagar";
            this.apagar_button.UseVisualStyleBackColor = true;
            this.apagar_button.Click += new System.EventHandler(this.apagar_button_Click);
            this.apagar_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // salvar_button
            // 
            this.salvar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salvar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar_button.Location = new System.Drawing.Point(142, 4);
            this.salvar_button.Name = "salvar_button";
            this.salvar_button.Size = new System.Drawing.Size(75, 29);
            this.salvar_button.TabIndex = 4;
            this.salvar_button.Text = "Salvar";
            this.salvar_button.UseVisualStyleBackColor = true;
            this.salvar_button.Visible = false;
            this.salvar_button.Click += new System.EventHandler(this.salvar_button_Click);
            this.salvar_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // editar_button
            // 
            this.editar_button.Enabled = false;
            this.editar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_button.Location = new System.Drawing.Point(142, 4);
            this.editar_button.Name = "editar_button";
            this.editar_button.Size = new System.Drawing.Size(75, 29);
            this.editar_button.TabIndex = 3;
            this.editar_button.Text = "Editar";
            this.editar_button.UseVisualStyleBackColor = true;
            this.editar_button.Click += new System.EventHandler(this.editar_button_Click);
            // 
            // novo_button
            // 
            this.novo_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.novo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novo_button.Location = new System.Drawing.Point(223, 4);
            this.novo_button.Name = "novo_button";
            this.novo_button.Size = new System.Drawing.Size(75, 29);
            this.novo_button.TabIndex = 2;
            this.novo_button.Text = "Novo";
            this.novo_button.UseVisualStyleBackColor = true;
            this.novo_button.Click += new System.EventHandler(this.novo_button_Click);
            this.novo_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.SystemColors.Control;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ok_button.Location = new System.Drawing.Point(304, 4);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 29);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            this.ok_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.telefone});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(331, 256);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 184;
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone/Cel.";
            this.telefone.Width = 121;
            // 
            // cliente_group
            // 
            this.cliente_group.Controls.Add(this.endereco_group);
            this.cliente_group.Controls.Add(this.telefone_edit);
            this.cliente_group.Controls.Add(this.celular_edit);
            this.cliente_group.Controls.Add(this.cpf_edit);
            this.cliente_group.Controls.Add(this.nome_edit);
            this.cliente_group.Controls.Add(this.celular_label);
            this.cliente_group.Controls.Add(this.telefone_label);
            this.cliente_group.Controls.Add(this.cpf_label);
            this.cliente_group.Controls.Add(this.nome_label);
            this.cliente_group.Location = new System.Drawing.Point(340, 3);
            this.cliente_group.Name = "cliente_group";
            this.cliente_group.Size = new System.Drawing.Size(385, 256);
            this.cliente_group.TabIndex = 2;
            this.cliente_group.TabStop = false;
            this.cliente_group.Text = "Dados do cliente";
            // 
            // endereco_group
            // 
            this.endereco_group.Controls.Add(this.estado_comboBox);
            this.endereco_group.Controls.Add(this.bairro_edit);
            this.endereco_group.Controls.Add(this.cidade_edit);
            this.endereco_group.Controls.Add(this.estado_label);
            this.endereco_group.Controls.Add(this.numero_edit);
            this.endereco_group.Controls.Add(this.rua_edit);
            this.endereco_group.Controls.Add(this.bairro_label);
            this.endereco_group.Controls.Add(this.cidade_label);
            this.endereco_group.Controls.Add(this.numero_label);
            this.endereco_group.Controls.Add(this.rua_label);
            this.endereco_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco_group.Location = new System.Drawing.Point(9, 121);
            this.endereco_group.Name = "endereco_group";
            this.endereco_group.Size = new System.Drawing.Size(370, 119);
            this.endereco_group.TabIndex = 8;
            this.endereco_group.TabStop = false;
            this.endereco_group.Text = "Endereço:";
            // 
            // estado_comboBox
            // 
            this.estado_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_comboBox.FormattingEnabled = true;
            this.estado_comboBox.Location = new System.Drawing.Point(310, 83);
            this.estado_comboBox.Name = "estado_comboBox";
            this.estado_comboBox.Size = new System.Drawing.Size(54, 26);
            this.estado_comboBox.TabIndex = 9;
            this.estado_comboBox.Text = "__";
            this.estado_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // bairro_edit
            // 
            this.bairro_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro_edit.Location = new System.Drawing.Point(169, 83);
            this.bairro_edit.Name = "bairro_edit";
            this.bairro_edit.Size = new System.Drawing.Size(135, 26);
            this.bairro_edit.TabIndex = 8;
            this.bairro_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // cidade_edit
            // 
            this.cidade_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade_edit.Location = new System.Drawing.Point(18, 84);
            this.cidade_edit.Name = "cidade_edit";
            this.cidade_edit.Size = new System.Drawing.Size(145, 26);
            this.cidade_edit.TabIndex = 7;
            this.cidade_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // estado_label
            // 
            this.estado_label.AutoSize = true;
            this.estado_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_label.Location = new System.Drawing.Point(300, 65);
            this.estado_label.Name = "estado_label";
            this.estado_label.Size = new System.Drawing.Size(55, 15);
            this.estado_label.TabIndex = 6;
            this.estado_label.Text = "Estado:";
            // 
            // numero_edit
            // 
            this.numero_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_edit.Location = new System.Drawing.Point(290, 36);
            this.numero_edit.Name = "numero_edit";
            this.numero_edit.Size = new System.Drawing.Size(74, 26);
            this.numero_edit.TabIndex = 5;
            this.numero_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // rua_edit
            // 
            this.rua_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rua_edit.Location = new System.Drawing.Point(18, 36);
            this.rua_edit.Name = "rua_edit";
            this.rua_edit.Size = new System.Drawing.Size(266, 26);
            this.rua_edit.TabIndex = 4;
            this.rua_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // bairro_label
            // 
            this.bairro_label.AutoSize = true;
            this.bairro_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro_label.Location = new System.Drawing.Point(159, 65);
            this.bairro_label.Name = "bairro_label";
            this.bairro_label.Size = new System.Drawing.Size(50, 15);
            this.bairro_label.TabIndex = 3;
            this.bairro_label.Text = "Bairro:";
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade_label.Location = new System.Drawing.Point(6, 65);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(56, 15);
            this.cidade_label.TabIndex = 2;
            this.cidade_label.Text = "Cidade:";
            // 
            // numero_label
            // 
            this.numero_label.AutoSize = true;
            this.numero_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_label.Location = new System.Drawing.Point(283, 18);
            this.numero_label.Name = "numero_label";
            this.numero_label.Size = new System.Drawing.Size(27, 15);
            this.numero_label.TabIndex = 1;
            this.numero_label.Text = "N°:";
            // 
            // rua_label
            // 
            this.rua_label.AutoSize = true;
            this.rua_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rua_label.Location = new System.Drawing.Point(9, 18);
            this.rua_label.Name = "rua_label";
            this.rua_label.Size = new System.Drawing.Size(37, 15);
            this.rua_label.TabIndex = 0;
            this.rua_label.Text = "Rua:";
            // 
            // telefone_edit
            // 
            this.telefone_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone_edit.Location = new System.Drawing.Point(142, 81);
            this.telefone_edit.MaxLength = 14;
            this.telefone_edit.Name = "telefone_edit";
            this.telefone_edit.Size = new System.Drawing.Size(106, 24);
            this.telefone_edit.TabIndex = 7;
            this.telefone_edit.Text = "(__) ____-____";
            this.telefone_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // celular_edit
            // 
            this.celular_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular_edit.Location = new System.Drawing.Point(254, 81);
            this.celular_edit.MaxLength = 15;
            this.celular_edit.Name = "celular_edit";
            this.celular_edit.Size = new System.Drawing.Size(119, 24);
            this.celular_edit.TabIndex = 6;
            this.celular_edit.Text = "(__) _____-____";
            this.celular_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // cpf_edit
            // 
            this.cpf_edit.Enabled = false;
            this.cpf_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf_edit.Location = new System.Drawing.Point(27, 81);
            this.cpf_edit.MaxLength = 14;
            this.cpf_edit.Name = "cpf_edit";
            this.cpf_edit.Size = new System.Drawing.Size(109, 24);
            this.cpf_edit.TabIndex = 5;
            this.cpf_edit.Text = "___.___.___-__";
            this.cpf_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // nome_edit
            // 
            this.nome_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_edit.Location = new System.Drawing.Point(27, 34);
            this.nome_edit.Name = "nome_edit";
            this.nome_edit.Size = new System.Drawing.Size(346, 26);
            this.nome_edit.TabIndex = 4;
            this.nome_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // celular_label
            // 
            this.celular_label.AutoSize = true;
            this.celular_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular_label.Location = new System.Drawing.Point(247, 63);
            this.celular_label.Name = "celular_label";
            this.celular_label.Size = new System.Drawing.Size(57, 15);
            this.celular_label.TabIndex = 3;
            this.celular_label.Text = "Celular:";
            // 
            // telefone_label
            // 
            this.telefone_label.AutoSize = true;
            this.telefone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone_label.Location = new System.Drawing.Point(135, 63);
            this.telefone_label.Name = "telefone_label";
            this.telefone_label.Size = new System.Drawing.Size(67, 15);
            this.telefone_label.TabIndex = 2;
            this.telefone_label.Text = "Telefone:";
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf_label.Location = new System.Drawing.Point(15, 63);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(37, 15);
            this.cpf_label.TabIndex = 1;
            this.cpf_label.Text = "CPF:";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_label.Location = new System.Drawing.Point(15, 16);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(49, 15);
            this.nome_label.TabIndex = 0;
            this.nome_label.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.busca_edit);
            this.panel2.Controls.Add(this.busca_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 265);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 37);
            this.panel2.TabIndex = 4;
            // 
            // busca_edit
            // 
            this.busca_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_edit.FormattingEnabled = true;
            this.busca_edit.Location = new System.Drawing.Point(3, 4);
            this.busca_edit.Name = "busca_edit";
            this.busca_edit.Size = new System.Drawing.Size(250, 28);
            this.busca_edit.TabIndex = 3;
            this.busca_edit.TextChanged += new System.EventHandler(this.busca_edit_TextChanged);
            this.busca_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.busca_edit_KeyDown);
            // 
            // busca_button
            // 
            this.busca_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.busca_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_button.Location = new System.Drawing.Point(259, 4);
            this.busca_button.Name = "busca_button";
            this.busca_button.Size = new System.Drawing.Size(75, 29);
            this.busca_button.TabIndex = 4;
            this.busca_button.Text = "Buscar";
            this.busca_button.UseVisualStyleBackColor = true;
            this.busca_button.Click += new System.EventHandler(this.busca_button_Click);
            this.busca_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            // 
            // error_panel
            // 
            this.error_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.error_panel.Controls.Add(this.error_label);
            this.error_panel.Location = new System.Drawing.Point(18, 49);
            this.error_panel.Name = "error_panel";
            this.error_panel.Size = new System.Drawing.Size(326, 218);
            this.error_panel.TabIndex = 2;
            this.error_panel.Visible = false;
            // 
            // error_label
            // 
            this.error_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.Location = new System.Drawing.Point(0, 0);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(326, 218);
            this.error_label.TabIndex = 0;
            this.error_label.Text = "Nenhum cliente encontrado.";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(753, 327);
            this.Controls.Add(this.error_panel);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clientes_FormClosing);
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clientes_KeyDown);
            this.tableLayout.ResumeLayout(false);
            this.button_panel.ResumeLayout(false);
            this.cliente_group.ResumeLayout(false);
            this.cliente_group.PerformLayout();
            this.endereco_group.ResumeLayout(false);
            this.endereco_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numero_edit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.error_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.Button novo_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.Button editar_button;
        private System.Windows.Forms.GroupBox cliente_group;
        private System.Windows.Forms.ComboBox busca_edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button busca_button;
        private System.Windows.Forms.TextBox telefone_edit;
        private System.Windows.Forms.TextBox celular_edit;
        private System.Windows.Forms.TextBox cpf_edit;
        private System.Windows.Forms.TextBox nome_edit;
        private System.Windows.Forms.Label celular_label;
        private System.Windows.Forms.Label telefone_label;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.GroupBox endereco_group;
        private System.Windows.Forms.ComboBox estado_comboBox;
        private System.Windows.Forms.TextBox cidade_edit;
        private System.Windows.Forms.Label estado_label;
        private System.Windows.Forms.NumericUpDown numero_edit;
        private System.Windows.Forms.TextBox rua_edit;
        private System.Windows.Forms.Label bairro_label;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.Label numero_label;
        private System.Windows.Forms.Label rua_label;
        private System.Windows.Forms.Button salvar_button;
        private System.Windows.Forms.TextBox bairro_edit;
        private System.Windows.Forms.Button apagar_button;
        private System.Windows.Forms.Panel error_panel;
        private System.Windows.Forms.Label error_label;





    }
}