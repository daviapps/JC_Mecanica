namespace JC_Mecanica {
    partial class Orcamentos {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("2016");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2017");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Jan");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Fev");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Mar");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Abr");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Mai");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Jun");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Jul");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Ago");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Set");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Out");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Nov");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Dez");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orcamentos));
            this.error_panel = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.back_tayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_panel = new System.Windows.Forms.Panel();
            this.nova_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.date_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ano_listView = new System.Windows.Forms.ListView();
            this.ano_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mes_listView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.servico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detalhe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.busca_button = new System.Windows.Forms.Button();
            this.busca_edit = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.soma_orcamentos_label = new System.Windows.Forms.Label();
            this.tudo_panel = new System.Windows.Forms.Panel();
            this.tudo_label = new System.Windows.Forms.Label();
            this.tudo_checkBox = new System.Windows.Forms.CheckBox();
            this.error_panel.SuspendLayout();
            this.back_tayoutPanel.SuspendLayout();
            this.button_panel.SuspendLayout();
            this.date_tableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tudo_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // error_panel
            // 
            this.error_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.error_panel.Controls.Add(this.error_label);
            this.error_panel.Location = new System.Drawing.Point(52, 67);
            this.error_panel.Name = "error_panel";
            this.error_panel.Size = new System.Drawing.Size(774, 320);
            this.error_panel.TabIndex = 4;
            this.error_panel.Visible = false;
            // 
            // error_label
            // 
            this.error_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.Location = new System.Drawing.Point(0, 0);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(774, 320);
            this.error_label.TabIndex = 1;
            this.error_label.Text = "Nenhum orçamento encontrado";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_tayoutPanel
            // 
            this.back_tayoutPanel.ColumnCount = 2;
            this.back_tayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.24031F));
            this.back_tayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75969F));
            this.back_tayoutPanel.Controls.Add(this.button_panel, 1, 1);
            this.back_tayoutPanel.Controls.Add(this.date_tableLayout, 1, 0);
            this.back_tayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.back_tayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.back_tayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_tayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.back_tayoutPanel.Name = "back_tayoutPanel";
            this.back_tayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.back_tayoutPanel.RowCount = 2;
            this.back_tayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.93362F));
            this.back_tayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.066381F));
            this.back_tayoutPanel.Size = new System.Drawing.Size(1042, 484);
            this.back_tayoutPanel.TabIndex = 3;
            // 
            // button_panel
            // 
            this.button_panel.Controls.Add(this.nova_button);
            this.button_panel.Controls.Add(this.ok_button);
            this.button_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_panel.Location = new System.Drawing.Point(895, 445);
            this.button_panel.Margin = new System.Windows.Forms.Padding(0);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(142, 34);
            this.button_panel.TabIndex = 3;
            // 
            // nova_button
            // 
            this.nova_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nova_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nova_button.Location = new System.Drawing.Point(3, 2);
            this.nova_button.Name = "nova_button";
            this.nova_button.Size = new System.Drawing.Size(66, 29);
            this.nova_button.TabIndex = 4;
            this.nova_button.Text = "Novo";
            this.nova_button.UseVisualStyleBackColor = true;
            this.nova_button.Click += new System.EventHandler(this.nova_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(71, 2);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(68, 29);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // date_tableLayout
            // 
            this.date_tableLayout.ColumnCount = 1;
            this.date_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.date_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.date_tableLayout.Controls.Add(this.ano_listView, 0, 0);
            this.date_tableLayout.Controls.Add(this.mes_listView, 0, 1);
            this.date_tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_tableLayout.Location = new System.Drawing.Point(895, 5);
            this.date_tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.date_tableLayout.Name = "date_tableLayout";
            this.date_tableLayout.RowCount = 2;
            this.date_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.date_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.date_tableLayout.Size = new System.Drawing.Size(142, 440);
            this.date_tableLayout.TabIndex = 5;
            // 
            // ano_listView
            // 
            this.ano_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ano_column});
            this.ano_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ano_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.ano_listView.Location = new System.Drawing.Point(3, 3);
            this.ano_listView.Name = "ano_listView";
            this.ano_listView.Size = new System.Drawing.Size(136, 243);
            this.ano_listView.TabIndex = 0;
            this.ano_listView.UseCompatibleStateImageBehavior = false;
            this.ano_listView.View = System.Windows.Forms.View.List;
            this.ano_listView.SelectedIndexChanged += new System.EventHandler(this.ano_listView_SelectedIndexChanged);
            // 
            // ano_column
            // 
            this.ano_column.Text = "ano";
            this.ano_column.Width = 168;
            // 
            // mes_listView
            // 
            this.mes_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.mes_listView.Location = new System.Drawing.Point(3, 252);
            this.mes_listView.Name = "mes_listView";
            this.mes_listView.Size = new System.Drawing.Size(136, 185);
            this.mes_listView.TabIndex = 1;
            this.mes_listView.UseCompatibleStateImageBehavior = false;
            this.mes_listView.SelectedIndexChanged += new System.EventHandler(this.mes_listView_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listView, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.90476F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(884, 434);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.servico,
            this.cliente,
            this.carro,
            this.valor,
            this.data,
            this.detalhe});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(884, 434);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // servico
            // 
            this.servico.Text = "Serviço";
            this.servico.Width = 136;
            // 
            // cliente
            // 
            this.cliente.Text = "Cliente";
            this.cliente.Width = 178;
            // 
            // carro
            // 
            this.carro.Text = "Carro";
            this.carro.Width = 94;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.Width = 120;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 98;
            // 
            // detalhe
            // 
            this.detalhe.Text = "Detalhes";
            this.detalhe.Width = 234;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.12575F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.87425F));
            this.tableLayoutPanel3.Controls.Add(this.busca_button, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.busca_edit, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tudo_panel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 445);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(890, 34);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // busca_button
            // 
            this.busca_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busca_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.busca_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_button.Location = new System.Drawing.Point(225, 3);
            this.busca_button.Name = "busca_button";
            this.busca_button.Size = new System.Drawing.Size(75, 28);
            this.busca_button.TabIndex = 1;
            this.busca_button.Text = "Buscar";
            this.busca_button.UseVisualStyleBackColor = true;
            this.busca_button.Click += new System.EventHandler(this.busca_button_Click);
            // 
            // busca_edit
            // 
            this.busca_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busca_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.busca_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_edit.FormattingEnabled = true;
            this.busca_edit.Location = new System.Drawing.Point(3, 3);
            this.busca_edit.Name = "busca_edit";
            this.busca_edit.Size = new System.Drawing.Size(179, 28);
            this.busca_edit.TabIndex = 0;
            this.busca_edit.TextChanged += new System.EventHandler(this.busca_edit_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.soma_orcamentos_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(306, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 28);
            this.panel1.TabIndex = 2;
            // 
            // soma_orcamentos_label
            // 
            this.soma_orcamentos_label.BackColor = System.Drawing.Color.Transparent;
            this.soma_orcamentos_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soma_orcamentos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma_orcamentos_label.Location = new System.Drawing.Point(0, 0);
            this.soma_orcamentos_label.Name = "soma_orcamentos_label";
            this.soma_orcamentos_label.Size = new System.Drawing.Size(579, 26);
            this.soma_orcamentos_label.TabIndex = 0;
            this.soma_orcamentos_label.Text = "Valor total de Janeiro / 2017: R$ ERROR";
            this.soma_orcamentos_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tudo_panel
            // 
            this.tudo_panel.Controls.Add(this.tudo_label);
            this.tudo_panel.Controls.Add(this.tudo_checkBox);
            this.tudo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tudo_panel.Location = new System.Drawing.Point(185, 0);
            this.tudo_panel.Margin = new System.Windows.Forms.Padding(0);
            this.tudo_panel.Name = "tudo_panel";
            this.tudo_panel.Size = new System.Drawing.Size(37, 34);
            this.tudo_panel.TabIndex = 3;
            // 
            // tudo_label
            // 
            this.tudo_label.AutoSize = true;
            this.tudo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tudo_label.Location = new System.Drawing.Point(0, 19);
            this.tudo_label.Name = "tudo_label";
            this.tudo_label.Size = new System.Drawing.Size(36, 13);
            this.tudo_label.TabIndex = 1;
            this.tudo_label.Text = "Tudo";
            // 
            // tudo_checkBox
            // 
            this.tudo_checkBox.AutoSize = true;
            this.tudo_checkBox.Location = new System.Drawing.Point(12, 4);
            this.tudo_checkBox.Name = "tudo_checkBox";
            this.tudo_checkBox.Size = new System.Drawing.Size(15, 14);
            this.tudo_checkBox.TabIndex = 0;
            this.tudo_checkBox.UseVisualStyleBackColor = true;
            this.tudo_checkBox.CheckedChanged += new System.EventHandler(this.tudo_checkBox_CheckedChanged);
            // 
            // Orcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 484);
            this.Controls.Add(this.error_panel);
            this.Controls.Add(this.back_tayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orcamentos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orcamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Orcamentos_FormClosing);
            this.Load += new System.EventHandler(this.Orcamentos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Orcamentos_KeyDown);
            this.error_panel.ResumeLayout(false);
            this.back_tayoutPanel.ResumeLayout(false);
            this.button_panel.ResumeLayout(false);
            this.date_tableLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tudo_panel.ResumeLayout(false);
            this.tudo_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel error_panel;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.TableLayoutPanel back_tayoutPanel;
        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.Button nova_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TableLayoutPanel date_tableLayout;
        private System.Windows.Forms.ListView ano_listView;
        private System.Windows.Forms.ColumnHeader ano_column;
        private System.Windows.Forms.ListView mes_listView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader servico;
        private System.Windows.Forms.ColumnHeader cliente;
        private System.Windows.Forms.ColumnHeader carro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button busca_button;
        private System.Windows.Forms.ComboBox busca_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label soma_orcamentos_label;
        private System.Windows.Forms.Panel tudo_panel;
        private System.Windows.Forms.Label tudo_label;
        private System.Windows.Forms.CheckBox tudo_checkBox;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader detalhe;
    }
}