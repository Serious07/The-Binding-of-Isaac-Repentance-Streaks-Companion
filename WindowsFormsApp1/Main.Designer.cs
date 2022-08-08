
namespace SelectRandomCharacter
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button_Win = new System.Windows.Forms.Button();
            this.button_Lose = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Win
            // 
            this.button_Win.BackgroundImage = global::SelectRandomCharacter.Properties.Resources.Godhead_icon;
            this.button_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Win.Location = new System.Drawing.Point(1, 1);
            this.button_Win.Name = "button_Win";
            this.button_Win.Size = new System.Drawing.Size(50, 50);
            this.button_Win.TabIndex = 0;
            this.button_Win.UseVisualStyleBackColor = true;
            this.button_Win.Click += new System.EventHandler(this.button_Win_Click);
            // 
            // button_Lose
            // 
            this.button_Lose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Lose.BackgroundImage = global::SelectRandomCharacter.Properties.Resources.Poop_icon;
            this.button_Lose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Lose.Location = new System.Drawing.Point(57, 1);
            this.button_Lose.Name = "button_Lose";
            this.button_Lose.Size = new System.Drawing.Size(50, 50);
            this.button_Lose.TabIndex = 1;
            this.button_Lose.UseVisualStyleBackColor = true;
            this.button_Lose.Click += new System.EventHandler(this.button_Lose_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Settings.AutoSize = true;
            this.button_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Settings.Location = new System.Drawing.Point(1, 57);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(106, 37);
            this.button_Settings.TabIndex = 2;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.AutoSize = true;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(1, 100);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(106, 37);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(108, 138);
            this.ControlBox = false;
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Settings);
            this.Controls.Add(this.button_Lose);
            this.Controls.Add(this.button_Win);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Random character";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Win;
        private System.Windows.Forms.Button button_Lose;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Exit;
    }
}

