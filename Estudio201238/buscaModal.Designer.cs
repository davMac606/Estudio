
namespace Estudio201238
{
    partial class BuscaModal
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpBusca = new System.Windows.Forms.GroupBox();
            this.cbxModal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grpBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 37);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpBusca
            // 
            this.grpBusca.Controls.Add(this.btnVoltar);
            this.grpBusca.Controls.Add(this.cbxModal);
            this.grpBusca.Controls.Add(this.label1);
            this.grpBusca.Controls.Add(this.txtDesc);
            this.grpBusca.Controls.Add(this.btnSearch);
            this.grpBusca.Location = new System.Drawing.Point(12, 12);
            this.grpBusca.Name = "grpBusca";
            this.grpBusca.Size = new System.Drawing.Size(577, 432);
            this.grpBusca.TabIndex = 1;
            this.grpBusca.TabStop = false;
            this.grpBusca.Text = "Modalidades";
            // 
            // cbxModal
            // 
            this.cbxModal.FormattingEnabled = true;
            this.cbxModal.Location = new System.Drawing.Point(126, 119);
            this.cbxModal.Name = "cbxModal";
            this.cbxModal.Size = new System.Drawing.Size(445, 29);
            this.cbxModal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(126, 75);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(445, 29);
            this.txtDesc.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(458, 21);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(112, 37);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // BuscaModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.grpBusca);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BuscaModal";
            this.Text = "Busca de Modalidades";
            this.grpBusca.ResumeLayout(false);
            this.grpBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpBusca;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxModal;
        private System.Windows.Forms.Button btnVoltar;
    }
}