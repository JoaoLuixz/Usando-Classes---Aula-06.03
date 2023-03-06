namespace Usando_Classes___Aula_06._03
{
    partial class frmCalculaMediaAluno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNome = new System.Windows.Forms.Label();
            this.lbRA = new System.Windows.Forms.Label();
            this.lbP1 = new System.Windows.Forms.Label();
            this.lbP2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.lbMedia = new System.Windows.Forms.Label();
            this.txtMediaSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.Location = new System.Drawing.Point(61, 90);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(61, 22);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            this.lbNome.UseWaitCursor = true;
            // 
            // lbRA
            // 
            this.lbRA.AutoSize = true;
            this.lbRA.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRA.Location = new System.Drawing.Point(61, 167);
            this.lbRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRA.Name = "lbRA";
            this.lbRA.Size = new System.Drawing.Size(37, 22);
            this.lbRA.TabIndex = 1;
            this.lbRA.Text = "RA";
            this.lbRA.UseWaitCursor = true;
            // 
            // lbP1
            // 
            this.lbP1.AutoSize = true;
            this.lbP1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbP1.Location = new System.Drawing.Point(64, 248);
            this.lbP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbP1.Name = "lbP1";
            this.lbP1.Size = new System.Drawing.Size(34, 22);
            this.lbP1.TabIndex = 2;
            this.lbP1.Text = "P1";
            this.lbP1.UseWaitCursor = true;
            // 
            // lbP2
            // 
            this.lbP2.AutoSize = true;
            this.lbP2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbP2.Location = new System.Drawing.Point(64, 318);
            this.lbP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbP2.Name = "lbP2";
            this.lbP2.Size = new System.Drawing.Size(34, 22);
            this.lbP2.TabIndex = 3;
            this.lbP2.Text = "P2";
            this.lbP2.UseWaitCursor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(203, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 29);
            this.txtNome.TabIndex = 1;
            this.txtNome.UseWaitCursor = true;
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(203, 160);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(161, 29);
            this.txtRA.TabIndex = 2;
            this.txtRA.UseWaitCursor = true;
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(203, 241);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(161, 29);
            this.txtP1.TabIndex = 3;
            this.txtP1.UseWaitCursor = true;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(203, 314);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(161, 29);
            this.txtP2.TabIndex = 4;
            this.txtP2.UseWaitCursor = true;
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(507, 192);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(182, 113);
            this.btnCalcularMedia.TabIndex = 5;
            this.btnCalcularMedia.Text = "Calcular";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.UseWaitCursor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // lbMedia
            // 
            this.lbMedia.AutoSize = true;
            this.lbMedia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMedia.Location = new System.Drawing.Point(61, 377);
            this.lbMedia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.Size = new System.Drawing.Size(61, 22);
            this.lbMedia.TabIndex = 9;
            this.lbMedia.Text = "Média";
            this.lbMedia.UseWaitCursor = true;
            // 
            // txtMediaSaida
            // 
            this.txtMediaSaida.Location = new System.Drawing.Point(203, 373);
            this.txtMediaSaida.Name = "txtMediaSaida";
            this.txtMediaSaida.Size = new System.Drawing.Size(161, 29);
            this.txtMediaSaida.TabIndex = 10;
            this.txtMediaSaida.UseWaitCursor = true;
            // 
            // frmCalculaMediaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 456);
            this.Controls.Add(this.txtMediaSaida);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbP2);
            this.Controls.Add(this.lbP1);
            this.Controls.Add(this.lbRA);
            this.Controls.Add(this.lbNome);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculaMediaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Média";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmCalculaMediaAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNome;
        private Label lbRA;
        private Label lbP1;
        private Label lbP2;
        private TextBox txtNome;
        private TextBox txtRA;
        private TextBox txtP1;
        private TextBox txtP2;
        private Button btnCalcularMedia;
        private Label lbMedia;
        private TextBox txtMediaSaida;
    }
}