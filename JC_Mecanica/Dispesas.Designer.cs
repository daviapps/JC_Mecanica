namespace JC_Mecanica {
    partial class Dispesas {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dispesas));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_panel = new System.Windows.Forms.Panel();
            this.nova_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.date_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ano_listView = new System.Windows.Forms.ListView();
            this.ano_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mes_listView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.busca_button = new System.Windows.Forms.Button();
            this.busca_edit = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.soma_dispesas_label = new System.Windows.Forms.Label();
            this.tudo_panel = new System.Windows.Forms.Panel();
            this.tudo_label = new System.Windows.Forms.Label();
            this.tudo_checkBox = new System.Windows.Forms.CheckBox();
            this.error_panel = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.button_panel.SuspendLayout();
            this.date_tableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tudo_panel.SuspendLayout();
            this.error_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.65829F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.34171F));
            this.tableLayoutPanel1.Controls.Add(this.button_panel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.date_tableLayout, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.93362F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.066381F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_panel
            // 
            this.button_panel.Controls.Add(this.nova_button);
            this.button_panel.Controls.Add(this.ok_button);
            this.button_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_panel.Location = new System.Drawing.Point(649, 433);
            this.button_panel.Margin = new System.Windows.Forms.Padding(0);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(147, 34);
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
            this.nova_button.Text = "Nova";
            this.nova_button.UseVisualStyleBackColor = true;
            this.nova_button.Click += new System.EventHandler(this.nova_button_Click);
            this.nova_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dispesas_KeyDown);
            // 
            // ok_button
            // 
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(75, 3);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(68, 29);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            this.ok_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dispesas_KeyDown);
            // 
            // date_tableLayout
            // 
            this.date_tableLayout.ColumnCount = 1;
            this.date_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.date_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.date_tableLayout.Controls.Add(this.ano_listView, 0, 0);
            this.date_tableLayout.Controls.Add(this.mes_listView, 0, 1);
            this.date_tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_tableLayout.Location = new System.Drawing.Point(649, 0);
            this.date_tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.date_tableLayout.Name = "date_tableLayout";
            this.date_tableLayout.RowCount = 2;
            this.date_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.date_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.date_tableLayout.Size = new System.Drawing.Size(147, 433);
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
            this.ano_listView.Size = new System.Drawing.Size(141, 239);
            this.ano_listView.TabIndex = 0;
            this.ano_listView.UseCompatibleStateImageBehavior = false;
            this.ano_listView.View = System.Windows.Forms.View.List;
            this.ano_listView.SelectedIndexChanged += new System.EventHandler(this.ano_listView_SelectedIndexChanged);
            this.ano_listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dispesas_KeyDown);
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
            this.mes_listView.Location = new System.Drawing.Point(3, 248);
            this.mes_listView.Name = "mes_listView";
            this.mes_listView.Size = new System.Drawing.Size(141, 182);
            this.mes_listView.TabIndex = 1;
            this.mes_listView.UseCompatibleStateImageBehavior = false;
            this.mes_listView.SelectedIndexChanged += new System.EventHandler(this.mes_listView_SelectedIndexChanged);
            this.mes_listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dispesas_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listView, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.90476F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(643, 427);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.produto,
            this.count,
            this.valor,
            this.data});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(643, 427);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dispesas_KeyDown);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // produto
            // 
            this.produto.Text = "Produto";
            this.produto.Width = 345;
            // 
            // count
            // 
            this.count.Text = "Quantidade";
            this.count.Width = 71;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.Width = 107;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 95;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.10934F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.89066F));
            this.tableLayoutPanel3.Controls.Add(this.busca_button, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.busca_edit, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tudo_panel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 433);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(649, 34);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // busca_button
            // 
            this.busca_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busca_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.busca_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_button.Location = new System.Drawing.Point(147, 3);
            this.busca_button.Name = "busca_button";
            this.busca_button.Size = new System.Drawing.Size(70, 28);
            this.busca_button.TabIndex = 1;
            this.busca_button.Text = "Buscar";
            this.busca_button.UseVisualStyleBackColor = true;
            this.busca_button.Click += new System.EventHandler(this.busca_button_Click);
            this.busca_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dispesas_KeyDown);
            // 
            // busca_edit
            // 
            this.busca_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busca_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.busca_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_edit.FormattingEnabled = true;
            this.busca_edit.Location = new System.Drawing.Point(3, 3);
            this.busca_edit.Name = "busca_edit";
            this.busca_edit.Size = new System.Drawing.Size(102, 28);
            this.busca_edit.TabIndex = 0;
            this.busca_edit.TextChanged += new System.EventHandler(this.busca_edit_TextChanged);
            this.busca_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dispesas_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.soma_dispesas_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(223, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 28);
            this.panel1.TabIndex = 2;
            // 
            // soma_dispesas_label
            // 
            this.soma_dispesas_label.BackColor = System.Drawing.Color.Transparent;
            this.soma_dispesas_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soma_dispesas_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soma_dispesas_label.Location = new System.Drawing.Point(0, 0);
            this.soma_dispesas_label.Name = "soma_dispesas_label";
            this.soma_dispesas_label.Size = new System.Drawing.Size(421, 26);
            this.soma_dispesas_label.TabIndex = 0;
            this.soma_dispesas_label.Text = "Valor total de Janeiro / 2017: R$ ERROR";
            this.soma_dispesas_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tudo_panel
            // 
            this.tudo_panel.Controls.Add(this.tudo_label);
            this.tudo_panel.Controls.Add(this.tudo_checkBox);
            this.tudo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tudo_panel.Location = new System.Drawing.Point(108, 0);
            this.tudo_panel.Margin = new System.Windows.Forms.Padding(0);
            this.tudo_panel.Name = "tudo_panel";
            this.tudo_panel.Size = new System.Drawing.Size(36, 34);
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
            // error_panel
            // 
            this.error_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.error_panel.Controls.Add(this.error_label);
            this.error_panel.Location = new System.Drawing.Point(20, 50);
            this.error_panel.Name = "error_panel";
            this.error_panel.Size = new System.Drawing.Size(632, 388);
            this.error_panel.TabIndex = 2;
            this.error_panel.Visible = false;
            // 
            // error_label
            // 
            this.error_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.Location = new System.Drawing.Point(0, 0);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(632, 388);
            this.error_label.TabIndex = 1;
            this.error_label.Text = "Nenhuma dispesa encontrada";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dispesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 485);
            this.Controls.Add(this.error_panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dispesas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dispesas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dispesas_FormClosing);
            this.Load += new System.EventHandler(this.Dispesas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dispesas_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.button_panel.ResumeLayout(false);
            this.date_tableLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tudo_panel.ResumeLayout(false);
            this.tudo_panel.PerformLayout();
            this.error_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader produto;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.Button nova_button;
        private System.Windows.Forms.ComboBox busca_edit;
        private System.Windows.Forms.Button busca_button;
        private System.Windows.Forms.TableLayoutPanel date_tableLayout;
        private System.Windows.Forms.ListView ano_listView;
        private System.Windows.Forms.ListView mes_listView;
        private System.Windows.Forms.ColumnHeader ano_column;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label soma_dispesas_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel tudo_panel;
        private System.Windows.Forms.CheckBox tudo_checkBox;
        private System.Windows.Forms.Label tudo_label;
        private System.Windows.Forms.Panel error_panel;
        private System.Windows.Forms.Label error_label;
    }
}