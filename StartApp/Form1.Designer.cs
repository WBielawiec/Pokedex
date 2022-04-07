
namespace StartApp
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
            this.consoleAplicationLabel = new System.Windows.Forms.Label();
            this.windowAplicationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // consoleAplicationLabel
            // 
            this.consoleAplicationLabel.AutoSize = true;
            this.consoleAplicationLabel.BackColor = System.Drawing.Color.Transparent;
            this.consoleAplicationLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.consoleAplicationLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.consoleAplicationLabel.Location = new System.Drawing.Point(43, 353);
            this.consoleAplicationLabel.Name = "consoleAplicationLabel";
            this.consoleAplicationLabel.Size = new System.Drawing.Size(268, 37);
            this.consoleAplicationLabel.TabIndex = 0;
            this.consoleAplicationLabel.Text = "Console  Aplication";
            this.consoleAplicationLabel.Click += new System.EventHandler(this.consoleAplicationLabel_Click);
            this.consoleAplicationLabel.MouseEnter += new System.EventHandler(this.consoleAplicationLabel_MouseEnter);
            this.consoleAplicationLabel.MouseLeave += new System.EventHandler(this.consoleAplicationLabel_MouseLeave);
            // 
            // windowAplicationLabel
            // 
            this.windowAplicationLabel.AutoSize = true;
            this.windowAplicationLabel.BackColor = System.Drawing.Color.Transparent;
            this.windowAplicationLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.windowAplicationLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.windowAplicationLabel.Location = new System.Drawing.Point(43, 400);
            this.windowAplicationLabel.Name = "windowAplicationLabel";
            this.windowAplicationLabel.Size = new System.Drawing.Size(269, 37);
            this.windowAplicationLabel.TabIndex = 1;
            this.windowAplicationLabel.Text = "Window Aplication";
            this.windowAplicationLabel.Click += new System.EventHandler(this.windowAplicationLabel_Click);
            this.windowAplicationLabel.MouseEnter += new System.EventHandler(this.windowAplicationLabel_MouseEnter);
            this.windowAplicationLabel.MouseLeave += new System.EventHandler(this.windowAplicationLabel_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StartApp.Properties.Resources.start_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.windowAplicationLabel);
            this.Controls.Add(this.consoleAplicationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label consoleAplicationLabel;
        private System.Windows.Forms.Label windowAplicationLabel;
    }
}

