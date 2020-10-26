namespace MainMenu
{
    partial class Stackform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stackform));
            this.StackStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StackStartButton
            // 
            this.StackStartButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StackStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackStartButton.Location = new System.Drawing.Point(28, 23);
            this.StackStartButton.Name = "StackStartButton";
            this.StackStartButton.Size = new System.Drawing.Size(122, 31);
            this.StackStartButton.TabIndex = 1;
            this.StackStartButton.Text = "Create Stack ";
            this.StackStartButton.UseVisualStyleBackColor = false;
            this.StackStartButton.Click += new System.EventHandler(this.StackStartButton_Click);
            // 
            // Stackform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainMenu.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(182, 82);
            this.Controls.Add(this.StackStartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stackform";
            this.Text = "Stacks";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StackStartButton;
    }
}