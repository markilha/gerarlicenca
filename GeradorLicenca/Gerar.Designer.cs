namespace GeradorLicenca
{
    partial class Gerar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarLicenca = new MetroFramework.Controls.MetroButton();
            this.txtProdutoId = new MetroFramework.Controls.MetroTextBox();
            this.gbProdutoId = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtExe = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtData = new MetroFramework.Controls.MetroTextBox();
            this.btnLer = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtContagem = new MetroFramework.Controls.MetroTextBox();
            this.gbProdutoId.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarLicenca
            // 
            this.btnGerarLicenca.Location = new System.Drawing.Point(352, 152);
            this.btnGerarLicenca.Name = "btnGerarLicenca";
            this.btnGerarLicenca.Size = new System.Drawing.Size(111, 45);
            this.btnGerarLicenca.TabIndex = 0;
            this.btnGerarLicenca.Text = "Gerar licença";
            this.btnGerarLicenca.UseSelectable = true;
            this.btnGerarLicenca.Click += new System.EventHandler(this.btnGerarLicenca_Click);
            // 
            // txtProdutoId
            // 
            // 
            // 
            // 
            this.txtProdutoId.CustomButton.Image = null;
            this.txtProdutoId.CustomButton.Location = new System.Drawing.Point(433, 2);
            this.txtProdutoId.CustomButton.Name = "";
            this.txtProdutoId.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtProdutoId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProdutoId.CustomButton.TabIndex = 1;
            this.txtProdutoId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProdutoId.CustomButton.UseSelectable = true;
            this.txtProdutoId.CustomButton.Visible = false;
            this.txtProdutoId.Enabled = false;
            this.txtProdutoId.Lines = new string[0];
            this.txtProdutoId.Location = new System.Drawing.Point(8, 46);
            this.txtProdutoId.MaxLength = 32767;
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.PasswordChar = '\0';
            this.txtProdutoId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProdutoId.SelectedText = "";
            this.txtProdutoId.SelectionLength = 0;
            this.txtProdutoId.SelectionStart = 0;
            this.txtProdutoId.ShortcutsEnabled = true;
            this.txtProdutoId.Size = new System.Drawing.Size(455, 24);
            this.txtProdutoId.TabIndex = 1;
            this.txtProdutoId.UseSelectable = true;
            this.txtProdutoId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProdutoId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gbProdutoId
            // 
            this.gbProdutoId.Controls.Add(this.metroLabel4);
            this.gbProdutoId.Controls.Add(this.txtContagem);
            this.gbProdutoId.Controls.Add(this.btnLer);
            this.gbProdutoId.Controls.Add(this.metroLabel3);
            this.gbProdutoId.Controls.Add(this.btnGerarLicenca);
            this.gbProdutoId.Controls.Add(this.txtData);
            this.gbProdutoId.Controls.Add(this.metroLabel2);
            this.gbProdutoId.Controls.Add(this.txtExe);
            this.gbProdutoId.Controls.Add(this.metroLabel1);
            this.gbProdutoId.Controls.Add(this.txtProdutoId);
            this.gbProdutoId.Location = new System.Drawing.Point(23, 112);
            this.gbProdutoId.Name = "gbProdutoId";
            this.gbProdutoId.Size = new System.Drawing.Size(487, 211);
            this.gbProdutoId.TabIndex = 2;
            this.gbProdutoId.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Produto ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(131, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Nº de execuções";
            // 
            // txtExe
            // 
            // 
            // 
            // 
            this.txtExe.CustomButton.Image = null;
            this.txtExe.CustomButton.Location = new System.Drawing.Point(85, 2);
            this.txtExe.CustomButton.Name = "";
            this.txtExe.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtExe.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExe.CustomButton.TabIndex = 1;
            this.txtExe.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExe.CustomButton.UseSelectable = true;
            this.txtExe.CustomButton.Visible = false;
            this.txtExe.Enabled = false;
            this.txtExe.Lines = new string[] {
        "0"};
            this.txtExe.Location = new System.Drawing.Point(131, 103);
            this.txtExe.MaxLength = 32767;
            this.txtExe.Name = "txtExe";
            this.txtExe.PasswordChar = '\0';
            this.txtExe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExe.SelectedText = "";
            this.txtExe.SelectionLength = 0;
            this.txtExe.SelectionStart = 0;
            this.txtExe.ShortcutsEnabled = true;
            this.txtExe.Size = new System.Drawing.Size(107, 24);
            this.txtExe.TabIndex = 3;
            this.txtExe.Text = "0";
            this.txtExe.UseSelectable = true;
            this.txtExe.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExe.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(344, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Expira";
            // 
            // txtData
            // 
            // 
            // 
            // 
            this.txtData.CustomButton.Image = null;
            this.txtData.CustomButton.Location = new System.Drawing.Point(56, 2);
            this.txtData.CustomButton.Name = "";
            this.txtData.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtData.CustomButton.TabIndex = 1;
            this.txtData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtData.CustomButton.UseSelectable = true;
            this.txtData.CustomButton.Visible = false;
            this.txtData.Enabled = false;
            this.txtData.Lines = new string[] {
        "XX/XX/XXXX"};
            this.txtData.Location = new System.Drawing.Point(344, 103);
            this.txtData.MaxLength = 32767;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(78, 24);
            this.txtData.TabIndex = 5;
            this.txtData.Text = "XX/XX/XXXX";
            this.txtData.UseSelectable = true;
            this.txtData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(220, 152);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(111, 45);
            this.btnLer.TabIndex = 7;
            this.btnLer.Text = "Ler Licença";
            this.btnLer.UseSelectable = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Location = new System.Drawing.Point(23, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Senha Desbloqueio";
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(193, 2);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(8, 20);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '$';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(215, 24);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyUp);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Execução";
            // 
            // txtContagem
            // 
            // 
            // 
            // 
            this.txtContagem.CustomButton.Image = null;
            this.txtContagem.CustomButton.Location = new System.Drawing.Point(85, 2);
            this.txtContagem.CustomButton.Name = "";
            this.txtContagem.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtContagem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContagem.CustomButton.TabIndex = 1;
            this.txtContagem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContagem.CustomButton.UseSelectable = true;
            this.txtContagem.CustomButton.Visible = false;
            this.txtContagem.Enabled = false;
            this.txtContagem.Lines = new string[] {
        "0"};
            this.txtContagem.Location = new System.Drawing.Point(8, 103);
            this.txtContagem.MaxLength = 32767;
            this.txtContagem.Name = "txtContagem";
            this.txtContagem.PasswordChar = '\0';
            this.txtContagem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContagem.SelectedText = "";
            this.txtContagem.SelectionLength = 0;
            this.txtContagem.SelectionStart = 0;
            this.txtContagem.ShortcutsEnabled = true;
            this.txtContagem.Size = new System.Drawing.Size(107, 24);
            this.txtContagem.TabIndex = 8;
            this.txtContagem.Text = "0";
            this.txtContagem.UseSelectable = true;
            this.txtContagem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContagem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Gerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProdutoId);
            this.Name = "Gerar";
            this.Load += new System.EventHandler(this.Gerar_Load);
            this.gbProdutoId.ResumeLayout(false);
            this.gbProdutoId.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGerarLicenca;
        private MetroFramework.Controls.MetroTextBox txtProdutoId;
        private System.Windows.Forms.GroupBox gbProdutoId;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtData;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtExe;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnLer;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtContagem;
    }
}

