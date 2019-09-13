namespace Shutdown
{
    partial class ShutdownWindow
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
            if (disposing && (components != null))
            {
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
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Seconds = new Shutdown.NumericInput();
            this.Minutes = new Shutdown.NumericInput();
            this.Hours = new Shutdown.NumericInput();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShutdownButton.Location = new System.Drawing.Point(14, 133);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(87, 27);
            this.ShutdownButton.TabIndex = 3;
            this.ShutdownButton.Text = "Shutdown";
            this.ShutdownButton.UseVisualStyleBackColor = true;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(309, 133);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 27);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RestartButton.Location = new System.Drawing.Point(108, 133);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(87, 27);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Seconds);
            this.groupBox1.Controls.Add(this.Minutes);
            this.groupBox1.Controls.Add(this.Hours);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // Seconds
            // 
            this.Seconds.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seconds.Label = "Seconds";
            this.Seconds.Location = new System.Drawing.Point(268, 22);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(107, 80);
            this.Seconds.TabIndex = 2;
            this.Seconds.Value = 0;
            // 
            // Minutes
            // 
            this.Minutes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minutes.Label = "Minutes";
            this.Minutes.Location = new System.Drawing.Point(137, 22);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(107, 80);
            this.Minutes.TabIndex = 1;
            this.Minutes.Value = 0;
            // 
            // Hours
            // 
            this.Hours.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hours.Label = "Hours";
            this.Hours.Location = new System.Drawing.Point(6, 22);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(107, 80);
            this.Hours.TabIndex = 0;
            this.Hours.Value = 0;
            // 
            // ShutdownWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 173);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ShutdownButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShutdownWindow";
            this.Text = "Shutdown";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShutdownButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private NumericInput Hours;
        private NumericInput Seconds;
        private NumericInput Minutes;
    }
}

