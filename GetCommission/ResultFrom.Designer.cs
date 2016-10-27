namespace GetCommission
{
    partial class ResultFormTable
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
            this.SummInfo = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.Panel();
            this.minimizeButtonPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Label();
            this.closeButtonPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.GridViewPanel = new System.Windows.Forms.Panel();
            this.Upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SummInfo)).BeginInit();
            this.Header.SuspendLayout();
            this.minimizeButtonPanel.SuspendLayout();
            this.closeButtonPanel.SuspendLayout();
            this.GridViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SummInfo
            // 
            this.SummInfo.AllowUserToAddRows = false;
            this.SummInfo.AllowUserToDeleteRows = false;
            this.SummInfo.AllowUserToOrderColumns = true;
            this.SummInfo.AllowUserToResizeColumns = false;
            this.SummInfo.AllowUserToResizeRows = false;
            this.SummInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SummInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SummInfo.BackgroundColor = System.Drawing.Color.White;
            this.SummInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SummInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SummInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SummInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SummInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummInfo.GridColor = System.Drawing.Color.SteelBlue;
            this.SummInfo.Location = new System.Drawing.Point(10, 10);
            this.SummInfo.Margin = new System.Windows.Forms.Padding(10);
            this.SummInfo.Name = "SummInfo";
            this.SummInfo.ReadOnly = true;
            this.SummInfo.RowHeadersVisible = false;
            this.SummInfo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SummInfo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummInfo.Size = new System.Drawing.Size(678, 158);
            this.SummInfo.TabIndex = 1;
            this.SummInfo.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.SummInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResultFormTable_MouseMove);
            this.SummInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResultFormTable_MouseUp);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Header.Controls.Add(this.minimizeButtonPanel);
            this.Header.Controls.Add(this.closeButtonPanel);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(698, 24);
            this.Header.TabIndex = 2;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultFormTable_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResultFormTable_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResultFormTable_MouseUp);
            // 
            // minimizeButtonPanel
            // 
            this.minimizeButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButtonPanel.Controls.Add(this.minimizeButton);
            this.minimizeButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButtonPanel.Location = new System.Drawing.Point(650, 0);
            this.minimizeButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButtonPanel.Name = "minimizeButtonPanel";
            this.minimizeButtonPanel.Size = new System.Drawing.Size(24, 24);
            this.minimizeButtonPanel.TabIndex = 1;
            // 
            // minimizeButton
            // 
            this.minimizeButton.AutoSize = true;
            this.minimizeButton.Font = new System.Drawing.Font("Noto Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimizeButton.Location = new System.Drawing.Point(2, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(22, 26);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "–";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.minimizeButton_MouseHover);
            // 
            // closeButtonPanel
            // 
            this.closeButtonPanel.Controls.Add(this.closeButton);
            this.closeButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButtonPanel.Location = new System.Drawing.Point(674, 0);
            this.closeButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonPanel.Name = "closeButtonPanel";
            this.closeButtonPanel.Size = new System.Drawing.Size(24, 24);
            this.closeButtonPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Noto Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(1, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 26);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "×";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // GridViewPanel
            // 
            this.GridViewPanel.Controls.Add(this.SummInfo);
            this.GridViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridViewPanel.Location = new System.Drawing.Point(0, 24);
            this.GridViewPanel.Name = "GridViewPanel";
            this.GridViewPanel.Padding = new System.Windows.Forms.Padding(10);
            this.GridViewPanel.Size = new System.Drawing.Size(698, 178);
            this.GridViewPanel.TabIndex = 3;
            // 
            // Upload
            // 
            this.Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upload.Location = new System.Drawing.Point(553, 206);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(135, 23);
            this.Upload.TabIndex = 4;
            this.Upload.Text = "Вивантажити";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // ResultFormTable
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 232);
            this.ControlBox = false;
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.GridViewPanel);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultFormTable";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Акти комісійної винагороди";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultFormTable_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResultFormTable_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResultFormTable_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.SummInfo)).EndInit();
            this.Header.ResumeLayout(false);
            this.minimizeButtonPanel.ResumeLayout(false);
            this.minimizeButtonPanel.PerformLayout();
            this.closeButtonPanel.ResumeLayout(false);
            this.closeButtonPanel.PerformLayout();
            this.GridViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView SummInfo;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel minimizeButtonPanel;
        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.Panel closeButtonPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel GridViewPanel;
        private System.Windows.Forms.Button Upload;
    }
}