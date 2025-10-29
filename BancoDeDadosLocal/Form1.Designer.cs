namespace BancoDeDadosLocal
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
            buttonCriarTabela = new Button();
            deletarTabela = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonCriarTabela
            // 
            buttonCriarTabela.Location = new Point(338, 170);
            buttonCriarTabela.Name = "buttonCriarTabela";
            buttonCriarTabela.Size = new Size(103, 42);
            buttonCriarTabela.TabIndex = 0;
            buttonCriarTabela.Text = "Criar Tabela";
            buttonCriarTabela.UseVisualStyleBackColor = true;
            buttonCriarTabela.Click += CriarTabela;
            // 
            // deletarTabela
            // 
            deletarTabela.ForeColor = Color.Red;
            deletarTabela.Location = new Point(338, 101);
            deletarTabela.Name = "deletarTabela";
            deletarTabela.Size = new Size(103, 40);
            deletarTabela.TabIndex = 1;
            deletarTabela.Text = "Deletar Tabela";
            deletarTabela.UseVisualStyleBackColor = true;
            deletarTabela.Click += DeletarTabela;
            // 
            // button1
            // 
            button1.Location = new Point(338, 242);
            button1.Name = "button1";
            button1.Size = new Size(103, 40);
            button1.TabIndex = 2;
            button1.Text = "Inserir Dados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += InserirDados;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(deletarTabela);
            Controls.Add(buttonCriarTabela);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCriarTabela;
        private Button deletarTabela;
        private Button button1;
    }
}
