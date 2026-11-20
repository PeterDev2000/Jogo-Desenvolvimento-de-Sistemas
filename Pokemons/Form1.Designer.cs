namespace Pokemons
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
            label1 = new Label();
            StartGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("BIZ UDGothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(225, 159);
            label1.Name = "label1";
            label1.Size = new Size(424, 96);
            label1.TabIndex = 0;
            label1.Text = "POKEMONS";
            // 
            // StartGame
            // 
            StartGame.BackColor = Color.Transparent;
            StartGame.CausesValidation = false;
            StartGame.FlatStyle = FlatStyle.Flat;
            StartGame.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartGame.ForeColor = Color.FromArgb(192, 255, 192);
            StartGame.Location = new Point(338, 291);
            StartGame.Name = "StartGame";
            StartGame.Size = new Size(196, 42);
            StartGame.TabIndex = 1;
            StartGame.Text = "Iniciar Jogo";
            StartGame.UseVisualStyleBackColor = false;
            StartGame.Click += StartGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(878, 488);
            Controls.Add(StartGame);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pokemons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button StartGame;
    }
}
