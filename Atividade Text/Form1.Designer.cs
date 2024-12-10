namespace Atividade_Text
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCaminho1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupCriar = new System.Windows.Forms.GroupBox();
            this.txtCaminho2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.txtDigitar = new System.Windows.Forms.TextBox();
            this.groupCriar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCaminho1
            // 
            this.txtCaminho1.Location = new System.Drawing.Point(118, 38);
            this.txtCaminho1.Name = "txtCaminho1";
            this.txtCaminho1.Size = new System.Drawing.Size(283, 20);
            this.txtCaminho1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conteudo";
            // 
            // groupCriar
            // 
            this.groupCriar.Controls.Add(this.buttonCriar);
            this.groupCriar.Controls.Add(this.label3);
            this.groupCriar.Controls.Add(this.txtCaminho2);
            this.groupCriar.Location = new System.Drawing.Point(478, 41);
            this.groupCriar.Name = "groupCriar";
            this.groupCriar.Size = new System.Drawing.Size(342, 229);
            this.groupCriar.TabIndex = 4;
            this.groupCriar.TabStop = false;
            this.groupCriar.Text = "groupBox1";
            // 
            // txtCaminho2
            // 
            this.txtCaminho2.Location = new System.Drawing.Point(119, 32);
            this.txtCaminho2.Name = "txtCaminho2";
            this.txtCaminho2.Size = new System.Drawing.Size(197, 20);
            this.txtCaminho2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Caminho:";
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(119, 146);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(75, 23);
            this.buttonCriar.TabIndex = 2;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Location = new System.Drawing.Point(270, 374);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrir.TabIndex = 5;
            this.buttonAbrir.Text = "Abrir TXT";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(418, 374);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar TXT";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // txtDigitar
            // 
            this.txtDigitar.Location = new System.Drawing.Point(108, 97);
            this.txtDigitar.Multiline = true;
            this.txtDigitar.Name = "txtDigitar";
            this.txtDigitar.Size = new System.Drawing.Size(251, 181);
            this.txtDigitar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.txtDigitar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.groupCriar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminho1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupCriar.ResumeLayout(false);
            this.groupCriar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminho1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupCriar;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaminho2;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox txtDigitar;
    }
}

