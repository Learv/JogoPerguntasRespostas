﻿namespace JogoDesktop
{
    partial class Pergunta4
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
            this.btnProxPergunta = new System.Windows.Forms.Button();
            this.rdbResposta4 = new System.Windows.Forms.RadioButton();
            this.rdbResposta3 = new System.Windows.Forms.RadioButton();
            this.rdbResposta2 = new System.Windows.Forms.RadioButton();
            this.rdbResposta1 = new System.Windows.Forms.RadioButton();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProxPergunta
            // 
            this.btnProxPergunta.Location = new System.Drawing.Point(158, 267);
            this.btnProxPergunta.Name = "btnProxPergunta";
            this.btnProxPergunta.Size = new System.Drawing.Size(143, 45);
            this.btnProxPergunta.TabIndex = 17;
            this.btnProxPergunta.Text = "Próxima pergunta";
            this.btnProxPergunta.UseVisualStyleBackColor = true;
            this.btnProxPergunta.Click += new System.EventHandler(this.btnProxPergunta_Click);
            // 
            // rdbResposta4
            // 
            this.rdbResposta4.AutoSize = true;
            this.rdbResposta4.Location = new System.Drawing.Point(89, 224);
            this.rdbResposta4.Name = "rdbResposta4";
            this.rdbResposta4.Size = new System.Drawing.Size(31, 17);
            this.rdbResposta4.TabIndex = 16;
            this.rdbResposta4.TabStop = true;
            this.rdbResposta4.Text = "7";
            this.rdbResposta4.UseVisualStyleBackColor = true;
            // 
            // rdbResposta3
            // 
            this.rdbResposta3.AutoSize = true;
            this.rdbResposta3.Location = new System.Drawing.Point(89, 188);
            this.rdbResposta3.Name = "rdbResposta3";
            this.rdbResposta3.Size = new System.Drawing.Size(31, 17);
            this.rdbResposta3.TabIndex = 15;
            this.rdbResposta3.TabStop = true;
            this.rdbResposta3.Text = "5";
            this.rdbResposta3.UseVisualStyleBackColor = true;
            // 
            // rdbResposta2
            // 
            this.rdbResposta2.AutoSize = true;
            this.rdbResposta2.Location = new System.Drawing.Point(89, 154);
            this.rdbResposta2.Name = "rdbResposta2";
            this.rdbResposta2.Size = new System.Drawing.Size(31, 17);
            this.rdbResposta2.TabIndex = 14;
            this.rdbResposta2.TabStop = true;
            this.rdbResposta2.Text = "6";
            this.rdbResposta2.UseVisualStyleBackColor = true;
            // 
            // rdbResposta1
            // 
            this.rdbResposta1.AutoSize = true;
            this.rdbResposta1.Location = new System.Drawing.Point(89, 120);
            this.rdbResposta1.Name = "rdbResposta1";
            this.rdbResposta1.Size = new System.Drawing.Size(31, 17);
            this.rdbResposta1.TabIndex = 13;
            this.rdbResposta1.TabStop = true;
            this.rdbResposta1.Text = "1";
            this.rdbResposta1.UseVisualStyleBackColor = true;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(86, 51);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(194, 13);
            this.lblPergunta.TabIndex = 12;
            this.lblPergunta.Text = "Quantos gênios cabem numa lâmpada?";
            // 
            // Pergunta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 362);
            this.Controls.Add(this.btnProxPergunta);
            this.Controls.Add(this.rdbResposta4);
            this.Controls.Add(this.rdbResposta3);
            this.Controls.Add(this.rdbResposta2);
            this.Controls.Add(this.rdbResposta1);
            this.Controls.Add(this.lblPergunta);
            this.Name = "Pergunta4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quarta questão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProxPergunta;
        private System.Windows.Forms.RadioButton rdbResposta4;
        private System.Windows.Forms.RadioButton rdbResposta3;
        private System.Windows.Forms.RadioButton rdbResposta2;
        private System.Windows.Forms.RadioButton rdbResposta1;
        private System.Windows.Forms.Label lblPergunta;
    }
}