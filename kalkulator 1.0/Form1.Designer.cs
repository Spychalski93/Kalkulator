namespace kalkulator_1._0
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberA = new System.Windows.Forms.Label();
            this.textBoxNumberA = new System.Windows.Forms.TextBox();
            this.numberB = new System.Windows.Forms.Label();
            this.textBoxNumberB = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.difference = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.quotient = new System.Windows.Forms.Button();
            this.textBoxInstruction = new System.Windows.Forms.TextBox();
            this.Instruction = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numberA
            // 
            this.numberA.AutoSize = true;
            this.numberA.Location = new System.Drawing.Point(34, 96);
            this.numberA.Name = "numberA";
            this.numberA.Size = new System.Drawing.Size(48, 13);
            this.numberA.TabIndex = 0;
            this.numberA.Text = "Liczba A";
            // 
            // textBoxNumberA
            // 
            this.textBoxNumberA.Location = new System.Drawing.Point(12, 73);
            this.textBoxNumberA.Name = "textBoxNumberA";
            this.textBoxNumberA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberA.TabIndex = 1;
            // 
            // numberB
            // 
            this.numberB.AutoSize = true;
            this.numberB.Location = new System.Drawing.Point(156, 96);
            this.numberB.Name = "numberB";
            this.numberB.Size = new System.Drawing.Size(48, 13);
            this.numberB.TabIndex = 0;
            this.numberB.Text = "Liczba B";
            // 
            // textBoxNumberB
            // 
            this.textBoxNumberB.Location = new System.Drawing.Point(134, 73);
            this.textBoxNumberB.Name = "textBoxNumberB";
            this.textBoxNumberB.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberB.TabIndex = 1;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum.Location = new System.Drawing.Point(12, 112);
            this.sum.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(44, 36);
            this.sum.TabIndex = 2;
            this.sum.Text = "+";
            this.sum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            this.sum.MouseEnter += new System.EventHandler(this.sum_MouseEnter);
            this.sum.MouseLeave += new System.EventHandler(this.sum_MouseLeave);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difference.Location = new System.Drawing.Point(75, 112);
            this.difference.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(44, 36);
            this.difference.TabIndex = 2;
            this.difference.Text = "-";
            this.difference.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.difference.UseVisualStyleBackColor = true;
            this.difference.MouseEnter += new System.EventHandler(this.difference_MouseEnter);
            this.difference.MouseLeave += new System.EventHandler(this.difference_MouseLeave);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.product.Location = new System.Drawing.Point(134, 112);
            this.product.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(44, 36);
            this.product.TabIndex = 2;
            this.product.Text = "*";
            this.product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.product.UseVisualStyleBackColor = true;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quotient.Location = new System.Drawing.Point(190, 112);
            this.quotient.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(44, 36);
            this.quotient.TabIndex = 2;
            this.quotient.Text = "/";
            this.quotient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.quotient.UseVisualStyleBackColor = true;
            // 
            // textBoxInstruction
            // 
            this.textBoxInstruction.Location = new System.Drawing.Point(12, 12);
            this.textBoxInstruction.Multiline = true;
            this.textBoxInstruction.Name = "textBoxInstruction";
            this.textBoxInstruction.Size = new System.Drawing.Size(226, 55);
            this.textBoxInstruction.TabIndex = 4;
            this.textBoxInstruction.TabStop = false;
            this.textBoxInstruction.Text = "Najedż kursorem myszy na wybrane działanie i przeczytaj szczegóły. Następnie wpis" +
    "z dwie liczby i wybierz działanie.";
            // 
            // Instruction
            // 
            this.Instruction.AutoSize = true;
            this.Instruction.Location = new System.Drawing.Point(105, -1);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(53, 13);
            this.Instruction.TabIndex = 3;
            this.Instruction.Text = "Instrukcja";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(33, 158);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(46, 13);
            this.Score.TabIndex = 0;
            this.Score.Text = "WYNIK:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(87, 155);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxScore.TabIndex = 1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(250, 182);
            this.Controls.Add(this.textBoxInstruction);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.product);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.textBoxNumberB);
            this.Controls.Add(this.numberB);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.textBoxNumberA);
            this.Controls.Add(this.numberA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 220);
            this.MinimumSize = new System.Drawing.Size(266, 220);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberA;
        private System.Windows.Forms.TextBox textBoxNumberA;
        private System.Windows.Forms.Label numberB;
        private System.Windows.Forms.TextBox textBoxNumberB;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button difference;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button quotient;
        private System.Windows.Forms.TextBox textBoxInstruction;
        private System.Windows.Forms.Label Instruction;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.TextBox textBoxScore;
    }
}

