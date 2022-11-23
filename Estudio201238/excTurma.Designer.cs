
namespace Estudio201238
{
    partial class excTurma
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
            this.grpExclusao = new System.Windows.Forms.GroupBox();
            this.cbxId = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grpExclusao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpExclusao
            // 
            this.grpExclusao.Controls.Add(this.btnVoltar);
            this.grpExclusao.Controls.Add(this.txtNome);
            this.grpExclusao.Controls.Add(this.label2);
            this.grpExclusao.Controls.Add(this.cbxId);
            this.grpExclusao.Controls.Add(this.lblID);
            this.grpExclusao.Controls.Add(this.btnExcluir);
            this.grpExclusao.Controls.Add(this.label1);
            this.grpExclusao.Location = new System.Drawing.Point(13, 14);
            this.grpExclusao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpExclusao.Name = "grpExclusao";
            this.grpExclusao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpExclusao.Size = new System.Drawing.Size(610, 122);
            this.grpExclusao.TabIndex = 0;
            this.grpExclusao.TabStop = false;
            this.grpExclusao.Text = "Turmas";
            // 
            // cbxId
            // 
            this.cbxId.FormattingEnabled = true;
            this.cbxId.Location = new System.Drawing.Point(147, 33);
            this.cbxId.Name = "cbxId";
            this.cbxId.Size = new System.Drawing.Size(305, 29);
            this.cbxId.Sorted = true;
            this.cbxId.TabIndex = 7;
            this.cbxId.SelectedIndexChanged += new System.EventHandler(this.cbxId_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(177, 77);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 21);
            this.lblID.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(458, 30);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(141, 32);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código da turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome da turma:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(147, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(305, 29);
            this.txtNome.TabIndex = 9;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(458, 71);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(141, 32);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // excTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 150);
            this.Controls.Add(this.grpExclusao);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "excTurma";
            this.Text = "Exclusão de Turmas";
            this.Load += new System.EventHandler(this.excTurma_Load);
            this.grpExclusao.ResumeLayout(false);
            this.grpExclusao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpExclusao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbxId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
    }
}