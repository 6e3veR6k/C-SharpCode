namespace GetCommission
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.Header = new System.Windows.Forms.Panel();
            this.minimizeButtonPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Label();
            this.closeButtonPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.BrCBList = new System.Windows.Forms.CheckedListBox();
            this.sideControlBar = new System.Windows.Forms.Panel();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.AgentChanel = new System.Windows.Forms.ComboBox();
            this.QueryStart = new System.Windows.Forms.Button();
            this.idActTextBox = new System.Windows.Forms.TextBox();
            this.idAct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActStatusCB = new System.Windows.Forms.ComboBox();
            this.CommissionType = new System.Windows.Forms.Label();
            this.CommissionTypeCB = new System.Windows.Forms.ComboBox();
            this.ActClosedLabel = new System.Windows.Forms.Label();
            this.ActStatusLabel = new System.Windows.Forms.Label();
            this.ActClosed = new System.Windows.Forms.DateTimePicker();
            this.ActPeriod = new System.Windows.Forms.DateTimePicker();
            this.Header.SuspendLayout();
            this.minimizeButtonPanel.SuspendLayout();
            this.closeButtonPanel.SuspendLayout();
            this.sideControlBar.SuspendLayout();
            this.SuspendLayout();
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
            this.Header.Size = new System.Drawing.Size(634, 24);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseUp);
            // 
            // minimizeButtonPanel
            // 
            this.minimizeButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButtonPanel.Controls.Add(this.minimizeButton);
            this.minimizeButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButtonPanel.Location = new System.Drawing.Point(586, 0);
            this.minimizeButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButtonPanel.Name = "minimizeButtonPanel";
            this.minimizeButtonPanel.Size = new System.Drawing.Size(24, 24);
            this.minimizeButtonPanel.TabIndex = 1;
            this.minimizeButtonPanel.Click += new System.EventHandler(this.minimizeButtonPanel_Click);
            this.minimizeButtonPanel.MouseLeave += new System.EventHandler(this.minimizeButtonPanel_MouseLeave);
            this.minimizeButtonPanel.MouseHover += new System.EventHandler(this.minimizeButtonPanel_MouseHover);
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
            this.minimizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseDown);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButtonPanel_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.minimizeButtonPanel_MouseHover);
            // 
            // closeButtonPanel
            // 
            this.closeButtonPanel.Controls.Add(this.closeButton);
            this.closeButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButtonPanel.Location = new System.Drawing.Point(610, 0);
            this.closeButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.closeButtonPanel.Name = "closeButtonPanel";
            this.closeButtonPanel.Size = new System.Drawing.Size(24, 24);
            this.closeButtonPanel.TabIndex = 0;
            this.closeButtonPanel.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButtonPanel.MouseLeave += new System.EventHandler(this.closeButtonPanel_MouseLeave);
            this.closeButtonPanel.MouseHover += new System.EventHandler(this.closeButtonPanel_MouseHover);
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
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButtonPanel_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButtonPanel_MouseHover);
            // 
            // BrCBList
            // 
            this.BrCBList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrCBList.CheckOnClick = true;
            this.BrCBList.FormattingEnabled = true;
            this.BrCBList.Items.AddRange(new object[] {
            "01: Кримська республіканська дирекція НАСК \"Оранта\"",
            "02: Вінницька обласна дирекція НАСК \"Оранта\"",
            "03: Волинська обласна дирекція НАСК \"Оранта\"",
            "04: Дніпропетровська обласна дирекція НАСК \"Оранта\"",
            "05: Маріупольська дирекція НАСК \"Оранта\"",
            "06: Житомирська обласна дирекція НАСК \"Оранта\"",
            "07: Закарпатська обласна дирекція НАСК \"Оранта\"",
            "08: Запорізька обласна дирекція НАСК \"Оранта\"",
            "09: Івано-Франківська обласна дирекція НАСК \"Оранта\"",
            "10: Київська обласна дирекція НАСК \"Оранта\"",
            "11: Кіровоградська обласна дирекція НАСК \"Оранта\"",
            "12: Луганська обласна дирекція НАСК \"Оранта\"",
            "13: Львівська обласна дирекція НАСК \"Оранта\"",
            "14: Миколаївська обласна дирекція НАСК \"Оранта\"",
            "15: Одеська обласна дирекція НАСК \"Оранта\"",
            "16: Полтавська обласна дирекція НАСК \"Оранта\"",
            "17: Рівненська обласна дирекція НАСК \"Оранта\"",
            "18: Сумська обласна дирекція НАСК \"Оранта\"",
            "19: Тернопільська обласна дирекція НАСК \"Оранта\"",
            "20: Харківська обласна дирекція НАСК \"Оранта\"",
            "21: Херсонська обласна дирекція НАСК \"Оранта\"",
            "22: Хмельницька обласна дирекція НАСК \"Оранта\"",
            "23: Черкаська обласна дирекція НАСК \"Оранта\"",
            "24: Чернівецька обласна дирекція НАСК \"Оранта\"",
            "25: Чернігівська обласна дирекція НАСК \"Оранта\"",
            "26: Київська міська дирекція НАСК \"Оранта\"",
            "27: Севастопольська міська дирекція НАСК \"Оранта\"",
            "28: Донецька обласна дирекція НАСК \"Оранта\"",
            "29: Головний офіс",
            "30: ДБС НАСК \"Оранта\"",
            "31: Апарат дирекції"});
            this.BrCBList.Location = new System.Drawing.Point(9, 33);
            this.BrCBList.Margin = new System.Windows.Forms.Padding(0);
            this.BrCBList.Name = "BrCBList";
            this.BrCBList.Size = new System.Drawing.Size(327, 527);
            this.BrCBList.TabIndex = 1;
            // 
            // sideControlBar
            // 
            this.sideControlBar.Controls.Add(this.ChannelLabel);
            this.sideControlBar.Controls.Add(this.AgentChanel);
            this.sideControlBar.Controls.Add(this.QueryStart);
            this.sideControlBar.Controls.Add(this.idActTextBox);
            this.sideControlBar.Controls.Add(this.idAct);
            this.sideControlBar.Controls.Add(this.label1);
            this.sideControlBar.Controls.Add(this.ActStatusCB);
            this.sideControlBar.Controls.Add(this.CommissionType);
            this.sideControlBar.Controls.Add(this.CommissionTypeCB);
            this.sideControlBar.Controls.Add(this.ActClosedLabel);
            this.sideControlBar.Controls.Add(this.ActStatusLabel);
            this.sideControlBar.Controls.Add(this.ActClosed);
            this.sideControlBar.Controls.Add(this.ActPeriod);
            this.sideControlBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideControlBar.Location = new System.Drawing.Point(352, 24);
            this.sideControlBar.Name = "sideControlBar";
            this.sideControlBar.Size = new System.Drawing.Size(282, 547);
            this.sideControlBar.TabIndex = 2;
            this.sideControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseDown);
            this.sideControlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseMove);
            this.sideControlBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseUp);
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(8, 166);
            this.ChannelLabel.Margin = new System.Windows.Forms.Padding(8);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(77, 15);
            this.ChannelLabel.TabIndex = 15;
            this.ChannelLabel.Text = "Канал агента";
            // 
            // AgentChanel
            // 
            this.AgentChanel.FormattingEnabled = true;
            this.AgentChanel.Items.AddRange(new object[] {
            "11 - ФО по ТД",
            "12 - ФО по ЦПХ",
            "13 - інші агенти ФО",
            "14 - ЮО - банки",
            "15 - Агенти – ЮО банки",
            "16 - Агенти – ЮО",
            "17 - Агенти – ЮО",
            "18 - СПД (Категорія 2)",
            "19 - інші страхові агенти",
            "21 - штатні працівники",
            "22 - СПД (Категорія 1)",
            "31 - Iнтернет",
            "32 - Телемаркетинг",
            "33 - Дистанційні канали"});
            this.AgentChanel.Location = new System.Drawing.Point(132, 163);
            this.AgentChanel.Margin = new System.Windows.Forms.Padding(8);
            this.AgentChanel.Name = "AgentChanel";
            this.AgentChanel.Size = new System.Drawing.Size(139, 23);
            this.AgentChanel.TabIndex = 14;
            // 
            // QueryStart
            // 
            this.QueryStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QueryStart.Location = new System.Drawing.Point(156, 512);
            this.QueryStart.Name = "QueryStart";
            this.QueryStart.Size = new System.Drawing.Size(115, 23);
            this.QueryStart.TabIndex = 13;
            this.QueryStart.Text = "Вивантажити";
            this.QueryStart.UseVisualStyleBackColor = true;
            this.QueryStart.Click += new System.EventHandler(this.QueryStart_Click);
            // 
            // idActTextBox
            // 
            this.idActTextBox.Location = new System.Drawing.Point(11, 310);
            this.idActTextBox.Name = "idActTextBox";
            this.idActTextBox.Size = new System.Drawing.Size(139, 22);
            this.idActTextBox.TabIndex = 10;
            // 
            // idAct
            // 
            this.idAct.AutoSize = true;
            this.idAct.Location = new System.Drawing.Point(8, 284);
            this.idAct.Margin = new System.Windows.Forms.Padding(8);
            this.idAct.Name = "idAct";
            this.idAct.Size = new System.Drawing.Size(69, 15);
            this.idAct.TabIndex = 9;
            this.idAct.Text = "Номер акту";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Статус актів";
            // 
            // ActStatusCB
            // 
            this.ActStatusCB.FormattingEnabled = true;
            this.ActStatusCB.Items.AddRange(new object[] {
            "Затверджений",
            "На узгодженні",
            "Новий",
            "Сторно"});
            this.ActStatusCB.Location = new System.Drawing.Point(132, 124);
            this.ActStatusCB.Margin = new System.Windows.Forms.Padding(8);
            this.ActStatusCB.Name = "ActStatusCB";
            this.ActStatusCB.Size = new System.Drawing.Size(139, 23);
            this.ActStatusCB.TabIndex = 6;
            // 
            // CommissionType
            // 
            this.CommissionType.AutoSize = true;
            this.CommissionType.Location = new System.Drawing.Point(8, 88);
            this.CommissionType.Margin = new System.Windows.Forms.Padding(8);
            this.CommissionType.Name = "CommissionType";
            this.CommissionType.Size = new System.Drawing.Size(95, 15);
            this.CommissionType.TabIndex = 5;
            this.CommissionType.Text = "Тип винагороди";
            // 
            // CommissionTypeCB
            // 
            this.CommissionTypeCB.FormattingEnabled = true;
            this.CommissionTypeCB.Items.AddRange(new object[] {
            "АВ за надання ІКП",
            "Агентська винагорода",
            "Автор угоди"});
            this.CommissionTypeCB.Location = new System.Drawing.Point(132, 85);
            this.CommissionTypeCB.Margin = new System.Windows.Forms.Padding(8);
            this.CommissionTypeCB.Name = "CommissionTypeCB";
            this.CommissionTypeCB.Size = new System.Drawing.Size(139, 23);
            this.CommissionTypeCB.TabIndex = 4;
            // 
            // ActClosedLabel
            // 
            this.ActClosedLabel.AutoSize = true;
            this.ActClosedLabel.Location = new System.Drawing.Point(8, 53);
            this.ActClosedLabel.Margin = new System.Windows.Forms.Padding(8);
            this.ActClosedLabel.Name = "ActClosedLabel";
            this.ActClosedLabel.Size = new System.Drawing.Size(139, 15);
            this.ActClosedLabel.TabIndex = 3;
            this.ActClosedLabel.Text = "Дата затвердження актів";
            // 
            // ActStatusLabel
            // 
            this.ActStatusLabel.AutoSize = true;
            this.ActStatusLabel.Location = new System.Drawing.Point(8, 15);
            this.ActStatusLabel.Margin = new System.Windows.Forms.Padding(8);
            this.ActStatusLabel.Name = "ActStatusLabel";
            this.ActStatusLabel.Size = new System.Drawing.Size(73, 15);
            this.ActStatusLabel.TabIndex = 2;
            this.ActStatusLabel.Text = "Період актів";
            // 
            // ActClosed
            // 
            this.ActClosed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ActClosed.Location = new System.Drawing.Point(177, 47);
            this.ActClosed.Margin = new System.Windows.Forms.Padding(8);
            this.ActClosed.Name = "ActClosed";
            this.ActClosed.Size = new System.Drawing.Size(94, 22);
            this.ActClosed.TabIndex = 1;
            // 
            // ActPeriod
            // 
            this.ActPeriod.CustomFormat = "MM.yyyy";
            this.ActPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ActPeriod.Location = new System.Drawing.Point(177, 9);
            this.ActPeriod.Margin = new System.Windows.Forms.Padding(8);
            this.ActPeriod.Name = "ActPeriod";
            this.ActPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActPeriod.Size = new System.Drawing.Size(94, 22);
            this.ActPeriod.TabIndex = 0;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(634, 571);
            this.Controls.Add(this.sideControlBar);
            this.Controls.Add(this.BrCBList);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindowForm";
            this.Text = "Commission";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindowForm_MouseUp);
            this.Header.ResumeLayout(false);
            this.minimizeButtonPanel.ResumeLayout(false);
            this.minimizeButtonPanel.PerformLayout();
            this.closeButtonPanel.ResumeLayout(false);
            this.closeButtonPanel.PerformLayout();
            this.sideControlBar.ResumeLayout(false);
            this.sideControlBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel closeButtonPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Panel minimizeButtonPanel;
        private System.Windows.Forms.Label minimizeButton;
        public System.Windows.Forms.CheckedListBox BrCBList;
        private System.Windows.Forms.Panel sideControlBar;
        private System.Windows.Forms.Label ActClosedLabel;
        private System.Windows.Forms.Label ActStatusLabel;
        public System.Windows.Forms.DateTimePicker ActClosed;
        public System.Windows.Forms.DateTimePicker ActPeriod;
        public System.Windows.Forms.ComboBox CommissionTypeCB;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ActStatusCB;
        private System.Windows.Forms.Label CommissionType;
        public System.Windows.Forms.TextBox idActTextBox;
        private System.Windows.Forms.Label idAct;
        private System.Windows.Forms.Button QueryStart;
        private System.Windows.Forms.Label ChannelLabel;
        public System.Windows.Forms.ComboBox AgentChanel;
    }
}

