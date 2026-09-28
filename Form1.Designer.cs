namespace RipassoInterGrafica
{
    partial class Form1
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
            textNum1 = new TextBox();
            num1 = new Label();
            textNum2 = new TextBox();
            num2 = new Label();
            Somma = new Button();
            linkLabel1 = new LinkLabel();
            Risultato = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textNum1
            // 
            textNum1.Location = new Point(82, 66);
            textNum1.Name = "textNum1";
            textNum1.Size = new Size(100, 23);
            textNum1.TabIndex = 0;
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Location = new Point(82, 38);
            num1.Name = "num1";
            num1.Size = new Size(38, 15);
            num1.TabIndex = 1;
            num1.Text = "num1";
            num1.Click += label1_Click;
            // 
            // textNum2
            // 
            textNum2.Location = new Point(323, 66);
            textNum2.Name = "textNum2";
            textNum2.Size = new Size(100, 23);
            textNum2.TabIndex = 2;
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Location = new Point(323, 38);
            num2.Name = "num2";
            num2.Size = new Size(38, 15);
            num2.TabIndex = 3;
            num2.Text = "num2";
            // 
            // Somma
            // 
            Somma.Location = new Point(478, 66);
            Somma.Name = "Somma";
            Somma.Size = new Size(75, 23);
            Somma.TabIndex = 4;
            Somma.Text = "=";
            Somma.UseVisualStyleBackColor = true;
            Somma.Click += Somma_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(645, 86);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 5;
            // 
            // Risultato
            // 
            Risultato.AutoSize = true;
            Risultato.Location = new Point(645, 66);
            Risultato.Name = "Risultato";
            Risultato.Size = new Size(0, 15);
            Risultato.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 70);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 7;
            label1.Text = "+";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Risultato);
            Controls.Add(linkLabel1);
            Controls.Add(Somma);
            Controls.Add(num2);
            Controls.Add(textNum2);
            Controls.Add(num1);
            Controls.Add(textNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNum1;
        private Label num1;
        private TextBox textNum2;
        private Label num2;
        private Button Somma;
        private LinkLabel linkLabel1;
        private Label Risultato;
        private Label label1;
    }
}
