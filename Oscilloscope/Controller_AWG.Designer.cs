namespace Oscilloscope
{
    partial class Controller_AWG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller_AWG));
            this.AWG_ON_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AWG_ON_Button
            // 
            this.AWG_ON_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AWG_ON_Button.BackgroundImage")));
            this.AWG_ON_Button.Location = new System.Drawing.Point(12, 88);
            this.AWG_ON_Button.Name = "AWG_ON_Button";
            this.AWG_ON_Button.Size = new System.Drawing.Size(324, 37);
            this.AWG_ON_Button.TabIndex = 0;
            this.AWG_ON_Button.UseVisualStyleBackColor = true;
            // 
            // Controller_AWG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 238);
            this.Controls.Add(this.AWG_ON_Button);
            this.Name = "Controller_AWG";
            this.Text = "Controller_AWG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AWG_ON_Button;
    }
}