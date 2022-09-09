namespace MultApps.Client.Windows
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnAbrirFormPesoIdeal = new System.Windows.Forms.Button();
            this.btnAbrirFormMatriculaAluno = new System.Windows.Forms.Button();
            this.btnAbrirFormReajusteSalarial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFormPesoIdeal
            // 
            this.btnAbrirFormPesoIdeal.AutoSize = true;
            this.btnAbrirFormPesoIdeal.BackColor = System.Drawing.SystemColors.Control;
            this.btnAbrirFormPesoIdeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbrirFormPesoIdeal.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormPesoIdeal.Image")));
            this.btnAbrirFormPesoIdeal.Location = new System.Drawing.Point(46, 19);
            this.btnAbrirFormPesoIdeal.Name = "btnAbrirFormPesoIdeal";
            this.btnAbrirFormPesoIdeal.Size = new System.Drawing.Size(111, 100);
            this.btnAbrirFormPesoIdeal.TabIndex = 0;
            this.btnAbrirFormPesoIdeal.Text = "Peso Ideal";
            this.btnAbrirFormPesoIdeal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormPesoIdeal.UseVisualStyleBackColor = false;
            this.btnAbrirFormPesoIdeal.Click += new System.EventHandler(this.btnAbrirFormPesoIdeal_Click);
            // 
            // btnAbrirFormMatriculaAluno
            // 
            this.btnAbrirFormMatriculaAluno.BackColor = System.Drawing.Color.White;
            this.btnAbrirFormMatriculaAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormMatriculaAluno.Image")));
            this.btnAbrirFormMatriculaAluno.Location = new System.Drawing.Point(196, 19);
            this.btnAbrirFormMatriculaAluno.Name = "btnAbrirFormMatriculaAluno";
            this.btnAbrirFormMatriculaAluno.Size = new System.Drawing.Size(132, 100);
            this.btnAbrirFormMatriculaAluno.TabIndex = 1;
            this.btnAbrirFormMatriculaAluno.Text = "Matricula de Aluno";
            this.btnAbrirFormMatriculaAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormMatriculaAluno.UseVisualStyleBackColor = false;
            this.btnAbrirFormMatriculaAluno.Click += new System.EventHandler(this.btnAbrirFormMatriculaAluno_Click);
            // 
            // btnAbrirFormReajusteSalarial
            // 
            this.btnAbrirFormReajusteSalarial.BackColor = System.Drawing.Color.White;
            this.btnAbrirFormReajusteSalarial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormReajusteSalarial.BackgroundImage")));
            this.btnAbrirFormReajusteSalarial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirFormReajusteSalarial.Location = new System.Drawing.Point(361, 19);
            this.btnAbrirFormReajusteSalarial.Name = "btnAbrirFormReajusteSalarial";
            this.btnAbrirFormReajusteSalarial.Size = new System.Drawing.Size(140, 100);
            this.btnAbrirFormReajusteSalarial.TabIndex = 2;
            this.btnAbrirFormReajusteSalarial.Text = "Reajuste Salarial";
            this.btnAbrirFormReajusteSalarial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormReajusteSalarial.UseVisualStyleBackColor = false;
            this.btnAbrirFormReajusteSalarial.Click += new System.EventHandler(this.btnAbrirFormReajusteSalarial_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(513, 131);
            this.Controls.Add(this.btnAbrirFormReajusteSalarial);
            this.Controls.Add(this.btnAbrirFormMatriculaAluno);
            this.Controls.Add(this.btnAbrirFormPesoIdeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "MultApps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAbrirFormPesoIdeal;
        private Button btnAbrirFormMatriculaAluno;
        private Button btnAbrirFormReajusteSalarial;
    }
}