
namespace Oscilloscope
{
    partial class GUI
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
            this.leftMainTab = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rightMainTab = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.leftMainTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMainTab
            // 
            this.leftMainTab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.leftMainTab.Controls.Add(this.panel3);
            this.leftMainTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMainTab.Location = new System.Drawing.Point(0, 0);
            this.leftMainTab.Margin = new System.Windows.Forms.Padding(0);
            this.leftMainTab.Name = "leftMainTab";
            this.leftMainTab.Size = new System.Drawing.Size(230, 450);
            this.leftMainTab.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Channels";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(230, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 450);
            this.panel1.TabIndex = 3;
            // 
            // rightMainTab
            // 
            this.rightMainTab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rightMainTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightMainTab.Location = new System.Drawing.Point(570, 0);
            this.rightMainTab.Margin = new System.Windows.Forms.Padding(0);
            this.rightMainTab.Name = "rightMainTab";
            this.rightMainTab.Size = new System.Drawing.Size(230, 450);
            this.rightMainTab.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 56);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Trigger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightMainTab);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftMainTab);
            this.IsMdiContainer = true;
            this.Name = "GUI";
            this.Text = "Form1";
            this.leftMainTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftMainTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel rightMainTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
    }
}

