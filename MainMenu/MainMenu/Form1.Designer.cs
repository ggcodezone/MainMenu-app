namespace MainMenu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimerLaunch = new System.Windows.Forms.Button();
            this.LinkedlistLaunch = new System.Windows.Forms.Button();
            this.Queuelaunch = new System.Windows.Forms.Button();
            this.Stacklaunch = new System.Windows.Forms.Button();
            this.RandomNumberLaunch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerLaunch
            // 
            this.TimerLaunch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimerLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLaunch.Location = new System.Drawing.Point(12, 126);
            this.TimerLaunch.Name = "TimerLaunch";
            this.TimerLaunch.Size = new System.Drawing.Size(158, 27);
            this.TimerLaunch.TabIndex = 0;
            this.TimerLaunch.Text = "Launch Timer App";
            this.TimerLaunch.UseVisualStyleBackColor = false;
            this.TimerLaunch.Click += new System.EventHandler(this.TimerLaunch_Click);
            // 
            // LinkedlistLaunch
            // 
            this.LinkedlistLaunch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LinkedlistLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkedlistLaunch.Location = new System.Drawing.Point(311, 54);
            this.LinkedlistLaunch.Name = "LinkedlistLaunch";
            this.LinkedlistLaunch.Size = new System.Drawing.Size(128, 24);
            this.LinkedlistLaunch.TabIndex = 1;
            this.LinkedlistLaunch.Text = "Linked List";
            this.LinkedlistLaunch.UseVisualStyleBackColor = false;
            this.LinkedlistLaunch.Click += new System.EventHandler(this.LinkedlistLaunch_Click);
            // 
            // Queuelaunch
            // 
            this.Queuelaunch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Queuelaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Queuelaunch.Location = new System.Drawing.Point(333, 101);
            this.Queuelaunch.Name = "Queuelaunch";
            this.Queuelaunch.Size = new System.Drawing.Size(75, 23);
            this.Queuelaunch.TabIndex = 2;
            this.Queuelaunch.Text = "Queue";
            this.Queuelaunch.UseVisualStyleBackColor = false;
            this.Queuelaunch.Click += new System.EventHandler(this.Queuelaunch_Click);
            // 
            // Stacklaunch
            // 
            this.Stacklaunch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Stacklaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stacklaunch.Location = new System.Drawing.Point(333, 154);
            this.Stacklaunch.Name = "Stacklaunch";
            this.Stacklaunch.Size = new System.Drawing.Size(75, 23);
            this.Stacklaunch.TabIndex = 3;
            this.Stacklaunch.Text = "Stack";
            this.Stacklaunch.UseVisualStyleBackColor = false;
            this.Stacklaunch.Click += new System.EventHandler(this.Stacklaunch_Click);
            // 
            // RandomNumberLaunch
            // 
            this.RandomNumberLaunch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RandomNumberLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomNumberLaunch.Location = new System.Drawing.Point(278, 205);
            this.RandomNumberLaunch.Name = "RandomNumberLaunch";
            this.RandomNumberLaunch.Size = new System.Drawing.Size(183, 48);
            this.RandomNumberLaunch.TabIndex = 4;
            this.RandomNumberLaunch.Text = "Random Number Generator";
            this.RandomNumberLaunch.UseVisualStyleBackColor = false;
            this.RandomNumberLaunch.Click += new System.EventHandler(this.RandomNumberLaunch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Work in progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Working";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainMenu.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(502, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RandomNumberLaunch);
            this.Controls.Add(this.Stacklaunch);
            this.Controls.Add(this.Queuelaunch);
            this.Controls.Add(this.LinkedlistLaunch);
            this.Controls.Add(this.TimerLaunch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TimerLaunch;
        private System.Windows.Forms.Button LinkedlistLaunch;
        private System.Windows.Forms.Button Queuelaunch;
        private System.Windows.Forms.Button Stacklaunch;
        private System.Windows.Forms.Button RandomNumberLaunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

