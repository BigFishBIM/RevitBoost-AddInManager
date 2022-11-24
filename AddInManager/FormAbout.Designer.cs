namespace AddInManager
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.linkLabelStantec = new System.Windows.Forms.LinkLabel();
            this.linkLabelBoost = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelStantec
            // 
            this.linkLabelStantec.AutoSize = true;
            this.linkLabelStantec.Location = new System.Drawing.Point(205, 56);
            this.linkLabelStantec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelStantec.Name = "linkLabelStantec";
            this.linkLabelStantec.Size = new System.Drawing.Size(47, 15);
            this.linkLabelStantec.TabIndex = 0;
            this.linkLabelStantec.TabStop = true;
            this.linkLabelStantec.Text = "Revit";
            this.linkLabelStantec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelStantec_LinkClicked);
            // 
            // linkLabelBoost
            // 
            this.linkLabelBoost.AutoSize = true;
            this.linkLabelBoost.Location = new System.Drawing.Point(205, 36);
            this.linkLabelBoost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelBoost.Name = "linkLabelBoost";
            this.linkLabelBoost.Size = new System.Drawing.Size(87, 15);
            this.linkLabelBoost.TabIndex = 1;
            this.linkLabelBoost.TabStop = true;
            this.linkLabelBoost.Text = "BigFishBIM";
            this.linkLabelBoost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBoost_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(93, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Revit Addin Manager";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(0, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 117);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copyright 2023\r\n\r\nYOU AGREE THAT ANY USE OF THE SOFTWARE IS AT YOUR SOLE RISK AND" +
    " THAT THE SOFTWARE IS PROVIDED ON AN \"AS IS\" BASIS WITHOUT WARRANTIES OF ANY KIN" +
    "D, EITHER EXPRESS OR IMPLIED.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Developed By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "For";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 203);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelBoost);
            this.Controls.Add(this.linkLabelStantec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelStantec;
        private System.Windows.Forms.LinkLabel linkLabelBoost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}