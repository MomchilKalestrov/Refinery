namespace Refinery
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabs = new TabControl();
            timetableTab = new TabPage();
            container = new SplitContainer();
            hint = new GroupBox();
            timetableTextBox = new RichTextBox();
            startButton = new Button();
            startShopContainer = new TableLayoutPanel();
            saveTimetableButton = new Button();
            newTimeButton = new Button();
            emergencyButton = new Button();
            settingsTab = new TabPage();
            emergencyTextBox = new TextBox();
            emergencyLabel = new Label();
            endAudioTextBox = new TextBox();
            endAudioLabel = new Label();
            startAudioTextBox = new TextBox();
            startAudioLabel = new Label();
            saveConfigButton = new Button();
            bitsTextBox = new TextBox();
            bitsLabel = new Label();
            baudTextBox = new TextBox();
            baudLabel = new Label();
            portTextBox = new TextBox();
            comPortLabel = new Label();
            creditsTab = new TabPage();
            logsTab = new TabPage();
            logBox = new RichTextBox();
            tabs.SuspendLayout();
            timetableTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)container).BeginInit();
            container.Panel1.SuspendLayout();
            container.Panel2.SuspendLayout();
            container.SuspendLayout();
            hint.SuspendLayout();
            startShopContainer.SuspendLayout();
            settingsTab.SuspendLayout();
            logsTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(timetableTab);
            tabs.Controls.Add(settingsTab);
            tabs.Controls.Add(creditsTab);
            tabs.Controls.Add(logsTab);
            tabs.Dock = DockStyle.Fill;
            tabs.Location = new Point(0, 0);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(272, 489);
            tabs.TabIndex = 0;
            // 
            // timetableTab
            // 
            timetableTab.Controls.Add(container);
            timetableTab.Location = new Point(4, 24);
            timetableTab.Name = "timetableTab";
            timetableTab.Padding = new Padding(3);
            timetableTab.Size = new Size(264, 461);
            timetableTab.TabIndex = 0;
            timetableTab.Text = "Timetables";
            timetableTab.UseVisualStyleBackColor = true;
            // 
            // container
            // 
            container.Dock = DockStyle.Fill;
            container.FixedPanel = FixedPanel.Panel2;
            container.IsSplitterFixed = true;
            container.Location = new Point(3, 3);
            container.Name = "container";
            container.Orientation = Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            container.Panel1.Controls.Add(hint);
            // 
            // container.Panel2
            // 
            container.Panel2.Controls.Add(startButton);
            container.Panel2.Controls.Add(startShopContainer);
            container.Panel2.Controls.Add(emergencyButton);
            container.Size = new Size(258, 455);
            container.SplitterDistance = 380;
            container.SplitterWidth = 1;
            container.TabIndex = 4;
            // 
            // hint
            // 
            hint.Controls.Add(timetableTextBox);
            hint.Dock = DockStyle.Fill;
            hint.Location = new Point(0, 0);
            hint.Margin = new Padding(0);
            hint.Name = "hint";
            hint.Size = new Size(258, 380);
            hint.TabIndex = 0;
            hint.TabStop = false;
            hint.Text = "Schedule";
            // 
            // timetableTextBox
            // 
            timetableTextBox.BorderStyle = BorderStyle.None;
            timetableTextBox.Dock = DockStyle.Fill;
            timetableTextBox.Location = new Point(3, 19);
            timetableTextBox.Name = "timetableTextBox";
            timetableTextBox.Size = new Size(252, 358);
            timetableTextBox.TabIndex = 0;
            timetableTextBox.Text = "";
            timetableTextBox.TextChanged += timetableTextBox_TextChange;
            // 
            // startButton
            // 
            startButton.Dock = DockStyle.Bottom;
            startButton.Location = new Point(0, 5);
            startButton.Margin = new Padding(0);
            startButton.Name = "startButton";
            startButton.Size = new Size(258, 23);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // startShopContainer
            // 
            startShopContainer.ColumnCount = 2;
            startShopContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            startShopContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            startShopContainer.Controls.Add(saveTimetableButton, 0, 0);
            startShopContainer.Controls.Add(newTimeButton, 0, 0);
            startShopContainer.Dock = DockStyle.Bottom;
            startShopContainer.Location = new Point(0, 28);
            startShopContainer.Margin = new Padding(0);
            startShopContainer.Name = "startShopContainer";
            startShopContainer.RowCount = 1;
            startShopContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            startShopContainer.Size = new Size(258, 23);
            startShopContainer.TabIndex = 4;
            // 
            // saveTimetableButton
            // 
            saveTimetableButton.Dock = DockStyle.Fill;
            saveTimetableButton.Location = new Point(129, 0);
            saveTimetableButton.Margin = new Padding(0);
            saveTimetableButton.Name = "saveTimetableButton";
            saveTimetableButton.Size = new Size(129, 23);
            saveTimetableButton.TabIndex = 4;
            saveTimetableButton.Text = "Save to file";
            saveTimetableButton.UseVisualStyleBackColor = true;
            saveTimetableButton.Click += saveTimetableButton_Click;
            // 
            // newTimeButton
            // 
            newTimeButton.Dock = DockStyle.Fill;
            newTimeButton.Location = new Point(0, 0);
            newTimeButton.Margin = new Padding(0);
            newTimeButton.Name = "newTimeButton";
            newTimeButton.Size = new Size(129, 23);
            newTimeButton.TabIndex = 3;
            newTimeButton.Text = "Insert timetable";
            newTimeButton.UseVisualStyleBackColor = true;
            newTimeButton.Click += newTimeButton_Click;
            // 
            // emergencyButton
            // 
            emergencyButton.Dock = DockStyle.Bottom;
            emergencyButton.Location = new Point(0, 51);
            emergencyButton.Name = "emergencyButton";
            emergencyButton.Size = new Size(258, 23);
            emergencyButton.TabIndex = 2;
            emergencyButton.Text = "Emergency";
            emergencyButton.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            settingsTab.Controls.Add(emergencyTextBox);
            settingsTab.Controls.Add(emergencyLabel);
            settingsTab.Controls.Add(endAudioTextBox);
            settingsTab.Controls.Add(endAudioLabel);
            settingsTab.Controls.Add(startAudioTextBox);
            settingsTab.Controls.Add(startAudioLabel);
            settingsTab.Controls.Add(saveConfigButton);
            settingsTab.Controls.Add(bitsTextBox);
            settingsTab.Controls.Add(bitsLabel);
            settingsTab.Controls.Add(baudTextBox);
            settingsTab.Controls.Add(baudLabel);
            settingsTab.Controls.Add(portTextBox);
            settingsTab.Controls.Add(comPortLabel);
            settingsTab.Location = new Point(4, 24);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new Padding(3);
            settingsTab.Size = new Size(264, 461);
            settingsTab.TabIndex = 1;
            settingsTab.Text = "Settings";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // emergencyTextBox
            // 
            emergencyTextBox.Dock = DockStyle.Top;
            emergencyTextBox.Location = new Point(3, 208);
            emergencyTextBox.Name = "emergencyTextBox";
            emergencyTextBox.Size = new Size(258, 23);
            emergencyTextBox.TabIndex = 12;
            // 
            // emergencyLabel
            // 
            emergencyLabel.AutoSize = true;
            emergencyLabel.Dock = DockStyle.Top;
            emergencyLabel.Location = new Point(3, 193);
            emergencyLabel.Name = "emergencyLabel";
            emergencyLabel.Size = new Size(106, 15);
            emergencyLabel.TabIndex = 11;
            emergencyLabel.Text = "Emergency Sound:";
            // 
            // endAudioTextBox
            // 
            endAudioTextBox.Dock = DockStyle.Top;
            endAudioTextBox.Location = new Point(3, 170);
            endAudioTextBox.Name = "endAudioTextBox";
            endAudioTextBox.Size = new Size(258, 23);
            endAudioTextBox.TabIndex = 10;
            // 
            // endAudioLabel
            // 
            endAudioLabel.AutoSize = true;
            endAudioLabel.Dock = DockStyle.Top;
            endAudioLabel.Location = new Point(3, 155);
            endAudioLabel.Name = "endAudioLabel";
            endAudioLabel.Size = new Size(67, 15);
            endAudioLabel.TabIndex = 9;
            endAudioLabel.Text = "End Sound:";
            // 
            // startAudioTextBox
            // 
            startAudioTextBox.Dock = DockStyle.Top;
            startAudioTextBox.Location = new Point(3, 132);
            startAudioTextBox.Name = "startAudioTextBox";
            startAudioTextBox.Size = new Size(258, 23);
            startAudioTextBox.TabIndex = 8;
            // 
            // startAudioLabel
            // 
            startAudioLabel.AutoSize = true;
            startAudioLabel.Dock = DockStyle.Top;
            startAudioLabel.Location = new Point(3, 117);
            startAudioLabel.Name = "startAudioLabel";
            startAudioLabel.Size = new Size(71, 15);
            startAudioLabel.TabIndex = 7;
            startAudioLabel.Text = "Start Sound:";
            // 
            // saveConfigButton
            // 
            saveConfigButton.Dock = DockStyle.Bottom;
            saveConfigButton.Location = new Point(3, 435);
            saveConfigButton.Name = "saveConfigButton";
            saveConfigButton.Size = new Size(258, 23);
            saveConfigButton.TabIndex = 6;
            saveConfigButton.Text = "Save";
            saveConfigButton.UseVisualStyleBackColor = true;
            saveConfigButton.Click += saveConfigButton_Click;
            // 
            // bitsTextBox
            // 
            bitsTextBox.Dock = DockStyle.Top;
            bitsTextBox.Location = new Point(3, 94);
            bitsTextBox.Name = "bitsTextBox";
            bitsTextBox.Size = new Size(258, 23);
            bitsTextBox.TabIndex = 3;
            // 
            // bitsLabel
            // 
            bitsLabel.AutoSize = true;
            bitsLabel.Dock = DockStyle.Top;
            bitsLabel.Location = new Point(3, 79);
            bitsLabel.Name = "bitsLabel";
            bitsLabel.Size = new Size(56, 15);
            bitsLabel.TabIndex = 1;
            bitsLabel.Text = "Data Bits:";
            // 
            // baudTextBox
            // 
            baudTextBox.Dock = DockStyle.Top;
            baudTextBox.Location = new Point(3, 56);
            baudTextBox.Name = "baudTextBox";
            baudTextBox.Size = new Size(258, 23);
            baudTextBox.TabIndex = 4;
            // 
            // baudLabel
            // 
            baudLabel.AutoSize = true;
            baudLabel.Dock = DockStyle.Top;
            baudLabel.Location = new Point(3, 41);
            baudLabel.Name = "baudLabel";
            baudLabel.Size = new Size(37, 15);
            baudLabel.TabIndex = 0;
            baudLabel.Text = "Baud:";
            // 
            // portTextBox
            // 
            portTextBox.Dock = DockStyle.Top;
            portTextBox.Location = new Point(3, 18);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(258, 23);
            portTextBox.TabIndex = 5;
            // 
            // comPortLabel
            // 
            comPortLabel.AutoSize = true;
            comPortLabel.Dock = DockStyle.Top;
            comPortLabel.Location = new Point(3, 3);
            comPortLabel.Name = "comPortLabel";
            comPortLabel.Size = new Size(63, 15);
            comPortLabel.TabIndex = 2;
            comPortLabel.Text = "COM Port:";
            // 
            // creditsTab
            // 
            creditsTab.Location = new Point(4, 24);
            creditsTab.Name = "creditsTab";
            creditsTab.Padding = new Padding(3);
            creditsTab.Size = new Size(264, 461);
            creditsTab.TabIndex = 2;
            creditsTab.Text = "Credits";
            creditsTab.UseVisualStyleBackColor = true;
            // 
            // logsTab
            // 
            logsTab.Controls.Add(logBox);
            logsTab.Location = new Point(4, 24);
            logsTab.Name = "logsTab";
            logsTab.Padding = new Padding(3);
            logsTab.Size = new Size(264, 461);
            logsTab.TabIndex = 3;
            logsTab.Text = "Logs";
            logsTab.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            logBox.BackColor = Color.White;
            logBox.BorderStyle = BorderStyle.None;
            logBox.Dock = DockStyle.Fill;
            logBox.Location = new Point(3, 3);
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.Size = new Size(258, 455);
            logBox.TabIndex = 0;
            logBox.Text = "";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 489);
            Controls.Add(tabs);
            Name = "Main";
            Text = "Refinery";
            tabs.ResumeLayout(false);
            timetableTab.ResumeLayout(false);
            container.Panel1.ResumeLayout(false);
            container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)container).EndInit();
            container.ResumeLayout(false);
            hint.ResumeLayout(false);
            startShopContainer.ResumeLayout(false);
            settingsTab.ResumeLayout(false);
            settingsTab.PerformLayout();
            logsTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabs;
        private TabPage timetableTab;
        private TabPage settingsTab;
        private TabPage creditsTab;
        private Button newTimeButton;
        private Button emergencyButton;
        private SplitContainer container;
        private GroupBox hint;
        private RichTextBox timetableTextBox;
        private TableLayoutPanel startShopContainer;
        private Button startButton;
        private TabPage logsTab;
        private RichTextBox logBox;
        private TextBox bitsTextBox;
        private Label bitsLabel;
        private TextBox baudTextBox;
        private Label baudLabel;
        private TextBox portTextBox;
        private Label comPortLabel;
        private Button saveConfigButton;
        private TextBox endAudioTextBox;
        private Label endAudioLabel;
        private TextBox startAudioTextBox;
        private Label startAudioLabel;
        private TextBox emergencyTextBox;
        private Label emergencyLabel;
        private Button saveTimetableButton;
    }
}
