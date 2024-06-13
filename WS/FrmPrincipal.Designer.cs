namespace WS
{
    partial class FrmPrincipal
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
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tcbResp1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcbResp2 = new System.Windows.Forms.TrackBar();
            this.tcbResp3 = new System.Windows.Forms.TrackBar();
            this.lblResp1 = new System.Windows.Forms.Label();
            this.lblResp2 = new System.Windows.Forms.Label();
            this.lblResp3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tcbResp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbResp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbResp3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(518, 32);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(252, 48);
            this.btnPesquisa.TabIndex = 0;
            this.btnPesquisa.Text = "Finalizar Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(40, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(136, 20);
            this.txtNome.TabIndex = 2;
            // 
            // tcbResp1
            // 
            this.tcbResp1.Location = new System.Drawing.Point(147, 139);
            this.tcbResp1.Minimum = 1;
            this.tcbResp1.Name = "tcbResp1";
            this.tcbResp1.Size = new System.Drawing.Size(295, 45);
            this.tcbResp1.TabIndex = 3;
            this.tcbResp1.Value = 1;
            this.tcbResp1.ValueChanged += new System.EventHandler(this.tcbResp1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "1 - Qual é seu nível de satisfação com o ambiente de trabalho hoje?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "2 - Atualmente, o ambiente de trabalho atende às suas expectativas?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "3 - Quão próximo do ideal está seu atual ambiente de trabalho?";
            // 
            // tcbResp2
            // 
            this.tcbResp2.Location = new System.Drawing.Point(147, 251);
            this.tcbResp2.Minimum = 1;
            this.tcbResp2.Name = "tcbResp2";
            this.tcbResp2.Size = new System.Drawing.Size(295, 45);
            this.tcbResp2.TabIndex = 7;
            this.tcbResp2.Value = 1;
            this.tcbResp2.ValueChanged += new System.EventHandler(this.tcbResp2_ValueChanged);
            // 
            // tcbResp3
            // 
            this.tcbResp3.Location = new System.Drawing.Point(147, 367);
            this.tcbResp3.Minimum = 1;
            this.tcbResp3.Name = "tcbResp3";
            this.tcbResp3.Size = new System.Drawing.Size(295, 45);
            this.tcbResp3.TabIndex = 8;
            this.tcbResp3.Value = 1;
            this.tcbResp3.ValueChanged += new System.EventHandler(this.tcbResp3_ValueChanged);
            // 
            // lblResp1
            // 
            this.lblResp1.AutoSize = true;
            this.lblResp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp1.Location = new System.Drawing.Point(275, 187);
            this.lblResp1.Name = "lblResp1";
            this.lblResp1.Size = new System.Drawing.Size(0, 16);
            this.lblResp1.TabIndex = 9;
            // 
            // lblResp2
            // 
            this.lblResp2.AutoSize = true;
            this.lblResp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp2.Location = new System.Drawing.Point(275, 299);
            this.lblResp2.Name = "lblResp2";
            this.lblResp2.Size = new System.Drawing.Size(0, 16);
            this.lblResp2.TabIndex = 10;
            // 
            // lblResp3
            // 
            this.lblResp3.AutoSize = true;
            this.lblResp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp3.Location = new System.Drawing.Point(275, 425);
            this.lblResp3.Name = "lblResp3";
            this.lblResp3.Size = new System.Drawing.Size(0, 16);
            this.lblResp3.TabIndex = 11;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResp3);
            this.Controls.Add(this.lblResp2);
            this.Controls.Add(this.lblResp1);
            this.Controls.Add(this.tcbResp3);
            this.Controls.Add(this.tcbResp2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tcbResp1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisa);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcbResp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbResp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbResp3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TrackBar tcbResp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tcbResp2;
        private System.Windows.Forms.TrackBar tcbResp3;
        private System.Windows.Forms.Label lblResp1;
        private System.Windows.Forms.Label lblResp2;
        private System.Windows.Forms.Label lblResp3;
    }
}

