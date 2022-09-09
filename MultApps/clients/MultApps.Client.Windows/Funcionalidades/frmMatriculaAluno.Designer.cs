namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmMatriculaAluno
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.lblUtimoAniversario = new System.Windows.Forms.Label();
            this.txtAnoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.btnIndentificarCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(3, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "NOME :";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(57, 23);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(272, 23);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(3, 57);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(96, 15);
            this.lblAnoNascimento.TabIndex = 3;
            this.lblAnoNascimento.Text = "Ano Nascimento";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(105, 52);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(68, 23);
            this.txtAnoNascimento.TabIndex = 4;
            // 
            // lblUtimoAniversario
            // 
            this.lblUtimoAniversario.AutoSize = true;
            this.lblUtimoAniversario.Location = new System.Drawing.Point(179, 57);
            this.lblUtimoAniversario.Name = "lblUtimoAniversario";
            this.lblUtimoAniversario.Size = new System.Drawing.Size(127, 15);
            this.lblUtimoAniversario.TabIndex = 5;
            this.lblUtimoAniversario.Text = "Ano ultimo aniversario";
            // 
            // txtAnoUltimoAniversario
            // 
            this.txtAnoUltimoAniversario.Location = new System.Drawing.Point(303, 53);
            this.txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            this.txtAnoUltimoAniversario.Size = new System.Drawing.Size(81, 23);
            this.txtAnoUltimoAniversario.TabIndex = 6;
            // 
            // btnIndentificarCategoria
            // 
            this.btnIndentificarCategoria.Location = new System.Drawing.Point(3, 81);
            this.btnIndentificarCategoria.Name = "btnIndentificarCategoria";
            this.btnIndentificarCategoria.Size = new System.Drawing.Size(140, 23);
            this.btnIndentificarCategoria.TabIndex = 7;
            this.btnIndentificarCategoria.Text = "Indentificar Categoria";
            this.btnIndentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIndentificarCategoria.Click += new System.EventHandler(this.btnIndentificarCategoria_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(149, 89);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 15);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "CATEGORIA :";
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 118);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnIndentificarCategoria);
            this.Controls.Add(this.txtAnoUltimoAniversario);
            this.Controls.Add(this.lblUtimoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lbl1);
            this.Name = "frmMatriculaAluno";
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.frmMatriculaAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private TextBox txtNomeAluno;
        private Label lblAnoNascimento;
        private TextBox txtAnoNascimento;
        private Label lblUtimoAniversario;
        private TextBox txtAnoUltimoAniversario;
        private Button btnIndentificarCategoria;
        private Label lblCategoria;
    }
}