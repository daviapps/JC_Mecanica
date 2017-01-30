namespace JC_Mecanica {
    partial class Servicos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicos));
            this.main_tayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.Servico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_tayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ok_button = new System.Windows.Forms.Button();
            this.novo_button = new System.Windows.Forms.Button();
            this.busca_edit = new System.Windows.Forms.ComboBox();
            this.busca_button = new System.Windows.Forms.Button();
            this.main_tayoutPanel.SuspendLayout();
            this.button_tayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_tayoutPanel
            // 
            this.main_tayoutPanel.ColumnCount = 1;
            this.main_tayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tayoutPanel.Controls.Add(this.listView, 0, 0);
            this.main_tayoutPanel.Controls.Add(this.button_tayoutPanel, 0, 1);
            this.main_tayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.main_tayoutPanel.Name = "main_tayoutPanel";
            this.main_tayoutPanel.RowCount = 2;
            this.main_tayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.main_tayoutPanel.Size = new System.Drawing.Size(422, 288);
            this.main_tayoutPanel.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Servico,
            this.codigo});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(416, 246);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // Servico
            // 
            this.Servico.Text = "Serviço";
            this.Servico.Width = 305;
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo";
            this.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo.Width = 82;
            // 
            // button_tayoutPanel
            // 
            this.button_tayoutPanel.ColumnCount = 4;
            this.button_tayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.button_tayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.button_tayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.button_tayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.button_tayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.button_tayoutPanel.Controls.Add(this.ok_button, 3, 0);
            this.button_tayoutPanel.Controls.Add(this.novo_button, 2, 0);
            this.button_tayoutPanel.Controls.Add(this.busca_edit, 0, 0);
            this.button_tayoutPanel.Controls.Add(this.busca_button, 1, 0);
            this.button_tayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_tayoutPanel.Location = new System.Drawing.Point(0, 252);
            this.button_tayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.button_tayoutPanel.Name = "button_tayoutPanel";
            this.button_tayoutPanel.RowCount = 1;
            this.button_tayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.button_tayoutPanel.Size = new System.Drawing.Size(422, 36);
            this.button_tayoutPanel.TabIndex = 1;
            // 
            // ok_button
            // 
            this.ok_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(356, 3);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(63, 30);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "Ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // novo_button
            // 
            this.novo_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.novo_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.novo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novo_button.Location = new System.Drawing.Point(286, 3);
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
            this.busca_edit.Size = new System.Drawing.Size(196, 28);
            this.busca_edit.TabIndex = 4;
            this.busca_edit.TextChanged += new System.EventHandler(this.busca_edit_TextChanged);
            // 
            // busca_button
            // 
            this.busca_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busca_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.busca_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca_button.Location = new System.Drawing.Point(205, 3);
            this.busca_button.Name = "busca_button";
            this.busca_button.Size = new System.Drawing.Size(75, 30);
            this.busca_button.TabIndex = 5;
            this.busca_button.Text = "Buscar";
            this.busca_button.UseVisualStyleBackColor = true;
            this.busca_button.Click += new System.EventHandler(this.busca_button_Click);
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 308);
            this.Controls.Add(this.main_tayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servicos";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Servicos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Servicos_FormClosing);
            this.Load += new System.EventHandler(this.Servicos_Load);
            this.main_tayoutPanel.ResumeLayout(false);
            this.button_tayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel main_tayoutPanel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Servico;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.TableLayoutPanel button_tayoutPanel;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button novo_button;
        private System.Windows.Forms.ComboBox busca_edit;
        private System.Windows.Forms.Button busca_button;
    }
}