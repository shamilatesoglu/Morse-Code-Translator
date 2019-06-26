namespace Morse_Translator___Classic
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dotFreqNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.dashFreqNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.dotDurationNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.dashDurationNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.spaceDurationNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.amplitudeNumericUpdown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dotFreqNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashFreqNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotDurationNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashDurationNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceDurationNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dot (.) Frequency:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dash (-) Frequency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dash (-) Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dot (.) Duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amplitude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Milliseconds";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(192, 207);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Space Duration:";
            // 
            // dotFreqNumericUpdown
            // 
            this.dotFreqNumericUpdown.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotFreqNumericUpdown.Location = new System.Drawing.Point(192, 30);
            this.dotFreqNumericUpdown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.dotFreqNumericUpdown.Name = "dotFreqNumericUpdown";
            this.dotFreqNumericUpdown.Size = new System.Drawing.Size(118, 24);
            this.dotFreqNumericUpdown.TabIndex = 13;
            // 
            // dashFreqNumericUpdown
            // 
            this.dashFreqNumericUpdown.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashFreqNumericUpdown.Location = new System.Drawing.Point(192, 60);
            this.dashFreqNumericUpdown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.dashFreqNumericUpdown.Name = "dashFreqNumericUpdown";
            this.dashFreqNumericUpdown.Size = new System.Drawing.Size(118, 24);
            this.dashFreqNumericUpdown.TabIndex = 14;
            // 
            // dotDurationNumericUpdown
            // 
            this.dotDurationNumericUpdown.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotDurationNumericUpdown.Location = new System.Drawing.Point(192, 89);
            this.dotDurationNumericUpdown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.dotDurationNumericUpdown.Name = "dotDurationNumericUpdown";
            this.dotDurationNumericUpdown.Size = new System.Drawing.Size(118, 24);
            this.dotDurationNumericUpdown.TabIndex = 15;
            // 
            // dashDurationNumericUpdown
            // 
            this.dashDurationNumericUpdown.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashDurationNumericUpdown.Location = new System.Drawing.Point(192, 118);
            this.dashDurationNumericUpdown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.dashDurationNumericUpdown.Name = "dashDurationNumericUpdown";
            this.dashDurationNumericUpdown.Size = new System.Drawing.Size(118, 24);
            this.dashDurationNumericUpdown.TabIndex = 16;
            // 
            // spaceDurationNumericUpdown
            // 
            this.spaceDurationNumericUpdown.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceDurationNumericUpdown.Location = new System.Drawing.Point(192, 147);
            this.spaceDurationNumericUpdown.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.spaceDurationNumericUpdown.Name = "spaceDurationNumericUpdown";
            this.spaceDurationNumericUpdown.Size = new System.Drawing.Size(118, 24);
            this.spaceDurationNumericUpdown.TabIndex = 17;
            // 
            // amplitudeNumericUpdown
            // 
            this.amplitudeNumericUpdown.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amplitudeNumericUpdown.Location = new System.Drawing.Point(192, 176);
            this.amplitudeNumericUpdown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.amplitudeNumericUpdown.Name = "amplitudeNumericUpdown";
            this.amplitudeNumericUpdown.Size = new System.Drawing.Size(118, 24);
            this.amplitudeNumericUpdown.TabIndex = 18;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 242);
            this.Controls.Add(this.amplitudeNumericUpdown);
            this.Controls.Add(this.spaceDurationNumericUpdown);
            this.Controls.Add(this.dashDurationNumericUpdown);
            this.Controls.Add(this.dotDurationNumericUpdown);
            this.Controls.Add(this.dashFreqNumericUpdown);
            this.Controls.Add(this.dotFreqNumericUpdown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dotFreqNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashFreqNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotDurationNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashDurationNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceDurationNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown dotFreqNumericUpdown;
        private System.Windows.Forms.NumericUpDown dashFreqNumericUpdown;
        private System.Windows.Forms.NumericUpDown dotDurationNumericUpdown;
        private System.Windows.Forms.NumericUpDown dashDurationNumericUpdown;
        private System.Windows.Forms.NumericUpDown spaceDurationNumericUpdown;
        private System.Windows.Forms.NumericUpDown amplitudeNumericUpdown;
    }
}