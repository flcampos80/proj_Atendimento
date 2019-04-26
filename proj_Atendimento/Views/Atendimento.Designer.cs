namespace ProjetoAtendimento.Views
{
    partial class Atendimento
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
            this.listBoxSenhas = new System.Windows.Forms.ListBox();
            this.listBoxGuiche = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.btnListarAtend = new System.Windows.Forms.Button();
            this.numGuiche = new System.Windows.Forms.Label();
            this.qtdeGuiche = new System.Windows.Forms.Label();
            this.labelNumGuiche = new System.Windows.Forms.Label();
            this.textGuiche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxSenhas
            // 
            this.listBoxSenhas.Font = new System.Drawing.Font("Chiller", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSenhas.FormattingEnabled = true;
            this.listBoxSenhas.ItemHeight = 23;
            this.listBoxSenhas.Location = new System.Drawing.Point(26, 59);
            this.listBoxSenhas.Name = "listBoxSenhas";
            this.listBoxSenhas.Size = new System.Drawing.Size(217, 257);
            this.listBoxSenhas.TabIndex = 0;
            // 
            // listBoxGuiche
            // 
            this.listBoxGuiche.Font = new System.Drawing.Font("Chiller", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGuiche.FormattingEnabled = true;
            this.listBoxGuiche.ItemHeight = 23;
            this.listBoxGuiche.Location = new System.Drawing.Point(390, 59);
            this.listBoxGuiche.Name = "listBoxGuiche";
            this.listBoxGuiche.Size = new System.Drawing.Size(381, 257);
            this.listBoxGuiche.TabIndex = 1;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(82, 12);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(104, 41);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar Senha";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnChamar
            // 
            this.btnChamar.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamar.Location = new System.Drawing.Point(647, 26);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(124, 27);
            this.btnChamar.TabIndex = 3;
            this.btnChamar.Text = "Chamar Senha";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(249, 231);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(135, 30);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar Guichê";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSenhas.Location = new System.Drawing.Point(72, 329);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(114, 38);
            this.btnListarSenhas.TabIndex = 5;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // btnListarAtend
            // 
            this.btnListarAtend.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAtend.Location = new System.Drawing.Point(510, 329);
            this.btnListarAtend.Name = "btnListarAtend";
            this.btnListarAtend.Size = new System.Drawing.Size(162, 38);
            this.btnListarAtend.TabIndex = 6;
            this.btnListarAtend.Text = "Listar Atendimentos";
            this.btnListarAtend.UseVisualStyleBackColor = true;
            this.btnListarAtend.Click += new System.EventHandler(this.btnListarAtend_Click);
            // 
            // numGuiche
            // 
            this.numGuiche.AutoSize = true;
            this.numGuiche.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGuiche.Location = new System.Drawing.Point(305, 187);
            this.numGuiche.Name = "numGuiche";
            this.numGuiche.Size = new System.Drawing.Size(27, 31);
            this.numGuiche.TabIndex = 7;
            this.numGuiche.Text = "0";
            // 
            // qtdeGuiche
            // 
            this.qtdeGuiche.AutoSize = true;
            this.qtdeGuiche.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdeGuiche.Location = new System.Drawing.Point(264, 163);
            this.qtdeGuiche.Name = "qtdeGuiche";
            this.qtdeGuiche.Size = new System.Drawing.Size(108, 24);
            this.qtdeGuiche.TabIndex = 8;
            this.qtdeGuiche.Text = "Qtde Guichês:";
            // 
            // labelNumGuiche
            // 
            this.labelNumGuiche.AutoSize = true;
            this.labelNumGuiche.Font = new System.Drawing.Font("Chiller", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumGuiche.Location = new System.Drawing.Point(475, 28);
            this.labelNumGuiche.Name = "labelNumGuiche";
            this.labelNumGuiche.Size = new System.Drawing.Size(60, 24);
            this.labelNumGuiche.TabIndex = 9;
            this.labelNumGuiche.Text = "Guichê:";
            // 
            // textGuiche
            // 
            this.textGuiche.Font = new System.Drawing.Font("Chiller", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGuiche.Location = new System.Drawing.Point(541, 26);
            this.textGuiche.Name = "textGuiche";
            this.textGuiche.Size = new System.Drawing.Size(100, 29);
            this.textGuiche.TabIndex = 10;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 379);
            this.Controls.Add(this.textGuiche);
            this.Controls.Add(this.labelNumGuiche);
            this.Controls.Add(this.qtdeGuiche);
            this.Controls.Add(this.numGuiche);
            this.Controls.Add(this.btnListarAtend);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.listBoxGuiche);
            this.Controls.Add(this.listBoxSenhas);
            this.Name = "Atendimento";
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.Atendimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSenhas;
        private System.Windows.Forms.ListBox listBoxGuiche;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Button btnListarAtend;
        private System.Windows.Forms.Label numGuiche;
        private System.Windows.Forms.Label qtdeGuiche;
        private System.Windows.Forms.Label labelNumGuiche;
        private System.Windows.Forms.TextBox textGuiche;
    }
}