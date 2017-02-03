namespace JC_Mecanica {
    partial class ValidationForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidationForm));
            this.daviapps_label = new System.Windows.Forms.Label();
            this.code_label = new System.Windows.Forms.Label();
            this.code_edit = new System.Windows.Forms.TextBox();
            this.cancelar_button = new System.Windows.Forms.Button();
            this.avaliacao_labelLink = new System.Windows.Forms.LinkLabel();
            this.validar_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daviapps_label
            // 
            this.daviapps_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.daviapps_label.AutoSize = true;
            this.daviapps_label.Location = new System.Drawing.Point(210, 99);
            this.daviapps_label.Name = "daviapps_label";
            this.daviapps_label.Size = new System.Drawing.Size(138, 13);
            this.daviapps_label.TabIndex = 0;
            this.daviapps_label.Text = "DaviApps © copyright 2017";
            // 
            // code_label
            // 
            this.code_label.AutoSize = true;
            this.code_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_label.Location = new System.Drawing.Point(12, 9);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(190, 15);
            this.code_label.TabIndex = 1;
            this.code_label.Text = "Insira o codico de validação:";
            // 
            // code_edit
            // 
            this.code_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.code_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_edit.Location = new System.Drawing.Point(15, 27);
            this.code_edit.Name = "code_edit";
            this.code_edit.PasswordChar = '*';
            this.code_edit.Size = new System.Drawing.Size(323, 29);
            this.code_edit.TabIndex = 2;
            this.code_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.code_edit_KeyDown);
            // 
            // cancelar_button
            // 
            this.cancelar_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar_button.AutoSize = true;
            this.cancelar_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar_button.Location = new System.Drawing.Point(172, 62);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(85, 29);
            this.cancelar_button.TabIndex = 5;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            // 
            // avaliacao_labelLink
            // 
            this.avaliacao_labelLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.avaliacao_labelLink.AutoSize = true;
            this.avaliacao_labelLink.Location = new System.Drawing.Point(12, 99);
            this.avaliacao_labelLink.Name = "avaliacao_labelLink";
            this.avaliacao_labelLink.Size = new System.Drawing.Size(178, 13);
            this.avaliacao_labelLink.TabIndex = 6;
            this.avaliacao_labelLink.TabStop = true;
            this.avaliacao_labelLink.Text = "Usar verção de avaliação por 5 dias";
            this.avaliacao_labelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.avaliacao_labelLink_LinkClicked);
            // 
            // validar_button
            // 
            this.validar_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.validar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validar_button.Location = new System.Drawing.Point(263, 62);
            this.validar_button.Name = "validar_button";
            this.validar_button.Size = new System.Drawing.Size(75, 29);
            this.validar_button.TabIndex = 7;
            this.validar_button.Text = "Validar";
            this.validar_button.UseVisualStyleBackColor = true;
            this.validar_button.Click += new System.EventHandler(this.validar_button_Click);
            // 
            // error_label
            // 
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(12, 59);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(154, 54);
            this.error_label.TabIndex = 8;
            this.error_label.Text = "Seu tempo de avaliação espirou, por favor digite o codigo de validação para conti" +
    "nuar usando";
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error_label.Visible = false;
            // 
            // ValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelar_button;
            this.ClientSize = new System.Drawing.Size(350, 121);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.validar_button);
            this.Controls.Add(this.avaliacao_labelLink);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.code_edit);
            this.Controls.Add(this.code_label);
            this.Controls.Add(this.daviapps_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValidationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação - ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ValidationForm_FormClosed);
            this.Load += new System.EventHandler(this.ValidationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daviapps_label;
        private System.Windows.Forms.Label code_label;
        private System.Windows.Forms.TextBox code_edit;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.LinkLabel avaliacao_labelLink;
        private System.Windows.Forms.Button validar_button;
        private System.Windows.Forms.Label error_label;
    }
}