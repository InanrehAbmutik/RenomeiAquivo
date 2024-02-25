namespace RenomeiAquivo
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
            button1 = new Button();
            button2 = new Button();
            txtCaminho = new TextBox();
            txtPalavra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 103);
            button1.Name = "button1";
            button1.Size = new Size(117, 32);
            button1.TabIndex = 0;
            button1.Text = "Selecionar Pasta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 103);
            button2.Name = "button2";
            button2.Size = new Size(123, 32);
            button2.TabIndex = 1;
            button2.Text = "Renomeiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(22, 25);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(272, 23);
            txtCaminho.TabIndex = 2;
            // 
            // txtPalavra
            // 
            txtPalavra.Location = new Point(22, 74);
            txtPalavra.Name = "txtPalavra";
            txtPalavra.Size = new Size(272, 23);
            txtPalavra.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 4;
            label1.Text = "Caminho da Pasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 56);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "Renomeiação";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 171);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPalavra);
            Controls.Add(txtCaminho);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renomei Arquivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtCaminho;
        private TextBox txtPalavra;
        private Label label1;
        private Label label2;
    }
}
