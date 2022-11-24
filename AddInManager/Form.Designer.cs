namespace AddInManager
{
    partial class Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddinName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSpecific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddinPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnDis = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnSelEnabled = new System.Windows.Forms.Button();
            this.btnSelDis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboVersion = new System.Windows.Forms.ComboBox();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddinName,
            this.IsEnabled,
            this.Version,
            this.UserSpecific,
            this.AddinPath});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(16, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(950, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddinName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AddinName.DefaultCellStyle = dataGridViewCellStyle2;
            this.AddinName.FillWeight = 1F;
            this.AddinName.HeaderText = "Name";
            this.AddinName.MinimumWidth = 6;
            this.AddinName.Name = "AddinName";
            this.AddinName.ReadOnly = true;
            this.AddinName.ToolTipText = ".addin 文件中定义的 Name";
            // 
            // IsEnabled
            // 
            this.IsEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsEnabled.FillWeight = 1F;
            this.IsEnabled.HeaderText = "Enabled";
            this.IsEnabled.MinimumWidth = 60;
            this.IsEnabled.Name = "IsEnabled";
            this.IsEnabled.ReadOnly = true;
            this.IsEnabled.Width = 60;
            // 
            // Version
            // 
            this.Version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Version.FillWeight = 1F;
            this.Version.HeaderText = "Version";
            this.Version.MinimumWidth = 60;
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.Width = 60;
            // 
            // UserSpecific
            // 
            this.UserSpecific.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserSpecific.FillWeight = 1F;
            this.UserSpecific.HeaderText = "User Specific";
            this.UserSpecific.MinimumWidth = 70;
            this.UserSpecific.Name = "UserSpecific";
            this.UserSpecific.ReadOnly = true;
            this.UserSpecific.Width = 70;
            // 
            // AddinPath
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AddinPath.DefaultCellStyle = dataGridViewCellStyle3;
            this.AddinPath.FillWeight = 3F;
            this.AddinPath.HeaderText = "AddinPath";
            this.AddinPath.MinimumWidth = 6;
            this.AddinPath.Name = "AddinPath";
            this.AddinPath.ReadOnly = true;
            // 
            // btnEnDis
            // 
            this.btnEnDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnDis.Location = new System.Drawing.Point(810, 530);
            this.btnEnDis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEnDis.Name = "btnEnDis";
            this.btnEnDis.Size = new System.Drawing.Size(156, 27);
            this.btnEnDis.TabIndex = 1;
            this.btnEnDis.Text = "&Enable / Disable";
            this.btnEnDis.UseVisualStyleBackColor = true;
            this.btnEnDis.Click += new System.EventHandler(this.btnEnDis_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAll.Location = new System.Drawing.Point(16, 530);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(100, 27);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "Select &All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInvert.Location = new System.Drawing.Point(124, 530);
            this.btnInvert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(100, 27);
            this.btnInvert.TabIndex = 3;
            this.btnInvert.Text = "&Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnSelEnabled
            // 
            this.btnSelEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelEnabled.Location = new System.Drawing.Point(444, 530);
            this.btnSelEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelEnabled.Name = "btnSelEnabled";
            this.btnSelEnabled.Size = new System.Drawing.Size(141, 27);
            this.btnSelEnabled.TabIndex = 4;
            this.btnSelEnabled.Text = "&Select Enabled";
            this.btnSelEnabled.UseVisualStyleBackColor = true;
            this.btnSelEnabled.Click += new System.EventHandler(this.btnSelEnabled_Click);
            // 
            // btnSelDis
            // 
            this.btnSelDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelDis.Location = new System.Drawing.Point(593, 530);
            this.btnSelDis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelDis.Name = "btnSelDis";
            this.btnSelDis.Size = new System.Drawing.Size(141, 27);
            this.btnSelDis.TabIndex = 5;
            this.btnSelDis.Text = "Select &Disabled";
            this.btnSelDis.UseVisualStyleBackColor = true;
            this.btnSelDis.Click += new System.EventHandler(this.btnSelDis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Revit版本:";
            // 
            // cboVersion
            // 
            this.cboVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVersion.FormattingEnabled = true;
            this.cboVersion.Location = new System.Drawing.Point(104, 7);
            this.cboVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboVersion.Name = "cboVersion";
            this.cboVersion.Size = new System.Drawing.Size(160, 23);
            this.cboVersion.TabIndex = 7;
            this.cboVersion.SelectedIndexChanged += new System.EventHandler(this.cboVersion_SelectedIndexChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(897, 5);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(69, 27);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.cboVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelDis);
            this.Controls.Add(this.btnSelEnabled);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnEnDis);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(500, 47);
            this.Name = "Form";
            this.Text = "RevitBoost - Addin Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEnDis;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnSelEnabled;
        private System.Windows.Forms.Button btnSelDis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboVersion;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddinName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSpecific;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddinPath;
    }
}

