namespace Oscilloscope
{
    partial class AccessAdjustment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessAdjustment));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdjAccess_OkButton = new System.Windows.Forms.Button();
            this.AdjAccess_CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(81, 43);
            this.textBox1.MaximumSize = new System.Drawing.Size(175, 30);
            this.textBox1.MinimumSize = new System.Drawing.Size(175, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adjustment Access";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AdjAccess_OkButton
            // 
            this.AdjAccess_OkButton.Location = new System.Drawing.Point(6, 74);
            this.AdjAccess_OkButton.Name = "AdjAccess_OkButton";
            this.AdjAccess_OkButton.Size = new System.Drawing.Size(136, 24);
            this.AdjAccess_OkButton.TabIndex = 4;
            this.AdjAccess_OkButton.Text = "OK";
            this.AdjAccess_OkButton.UseVisualStyleBackColor = true;
            // 
            // AdjAccess_CancelButton
            // 
            this.AdjAccess_CancelButton.Location = new System.Drawing.Point(148, 74);
            this.AdjAccess_CancelButton.Name = "AdjAccess_CancelButton";
            this.AdjAccess_CancelButton.Size = new System.Drawing.Size(108, 24);
            this.AdjAccess_CancelButton.TabIndex = 5;
            this.AdjAccess_CancelButton.Text = "Cancel";
            this.AdjAccess_CancelButton.UseVisualStyleBackColor = true;
            // 
            // AccessAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(273, 101);
            this.Controls.Add(this.AdjAccess_CancelButton);
            this.Controls.Add(this.AdjAccess_OkButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessAdjustment";
            this.Text = "Adjustment Access";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AdjAccess_OkButton;
        private System.Windows.Forms.Button AdjAccess_CancelButton;
    }
}