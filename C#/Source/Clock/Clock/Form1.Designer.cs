namespace Clock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_presets = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ISOwithSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_ISOwithT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_suitableForFilenames = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_europeanShort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_europeanNumerical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_britishMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_britishFull = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_americanShort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_americanNumerical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_americanMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_americanFull = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_chinese = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_hungarian = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_vietnamese = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_displayDate = new System.Windows.Forms.ComboBox();
            this.label_outputDateTime = new System.Windows.Forms.Label();
            this.groupBox_dateOrder = new System.Windows.Forms.GroupBox();
            this.radioButton_mdy = new System.Windows.Forms.RadioButton();
            this.radioButton_dmy = new System.Windows.Forms.RadioButton();
            this.radioButton_ymd = new System.Windows.Forms.RadioButton();
            this.groupBox_yearFormat = new System.Windows.Forms.GroupBox();
            this.radioButton_year2digit = new System.Windows.Forms.RadioButton();
            this.radioButton_year4digit = new System.Windows.Forms.RadioButton();
            this.groupBox_monthFormat = new System.Windows.Forms.GroupBox();
            this.button_customizeMonthFormat = new System.Windows.Forms.Button();
            this.radioButton_monthFormat_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_monthFormat_full = new System.Windows.Forms.RadioButton();
            this.radioButton_monthFormat_3letter = new System.Windows.Forms.RadioButton();
            this.radioButton_monthFormat_withLeadingZero = new System.Windows.Forms.RadioButton();
            this.radioButton_monthFormat_withoutLeadingZero = new System.Windows.Forms.RadioButton();
            this.groupBox_dayFormat = new System.Windows.Forms.GroupBox();
            this.radioButton_dayFormat_ordinal = new System.Windows.Forms.RadioButton();
            this.radioButton_dayFormat_withLeadingZero = new System.Windows.Forms.RadioButton();
            this.radioButton_dayFormat_withoutLeadingZero = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep1_hyphen = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep1_dot = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep1_slash = new System.Windows.Forms.RadioButton();
            this.groupBox_dateSep1 = new System.Windows.Forms.GroupBox();
            this.textBox_dateSep1_custom = new System.Windows.Forms.TextBox();
            this.radioButton_dateSep1_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep1_underscore = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep1_none = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep1_dotSpace = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep1_commaSpace = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep1_space = new System.Windows.Forms.RadioButton();
            this.groupBox_dateSep2 = new System.Windows.Forms.GroupBox();
            this.checkBox_dateSep2_sameAsDateSep1 = new System.Windows.Forms.CheckBox();
            this.textBox_dateSep2_custom = new System.Windows.Forms.TextBox();
            this.radioButton_dateSep2_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep2_underscore = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep2_none = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep2_dotSpace = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep2_commaSpace = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep2_space = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep2_slash = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep2_dot = new System.Windows.Forms.RadioButton();
            this.radioButton_dateSep2_hyphen = new System.Windows.Forms.RadioButton();
            this.groupBox_weekday = new System.Windows.Forms.GroupBox();
            this.checkBox_showWeekday = new System.Windows.Forms.CheckBox();
            this.radioButton_weekdayAfterDate = new System.Windows.Forms.RadioButton();
            this.radioButton_weekdayBeforeDate = new System.Windows.Forms.RadioButton();
            this.groupBox_weekdaySep = new System.Windows.Forms.GroupBox();
            this.textBox_weekdaySep_custom = new System.Windows.Forms.TextBox();
            this.radioButton_weekdaySep_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_weekdaySep_underscore = new System.Windows.Forms.RadioButton();
            this.radioButton_weekdaySep_none = new System.Windows.Forms.RadioButton();
            this.radioButton_weekdaySep_dot = new System.Windows.Forms.RadioButton();
            this.radioButton_weekdaySep_dotSpace = new System.Windows.Forms.RadioButton();
            this.radioButton_weekdaySep_commaSpace = new System.Windows.Forms.RadioButton();
            this.radioButton_weekdaySep_space = new System.Windows.Forms.RadioButton();
            this.radioButton_weekdaySep_hyphen = new System.Windows.Forms.RadioButton();
            this.groupBox_dateTimeSep = new System.Windows.Forms.GroupBox();
            this.textBox_dateTimeSep_custom = new System.Windows.Forms.TextBox();
            this.radioButton_dateTimeSep_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_dateTimeSep_underscore = new System.Windows.Forms.RadioButton();
            this.radioButton_dateTimeSep_none = new System.Windows.Forms.RadioButton();
            this.radioButton_dateTimeSep_dot = new System.Windows.Forms.RadioButton();
            this.radioButton_dateTimeSep_t = new System.Windows.Forms.RadioButton();
            this.radioButton_dateTimeSep_commaSpace = new System.Windows.Forms.RadioButton();
            this.radioButton_dateTimeSep_space = new System.Windows.Forms.RadioButton();
            this.radioButton_dateTimeSep_hyphen = new System.Windows.Forms.RadioButton();
            this.groupBox_timeFormat = new System.Windows.Forms.GroupBox();
            this.checkBox_showSeconds = new System.Windows.Forms.CheckBox();
            this.checkBox_zeroPadHour = new System.Windows.Forms.CheckBox();
            this.radioButton_timeFormat_1_12amPmLast = new System.Windows.Forms.RadioButton();
            this.radioButton_timeFormat_0_11amPmLast = new System.Windows.Forms.RadioButton();
            this.radioButton_timeFormat_1_12amPmFirst = new System.Windows.Forms.RadioButton();
            this.radioButton_timeFormat_0_11amPmFirst = new System.Windows.Forms.RadioButton();
            this.radioButton_timeFormat_1_24 = new System.Windows.Forms.RadioButton();
            this.radioButton_timeFormat_0_23 = new System.Windows.Forms.RadioButton();
            this.groupBox_hrMinSep = new System.Windows.Forms.GroupBox();
            this.textBox_hrMinSep_custom = new System.Windows.Forms.TextBox();
            this.radioButton_hrMinSep_space = new System.Windows.Forms.RadioButton();
            this.radioButton_hrMinSep_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_hrMinSep_none = new System.Windows.Forms.RadioButton();
            this.radioButton_hrMinSep_hyphen = new System.Windows.Forms.RadioButton();
            this.radioButton_hrMinSep_dot = new System.Windows.Forms.RadioButton();
            this.radioButton_hrMinSep_colon = new System.Windows.Forms.RadioButton();
            this.groupBox_minSecSep = new System.Windows.Forms.GroupBox();
            this.checkBox_minSecSep_sameAsHrMin = new System.Windows.Forms.CheckBox();
            this.textBox_minSecSep_custom = new System.Windows.Forms.TextBox();
            this.radioButton_minSecSep_space = new System.Windows.Forms.RadioButton();
            this.radioButton_minSecSep_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_minSecSep_none = new System.Windows.Forms.RadioButton();
            this.radioButton_minSecSep_hyphen = new System.Windows.Forms.RadioButton();
            this.radioButton_minSecSep_dot = new System.Windows.Forms.RadioButton();
            this.radioButton_minSecSep_colon = new System.Windows.Forms.RadioButton();
            this.groupBox_amPmFormat = new System.Windows.Forms.GroupBox();
            this.label_pmCustom = new System.Windows.Forms.Label();
            this.label_amCustom = new System.Windows.Forms.Label();
            this.textBox_pmCustom = new System.Windows.Forms.TextBox();
            this.textBox_amCustom = new System.Windows.Forms.TextBox();
            this.radioButton_amPmLowercaseDots = new System.Windows.Forms.RadioButton();
            this.radioButton_amPmCustom = new System.Windows.Forms.RadioButton();
            this.radioButton_ap_lowercase = new System.Windows.Forms.RadioButton();
            this.radioButton_ap_capital = new System.Windows.Forms.RadioButton();
            this.radioButton_amPmCapitalDots = new System.Windows.Forms.RadioButton();
            this.radioButton_amPmLowercase = new System.Windows.Forms.RadioButton();
            this.radioButton_amPmCapital = new System.Windows.Forms.RadioButton();
            this.groupBox_amPmSep = new System.Windows.Forms.GroupBox();
            this.textBox_amPmSep_custom = new System.Windows.Forms.TextBox();
            this.radioButton_amPmSep_dot = new System.Windows.Forms.RadioButton();
            this.radioButton_amPmSep_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_amPmSep_underscore = new System.Windows.Forms.RadioButton();
            this.radioButton_amPmSep_none = new System.Windows.Forms.RadioButton();
            this.radioButton_amPmSep_space = new System.Windows.Forms.RadioButton();
            this.groupBox_dateEndChar = new System.Windows.Forms.GroupBox();
            this.textBox_dateEndChar_custom = new System.Windows.Forms.TextBox();
            this.radioButton_dateEndChar_custom = new System.Windows.Forms.RadioButton();
            this.radioButton_dateEndChar_dot = new System.Windows.Forms.RadioButton();
            this.radioButton_dateEndChar_none = new System.Windows.Forms.RadioButton();
            this.groupBox_showDateTime = new System.Windows.Forms.GroupBox();
            this.radioButton_timeOnly = new System.Windows.Forms.RadioButton();
            this.radioButton_dateOnly = new System.Windows.Forms.RadioButton();
            this.radioButton_timeThenDate = new System.Windows.Forms.RadioButton();
            this.radioButton_dateThenTime = new System.Windows.Forms.RadioButton();
            this.groupBox_dateTime = new System.Windows.Forms.GroupBox();
            this.groupBox_date = new System.Windows.Forms.GroupBox();
            this.groupBox_weekdayFormat = new System.Windows.Forms.GroupBox();
            this.button_customizeWeekdayFormat = new System.Windows.Forms.Button();
            this.radioButton_customWeekday = new System.Windows.Forms.RadioButton();
            this.radioButton_weekdayFull = new System.Windows.Forms.RadioButton();
            this.radioButton_weekday_3letter = new System.Windows.Forms.RadioButton();
            this.groupBox_time = new System.Windows.Forms.GroupBox();
            this.button_copyDateTime = new System.Windows.Forms.Button();
            this.button_saveDateTimeToFile = new System.Windows.Forms.Button();
            this.checkBox_showDateInTitle = new System.Windows.Forms.CheckBox();
            this.checkBox_loadSettings = new System.Windows.Forms.CheckBox();
            this.button_savePreset = new System.Windows.Forms.Button();
            this.button_changeCustomDateTime = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_deletePreset = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.groupBox_dateOrder.SuspendLayout();
            this.groupBox_yearFormat.SuspendLayout();
            this.groupBox_monthFormat.SuspendLayout();
            this.groupBox_dayFormat.SuspendLayout();
            this.groupBox_dateSep1.SuspendLayout();
            this.groupBox_dateSep2.SuspendLayout();
            this.groupBox_weekday.SuspendLayout();
            this.groupBox_weekdaySep.SuspendLayout();
            this.groupBox_dateTimeSep.SuspendLayout();
            this.groupBox_timeFormat.SuspendLayout();
            this.groupBox_hrMinSep.SuspendLayout();
            this.groupBox_minSecSep.SuspendLayout();
            this.groupBox_amPmFormat.SuspendLayout();
            this.groupBox_amPmSep.SuspendLayout();
            this.groupBox_dateEndChar.SuspendLayout();
            this.groupBox_showDateTime.SuspendLayout();
            this.groupBox_dateTime.SuspendLayout();
            this.groupBox_date.SuspendLayout();
            this.groupBox_weekdayFormat.SuspendLayout();
            this.groupBox_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_presets});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem_presets
            // 
            this.toolStripMenuItem_presets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ISOwithSpace,
            this.toolStripMenuItem_ISOwithT,
            this.toolStripMenuItem_suitableForFilenames,
            this.toolStripMenuItem_europeanShort,
            this.toolStripMenuItem_europeanNumerical,
            this.toolStripMenuItem_britishMedium,
            this.toolStripMenuItem_britishFull,
            this.toolStripMenuItem_americanShort,
            this.toolStripMenuItem_americanNumerical,
            this.toolStripMenuItem_americanMedium,
            this.toolStripMenuItem_americanFull,
            this.toolStripMenuItem_chinese,
            this.toolStripMenuItem_hungarian,
            this.toolStripMenuItem_vietnamese});
            this.toolStripMenuItem_presets.Name = "toolStripMenuItem_presets";
            this.toolStripMenuItem_presets.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem_presets.Text = "Presets";
            this.toolStripMenuItem_presets.Click += new System.EventHandler(this.toolStripMenuItem_presets_Click);
            // 
            // toolStripMenuItem_ISOwithSpace
            // 
            this.toolStripMenuItem_ISOwithSpace.Name = "toolStripMenuItem_ISOwithSpace";
            this.toolStripMenuItem_ISOwithSpace.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_ISOwithSpace.Text = "ISO 8601 with space";
            this.toolStripMenuItem_ISOwithSpace.Click += new System.EventHandler(this.toolStripMenuItem_ISOwithSpace_Click);
            // 
            // toolStripMenuItem_ISOwithT
            // 
            this.toolStripMenuItem_ISOwithT.Name = "toolStripMenuItem_ISOwithT";
            this.toolStripMenuItem_ISOwithT.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_ISOwithT.Text = "ISO 8601 with T";
            this.toolStripMenuItem_ISOwithT.Click += new System.EventHandler(this.toolStripMenuItem_ISOwithT_Click);
            // 
            // toolStripMenuItem_suitableForFilenames
            // 
            this.toolStripMenuItem_suitableForFilenames.Name = "toolStripMenuItem_suitableForFilenames";
            this.toolStripMenuItem_suitableForFilenames.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_suitableForFilenames.Text = "Suitable for filenames";
            this.toolStripMenuItem_suitableForFilenames.Click += new System.EventHandler(this.toolStripMenuItem_suitableForFilenames_Click);
            // 
            // toolStripMenuItem_europeanShort
            // 
            this.toolStripMenuItem_europeanShort.Name = "toolStripMenuItem_europeanShort";
            this.toolStripMenuItem_europeanShort.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_europeanShort.Text = "European short";
            this.toolStripMenuItem_europeanShort.Click += new System.EventHandler(this.toolStripMenuItem_europeanShort_Click);
            // 
            // toolStripMenuItem_europeanNumerical
            // 
            this.toolStripMenuItem_europeanNumerical.Name = "toolStripMenuItem_europeanNumerical";
            this.toolStripMenuItem_europeanNumerical.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_europeanNumerical.Text = "European numerical";
            this.toolStripMenuItem_europeanNumerical.Click += new System.EventHandler(this.toolStripMenuItem_europeanNumerical_Click);
            // 
            // toolStripMenuItem_britishMedium
            // 
            this.toolStripMenuItem_britishMedium.Name = "toolStripMenuItem_britishMedium";
            this.toolStripMenuItem_britishMedium.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_britishMedium.Text = "British medium";
            this.toolStripMenuItem_britishMedium.Click += new System.EventHandler(this.toolStripMenuItem_britishMedium_Click);
            // 
            // toolStripMenuItem_britishFull
            // 
            this.toolStripMenuItem_britishFull.Name = "toolStripMenuItem_britishFull";
            this.toolStripMenuItem_britishFull.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_britishFull.Text = "British full";
            this.toolStripMenuItem_britishFull.Click += new System.EventHandler(this.toolStripMenuItem_britishFull_Click);
            // 
            // toolStripMenuItem_americanShort
            // 
            this.toolStripMenuItem_americanShort.Name = "toolStripMenuItem_americanShort";
            this.toolStripMenuItem_americanShort.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_americanShort.Text = "American short";
            this.toolStripMenuItem_americanShort.Click += new System.EventHandler(this.toolStripMenuItem_americanShort_Click);
            // 
            // toolStripMenuItem_americanNumerical
            // 
            this.toolStripMenuItem_americanNumerical.Name = "toolStripMenuItem_americanNumerical";
            this.toolStripMenuItem_americanNumerical.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_americanNumerical.Text = "American numerical";
            this.toolStripMenuItem_americanNumerical.Click += new System.EventHandler(this.toolStripMenuItem_americanNumerical_Click);
            // 
            // toolStripMenuItem_americanMedium
            // 
            this.toolStripMenuItem_americanMedium.Name = "toolStripMenuItem_americanMedium";
            this.toolStripMenuItem_americanMedium.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_americanMedium.Text = "American medium";
            this.toolStripMenuItem_americanMedium.Click += new System.EventHandler(this.toolStripMenuItem_americanMedium_Click);
            // 
            // toolStripMenuItem_americanFull
            // 
            this.toolStripMenuItem_americanFull.Name = "toolStripMenuItem_americanFull";
            this.toolStripMenuItem_americanFull.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_americanFull.Text = "American full";
            this.toolStripMenuItem_americanFull.Click += new System.EventHandler(this.toolStripMenuItem_americanFull_Click);
            // 
            // toolStripMenuItem_chinese
            // 
            this.toolStripMenuItem_chinese.Name = "toolStripMenuItem_chinese";
            this.toolStripMenuItem_chinese.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_chinese.Text = "Chinese";
            this.toolStripMenuItem_chinese.Click += new System.EventHandler(this.toolStripMenuItem_chinese_Click);
            // 
            // toolStripMenuItem_hungarian
            // 
            this.toolStripMenuItem_hungarian.Name = "toolStripMenuItem_hungarian";
            this.toolStripMenuItem_hungarian.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_hungarian.Text = "Hungarian";
            this.toolStripMenuItem_hungarian.Click += new System.EventHandler(this.toolStripMenuItem_hungarian_Click);
            // 
            // toolStripMenuItem_vietnamese
            // 
            this.toolStripMenuItem_vietnamese.Name = "toolStripMenuItem_vietnamese";
            this.toolStripMenuItem_vietnamese.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem_vietnamese.Text = "Vietnamese";
            this.toolStripMenuItem_vietnamese.Click += new System.EventHandler(this.toolStripMenuItem_vietnamese_Click);
            // 
            // comboBox_displayDate
            // 
            this.comboBox_displayDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_displayDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_displayDate.FormattingEnabled = true;
            this.comboBox_displayDate.Items.AddRange(new object[] {
            "Display current date/time",
            "Enter custom date/time"});
            this.comboBox_displayDate.Location = new System.Drawing.Point(837, 3);
            this.comboBox_displayDate.Name = "comboBox_displayDate";
            this.comboBox_displayDate.Size = new System.Drawing.Size(203, 21);
            this.comboBox_displayDate.TabIndex = 22;
            this.comboBox_displayDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_displayDate_SelectedIndexChanged);
            // 
            // label_outputDateTime
            // 
            this.label_outputDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_outputDateTime.AutoSize = true;
            this.label_outputDateTime.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputDateTime.Location = new System.Drawing.Point(232, 42);
            this.label_outputDateTime.Name = "label_outputDateTime";
            this.label_outputDateTime.Size = new System.Drawing.Size(642, 40);
            this.label_outputDateTime.TabIndex = 2;
            this.label_outputDateTime.Text = "Tuesday, December 5, 2023, 8:15:38 PM";
            this.label_outputDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_dateOrder
            // 
            this.groupBox_dateOrder.Controls.Add(this.radioButton_mdy);
            this.groupBox_dateOrder.Controls.Add(this.radioButton_dmy);
            this.groupBox_dateOrder.Controls.Add(this.radioButton_ymd);
            this.groupBox_dateOrder.Location = new System.Drawing.Point(6, 19);
            this.groupBox_dateOrder.Name = "groupBox_dateOrder";
            this.groupBox_dateOrder.Size = new System.Drawing.Size(175, 88);
            this.groupBox_dateOrder.TabIndex = 2;
            this.groupBox_dateOrder.TabStop = false;
            this.groupBox_dateOrder.Text = "Date order";
            // 
            // radioButton_mdy
            // 
            this.radioButton_mdy.AutoSize = true;
            this.radioButton_mdy.Location = new System.Drawing.Point(6, 65);
            this.radioButton_mdy.Name = "radioButton_mdy";
            this.radioButton_mdy.Size = new System.Drawing.Size(102, 17);
            this.radioButton_mdy.TabIndex = 2;
            this.radioButton_mdy.Text = "Month-Day-Year";
            this.radioButton_mdy.UseVisualStyleBackColor = true;
            this.radioButton_mdy.CheckedChanged += new System.EventHandler(this.radioButton_mdy_CheckedChanged);
            // 
            // radioButton_dmy
            // 
            this.radioButton_dmy.AutoSize = true;
            this.radioButton_dmy.Location = new System.Drawing.Point(6, 42);
            this.radioButton_dmy.Name = "radioButton_dmy";
            this.radioButton_dmy.Size = new System.Drawing.Size(102, 17);
            this.radioButton_dmy.TabIndex = 1;
            this.radioButton_dmy.Text = "Day-Month-Year";
            this.radioButton_dmy.UseVisualStyleBackColor = true;
            this.radioButton_dmy.CheckedChanged += new System.EventHandler(this.radioButton_dmy_CheckedChanged);
            // 
            // radioButton_ymd
            // 
            this.radioButton_ymd.AutoSize = true;
            this.radioButton_ymd.Checked = true;
            this.radioButton_ymd.Location = new System.Drawing.Point(6, 19);
            this.radioButton_ymd.Name = "radioButton_ymd";
            this.radioButton_ymd.Size = new System.Drawing.Size(102, 17);
            this.radioButton_ymd.TabIndex = 0;
            this.radioButton_ymd.TabStop = true;
            this.radioButton_ymd.Text = "Year-Month-Day";
            this.radioButton_ymd.UseVisualStyleBackColor = true;
            this.radioButton_ymd.CheckedChanged += new System.EventHandler(this.radioButton_ymd_CheckedChanged);
            // 
            // groupBox_yearFormat
            // 
            this.groupBox_yearFormat.Controls.Add(this.radioButton_year2digit);
            this.groupBox_yearFormat.Controls.Add(this.radioButton_year4digit);
            this.groupBox_yearFormat.Location = new System.Drawing.Point(6, 114);
            this.groupBox_yearFormat.Name = "groupBox_yearFormat";
            this.groupBox_yearFormat.Size = new System.Drawing.Size(175, 66);
            this.groupBox_yearFormat.TabIndex = 3;
            this.groupBox_yearFormat.TabStop = false;
            this.groupBox_yearFormat.Text = "Year format";
            // 
            // radioButton_year2digit
            // 
            this.radioButton_year2digit.AutoSize = true;
            this.radioButton_year2digit.Location = new System.Drawing.Point(6, 42);
            this.radioButton_year2digit.Name = "radioButton_year2digit";
            this.radioButton_year2digit.Size = new System.Drawing.Size(53, 17);
            this.radioButton_year2digit.TabIndex = 1;
            this.radioButton_year2digit.Text = "2-digit";
            this.radioButton_year2digit.UseVisualStyleBackColor = true;
            this.radioButton_year2digit.CheckedChanged += new System.EventHandler(this.radioButton_year2digit_CheckedChanged);
            // 
            // radioButton_year4digit
            // 
            this.radioButton_year4digit.AutoSize = true;
            this.radioButton_year4digit.Checked = true;
            this.radioButton_year4digit.Location = new System.Drawing.Point(6, 19);
            this.radioButton_year4digit.Name = "radioButton_year4digit";
            this.radioButton_year4digit.Size = new System.Drawing.Size(53, 17);
            this.radioButton_year4digit.TabIndex = 0;
            this.radioButton_year4digit.TabStop = true;
            this.radioButton_year4digit.Text = "4-digit";
            this.radioButton_year4digit.UseVisualStyleBackColor = true;
            this.radioButton_year4digit.CheckedChanged += new System.EventHandler(this.radioButton_year4digit_CheckedChanged);
            // 
            // groupBox_monthFormat
            // 
            this.groupBox_monthFormat.Controls.Add(this.button_customizeMonthFormat);
            this.groupBox_monthFormat.Controls.Add(this.radioButton_monthFormat_custom);
            this.groupBox_monthFormat.Controls.Add(this.radioButton_monthFormat_full);
            this.groupBox_monthFormat.Controls.Add(this.radioButton_monthFormat_3letter);
            this.groupBox_monthFormat.Controls.Add(this.radioButton_monthFormat_withLeadingZero);
            this.groupBox_monthFormat.Controls.Add(this.radioButton_monthFormat_withoutLeadingZero);
            this.groupBox_monthFormat.Location = new System.Drawing.Point(6, 186);
            this.groupBox_monthFormat.Name = "groupBox_monthFormat";
            this.groupBox_monthFormat.Size = new System.Drawing.Size(176, 137);
            this.groupBox_monthFormat.TabIndex = 4;
            this.groupBox_monthFormat.TabStop = false;
            this.groupBox_monthFormat.Text = "Month format";
            // 
            // button_customizeMonthFormat
            // 
            this.button_customizeMonthFormat.Enabled = false;
            this.button_customizeMonthFormat.Location = new System.Drawing.Point(85, 108);
            this.button_customizeMonthFormat.Name = "button_customizeMonthFormat";
            this.button_customizeMonthFormat.Size = new System.Drawing.Size(75, 23);
            this.button_customizeMonthFormat.TabIndex = 5;
            this.button_customizeMonthFormat.Text = "Customize...";
            this.button_customizeMonthFormat.UseVisualStyleBackColor = true;
            this.button_customizeMonthFormat.Click += new System.EventHandler(this.button_customizeMonthFormat_Click);
            // 
            // radioButton_monthFormat_custom
            // 
            this.radioButton_monthFormat_custom.AutoSize = true;
            this.radioButton_monthFormat_custom.Location = new System.Drawing.Point(6, 111);
            this.radioButton_monthFormat_custom.Name = "radioButton_monthFormat_custom";
            this.radioButton_monthFormat_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_monthFormat_custom.TabIndex = 4;
            this.radioButton_monthFormat_custom.Text = "Custom:";
            this.radioButton_monthFormat_custom.UseVisualStyleBackColor = true;
            this.radioButton_monthFormat_custom.CheckedChanged += new System.EventHandler(this.radioButton_monthFormat_custom_CheckedChanged);
            // 
            // radioButton_monthFormat_full
            // 
            this.radioButton_monthFormat_full.AutoSize = true;
            this.radioButton_monthFormat_full.Location = new System.Drawing.Point(6, 88);
            this.radioButton_monthFormat_full.Name = "radioButton_monthFormat_full";
            this.radioButton_monthFormat_full.Size = new System.Drawing.Size(75, 17);
            this.radioButton_monthFormat_full.TabIndex = 3;
            this.radioButton_monthFormat_full.Text = "English full";
            this.radioButton_monthFormat_full.UseVisualStyleBackColor = true;
            this.radioButton_monthFormat_full.CheckedChanged += new System.EventHandler(this.radioButton_monthFormat_full_CheckedChanged);
            // 
            // radioButton_monthFormat_3letter
            // 
            this.radioButton_monthFormat_3letter.AutoSize = true;
            this.radioButton_monthFormat_3letter.Location = new System.Drawing.Point(6, 65);
            this.radioButton_monthFormat_3letter.Name = "radioButton_monthFormat_3letter";
            this.radioButton_monthFormat_3letter.Size = new System.Drawing.Size(94, 17);
            this.radioButton_monthFormat_3letter.TabIndex = 2;
            this.radioButton_monthFormat_3letter.Text = "English 3-letter";
            this.radioButton_monthFormat_3letter.UseVisualStyleBackColor = true;
            this.radioButton_monthFormat_3letter.CheckedChanged += new System.EventHandler(this.radioButton_monthFormat_3letter_CheckedChanged);
            // 
            // radioButton_monthFormat_withLeadingZero
            // 
            this.radioButton_monthFormat_withLeadingZero.AutoSize = true;
            this.radioButton_monthFormat_withLeadingZero.Checked = true;
            this.radioButton_monthFormat_withLeadingZero.Location = new System.Drawing.Point(6, 42);
            this.radioButton_monthFormat_withLeadingZero.Name = "radioButton_monthFormat_withLeadingZero";
            this.radioButton_monthFormat_withLeadingZero.Size = new System.Drawing.Size(154, 17);
            this.radioButton_monthFormat_withLeadingZero.TabIndex = 1;
            this.radioButton_monthFormat_withLeadingZero.TabStop = true;
            this.radioButton_monthFormat_withLeadingZero.Text = "Numerical with leading-zero";
            this.radioButton_monthFormat_withLeadingZero.UseVisualStyleBackColor = true;
            this.radioButton_monthFormat_withLeadingZero.CheckedChanged += new System.EventHandler(this.radioButton_monthFormat_withLeadingZero_CheckedChanged);
            // 
            // radioButton_monthFormat_withoutLeadingZero
            // 
            this.radioButton_monthFormat_withoutLeadingZero.AutoSize = true;
            this.radioButton_monthFormat_withoutLeadingZero.Location = new System.Drawing.Point(6, 19);
            this.radioButton_monthFormat_withoutLeadingZero.Name = "radioButton_monthFormat_withoutLeadingZero";
            this.radioButton_monthFormat_withoutLeadingZero.Size = new System.Drawing.Size(169, 17);
            this.radioButton_monthFormat_withoutLeadingZero.TabIndex = 0;
            this.radioButton_monthFormat_withoutLeadingZero.Text = "Numerical without leading-zero";
            this.radioButton_monthFormat_withoutLeadingZero.UseVisualStyleBackColor = true;
            this.radioButton_monthFormat_withoutLeadingZero.CheckedChanged += new System.EventHandler(this.radioButton_monthFormat_withoutLeadingZero_CheckedChanged);
            // 
            // groupBox_dayFormat
            // 
            this.groupBox_dayFormat.Controls.Add(this.radioButton_dayFormat_ordinal);
            this.groupBox_dayFormat.Controls.Add(this.radioButton_dayFormat_withLeadingZero);
            this.groupBox_dayFormat.Controls.Add(this.radioButton_dayFormat_withoutLeadingZero);
            this.groupBox_dayFormat.Location = new System.Drawing.Point(6, 329);
            this.groupBox_dayFormat.Name = "groupBox_dayFormat";
            this.groupBox_dayFormat.Size = new System.Drawing.Size(176, 87);
            this.groupBox_dayFormat.TabIndex = 5;
            this.groupBox_dayFormat.TabStop = false;
            this.groupBox_dayFormat.Text = "Day format";
            // 
            // radioButton_dayFormat_ordinal
            // 
            this.radioButton_dayFormat_ordinal.AutoSize = true;
            this.radioButton_dayFormat_ordinal.Location = new System.Drawing.Point(6, 65);
            this.radioButton_dayFormat_ordinal.Name = "radioButton_dayFormat_ordinal";
            this.radioButton_dayFormat_ordinal.Size = new System.Drawing.Size(58, 17);
            this.radioButton_dayFormat_ordinal.TabIndex = 2;
            this.radioButton_dayFormat_ordinal.Text = "Ordinal";
            this.radioButton_dayFormat_ordinal.UseVisualStyleBackColor = true;
            this.radioButton_dayFormat_ordinal.CheckedChanged += new System.EventHandler(this.radioButton_dayFormat_ordinal_CheckedChanged);
            // 
            // radioButton_dayFormat_withLeadingZero
            // 
            this.radioButton_dayFormat_withLeadingZero.AutoSize = true;
            this.radioButton_dayFormat_withLeadingZero.Checked = true;
            this.radioButton_dayFormat_withLeadingZero.Location = new System.Drawing.Point(6, 42);
            this.radioButton_dayFormat_withLeadingZero.Name = "radioButton_dayFormat_withLeadingZero";
            this.radioButton_dayFormat_withLeadingZero.Size = new System.Drawing.Size(107, 17);
            this.radioButton_dayFormat_withLeadingZero.TabIndex = 1;
            this.radioButton_dayFormat_withLeadingZero.TabStop = true;
            this.radioButton_dayFormat_withLeadingZero.Text = "With leading-zero";
            this.radioButton_dayFormat_withLeadingZero.UseVisualStyleBackColor = true;
            this.radioButton_dayFormat_withLeadingZero.CheckedChanged += new System.EventHandler(this.radioButton_dayFormat_withLeadingZero_CheckedChanged);
            // 
            // radioButton_dayFormat_withoutLeadingZero
            // 
            this.radioButton_dayFormat_withoutLeadingZero.AutoSize = true;
            this.radioButton_dayFormat_withoutLeadingZero.Location = new System.Drawing.Point(6, 19);
            this.radioButton_dayFormat_withoutLeadingZero.Name = "radioButton_dayFormat_withoutLeadingZero";
            this.radioButton_dayFormat_withoutLeadingZero.Size = new System.Drawing.Size(122, 17);
            this.radioButton_dayFormat_withoutLeadingZero.TabIndex = 0;
            this.radioButton_dayFormat_withoutLeadingZero.Text = "Without leading-zero";
            this.radioButton_dayFormat_withoutLeadingZero.UseVisualStyleBackColor = true;
            this.radioButton_dayFormat_withoutLeadingZero.CheckedChanged += new System.EventHandler(this.radioButton_dayFormat_withoutLeadingZero_CheckedChanged);
            // 
            // radioButton_dateSep1_hyphen
            // 
            this.radioButton_dateSep1_hyphen.AutoSize = true;
            this.radioButton_dateSep1_hyphen.Checked = true;
            this.radioButton_dateSep1_hyphen.Location = new System.Drawing.Point(6, 19);
            this.radioButton_dateSep1_hyphen.Name = "radioButton_dateSep1_hyphen";
            this.radioButton_dateSep1_hyphen.Size = new System.Drawing.Size(74, 17);
            this.radioButton_dateSep1_hyphen.TabIndex = 0;
            this.radioButton_dateSep1_hyphen.TabStop = true;
            this.radioButton_dateSep1_hyphen.Text = "Hyphen (-)";
            this.radioButton_dateSep1_hyphen.UseVisualStyleBackColor = true;
            this.radioButton_dateSep1_hyphen.CheckedChanged += new System.EventHandler(this.radioButton_dateSep1_hyphen_CheckedChanged);
            // 
            // radioButton_dateSep1_dot
            // 
            this.radioButton_dateSep1_dot.AutoSize = true;
            this.radioButton_dateSep1_dot.Location = new System.Drawing.Point(6, 42);
            this.radioButton_dateSep1_dot.Name = "radioButton_dateSep1_dot";
            this.radioButton_dateSep1_dot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_dateSep1_dot.TabIndex = 1;
            this.radioButton_dateSep1_dot.Text = "Dot (.)";
            this.radioButton_dateSep1_dot.UseVisualStyleBackColor = true;
            this.radioButton_dateSep1_dot.CheckedChanged += new System.EventHandler(this.radioButton_dateSep1_dot_CheckedChanged);
            // 
            // radioButton_dateSep1_slash
            // 
            this.radioButton_dateSep1_slash.AutoSize = true;
            this.radioButton_dateSep1_slash.Location = new System.Drawing.Point(6, 65);
            this.radioButton_dateSep1_slash.Name = "radioButton_dateSep1_slash";
            this.radioButton_dateSep1_slash.Size = new System.Drawing.Size(65, 17);
            this.radioButton_dateSep1_slash.TabIndex = 2;
            this.radioButton_dateSep1_slash.Text = "Slash (/)";
            this.radioButton_dateSep1_slash.UseVisualStyleBackColor = true;
            this.radioButton_dateSep1_slash.CheckedChanged += new System.EventHandler(this.radioButton_dateSep1_slash_CheckedChanged);
            // 
            // groupBox_dateSep1
            // 
            this.groupBox_dateSep1.Controls.Add(this.textBox_dateSep1_custom);
            this.groupBox_dateSep1.Controls.Add(this.radioButton_dateSep1_custom);
            this.groupBox_dateSep1.Controls.Add(this.radioButton_dateSep1_underscore);
            this.groupBox_dateSep1.Controls.Add(this.radioButton_dateSep1_none);
            this.groupBox_dateSep1.Controls.Add(this.radioButton_dateSep1_dotSpace);
            this.groupBox_dateSep1.Controls.Add(this.radioButton_dateSep1_commaSpace);
            this.groupBox_dateSep1.Controls.Add(this.radioButton_dateSep1_space);
            this.groupBox_dateSep1.Controls.Add(this.radioButton_dateSep1_slash);
            this.groupBox_dateSep1.Controls.Add(this.radioButton_dateSep1_dot);
            this.groupBox_dateSep1.Controls.Add(this.radioButton_dateSep1_hyphen);
            this.groupBox_dateSep1.Location = new System.Drawing.Point(191, 19);
            this.groupBox_dateSep1.Name = "groupBox_dateSep1";
            this.groupBox_dateSep1.Size = new System.Drawing.Size(159, 234);
            this.groupBox_dateSep1.TabIndex = 6;
            this.groupBox_dateSep1.TabStop = false;
            this.groupBox_dateSep1.Text = "Date seperator 1";
            // 
            // textBox_dateSep1_custom
            // 
            this.textBox_dateSep1_custom.Enabled = false;
            this.textBox_dateSep1_custom.Location = new System.Drawing.Point(75, 202);
            this.textBox_dateSep1_custom.MaxLength = 8;
            this.textBox_dateSep1_custom.Name = "textBox_dateSep1_custom";
            this.textBox_dateSep1_custom.Size = new System.Drawing.Size(56, 20);
            this.textBox_dateSep1_custom.TabIndex = 9;
            this.textBox_dateSep1_custom.TextChanged += new System.EventHandler(this.textBox_dateSep1_custom_TextChanged);
            // 
            // radioButton_dateSep1_custom
            // 
            this.radioButton_dateSep1_custom.AutoSize = true;
            this.radioButton_dateSep1_custom.Location = new System.Drawing.Point(6, 203);
            this.radioButton_dateSep1_custom.Name = "radioButton_dateSep1_custom";
            this.radioButton_dateSep1_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_dateSep1_custom.TabIndex = 8;
            this.radioButton_dateSep1_custom.Text = "Custom:";
            this.radioButton_dateSep1_custom.UseVisualStyleBackColor = true;
            this.radioButton_dateSep1_custom.CheckedChanged += new System.EventHandler(this.radioButton_dateSep1_custom_CheckedChanged);
            // 
            // radioButton_dateSep1_underscore
            // 
            this.radioButton_dateSep1_underscore.AutoSize = true;
            this.radioButton_dateSep1_underscore.Location = new System.Drawing.Point(6, 180);
            this.radioButton_dateSep1_underscore.Name = "radioButton_dateSep1_underscore";
            this.radioButton_dateSep1_underscore.Size = new System.Drawing.Size(95, 17);
            this.radioButton_dateSep1_underscore.TabIndex = 7;
            this.radioButton_dateSep1_underscore.Text = "Underscore (_)";
            this.radioButton_dateSep1_underscore.UseVisualStyleBackColor = true;
            this.radioButton_dateSep1_underscore.CheckedChanged += new System.EventHandler(this.radioButton_dateSep1_underscore_CheckedChanged);
            // 
            // radioButton_dateSep1_none
            // 
            this.radioButton_dateSep1_none.AutoSize = true;
            this.radioButton_dateSep1_none.Location = new System.Drawing.Point(6, 157);
            this.radioButton_dateSep1_none.Name = "radioButton_dateSep1_none";
            this.radioButton_dateSep1_none.Size = new System.Drawing.Size(60, 17);
            this.radioButton_dateSep1_none.TabIndex = 6;
            this.radioButton_dateSep1_none.Text = "None ()";
            this.radioButton_dateSep1_none.UseVisualStyleBackColor = true;
            this.radioButton_dateSep1_none.CheckedChanged += new System.EventHandler(this.radioButton_dateSep1_none_CheckedChanged);
            // 
            // radioButton_dateSep1_dotSpace
            // 
            this.radioButton_dateSep1_dotSpace.AutoSize = true;
            this.radioButton_dateSep1_dotSpace.Location = new System.Drawing.Point(6, 134);
            this.radioButton_dateSep1_dotSpace.Name = "radioButton_dateSep1_dotSpace";
            this.radioButton_dateSep1_dotSpace.Size = new System.Drawing.Size(89, 17);
            this.radioButton_dateSep1_dotSpace.TabIndex = 5;
            this.radioButton_dateSep1_dotSpace.Text = "Dot space (. )";
            this.radioButton_dateSep1_dotSpace.UseVisualStyleBackColor = true;
            this.radioButton_dateSep1_dotSpace.CheckedChanged += new System.EventHandler(this.radioButton_dateSep1_dotSpace_CheckedChanged);
            // 
            // radioButton_dateSep1_commaSpace
            // 
            this.radioButton_dateSep1_commaSpace.AutoSize = true;
            this.radioButton_dateSep1_commaSpace.Location = new System.Drawing.Point(6, 111);
            this.radioButton_dateSep1_commaSpace.Name = "radioButton_dateSep1_commaSpace";
            this.radioButton_dateSep1_commaSpace.Size = new System.Drawing.Size(107, 17);
            this.radioButton_dateSep1_commaSpace.TabIndex = 4;
            this.radioButton_dateSep1_commaSpace.Text = "Comma space (, )";
            this.radioButton_dateSep1_commaSpace.UseVisualStyleBackColor = true;
            this.radioButton_dateSep1_commaSpace.CheckedChanged += new System.EventHandler(this.radioButton_dateSep1_commaSpace_CheckedChanged);
            // 
            // radioButton_dateSep1_space
            // 
            this.radioButton_dateSep1_space.AutoSize = true;
            this.radioButton_dateSep1_space.Location = new System.Drawing.Point(6, 88);
            this.radioButton_dateSep1_space.Name = "radioButton_dateSep1_space";
            this.radioButton_dateSep1_space.Size = new System.Drawing.Size(68, 17);
            this.radioButton_dateSep1_space.TabIndex = 3;
            this.radioButton_dateSep1_space.Text = "Space ( )";
            this.radioButton_dateSep1_space.UseVisualStyleBackColor = true;
            this.radioButton_dateSep1_space.CheckedChanged += new System.EventHandler(this.radioButton_dateSep1_space_CheckedChanged);
            // 
            // groupBox_dateSep2
            // 
            this.groupBox_dateSep2.Controls.Add(this.checkBox_dateSep2_sameAsDateSep1);
            this.groupBox_dateSep2.Controls.Add(this.textBox_dateSep2_custom);
            this.groupBox_dateSep2.Controls.Add(this.radioButton_dateSep2_custom);
            this.groupBox_dateSep2.Controls.Add(this.radioButton_dateSep2_underscore);
            this.groupBox_dateSep2.Controls.Add(this.radioButton_dateSep2_none);
            this.groupBox_dateSep2.Controls.Add(this.radioButton_dateSep2_dotSpace);
            this.groupBox_dateSep2.Controls.Add(this.radioButton_dateSep2_commaSpace);
            this.groupBox_dateSep2.Controls.Add(this.radioButton_dateSep2_space);
            this.groupBox_dateSep2.Controls.Add(this.radioButton_dateSep2_slash);
            this.groupBox_dateSep2.Controls.Add(this.radioButton_dateSep2_dot);
            this.groupBox_dateSep2.Controls.Add(this.radioButton_dateSep2_hyphen);
            this.groupBox_dateSep2.Location = new System.Drawing.Point(191, 261);
            this.groupBox_dateSep2.Name = "groupBox_dateSep2";
            this.groupBox_dateSep2.Size = new System.Drawing.Size(159, 254);
            this.groupBox_dateSep2.TabIndex = 7;
            this.groupBox_dateSep2.TabStop = false;
            this.groupBox_dateSep2.Text = "Date seperator 2";
            // 
            // checkBox_dateSep2_sameAsDateSep1
            // 
            this.checkBox_dateSep2_sameAsDateSep1.AutoSize = true;
            this.checkBox_dateSep2_sameAsDateSep1.Checked = true;
            this.checkBox_dateSep2_sameAsDateSep1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_dateSep2_sameAsDateSep1.Location = new System.Drawing.Point(7, 20);
            this.checkBox_dateSep2_sameAsDateSep1.Name = "checkBox_dateSep2_sameAsDateSep1";
            this.checkBox_dateSep2_sameAsDateSep1.Size = new System.Drawing.Size(147, 17);
            this.checkBox_dateSep2_sameAsDateSep1.TabIndex = 0;
            this.checkBox_dateSep2_sameAsDateSep1.Text = "Same as date seperator 1";
            this.checkBox_dateSep2_sameAsDateSep1.UseVisualStyleBackColor = true;
            this.checkBox_dateSep2_sameAsDateSep1.CheckedChanged += new System.EventHandler(this.checkBox_dateSep2_sameAsDateSep1_CheckedChanged);
            // 
            // textBox_dateSep2_custom
            // 
            this.textBox_dateSep2_custom.Enabled = false;
            this.textBox_dateSep2_custom.Location = new System.Drawing.Point(75, 225);
            this.textBox_dateSep2_custom.MaxLength = 8;
            this.textBox_dateSep2_custom.Name = "textBox_dateSep2_custom";
            this.textBox_dateSep2_custom.Size = new System.Drawing.Size(56, 20);
            this.textBox_dateSep2_custom.TabIndex = 10;
            this.textBox_dateSep2_custom.TextChanged += new System.EventHandler(this.textBox_dateSep2_custom_TextChanged);
            // 
            // radioButton_dateSep2_custom
            // 
            this.radioButton_dateSep2_custom.AutoSize = true;
            this.radioButton_dateSep2_custom.Enabled = false;
            this.radioButton_dateSep2_custom.Location = new System.Drawing.Point(6, 226);
            this.radioButton_dateSep2_custom.Name = "radioButton_dateSep2_custom";
            this.radioButton_dateSep2_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_dateSep2_custom.TabIndex = 9;
            this.radioButton_dateSep2_custom.TabStop = true;
            this.radioButton_dateSep2_custom.Text = "Custom:";
            this.radioButton_dateSep2_custom.UseVisualStyleBackColor = true;
            this.radioButton_dateSep2_custom.CheckedChanged += new System.EventHandler(this.radioButton_dateSep2_custom_CheckedChanged);
            // 
            // radioButton_dateSep2_underscore
            // 
            this.radioButton_dateSep2_underscore.AutoSize = true;
            this.radioButton_dateSep2_underscore.Enabled = false;
            this.radioButton_dateSep2_underscore.Location = new System.Drawing.Point(6, 203);
            this.radioButton_dateSep2_underscore.Name = "radioButton_dateSep2_underscore";
            this.radioButton_dateSep2_underscore.Size = new System.Drawing.Size(95, 17);
            this.radioButton_dateSep2_underscore.TabIndex = 8;
            this.radioButton_dateSep2_underscore.TabStop = true;
            this.radioButton_dateSep2_underscore.Text = "Underscore (_)";
            this.radioButton_dateSep2_underscore.UseVisualStyleBackColor = true;
            this.radioButton_dateSep2_underscore.CheckedChanged += new System.EventHandler(this.radioButton_dateSep2_underscore_CheckedChanged);
            // 
            // radioButton_dateSep2_none
            // 
            this.radioButton_dateSep2_none.AutoSize = true;
            this.radioButton_dateSep2_none.Enabled = false;
            this.radioButton_dateSep2_none.Location = new System.Drawing.Point(6, 180);
            this.radioButton_dateSep2_none.Name = "radioButton_dateSep2_none";
            this.radioButton_dateSep2_none.Size = new System.Drawing.Size(60, 17);
            this.radioButton_dateSep2_none.TabIndex = 7;
            this.radioButton_dateSep2_none.TabStop = true;
            this.radioButton_dateSep2_none.Text = "None ()";
            this.radioButton_dateSep2_none.UseVisualStyleBackColor = true;
            this.radioButton_dateSep2_none.CheckedChanged += new System.EventHandler(this.radioButton_dateSep2_none_CheckedChanged);
            // 
            // radioButton_dateSep2_dotSpace
            // 
            this.radioButton_dateSep2_dotSpace.AutoSize = true;
            this.radioButton_dateSep2_dotSpace.Enabled = false;
            this.radioButton_dateSep2_dotSpace.Location = new System.Drawing.Point(6, 157);
            this.radioButton_dateSep2_dotSpace.Name = "radioButton_dateSep2_dotSpace";
            this.radioButton_dateSep2_dotSpace.Size = new System.Drawing.Size(89, 17);
            this.radioButton_dateSep2_dotSpace.TabIndex = 6;
            this.radioButton_dateSep2_dotSpace.TabStop = true;
            this.radioButton_dateSep2_dotSpace.Text = "Dot space (. )";
            this.radioButton_dateSep2_dotSpace.UseVisualStyleBackColor = true;
            this.radioButton_dateSep2_dotSpace.CheckedChanged += new System.EventHandler(this.radioButton_dateSep2_dotSpace_CheckedChanged);
            // 
            // radioButton_dateSep2_commaSpace
            // 
            this.radioButton_dateSep2_commaSpace.AutoSize = true;
            this.radioButton_dateSep2_commaSpace.Enabled = false;
            this.radioButton_dateSep2_commaSpace.Location = new System.Drawing.Point(6, 134);
            this.radioButton_dateSep2_commaSpace.Name = "radioButton_dateSep2_commaSpace";
            this.radioButton_dateSep2_commaSpace.Size = new System.Drawing.Size(107, 17);
            this.radioButton_dateSep2_commaSpace.TabIndex = 5;
            this.radioButton_dateSep2_commaSpace.TabStop = true;
            this.radioButton_dateSep2_commaSpace.Text = "Comma space (, )";
            this.radioButton_dateSep2_commaSpace.UseVisualStyleBackColor = true;
            this.radioButton_dateSep2_commaSpace.CheckedChanged += new System.EventHandler(this.radioButton_dateSep2_commaSpace_CheckedChanged);
            // 
            // radioButton_dateSep2_space
            // 
            this.radioButton_dateSep2_space.AutoSize = true;
            this.radioButton_dateSep2_space.Enabled = false;
            this.radioButton_dateSep2_space.Location = new System.Drawing.Point(6, 111);
            this.radioButton_dateSep2_space.Name = "radioButton_dateSep2_space";
            this.radioButton_dateSep2_space.Size = new System.Drawing.Size(68, 17);
            this.radioButton_dateSep2_space.TabIndex = 4;
            this.radioButton_dateSep2_space.TabStop = true;
            this.radioButton_dateSep2_space.Text = "Space ( )";
            this.radioButton_dateSep2_space.UseVisualStyleBackColor = true;
            this.radioButton_dateSep2_space.CheckedChanged += new System.EventHandler(this.radioButton_dateSep2_space_CheckedChanged);
            // 
            // radioButton_dateSep2_slash
            // 
            this.radioButton_dateSep2_slash.AutoSize = true;
            this.radioButton_dateSep2_slash.Enabled = false;
            this.radioButton_dateSep2_slash.Location = new System.Drawing.Point(6, 88);
            this.radioButton_dateSep2_slash.Name = "radioButton_dateSep2_slash";
            this.radioButton_dateSep2_slash.Size = new System.Drawing.Size(65, 17);
            this.radioButton_dateSep2_slash.TabIndex = 3;
            this.radioButton_dateSep2_slash.TabStop = true;
            this.radioButton_dateSep2_slash.Text = "Slash (/)";
            this.radioButton_dateSep2_slash.UseVisualStyleBackColor = true;
            this.radioButton_dateSep2_slash.CheckedChanged += new System.EventHandler(this.radioButton_dateSep2_slash_CheckedChanged);
            // 
            // radioButton_dateSep2_dot
            // 
            this.radioButton_dateSep2_dot.AutoSize = true;
            this.radioButton_dateSep2_dot.Enabled = false;
            this.radioButton_dateSep2_dot.Location = new System.Drawing.Point(6, 65);
            this.radioButton_dateSep2_dot.Name = "radioButton_dateSep2_dot";
            this.radioButton_dateSep2_dot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_dateSep2_dot.TabIndex = 2;
            this.radioButton_dateSep2_dot.TabStop = true;
            this.radioButton_dateSep2_dot.Text = "Dot (.)";
            this.radioButton_dateSep2_dot.UseVisualStyleBackColor = true;
            this.radioButton_dateSep2_dot.CheckedChanged += new System.EventHandler(this.radioButton_dateSep2_dot_CheckedChanged);
            // 
            // radioButton_dateSep2_hyphen
            // 
            this.radioButton_dateSep2_hyphen.AutoSize = true;
            this.radioButton_dateSep2_hyphen.Enabled = false;
            this.radioButton_dateSep2_hyphen.Location = new System.Drawing.Point(6, 42);
            this.radioButton_dateSep2_hyphen.Name = "radioButton_dateSep2_hyphen";
            this.radioButton_dateSep2_hyphen.Size = new System.Drawing.Size(74, 17);
            this.radioButton_dateSep2_hyphen.TabIndex = 1;
            this.radioButton_dateSep2_hyphen.TabStop = true;
            this.radioButton_dateSep2_hyphen.Text = "Hyphen (-)";
            this.radioButton_dateSep2_hyphen.UseVisualStyleBackColor = true;
            this.radioButton_dateSep2_hyphen.CheckedChanged += new System.EventHandler(this.radioButton_dateSep2_hyphen_CheckedChanged);
            // 
            // groupBox_weekday
            // 
            this.groupBox_weekday.Controls.Add(this.checkBox_showWeekday);
            this.groupBox_weekday.Controls.Add(this.radioButton_weekdayAfterDate);
            this.groupBox_weekday.Controls.Add(this.radioButton_weekdayBeforeDate);
            this.groupBox_weekday.Location = new System.Drawing.Point(356, 123);
            this.groupBox_weekday.Name = "groupBox_weekday";
            this.groupBox_weekday.Size = new System.Drawing.Size(138, 79);
            this.groupBox_weekday.TabIndex = 9;
            this.groupBox_weekday.TabStop = false;
            this.groupBox_weekday.Text = "Weekday";
            // 
            // checkBox_showWeekday
            // 
            this.checkBox_showWeekday.AutoSize = true;
            this.checkBox_showWeekday.Location = new System.Drawing.Point(6, 19);
            this.checkBox_showWeekday.Name = "checkBox_showWeekday";
            this.checkBox_showWeekday.Size = new System.Drawing.Size(99, 17);
            this.checkBox_showWeekday.TabIndex = 0;
            this.checkBox_showWeekday.Text = "Show weekday";
            this.checkBox_showWeekday.UseVisualStyleBackColor = true;
            this.checkBox_showWeekday.CheckedChanged += new System.EventHandler(this.checkBox_showWeekday_CheckedChanged);
            // 
            // radioButton_weekdayAfterDate
            // 
            this.radioButton_weekdayAfterDate.AutoSize = true;
            this.radioButton_weekdayAfterDate.Checked = true;
            this.radioButton_weekdayAfterDate.Enabled = false;
            this.radioButton_weekdayAfterDate.Location = new System.Drawing.Point(6, 58);
            this.radioButton_weekdayAfterDate.Name = "radioButton_weekdayAfterDate";
            this.radioButton_weekdayAfterDate.Size = new System.Drawing.Size(71, 17);
            this.radioButton_weekdayAfterDate.TabIndex = 2;
            this.radioButton_weekdayAfterDate.TabStop = true;
            this.radioButton_weekdayAfterDate.Text = "After date";
            this.radioButton_weekdayAfterDate.UseVisualStyleBackColor = true;
            this.radioButton_weekdayAfterDate.CheckedChanged += new System.EventHandler(this.radioButton_weekdayAfterDate_CheckedChanged);
            // 
            // radioButton_weekdayBeforeDate
            // 
            this.radioButton_weekdayBeforeDate.AutoSize = true;
            this.radioButton_weekdayBeforeDate.Enabled = false;
            this.radioButton_weekdayBeforeDate.Location = new System.Drawing.Point(6, 38);
            this.radioButton_weekdayBeforeDate.Name = "radioButton_weekdayBeforeDate";
            this.radioButton_weekdayBeforeDate.Size = new System.Drawing.Size(80, 17);
            this.radioButton_weekdayBeforeDate.TabIndex = 1;
            this.radioButton_weekdayBeforeDate.Text = "Before date";
            this.radioButton_weekdayBeforeDate.UseVisualStyleBackColor = true;
            this.radioButton_weekdayBeforeDate.CheckedChanged += new System.EventHandler(this.radioButton_weekdayBeforeDate_CheckedChanged);
            // 
            // groupBox_weekdaySep
            // 
            this.groupBox_weekdaySep.Controls.Add(this.textBox_weekdaySep_custom);
            this.groupBox_weekdaySep.Controls.Add(this.radioButton_weekdaySep_custom);
            this.groupBox_weekdaySep.Controls.Add(this.radioButton_weekdaySep_underscore);
            this.groupBox_weekdaySep.Controls.Add(this.radioButton_weekdaySep_none);
            this.groupBox_weekdaySep.Controls.Add(this.radioButton_weekdaySep_dot);
            this.groupBox_weekdaySep.Controls.Add(this.radioButton_weekdaySep_dotSpace);
            this.groupBox_weekdaySep.Controls.Add(this.radioButton_weekdaySep_commaSpace);
            this.groupBox_weekdaySep.Controls.Add(this.radioButton_weekdaySep_space);
            this.groupBox_weekdaySep.Controls.Add(this.radioButton_weekdaySep_hyphen);
            this.groupBox_weekdaySep.Enabled = false;
            this.groupBox_weekdaySep.Location = new System.Drawing.Point(356, 305);
            this.groupBox_weekdaySep.Name = "groupBox_weekdaySep";
            this.groupBox_weekdaySep.Size = new System.Drawing.Size(138, 210);
            this.groupBox_weekdaySep.TabIndex = 11;
            this.groupBox_weekdaySep.TabStop = false;
            this.groupBox_weekdaySep.Text = "Date-weekday seperator";
            // 
            // textBox_weekdaySep_custom
            // 
            this.textBox_weekdaySep_custom.Enabled = false;
            this.textBox_weekdaySep_custom.Location = new System.Drawing.Point(75, 177);
            this.textBox_weekdaySep_custom.MaxLength = 8;
            this.textBox_weekdaySep_custom.Name = "textBox_weekdaySep_custom";
            this.textBox_weekdaySep_custom.Size = new System.Drawing.Size(56, 20);
            this.textBox_weekdaySep_custom.TabIndex = 8;
            this.textBox_weekdaySep_custom.TextChanged += new System.EventHandler(this.textBox_weekdaySep_custom_TextChanged);
            // 
            // radioButton_weekdaySep_custom
            // 
            this.radioButton_weekdaySep_custom.AutoSize = true;
            this.radioButton_weekdaySep_custom.Location = new System.Drawing.Point(6, 180);
            this.radioButton_weekdaySep_custom.Name = "radioButton_weekdaySep_custom";
            this.radioButton_weekdaySep_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_weekdaySep_custom.TabIndex = 7;
            this.radioButton_weekdaySep_custom.Text = "Custom:";
            this.radioButton_weekdaySep_custom.UseVisualStyleBackColor = true;
            this.radioButton_weekdaySep_custom.CheckedChanged += new System.EventHandler(this.radioButton_weekdaySep_custom_CheckedChanged);
            // 
            // radioButton_weekdaySep_underscore
            // 
            this.radioButton_weekdaySep_underscore.AutoSize = true;
            this.radioButton_weekdaySep_underscore.Location = new System.Drawing.Point(6, 157);
            this.radioButton_weekdaySep_underscore.Name = "radioButton_weekdaySep_underscore";
            this.radioButton_weekdaySep_underscore.Size = new System.Drawing.Size(95, 17);
            this.radioButton_weekdaySep_underscore.TabIndex = 6;
            this.radioButton_weekdaySep_underscore.Text = "Underscore (_)";
            this.radioButton_weekdaySep_underscore.UseVisualStyleBackColor = true;
            this.radioButton_weekdaySep_underscore.CheckedChanged += new System.EventHandler(this.radioButton_weekdaySep_underscore_CheckedChanged);
            // 
            // radioButton_weekdaySep_none
            // 
            this.radioButton_weekdaySep_none.AutoSize = true;
            this.radioButton_weekdaySep_none.Location = new System.Drawing.Point(6, 134);
            this.radioButton_weekdaySep_none.Name = "radioButton_weekdaySep_none";
            this.radioButton_weekdaySep_none.Size = new System.Drawing.Size(60, 17);
            this.radioButton_weekdaySep_none.TabIndex = 5;
            this.radioButton_weekdaySep_none.Text = "None ()";
            this.radioButton_weekdaySep_none.UseVisualStyleBackColor = true;
            this.radioButton_weekdaySep_none.CheckedChanged += new System.EventHandler(this.radioButton_weekdaySep_none_CheckedChanged);
            // 
            // radioButton_weekdaySep_dot
            // 
            this.radioButton_weekdaySep_dot.AutoSize = true;
            this.radioButton_weekdaySep_dot.Location = new System.Drawing.Point(6, 111);
            this.radioButton_weekdaySep_dot.Name = "radioButton_weekdaySep_dot";
            this.radioButton_weekdaySep_dot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_weekdaySep_dot.TabIndex = 4;
            this.radioButton_weekdaySep_dot.Text = "Dot (.)";
            this.radioButton_weekdaySep_dot.UseVisualStyleBackColor = true;
            this.radioButton_weekdaySep_dot.CheckedChanged += new System.EventHandler(this.radioButton_weekdaySep_dot_CheckedChanged);
            // 
            // radioButton_weekdaySep_dotSpace
            // 
            this.radioButton_weekdaySep_dotSpace.AutoSize = true;
            this.radioButton_weekdaySep_dotSpace.Location = new System.Drawing.Point(6, 66);
            this.radioButton_weekdaySep_dotSpace.Name = "radioButton_weekdaySep_dotSpace";
            this.radioButton_weekdaySep_dotSpace.Size = new System.Drawing.Size(89, 17);
            this.radioButton_weekdaySep_dotSpace.TabIndex = 2;
            this.radioButton_weekdaySep_dotSpace.Text = "Dot space (. )";
            this.radioButton_weekdaySep_dotSpace.UseVisualStyleBackColor = true;
            this.radioButton_weekdaySep_dotSpace.CheckedChanged += new System.EventHandler(this.radioButton_weekdaySep_dotSpace_CheckedChanged);
            // 
            // radioButton_weekdaySep_commaSpace
            // 
            this.radioButton_weekdaySep_commaSpace.AutoSize = true;
            this.radioButton_weekdaySep_commaSpace.Location = new System.Drawing.Point(6, 43);
            this.radioButton_weekdaySep_commaSpace.Name = "radioButton_weekdaySep_commaSpace";
            this.radioButton_weekdaySep_commaSpace.Size = new System.Drawing.Size(107, 17);
            this.radioButton_weekdaySep_commaSpace.TabIndex = 1;
            this.radioButton_weekdaySep_commaSpace.Text = "Comma space (, )";
            this.radioButton_weekdaySep_commaSpace.UseVisualStyleBackColor = true;
            this.radioButton_weekdaySep_commaSpace.CheckedChanged += new System.EventHandler(this.radioButton_weekdaySep_commaSpace_CheckedChanged);
            // 
            // radioButton_weekdaySep_space
            // 
            this.radioButton_weekdaySep_space.AutoSize = true;
            this.radioButton_weekdaySep_space.Checked = true;
            this.radioButton_weekdaySep_space.Location = new System.Drawing.Point(6, 20);
            this.radioButton_weekdaySep_space.Name = "radioButton_weekdaySep_space";
            this.radioButton_weekdaySep_space.Size = new System.Drawing.Size(68, 17);
            this.radioButton_weekdaySep_space.TabIndex = 0;
            this.radioButton_weekdaySep_space.TabStop = true;
            this.radioButton_weekdaySep_space.Text = "Space ( )";
            this.radioButton_weekdaySep_space.UseVisualStyleBackColor = true;
            this.radioButton_weekdaySep_space.CheckedChanged += new System.EventHandler(this.radioButton_weekdaySep_space_CheckedChanged);
            // 
            // radioButton_weekdaySep_hyphen
            // 
            this.radioButton_weekdaySep_hyphen.AutoSize = true;
            this.radioButton_weekdaySep_hyphen.Location = new System.Drawing.Point(6, 88);
            this.radioButton_weekdaySep_hyphen.Name = "radioButton_weekdaySep_hyphen";
            this.radioButton_weekdaySep_hyphen.Size = new System.Drawing.Size(74, 17);
            this.radioButton_weekdaySep_hyphen.TabIndex = 3;
            this.radioButton_weekdaySep_hyphen.Text = "Hyphen (-)";
            this.radioButton_weekdaySep_hyphen.UseVisualStyleBackColor = true;
            this.radioButton_weekdaySep_hyphen.CheckedChanged += new System.EventHandler(this.radioButton_weekdaySep_hyphen_CheckedChanged);
            // 
            // groupBox_dateTimeSep
            // 
            this.groupBox_dateTimeSep.Controls.Add(this.textBox_dateTimeSep_custom);
            this.groupBox_dateTimeSep.Controls.Add(this.radioButton_dateTimeSep_custom);
            this.groupBox_dateTimeSep.Controls.Add(this.radioButton_dateTimeSep_underscore);
            this.groupBox_dateTimeSep.Controls.Add(this.radioButton_dateTimeSep_none);
            this.groupBox_dateTimeSep.Controls.Add(this.radioButton_dateTimeSep_dot);
            this.groupBox_dateTimeSep.Controls.Add(this.radioButton_dateTimeSep_t);
            this.groupBox_dateTimeSep.Controls.Add(this.radioButton_dateTimeSep_commaSpace);
            this.groupBox_dateTimeSep.Controls.Add(this.radioButton_dateTimeSep_space);
            this.groupBox_dateTimeSep.Controls.Add(this.radioButton_dateTimeSep_hyphen);
            this.groupBox_dateTimeSep.Location = new System.Drawing.Point(11, 137);
            this.groupBox_dateTimeSep.Name = "groupBox_dateTimeSep";
            this.groupBox_dateTimeSep.Size = new System.Drawing.Size(138, 220);
            this.groupBox_dateTimeSep.TabIndex = 1;
            this.groupBox_dateTimeSep.TabStop = false;
            this.groupBox_dateTimeSep.Text = "Date-time seperator";
            // 
            // textBox_dateTimeSep_custom
            // 
            this.textBox_dateTimeSep_custom.Enabled = false;
            this.textBox_dateTimeSep_custom.Location = new System.Drawing.Point(75, 179);
            this.textBox_dateTimeSep_custom.MaxLength = 8;
            this.textBox_dateTimeSep_custom.Name = "textBox_dateTimeSep_custom";
            this.textBox_dateTimeSep_custom.Size = new System.Drawing.Size(56, 20);
            this.textBox_dateTimeSep_custom.TabIndex = 8;
            this.textBox_dateTimeSep_custom.TextChanged += new System.EventHandler(this.textBox_dateTimeSep_custom_TextChanged);
            // 
            // radioButton_dateTimeSep_custom
            // 
            this.radioButton_dateTimeSep_custom.AutoSize = true;
            this.radioButton_dateTimeSep_custom.Location = new System.Drawing.Point(6, 180);
            this.radioButton_dateTimeSep_custom.Name = "radioButton_dateTimeSep_custom";
            this.radioButton_dateTimeSep_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_dateTimeSep_custom.TabIndex = 7;
            this.radioButton_dateTimeSep_custom.Text = "Custom:";
            this.radioButton_dateTimeSep_custom.UseVisualStyleBackColor = true;
            this.radioButton_dateTimeSep_custom.CheckedChanged += new System.EventHandler(this.radioButton_dateTimeSep_custom_CheckedChanged);
            // 
            // radioButton_dateTimeSep_underscore
            // 
            this.radioButton_dateTimeSep_underscore.AutoSize = true;
            this.radioButton_dateTimeSep_underscore.Location = new System.Drawing.Point(6, 89);
            this.radioButton_dateTimeSep_underscore.Name = "radioButton_dateTimeSep_underscore";
            this.radioButton_dateTimeSep_underscore.Size = new System.Drawing.Size(95, 17);
            this.radioButton_dateTimeSep_underscore.TabIndex = 3;
            this.radioButton_dateTimeSep_underscore.Text = "Underscore (_)";
            this.radioButton_dateTimeSep_underscore.UseVisualStyleBackColor = true;
            this.radioButton_dateTimeSep_underscore.CheckedChanged += new System.EventHandler(this.radioButton_dateTimeSep_underscore_CheckedChanged);
            // 
            // radioButton_dateTimeSep_none
            // 
            this.radioButton_dateTimeSep_none.AutoSize = true;
            this.radioButton_dateTimeSep_none.Location = new System.Drawing.Point(6, 157);
            this.radioButton_dateTimeSep_none.Name = "radioButton_dateTimeSep_none";
            this.radioButton_dateTimeSep_none.Size = new System.Drawing.Size(60, 17);
            this.radioButton_dateTimeSep_none.TabIndex = 6;
            this.radioButton_dateTimeSep_none.Text = "None ()";
            this.radioButton_dateTimeSep_none.UseVisualStyleBackColor = true;
            this.radioButton_dateTimeSep_none.CheckedChanged += new System.EventHandler(this.radioButton_dateTimeSep_none_CheckedChanged);
            // 
            // radioButton_dateTimeSep_dot
            // 
            this.radioButton_dateTimeSep_dot.AutoSize = true;
            this.radioButton_dateTimeSep_dot.Location = new System.Drawing.Point(6, 134);
            this.radioButton_dateTimeSep_dot.Name = "radioButton_dateTimeSep_dot";
            this.radioButton_dateTimeSep_dot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_dateTimeSep_dot.TabIndex = 5;
            this.radioButton_dateTimeSep_dot.Text = "Dot (.)";
            this.radioButton_dateTimeSep_dot.UseVisualStyleBackColor = true;
            this.radioButton_dateTimeSep_dot.CheckedChanged += new System.EventHandler(this.radioButton_dateTimeSep_dot_CheckedChanged);
            // 
            // radioButton_dateTimeSep_t
            // 
            this.radioButton_dateTimeSep_t.AutoSize = true;
            this.radioButton_dateTimeSep_t.Location = new System.Drawing.Point(6, 66);
            this.radioButton_dateTimeSep_t.Name = "radioButton_dateTimeSep_t";
            this.radioButton_dateTimeSep_t.Size = new System.Drawing.Size(32, 17);
            this.radioButton_dateTimeSep_t.TabIndex = 2;
            this.radioButton_dateTimeSep_t.Text = "T";
            this.radioButton_dateTimeSep_t.UseVisualStyleBackColor = true;
            this.radioButton_dateTimeSep_t.CheckedChanged += new System.EventHandler(this.radioButton_dateTimeSep_t_CheckedChanged);
            // 
            // radioButton_dateTimeSep_commaSpace
            // 
            this.radioButton_dateTimeSep_commaSpace.AutoSize = true;
            this.radioButton_dateTimeSep_commaSpace.Location = new System.Drawing.Point(6, 43);
            this.radioButton_dateTimeSep_commaSpace.Name = "radioButton_dateTimeSep_commaSpace";
            this.radioButton_dateTimeSep_commaSpace.Size = new System.Drawing.Size(107, 17);
            this.radioButton_dateTimeSep_commaSpace.TabIndex = 1;
            this.radioButton_dateTimeSep_commaSpace.Text = "Comma space (, )";
            this.radioButton_dateTimeSep_commaSpace.UseVisualStyleBackColor = true;
            this.radioButton_dateTimeSep_commaSpace.CheckedChanged += new System.EventHandler(this.radioButton_dateTimeSep_commaSpace_CheckedChanged);
            // 
            // radioButton_dateTimeSep_space
            // 
            this.radioButton_dateTimeSep_space.AutoSize = true;
            this.radioButton_dateTimeSep_space.Checked = true;
            this.radioButton_dateTimeSep_space.Location = new System.Drawing.Point(6, 20);
            this.radioButton_dateTimeSep_space.Name = "radioButton_dateTimeSep_space";
            this.radioButton_dateTimeSep_space.Size = new System.Drawing.Size(68, 17);
            this.radioButton_dateTimeSep_space.TabIndex = 0;
            this.radioButton_dateTimeSep_space.TabStop = true;
            this.radioButton_dateTimeSep_space.Text = "Space ( )";
            this.radioButton_dateTimeSep_space.UseVisualStyleBackColor = true;
            this.radioButton_dateTimeSep_space.CheckedChanged += new System.EventHandler(this.radioButton_dateTimeSep_space_CheckedChanged);
            // 
            // radioButton_dateTimeSep_hyphen
            // 
            this.radioButton_dateTimeSep_hyphen.AutoSize = true;
            this.radioButton_dateTimeSep_hyphen.Location = new System.Drawing.Point(6, 111);
            this.radioButton_dateTimeSep_hyphen.Name = "radioButton_dateTimeSep_hyphen";
            this.radioButton_dateTimeSep_hyphen.Size = new System.Drawing.Size(74, 17);
            this.radioButton_dateTimeSep_hyphen.TabIndex = 4;
            this.radioButton_dateTimeSep_hyphen.Text = "Hyphen (-)";
            this.radioButton_dateTimeSep_hyphen.UseVisualStyleBackColor = true;
            this.radioButton_dateTimeSep_hyphen.CheckedChanged += new System.EventHandler(this.radioButton_dateTimeSep_hyphen_CheckedChanged);
            // 
            // groupBox_timeFormat
            // 
            this.groupBox_timeFormat.Controls.Add(this.checkBox_showSeconds);
            this.groupBox_timeFormat.Controls.Add(this.checkBox_zeroPadHour);
            this.groupBox_timeFormat.Controls.Add(this.radioButton_timeFormat_1_12amPmLast);
            this.groupBox_timeFormat.Controls.Add(this.radioButton_timeFormat_0_11amPmLast);
            this.groupBox_timeFormat.Controls.Add(this.radioButton_timeFormat_1_12amPmFirst);
            this.groupBox_timeFormat.Controls.Add(this.radioButton_timeFormat_0_11amPmFirst);
            this.groupBox_timeFormat.Controls.Add(this.radioButton_timeFormat_1_24);
            this.groupBox_timeFormat.Controls.Add(this.radioButton_timeFormat_0_23);
            this.groupBox_timeFormat.Location = new System.Drawing.Point(15, 19);
            this.groupBox_timeFormat.Name = "groupBox_timeFormat";
            this.groupBox_timeFormat.Size = new System.Drawing.Size(170, 220);
            this.groupBox_timeFormat.TabIndex = 12;
            this.groupBox_timeFormat.TabStop = false;
            this.groupBox_timeFormat.Text = "Time format";
            // 
            // checkBox_showSeconds
            // 
            this.checkBox_showSeconds.AutoSize = true;
            this.checkBox_showSeconds.Checked = true;
            this.checkBox_showSeconds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showSeconds.Location = new System.Drawing.Point(6, 182);
            this.checkBox_showSeconds.Name = "checkBox_showSeconds";
            this.checkBox_showSeconds.Size = new System.Drawing.Size(96, 17);
            this.checkBox_showSeconds.TabIndex = 7;
            this.checkBox_showSeconds.Text = "Show seconds";
            this.checkBox_showSeconds.UseVisualStyleBackColor = true;
            this.checkBox_showSeconds.CheckedChanged += new System.EventHandler(this.checkBox_showSeconds_CheckedChanged);
            // 
            // checkBox_zeroPadHour
            // 
            this.checkBox_zeroPadHour.AutoSize = true;
            this.checkBox_zeroPadHour.Checked = true;
            this.checkBox_zeroPadHour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_zeroPadHour.Location = new System.Drawing.Point(6, 159);
            this.checkBox_zeroPadHour.Name = "checkBox_zeroPadHour";
            this.checkBox_zeroPadHour.Size = new System.Drawing.Size(93, 17);
            this.checkBox_zeroPadHour.TabIndex = 6;
            this.checkBox_zeroPadHour.Text = "Zero-pad hour";
            this.checkBox_zeroPadHour.UseVisualStyleBackColor = true;
            this.checkBox_zeroPadHour.CheckedChanged += new System.EventHandler(this.checkBox_zeroPadHour_CheckedChanged);
            // 
            // radioButton_timeFormat_1_12amPmLast
            // 
            this.radioButton_timeFormat_1_12amPmLast.AutoSize = true;
            this.radioButton_timeFormat_1_12amPmLast.Location = new System.Drawing.Point(6, 135);
            this.radioButton_timeFormat_1_12amPmLast.Name = "radioButton_timeFormat_1_12amPmLast";
            this.radioButton_timeFormat_1_12amPmLast.Size = new System.Drawing.Size(156, 17);
            this.radioButton_timeFormat_1_12amPmLast.TabIndex = 5;
            this.radioButton_timeFormat_1_12amPmLast.Text = "12-hour (1 - 12) AM/PM last";
            this.radioButton_timeFormat_1_12amPmLast.UseVisualStyleBackColor = true;
            this.radioButton_timeFormat_1_12amPmLast.CheckedChanged += new System.EventHandler(this.radioButton_timeFormat_1_12amPmLast_CheckedChanged);
            // 
            // radioButton_timeFormat_0_11amPmLast
            // 
            this.radioButton_timeFormat_0_11amPmLast.AutoSize = true;
            this.radioButton_timeFormat_0_11amPmLast.Location = new System.Drawing.Point(6, 89);
            this.radioButton_timeFormat_0_11amPmLast.Name = "radioButton_timeFormat_0_11amPmLast";
            this.radioButton_timeFormat_0_11amPmLast.Size = new System.Drawing.Size(156, 17);
            this.radioButton_timeFormat_0_11amPmLast.TabIndex = 3;
            this.radioButton_timeFormat_0_11amPmLast.Text = "12-hour (0 - 11) AM/PM last";
            this.radioButton_timeFormat_0_11amPmLast.UseVisualStyleBackColor = true;
            this.radioButton_timeFormat_0_11amPmLast.CheckedChanged += new System.EventHandler(this.radioButton_timeFormat_0_11amPmLast_CheckedChanged);
            // 
            // radioButton_timeFormat_1_12amPmFirst
            // 
            this.radioButton_timeFormat_1_12amPmFirst.AutoSize = true;
            this.radioButton_timeFormat_1_12amPmFirst.Location = new System.Drawing.Point(6, 112);
            this.radioButton_timeFormat_1_12amPmFirst.Name = "radioButton_timeFormat_1_12amPmFirst";
            this.radioButton_timeFormat_1_12amPmFirst.Size = new System.Drawing.Size(156, 17);
            this.radioButton_timeFormat_1_12amPmFirst.TabIndex = 4;
            this.radioButton_timeFormat_1_12amPmFirst.Text = "12-hour (1 - 12) AM/PM first";
            this.radioButton_timeFormat_1_12amPmFirst.UseVisualStyleBackColor = true;
            this.radioButton_timeFormat_1_12amPmFirst.CheckedChanged += new System.EventHandler(this.radioButton_timeFormat_1_12amPmFirst_CheckedChanged);
            // 
            // radioButton_timeFormat_0_11amPmFirst
            // 
            this.radioButton_timeFormat_0_11amPmFirst.AutoSize = true;
            this.radioButton_timeFormat_0_11amPmFirst.Location = new System.Drawing.Point(6, 66);
            this.radioButton_timeFormat_0_11amPmFirst.Name = "radioButton_timeFormat_0_11amPmFirst";
            this.radioButton_timeFormat_0_11amPmFirst.Size = new System.Drawing.Size(156, 17);
            this.radioButton_timeFormat_0_11amPmFirst.TabIndex = 2;
            this.radioButton_timeFormat_0_11amPmFirst.Text = "12-hour (0 - 11) AM/PM first";
            this.radioButton_timeFormat_0_11amPmFirst.UseVisualStyleBackColor = true;
            this.radioButton_timeFormat_0_11amPmFirst.CheckedChanged += new System.EventHandler(this.radioButton_timeFormat_0_11amPmFirst_CheckedChanged);
            // 
            // radioButton_timeFormat_1_24
            // 
            this.radioButton_timeFormat_1_24.AutoSize = true;
            this.radioButton_timeFormat_1_24.Location = new System.Drawing.Point(6, 43);
            this.radioButton_timeFormat_1_24.Name = "radioButton_timeFormat_1_24";
            this.radioButton_timeFormat_1_24.Size = new System.Drawing.Size(97, 17);
            this.radioButton_timeFormat_1_24.TabIndex = 1;
            this.radioButton_timeFormat_1_24.Text = "24-hour (1 - 24)";
            this.radioButton_timeFormat_1_24.UseVisualStyleBackColor = true;
            this.radioButton_timeFormat_1_24.CheckedChanged += new System.EventHandler(this.radioButton_timeFormat_1_24_CheckedChanged);
            // 
            // radioButton_timeFormat_0_23
            // 
            this.radioButton_timeFormat_0_23.AutoSize = true;
            this.radioButton_timeFormat_0_23.Checked = true;
            this.radioButton_timeFormat_0_23.Location = new System.Drawing.Point(6, 20);
            this.radioButton_timeFormat_0_23.Name = "radioButton_timeFormat_0_23";
            this.radioButton_timeFormat_0_23.Size = new System.Drawing.Size(97, 17);
            this.radioButton_timeFormat_0_23.TabIndex = 0;
            this.radioButton_timeFormat_0_23.TabStop = true;
            this.radioButton_timeFormat_0_23.Text = "24-hour (0 - 23)";
            this.radioButton_timeFormat_0_23.UseVisualStyleBackColor = true;
            this.radioButton_timeFormat_0_23.CheckedChanged += new System.EventHandler(this.radioButton_timeFormat_0_23_CheckedChanged);
            // 
            // groupBox_hrMinSep
            // 
            this.groupBox_hrMinSep.Controls.Add(this.textBox_hrMinSep_custom);
            this.groupBox_hrMinSep.Controls.Add(this.radioButton_hrMinSep_space);
            this.groupBox_hrMinSep.Controls.Add(this.radioButton_hrMinSep_custom);
            this.groupBox_hrMinSep.Controls.Add(this.radioButton_hrMinSep_none);
            this.groupBox_hrMinSep.Controls.Add(this.radioButton_hrMinSep_hyphen);
            this.groupBox_hrMinSep.Controls.Add(this.radioButton_hrMinSep_dot);
            this.groupBox_hrMinSep.Controls.Add(this.radioButton_hrMinSep_colon);
            this.groupBox_hrMinSep.Location = new System.Drawing.Point(191, 19);
            this.groupBox_hrMinSep.Name = "groupBox_hrMinSep";
            this.groupBox_hrMinSep.Size = new System.Drawing.Size(150, 161);
            this.groupBox_hrMinSep.TabIndex = 14;
            this.groupBox_hrMinSep.TabStop = false;
            this.groupBox_hrMinSep.Text = "Hour-minute seperator";
            // 
            // textBox_hrMinSep_custom
            // 
            this.textBox_hrMinSep_custom.Enabled = false;
            this.textBox_hrMinSep_custom.Location = new System.Drawing.Point(75, 134);
            this.textBox_hrMinSep_custom.MaxLength = 8;
            this.textBox_hrMinSep_custom.Name = "textBox_hrMinSep_custom";
            this.textBox_hrMinSep_custom.Size = new System.Drawing.Size(56, 20);
            this.textBox_hrMinSep_custom.TabIndex = 6;
            this.textBox_hrMinSep_custom.TextChanged += new System.EventHandler(this.textBox_hrMinSep_custom_TextChanged);
            // 
            // radioButton_hrMinSep_space
            // 
            this.radioButton_hrMinSep_space.AutoSize = true;
            this.radioButton_hrMinSep_space.Location = new System.Drawing.Point(6, 89);
            this.radioButton_hrMinSep_space.Name = "radioButton_hrMinSep_space";
            this.radioButton_hrMinSep_space.Size = new System.Drawing.Size(68, 17);
            this.radioButton_hrMinSep_space.TabIndex = 3;
            this.radioButton_hrMinSep_space.Text = "Space ( )";
            this.radioButton_hrMinSep_space.UseVisualStyleBackColor = true;
            this.radioButton_hrMinSep_space.CheckedChanged += new System.EventHandler(this.radioButton_hrMinSep_space_CheckedChanged);
            // 
            // radioButton_hrMinSep_custom
            // 
            this.radioButton_hrMinSep_custom.AutoSize = true;
            this.radioButton_hrMinSep_custom.Location = new System.Drawing.Point(6, 135);
            this.radioButton_hrMinSep_custom.Name = "radioButton_hrMinSep_custom";
            this.radioButton_hrMinSep_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_hrMinSep_custom.TabIndex = 5;
            this.radioButton_hrMinSep_custom.Text = "Custom:";
            this.radioButton_hrMinSep_custom.UseVisualStyleBackColor = true;
            this.radioButton_hrMinSep_custom.CheckedChanged += new System.EventHandler(this.radioButton_hrMinSep_custom_CheckedChanged);
            // 
            // radioButton_hrMinSep_none
            // 
            this.radioButton_hrMinSep_none.AutoSize = true;
            this.radioButton_hrMinSep_none.Location = new System.Drawing.Point(6, 112);
            this.radioButton_hrMinSep_none.Name = "radioButton_hrMinSep_none";
            this.radioButton_hrMinSep_none.Size = new System.Drawing.Size(60, 17);
            this.radioButton_hrMinSep_none.TabIndex = 4;
            this.radioButton_hrMinSep_none.Text = "None ()";
            this.radioButton_hrMinSep_none.UseVisualStyleBackColor = true;
            this.radioButton_hrMinSep_none.CheckedChanged += new System.EventHandler(this.radioButton_hrMinSep_none_CheckedChanged);
            // 
            // radioButton_hrMinSep_hyphen
            // 
            this.radioButton_hrMinSep_hyphen.AutoSize = true;
            this.radioButton_hrMinSep_hyphen.Location = new System.Drawing.Point(6, 66);
            this.radioButton_hrMinSep_hyphen.Name = "radioButton_hrMinSep_hyphen";
            this.radioButton_hrMinSep_hyphen.Size = new System.Drawing.Size(74, 17);
            this.radioButton_hrMinSep_hyphen.TabIndex = 2;
            this.radioButton_hrMinSep_hyphen.Text = "Hyphen (-)";
            this.radioButton_hrMinSep_hyphen.UseVisualStyleBackColor = true;
            this.radioButton_hrMinSep_hyphen.CheckedChanged += new System.EventHandler(this.radioButton_hrMinSep_hyphen_CheckedChanged);
            // 
            // radioButton_hrMinSep_dot
            // 
            this.radioButton_hrMinSep_dot.AutoSize = true;
            this.radioButton_hrMinSep_dot.Location = new System.Drawing.Point(6, 43);
            this.radioButton_hrMinSep_dot.Name = "radioButton_hrMinSep_dot";
            this.radioButton_hrMinSep_dot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_hrMinSep_dot.TabIndex = 1;
            this.radioButton_hrMinSep_dot.Text = "Dot (.)";
            this.radioButton_hrMinSep_dot.UseVisualStyleBackColor = true;
            this.radioButton_hrMinSep_dot.CheckedChanged += new System.EventHandler(this.radioButton_hrMinSep_dot_CheckedChanged);
            // 
            // radioButton_hrMinSep_colon
            // 
            this.radioButton_hrMinSep_colon.AutoSize = true;
            this.radioButton_hrMinSep_colon.Checked = true;
            this.radioButton_hrMinSep_colon.Location = new System.Drawing.Point(6, 20);
            this.radioButton_hrMinSep_colon.Name = "radioButton_hrMinSep_colon";
            this.radioButton_hrMinSep_colon.Size = new System.Drawing.Size(64, 17);
            this.radioButton_hrMinSep_colon.TabIndex = 0;
            this.radioButton_hrMinSep_colon.TabStop = true;
            this.radioButton_hrMinSep_colon.Text = "Colon (:)";
            this.radioButton_hrMinSep_colon.UseVisualStyleBackColor = true;
            this.radioButton_hrMinSep_colon.CheckedChanged += new System.EventHandler(this.radioButton_hrMinSep_colon_CheckedChanged);
            // 
            // groupBox_minSecSep
            // 
            this.groupBox_minSecSep.Controls.Add(this.checkBox_minSecSep_sameAsHrMin);
            this.groupBox_minSecSep.Controls.Add(this.textBox_minSecSep_custom);
            this.groupBox_minSecSep.Controls.Add(this.radioButton_minSecSep_space);
            this.groupBox_minSecSep.Controls.Add(this.radioButton_minSecSep_custom);
            this.groupBox_minSecSep.Controls.Add(this.radioButton_minSecSep_none);
            this.groupBox_minSecSep.Controls.Add(this.radioButton_minSecSep_hyphen);
            this.groupBox_minSecSep.Controls.Add(this.radioButton_minSecSep_dot);
            this.groupBox_minSecSep.Controls.Add(this.radioButton_minSecSep_colon);
            this.groupBox_minSecSep.Location = new System.Drawing.Point(191, 186);
            this.groupBox_minSecSep.Name = "groupBox_minSecSep";
            this.groupBox_minSecSep.Size = new System.Drawing.Size(154, 184);
            this.groupBox_minSecSep.TabIndex = 15;
            this.groupBox_minSecSep.TabStop = false;
            this.groupBox_minSecSep.Text = "Minute-second seperator";
            // 
            // checkBox_minSecSep_sameAsHrMin
            // 
            this.checkBox_minSecSep_sameAsHrMin.AutoSize = true;
            this.checkBox_minSecSep_sameAsHrMin.Checked = true;
            this.checkBox_minSecSep_sameAsHrMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_minSecSep_sameAsHrMin.Location = new System.Drawing.Point(6, 19);
            this.checkBox_minSecSep_sameAsHrMin.Name = "checkBox_minSecSep_sameAsHrMin";
            this.checkBox_minSecSep_sameAsHrMin.Size = new System.Drawing.Size(145, 17);
            this.checkBox_minSecSep_sameAsHrMin.TabIndex = 0;
            this.checkBox_minSecSep_sameAsHrMin.Text = "Same as hr-min seperator";
            this.checkBox_minSecSep_sameAsHrMin.UseVisualStyleBackColor = true;
            this.checkBox_minSecSep_sameAsHrMin.CheckedChanged += new System.EventHandler(this.checkBox_minSecSep_sameAsHrMin_CheckedChanged);
            // 
            // textBox_minSecSep_custom
            // 
            this.textBox_minSecSep_custom.Enabled = false;
            this.textBox_minSecSep_custom.Location = new System.Drawing.Point(75, 156);
            this.textBox_minSecSep_custom.MaxLength = 8;
            this.textBox_minSecSep_custom.Name = "textBox_minSecSep_custom";
            this.textBox_minSecSep_custom.Size = new System.Drawing.Size(56, 20);
            this.textBox_minSecSep_custom.TabIndex = 7;
            this.textBox_minSecSep_custom.TextChanged += new System.EventHandler(this.textBox_minSecSep_custom_TextChanged);
            // 
            // radioButton_minSecSep_space
            // 
            this.radioButton_minSecSep_space.AutoSize = true;
            this.radioButton_minSecSep_space.Enabled = false;
            this.radioButton_minSecSep_space.Location = new System.Drawing.Point(6, 111);
            this.radioButton_minSecSep_space.Name = "radioButton_minSecSep_space";
            this.radioButton_minSecSep_space.Size = new System.Drawing.Size(68, 17);
            this.radioButton_minSecSep_space.TabIndex = 4;
            this.radioButton_minSecSep_space.Text = "Space ( )";
            this.radioButton_minSecSep_space.UseVisualStyleBackColor = true;
            this.radioButton_minSecSep_space.CheckedChanged += new System.EventHandler(this.radioButton_minSecSep_space_CheckedChanged);
            // 
            // radioButton_minSecSep_custom
            // 
            this.radioButton_minSecSep_custom.AutoSize = true;
            this.radioButton_minSecSep_custom.Enabled = false;
            this.radioButton_minSecSep_custom.Location = new System.Drawing.Point(6, 157);
            this.radioButton_minSecSep_custom.Name = "radioButton_minSecSep_custom";
            this.radioButton_minSecSep_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_minSecSep_custom.TabIndex = 6;
            this.radioButton_minSecSep_custom.Text = "Custom:";
            this.radioButton_minSecSep_custom.UseVisualStyleBackColor = true;
            this.radioButton_minSecSep_custom.CheckedChanged += new System.EventHandler(this.radioButton_minSecSep_custom_CheckedChanged);
            // 
            // radioButton_minSecSep_none
            // 
            this.radioButton_minSecSep_none.AutoSize = true;
            this.radioButton_minSecSep_none.Enabled = false;
            this.radioButton_minSecSep_none.Location = new System.Drawing.Point(6, 134);
            this.radioButton_minSecSep_none.Name = "radioButton_minSecSep_none";
            this.radioButton_minSecSep_none.Size = new System.Drawing.Size(60, 17);
            this.radioButton_minSecSep_none.TabIndex = 5;
            this.radioButton_minSecSep_none.Text = "None ()";
            this.radioButton_minSecSep_none.UseVisualStyleBackColor = true;
            this.radioButton_minSecSep_none.CheckedChanged += new System.EventHandler(this.radioButton_minSecSep_none_CheckedChanged);
            // 
            // radioButton_minSecSep_hyphen
            // 
            this.radioButton_minSecSep_hyphen.AutoSize = true;
            this.radioButton_minSecSep_hyphen.Enabled = false;
            this.radioButton_minSecSep_hyphen.Location = new System.Drawing.Point(6, 88);
            this.radioButton_minSecSep_hyphen.Name = "radioButton_minSecSep_hyphen";
            this.radioButton_minSecSep_hyphen.Size = new System.Drawing.Size(74, 17);
            this.radioButton_minSecSep_hyphen.TabIndex = 3;
            this.radioButton_minSecSep_hyphen.Text = "Hyphen (-)";
            this.radioButton_minSecSep_hyphen.UseVisualStyleBackColor = true;
            this.radioButton_minSecSep_hyphen.CheckedChanged += new System.EventHandler(this.radioButton_minSecSep_hyphen_CheckedChanged);
            // 
            // radioButton_minSecSep_dot
            // 
            this.radioButton_minSecSep_dot.AutoSize = true;
            this.radioButton_minSecSep_dot.Enabled = false;
            this.radioButton_minSecSep_dot.Location = new System.Drawing.Point(6, 65);
            this.radioButton_minSecSep_dot.Name = "radioButton_minSecSep_dot";
            this.radioButton_minSecSep_dot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_minSecSep_dot.TabIndex = 2;
            this.radioButton_minSecSep_dot.Text = "Dot (.)";
            this.radioButton_minSecSep_dot.UseVisualStyleBackColor = true;
            this.radioButton_minSecSep_dot.CheckedChanged += new System.EventHandler(this.radioButton_minSecSep_dot_CheckedChanged);
            // 
            // radioButton_minSecSep_colon
            // 
            this.radioButton_minSecSep_colon.AutoSize = true;
            this.radioButton_minSecSep_colon.Checked = true;
            this.radioButton_minSecSep_colon.Enabled = false;
            this.radioButton_minSecSep_colon.Location = new System.Drawing.Point(6, 42);
            this.radioButton_minSecSep_colon.Name = "radioButton_minSecSep_colon";
            this.radioButton_minSecSep_colon.Size = new System.Drawing.Size(64, 17);
            this.radioButton_minSecSep_colon.TabIndex = 1;
            this.radioButton_minSecSep_colon.TabStop = true;
            this.radioButton_minSecSep_colon.Text = "Colon (:)";
            this.radioButton_minSecSep_colon.UseVisualStyleBackColor = true;
            this.radioButton_minSecSep_colon.CheckedChanged += new System.EventHandler(this.radioButton_minSecSep_colon_CheckedChanged);
            // 
            // groupBox_amPmFormat
            // 
            this.groupBox_amPmFormat.Controls.Add(this.label_pmCustom);
            this.groupBox_amPmFormat.Controls.Add(this.label_amCustom);
            this.groupBox_amPmFormat.Controls.Add(this.textBox_pmCustom);
            this.groupBox_amPmFormat.Controls.Add(this.textBox_amCustom);
            this.groupBox_amPmFormat.Controls.Add(this.radioButton_amPmLowercaseDots);
            this.groupBox_amPmFormat.Controls.Add(this.radioButton_amPmCustom);
            this.groupBox_amPmFormat.Controls.Add(this.radioButton_ap_lowercase);
            this.groupBox_amPmFormat.Controls.Add(this.radioButton_ap_capital);
            this.groupBox_amPmFormat.Controls.Add(this.radioButton_amPmCapitalDots);
            this.groupBox_amPmFormat.Controls.Add(this.radioButton_amPmLowercase);
            this.groupBox_amPmFormat.Controls.Add(this.radioButton_amPmCapital);
            this.groupBox_amPmFormat.Enabled = false;
            this.groupBox_amPmFormat.Location = new System.Drawing.Point(15, 245);
            this.groupBox_amPmFormat.Name = "groupBox_amPmFormat";
            this.groupBox_amPmFormat.Size = new System.Drawing.Size(170, 236);
            this.groupBox_amPmFormat.TabIndex = 14;
            this.groupBox_amPmFormat.TabStop = false;
            this.groupBox_amPmFormat.Text = "AM/PM format";
            // 
            // label_pmCustom
            // 
            this.label_pmCustom.AutoSize = true;
            this.label_pmCustom.Location = new System.Drawing.Point(6, 204);
            this.label_pmCustom.Name = "label_pmCustom";
            this.label_pmCustom.Size = new System.Drawing.Size(26, 13);
            this.label_pmCustom.TabIndex = 6;
            this.label_pmCustom.Text = "PM:";
            // 
            // label_amCustom
            // 
            this.label_amCustom.AutoSize = true;
            this.label_amCustom.Location = new System.Drawing.Point(6, 177);
            this.label_amCustom.Name = "label_amCustom";
            this.label_amCustom.Size = new System.Drawing.Size(26, 13);
            this.label_amCustom.TabIndex = 6;
            this.label_amCustom.Text = "AM:";
            // 
            // textBox_pmCustom
            // 
            this.textBox_pmCustom.Enabled = false;
            this.textBox_pmCustom.Location = new System.Drawing.Point(38, 200);
            this.textBox_pmCustom.MaxLength = 12;
            this.textBox_pmCustom.Name = "textBox_pmCustom";
            this.textBox_pmCustom.Size = new System.Drawing.Size(91, 20);
            this.textBox_pmCustom.TabIndex = 8;
            this.textBox_pmCustom.TextChanged += new System.EventHandler(this.textBox_pmCustom_TextChanged);
            // 
            // textBox_amCustom
            // 
            this.textBox_amCustom.Enabled = false;
            this.textBox_amCustom.Location = new System.Drawing.Point(38, 174);
            this.textBox_amCustom.MaxLength = 12;
            this.textBox_amCustom.Name = "textBox_amCustom";
            this.textBox_amCustom.Size = new System.Drawing.Size(91, 20);
            this.textBox_amCustom.TabIndex = 7;
            this.textBox_amCustom.TextChanged += new System.EventHandler(this.textBox_amCustom_TextChanged);
            // 
            // radioButton_amPmLowercaseDots
            // 
            this.radioButton_amPmLowercaseDots.AutoSize = true;
            this.radioButton_amPmLowercaseDots.Location = new System.Drawing.Point(6, 87);
            this.radioButton_amPmLowercaseDots.Name = "radioButton_amPmLowercaseDots";
            this.radioButton_amPmLowercaseDots.Size = new System.Drawing.Size(70, 17);
            this.radioButton_amPmLowercaseDots.TabIndex = 3;
            this.radioButton_amPmLowercaseDots.Text = "a.m./p.m.";
            this.radioButton_amPmLowercaseDots.UseVisualStyleBackColor = true;
            this.radioButton_amPmLowercaseDots.CheckedChanged += new System.EventHandler(this.radioButton_amPmLowercaseDots_CheckedChanged);
            // 
            // radioButton_amPmCustom
            // 
            this.radioButton_amPmCustom.AutoSize = true;
            this.radioButton_amPmCustom.Location = new System.Drawing.Point(6, 154);
            this.radioButton_amPmCustom.Name = "radioButton_amPmCustom";
            this.radioButton_amPmCustom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_amPmCustom.TabIndex = 6;
            this.radioButton_amPmCustom.Text = "Custom:";
            this.radioButton_amPmCustom.UseVisualStyleBackColor = true;
            this.radioButton_amPmCustom.CheckedChanged += new System.EventHandler(this.radioButton_amPmCustom_CheckedChanged);
            // 
            // radioButton_ap_lowercase
            // 
            this.radioButton_ap_lowercase.AutoSize = true;
            this.radioButton_ap_lowercase.Location = new System.Drawing.Point(6, 131);
            this.radioButton_ap_lowercase.Name = "radioButton_ap_lowercase";
            this.radioButton_ap_lowercase.Size = new System.Drawing.Size(42, 17);
            this.radioButton_ap_lowercase.TabIndex = 5;
            this.radioButton_ap_lowercase.Text = "a/p";
            this.radioButton_ap_lowercase.UseVisualStyleBackColor = true;
            this.radioButton_ap_lowercase.CheckedChanged += new System.EventHandler(this.radioButton_ap_lowercase_CheckedChanged);
            // 
            // radioButton_ap_capital
            // 
            this.radioButton_ap_capital.AutoSize = true;
            this.radioButton_ap_capital.Location = new System.Drawing.Point(6, 110);
            this.radioButton_ap_capital.Name = "radioButton_ap_capital";
            this.radioButton_ap_capital.Size = new System.Drawing.Size(44, 17);
            this.radioButton_ap_capital.TabIndex = 4;
            this.radioButton_ap_capital.Text = "A/P";
            this.radioButton_ap_capital.UseVisualStyleBackColor = true;
            this.radioButton_ap_capital.CheckedChanged += new System.EventHandler(this.radioButton_ap_capital_CheckedChanged);
            // 
            // radioButton_amPmCapitalDots
            // 
            this.radioButton_amPmCapitalDots.AutoSize = true;
            this.radioButton_amPmCapitalDots.Location = new System.Drawing.Point(6, 64);
            this.radioButton_amPmCapitalDots.Name = "radioButton_amPmCapitalDots";
            this.radioButton_amPmCapitalDots.Size = new System.Drawing.Size(74, 17);
            this.radioButton_amPmCapitalDots.TabIndex = 2;
            this.radioButton_amPmCapitalDots.Text = "A.M./P.M.";
            this.radioButton_amPmCapitalDots.UseVisualStyleBackColor = true;
            this.radioButton_amPmCapitalDots.CheckedChanged += new System.EventHandler(this.radioButton_amPmCapitalDots_CheckedChanged);
            // 
            // radioButton_amPmLowercase
            // 
            this.radioButton_amPmLowercase.AutoSize = true;
            this.radioButton_amPmLowercase.Location = new System.Drawing.Point(6, 41);
            this.radioButton_amPmLowercase.Name = "radioButton_amPmLowercase";
            this.radioButton_amPmLowercase.Size = new System.Drawing.Size(58, 17);
            this.radioButton_amPmLowercase.TabIndex = 1;
            this.radioButton_amPmLowercase.Text = "am/pm";
            this.radioButton_amPmLowercase.UseVisualStyleBackColor = true;
            this.radioButton_amPmLowercase.CheckedChanged += new System.EventHandler(this.radioButton_amPmLowercase_CheckedChanged);
            // 
            // radioButton_amPmCapital
            // 
            this.radioButton_amPmCapital.AutoSize = true;
            this.radioButton_amPmCapital.Checked = true;
            this.radioButton_amPmCapital.Location = new System.Drawing.Point(6, 18);
            this.radioButton_amPmCapital.Name = "radioButton_amPmCapital";
            this.radioButton_amPmCapital.Size = new System.Drawing.Size(62, 17);
            this.radioButton_amPmCapital.TabIndex = 0;
            this.radioButton_amPmCapital.TabStop = true;
            this.radioButton_amPmCapital.Text = "AM/PM";
            this.radioButton_amPmCapital.UseVisualStyleBackColor = true;
            this.radioButton_amPmCapital.CheckedChanged += new System.EventHandler(this.radioButton_amPmCapital_CheckedChanged);
            // 
            // groupBox_amPmSep
            // 
            this.groupBox_amPmSep.Controls.Add(this.textBox_amPmSep_custom);
            this.groupBox_amPmSep.Controls.Add(this.radioButton_amPmSep_dot);
            this.groupBox_amPmSep.Controls.Add(this.radioButton_amPmSep_custom);
            this.groupBox_amPmSep.Controls.Add(this.radioButton_amPmSep_underscore);
            this.groupBox_amPmSep.Controls.Add(this.radioButton_amPmSep_none);
            this.groupBox_amPmSep.Controls.Add(this.radioButton_amPmSep_space);
            this.groupBox_amPmSep.Enabled = false;
            this.groupBox_amPmSep.Location = new System.Drawing.Point(191, 377);
            this.groupBox_amPmSep.Name = "groupBox_amPmSep";
            this.groupBox_amPmSep.Size = new System.Drawing.Size(154, 138);
            this.groupBox_amPmSep.TabIndex = 16;
            this.groupBox_amPmSep.TabStop = false;
            this.groupBox_amPmSep.Text = "Time-AM/PM seperator";
            // 
            // textBox_amPmSep_custom
            // 
            this.textBox_amPmSep_custom.Enabled = false;
            this.textBox_amPmSep_custom.Location = new System.Drawing.Point(75, 109);
            this.textBox_amPmSep_custom.MaxLength = 8;
            this.textBox_amPmSep_custom.Name = "textBox_amPmSep_custom";
            this.textBox_amPmSep_custom.Size = new System.Drawing.Size(56, 20);
            this.textBox_amPmSep_custom.TabIndex = 5;
            this.textBox_amPmSep_custom.TextChanged += new System.EventHandler(this.textBox_amPmSep_custom_TextChanged);
            // 
            // radioButton_amPmSep_dot
            // 
            this.radioButton_amPmSep_dot.AutoSize = true;
            this.radioButton_amPmSep_dot.Location = new System.Drawing.Point(6, 87);
            this.radioButton_amPmSep_dot.Name = "radioButton_amPmSep_dot";
            this.radioButton_amPmSep_dot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_amPmSep_dot.TabIndex = 3;
            this.radioButton_amPmSep_dot.Text = "Dot (.)";
            this.radioButton_amPmSep_dot.UseVisualStyleBackColor = true;
            this.radioButton_amPmSep_dot.CheckedChanged += new System.EventHandler(this.radioButton_amPmSep_dot_CheckedChanged);
            // 
            // radioButton_amPmSep_custom
            // 
            this.radioButton_amPmSep_custom.AutoSize = true;
            this.radioButton_amPmSep_custom.Location = new System.Drawing.Point(6, 110);
            this.radioButton_amPmSep_custom.Name = "radioButton_amPmSep_custom";
            this.radioButton_amPmSep_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_amPmSep_custom.TabIndex = 4;
            this.radioButton_amPmSep_custom.Text = "Custom:";
            this.radioButton_amPmSep_custom.UseVisualStyleBackColor = true;
            this.radioButton_amPmSep_custom.CheckedChanged += new System.EventHandler(this.radioButton_amPmSep_custom_CheckedChanged);
            // 
            // radioButton_amPmSep_underscore
            // 
            this.radioButton_amPmSep_underscore.AutoSize = true;
            this.radioButton_amPmSep_underscore.Location = new System.Drawing.Point(6, 64);
            this.radioButton_amPmSep_underscore.Name = "radioButton_amPmSep_underscore";
            this.radioButton_amPmSep_underscore.Size = new System.Drawing.Size(95, 17);
            this.radioButton_amPmSep_underscore.TabIndex = 2;
            this.radioButton_amPmSep_underscore.Text = "Underscore (_)";
            this.radioButton_amPmSep_underscore.UseVisualStyleBackColor = true;
            this.radioButton_amPmSep_underscore.CheckedChanged += new System.EventHandler(this.radioButton_amPmSep_undercore_CheckedChanged);
            // 
            // radioButton_amPmSep_none
            // 
            this.radioButton_amPmSep_none.AutoSize = true;
            this.radioButton_amPmSep_none.Location = new System.Drawing.Point(6, 41);
            this.radioButton_amPmSep_none.Name = "radioButton_amPmSep_none";
            this.radioButton_amPmSep_none.Size = new System.Drawing.Size(60, 17);
            this.radioButton_amPmSep_none.TabIndex = 1;
            this.radioButton_amPmSep_none.Text = "None ()";
            this.radioButton_amPmSep_none.UseVisualStyleBackColor = true;
            this.radioButton_amPmSep_none.CheckedChanged += new System.EventHandler(this.radioButton_amPmSep_none_CheckedChanged);
            // 
            // radioButton_amPmSep_space
            // 
            this.radioButton_amPmSep_space.AutoSize = true;
            this.radioButton_amPmSep_space.Checked = true;
            this.radioButton_amPmSep_space.Location = new System.Drawing.Point(6, 18);
            this.radioButton_amPmSep_space.Name = "radioButton_amPmSep_space";
            this.radioButton_amPmSep_space.Size = new System.Drawing.Size(68, 17);
            this.radioButton_amPmSep_space.TabIndex = 0;
            this.radioButton_amPmSep_space.TabStop = true;
            this.radioButton_amPmSep_space.Text = "Space ( )";
            this.radioButton_amPmSep_space.UseVisualStyleBackColor = true;
            this.radioButton_amPmSep_space.CheckedChanged += new System.EventHandler(this.radioButton_amPmSep_space_CheckedChanged);
            // 
            // groupBox_dateEndChar
            // 
            this.groupBox_dateEndChar.Controls.Add(this.textBox_dateEndChar_custom);
            this.groupBox_dateEndChar.Controls.Add(this.radioButton_dateEndChar_custom);
            this.groupBox_dateEndChar.Controls.Add(this.radioButton_dateEndChar_dot);
            this.groupBox_dateEndChar.Controls.Add(this.radioButton_dateEndChar_none);
            this.groupBox_dateEndChar.Location = new System.Drawing.Point(356, 19);
            this.groupBox_dateEndChar.Name = "groupBox_dateEndChar";
            this.groupBox_dateEndChar.Size = new System.Drawing.Size(138, 98);
            this.groupBox_dateEndChar.TabIndex = 8;
            this.groupBox_dateEndChar.TabStop = false;
            this.groupBox_dateEndChar.Text = "Date end char";
            // 
            // textBox_dateEndChar_custom
            // 
            this.textBox_dateEndChar_custom.Enabled = false;
            this.textBox_dateEndChar_custom.Location = new System.Drawing.Point(75, 65);
            this.textBox_dateEndChar_custom.MaxLength = 8;
            this.textBox_dateEndChar_custom.Name = "textBox_dateEndChar_custom";
            this.textBox_dateEndChar_custom.Size = new System.Drawing.Size(56, 20);
            this.textBox_dateEndChar_custom.TabIndex = 3;
            this.textBox_dateEndChar_custom.TextChanged += new System.EventHandler(this.textBox_dateEndChar_custom_TextChanged);
            // 
            // radioButton_dateEndChar_custom
            // 
            this.radioButton_dateEndChar_custom.AutoSize = true;
            this.radioButton_dateEndChar_custom.Location = new System.Drawing.Point(6, 65);
            this.radioButton_dateEndChar_custom.Name = "radioButton_dateEndChar_custom";
            this.radioButton_dateEndChar_custom.Size = new System.Drawing.Size(63, 17);
            this.radioButton_dateEndChar_custom.TabIndex = 2;
            this.radioButton_dateEndChar_custom.Text = "Custom:";
            this.radioButton_dateEndChar_custom.UseVisualStyleBackColor = true;
            this.radioButton_dateEndChar_custom.CheckedChanged += new System.EventHandler(this.radioButton_dateEndChar_custom_CheckedChanged);
            // 
            // radioButton_dateEndChar_dot
            // 
            this.radioButton_dateEndChar_dot.AutoSize = true;
            this.radioButton_dateEndChar_dot.Location = new System.Drawing.Point(6, 42);
            this.radioButton_dateEndChar_dot.Name = "radioButton_dateEndChar_dot";
            this.radioButton_dateEndChar_dot.Size = new System.Drawing.Size(54, 17);
            this.radioButton_dateEndChar_dot.TabIndex = 1;
            this.radioButton_dateEndChar_dot.Text = "Dot (.)";
            this.radioButton_dateEndChar_dot.UseVisualStyleBackColor = true;
            this.radioButton_dateEndChar_dot.CheckedChanged += new System.EventHandler(this.radioButton_dateEndChar_dot_CheckedChanged);
            // 
            // radioButton_dateEndChar_none
            // 
            this.radioButton_dateEndChar_none.AutoSize = true;
            this.radioButton_dateEndChar_none.Checked = true;
            this.radioButton_dateEndChar_none.Location = new System.Drawing.Point(6, 19);
            this.radioButton_dateEndChar_none.Name = "radioButton_dateEndChar_none";
            this.radioButton_dateEndChar_none.Size = new System.Drawing.Size(60, 17);
            this.radioButton_dateEndChar_none.TabIndex = 0;
            this.radioButton_dateEndChar_none.TabStop = true;
            this.radioButton_dateEndChar_none.Text = "None ()";
            this.radioButton_dateEndChar_none.UseVisualStyleBackColor = true;
            this.radioButton_dateEndChar_none.CheckedChanged += new System.EventHandler(this.radioButton_dateEndChar_none_CheckedChanged);
            // 
            // groupBox_showDateTime
            // 
            this.groupBox_showDateTime.Controls.Add(this.radioButton_timeOnly);
            this.groupBox_showDateTime.Controls.Add(this.radioButton_dateOnly);
            this.groupBox_showDateTime.Controls.Add(this.radioButton_timeThenDate);
            this.groupBox_showDateTime.Controls.Add(this.radioButton_dateThenTime);
            this.groupBox_showDateTime.Location = new System.Drawing.Point(11, 19);
            this.groupBox_showDateTime.Name = "groupBox_showDateTime";
            this.groupBox_showDateTime.Size = new System.Drawing.Size(138, 112);
            this.groupBox_showDateTime.TabIndex = 0;
            this.groupBox_showDateTime.TabStop = false;
            this.groupBox_showDateTime.Text = "Show date/time";
            // 
            // radioButton_timeOnly
            // 
            this.radioButton_timeOnly.AutoSize = true;
            this.radioButton_timeOnly.Location = new System.Drawing.Point(6, 88);
            this.radioButton_timeOnly.Name = "radioButton_timeOnly";
            this.radioButton_timeOnly.Size = new System.Drawing.Size(70, 17);
            this.radioButton_timeOnly.TabIndex = 3;
            this.radioButton_timeOnly.Text = "Time only";
            this.radioButton_timeOnly.UseVisualStyleBackColor = true;
            this.radioButton_timeOnly.CheckedChanged += new System.EventHandler(this.radioButton_timeOnly_CheckedChanged);
            // 
            // radioButton_dateOnly
            // 
            this.radioButton_dateOnly.AutoSize = true;
            this.radioButton_dateOnly.Location = new System.Drawing.Point(6, 65);
            this.radioButton_dateOnly.Name = "radioButton_dateOnly";
            this.radioButton_dateOnly.Size = new System.Drawing.Size(70, 17);
            this.radioButton_dateOnly.TabIndex = 2;
            this.radioButton_dateOnly.Text = "Date only";
            this.radioButton_dateOnly.UseVisualStyleBackColor = true;
            this.radioButton_dateOnly.CheckedChanged += new System.EventHandler(this.radioButton_dateOnly_CheckedChanged);
            // 
            // radioButton_timeThenDate
            // 
            this.radioButton_timeThenDate.AutoSize = true;
            this.radioButton_timeThenDate.Location = new System.Drawing.Point(6, 42);
            this.radioButton_timeThenDate.Name = "radioButton_timeThenDate";
            this.radioButton_timeThenDate.Size = new System.Drawing.Size(96, 17);
            this.radioButton_timeThenDate.TabIndex = 1;
            this.radioButton_timeThenDate.Text = "Time then date";
            this.radioButton_timeThenDate.UseVisualStyleBackColor = true;
            this.radioButton_timeThenDate.CheckedChanged += new System.EventHandler(this.radioButton_timeThenDate_CheckedChanged);
            // 
            // radioButton_dateThenTime
            // 
            this.radioButton_dateThenTime.AutoSize = true;
            this.radioButton_dateThenTime.Checked = true;
            this.radioButton_dateThenTime.Location = new System.Drawing.Point(6, 19);
            this.radioButton_dateThenTime.Name = "radioButton_dateThenTime";
            this.radioButton_dateThenTime.Size = new System.Drawing.Size(94, 17);
            this.radioButton_dateThenTime.TabIndex = 0;
            this.radioButton_dateThenTime.TabStop = true;
            this.radioButton_dateThenTime.Text = "Date then time";
            this.radioButton_dateThenTime.UseVisualStyleBackColor = true;
            this.radioButton_dateThenTime.CheckedChanged += new System.EventHandler(this.radioButton_dateThenTime_CheckedChanged);
            // 
            // groupBox_dateTime
            // 
            this.groupBox_dateTime.Controls.Add(this.groupBox_showDateTime);
            this.groupBox_dateTime.Controls.Add(this.groupBox_dateTimeSep);
            this.groupBox_dateTime.Location = new System.Drawing.Point(10, 100);
            this.groupBox_dateTime.Name = "groupBox_dateTime";
            this.groupBox_dateTime.Size = new System.Drawing.Size(159, 370);
            this.groupBox_dateTime.TabIndex = 4;
            this.groupBox_dateTime.TabStop = false;
            this.groupBox_dateTime.Text = "Date/time";
            // 
            // groupBox_date
            // 
            this.groupBox_date.Controls.Add(this.groupBox_dateOrder);
            this.groupBox_date.Controls.Add(this.groupBox_yearFormat);
            this.groupBox_date.Controls.Add(this.groupBox_dateSep2);
            this.groupBox_date.Controls.Add(this.groupBox_monthFormat);
            this.groupBox_date.Controls.Add(this.groupBox_dayFormat);
            this.groupBox_date.Controls.Add(this.groupBox_dateSep1);
            this.groupBox_date.Controls.Add(this.groupBox_weekdayFormat);
            this.groupBox_date.Controls.Add(this.groupBox_weekday);
            this.groupBox_date.Controls.Add(this.groupBox_dateEndChar);
            this.groupBox_date.Controls.Add(this.groupBox_weekdaySep);
            this.groupBox_date.Location = new System.Drawing.Point(175, 100);
            this.groupBox_date.Name = "groupBox_date";
            this.groupBox_date.Size = new System.Drawing.Size(508, 525);
            this.groupBox_date.TabIndex = 5;
            this.groupBox_date.TabStop = false;
            this.groupBox_date.Text = "Date";
            // 
            // groupBox_weekdayFormat
            // 
            this.groupBox_weekdayFormat.Controls.Add(this.button_customizeWeekdayFormat);
            this.groupBox_weekdayFormat.Controls.Add(this.radioButton_customWeekday);
            this.groupBox_weekdayFormat.Controls.Add(this.radioButton_weekdayFull);
            this.groupBox_weekdayFormat.Controls.Add(this.radioButton_weekday_3letter);
            this.groupBox_weekdayFormat.Location = new System.Drawing.Point(356, 208);
            this.groupBox_weekdayFormat.Name = "groupBox_weekdayFormat";
            this.groupBox_weekdayFormat.Size = new System.Drawing.Size(138, 95);
            this.groupBox_weekdayFormat.TabIndex = 10;
            this.groupBox_weekdayFormat.TabStop = false;
            this.groupBox_weekdayFormat.Text = "Weekday format";
            // 
            // button_customizeWeekdayFormat
            // 
            this.button_customizeWeekdayFormat.Enabled = false;
            this.button_customizeWeekdayFormat.Location = new System.Drawing.Point(67, 63);
            this.button_customizeWeekdayFormat.Name = "button_customizeWeekdayFormat";
            this.button_customizeWeekdayFormat.Size = new System.Drawing.Size(65, 23);
            this.button_customizeWeekdayFormat.TabIndex = 3;
            this.button_customizeWeekdayFormat.Text = "Customize...";
            this.button_customizeWeekdayFormat.UseVisualStyleBackColor = true;
            this.button_customizeWeekdayFormat.Click += new System.EventHandler(this.button_customizeWeekdayFormat_Click);
            // 
            // radioButton_customWeekday
            // 
            this.radioButton_customWeekday.AutoSize = true;
            this.radioButton_customWeekday.Location = new System.Drawing.Point(7, 66);
            this.radioButton_customWeekday.Name = "radioButton_customWeekday";
            this.radioButton_customWeekday.Size = new System.Drawing.Size(63, 17);
            this.radioButton_customWeekday.TabIndex = 2;
            this.radioButton_customWeekday.Text = "Custom:";
            this.radioButton_customWeekday.UseVisualStyleBackColor = true;
            this.radioButton_customWeekday.CheckedChanged += new System.EventHandler(this.radioButton_customWeekday_CheckedChanged);
            // 
            // radioButton_weekdayFull
            // 
            this.radioButton_weekdayFull.AutoSize = true;
            this.radioButton_weekdayFull.Location = new System.Drawing.Point(7, 42);
            this.radioButton_weekdayFull.Name = "radioButton_weekdayFull";
            this.radioButton_weekdayFull.Size = new System.Drawing.Size(41, 17);
            this.radioButton_weekdayFull.TabIndex = 1;
            this.radioButton_weekdayFull.Text = "Full";
            this.radioButton_weekdayFull.UseVisualStyleBackColor = true;
            this.radioButton_weekdayFull.CheckedChanged += new System.EventHandler(this.radioButton_wekdayFull_CheckedChanged);
            // 
            // radioButton_weekday_3letter
            // 
            this.radioButton_weekday_3letter.AutoSize = true;
            this.radioButton_weekday_3letter.Checked = true;
            this.radioButton_weekday_3letter.Location = new System.Drawing.Point(7, 19);
            this.radioButton_weekday_3letter.Name = "radioButton_weekday_3letter";
            this.radioButton_weekday_3letter.Size = new System.Drawing.Size(57, 17);
            this.radioButton_weekday_3letter.TabIndex = 0;
            this.radioButton_weekday_3letter.TabStop = true;
            this.radioButton_weekday_3letter.Text = "3-letter";
            this.radioButton_weekday_3letter.UseVisualStyleBackColor = true;
            this.radioButton_weekday_3letter.CheckedChanged += new System.EventHandler(this.radioButton_weekday_3letter_CheckedChanged);
            // 
            // groupBox_time
            // 
            this.groupBox_time.Controls.Add(this.groupBox_timeFormat);
            this.groupBox_time.Controls.Add(this.groupBox_minSecSep);
            this.groupBox_time.Controls.Add(this.groupBox_hrMinSep);
            this.groupBox_time.Controls.Add(this.groupBox_amPmFormat);
            this.groupBox_time.Controls.Add(this.groupBox_amPmSep);
            this.groupBox_time.Location = new System.Drawing.Point(689, 100);
            this.groupBox_time.Name = "groupBox_time";
            this.groupBox_time.Size = new System.Drawing.Size(353, 525);
            this.groupBox_time.TabIndex = 6;
            this.groupBox_time.TabStop = false;
            this.groupBox_time.Text = "Time";
            // 
            // button_copyDateTime
            // 
            this.button_copyDateTime.Location = new System.Drawing.Point(175, 631);
            this.button_copyDateTime.Name = "button_copyDateTime";
            this.button_copyDateTime.Size = new System.Drawing.Size(164, 23);
            this.button_copyDateTime.TabIndex = 18;
            this.button_copyDateTime.Text = "Copy date/time to clipboard";
            this.button_copyDateTime.UseVisualStyleBackColor = true;
            this.button_copyDateTime.Click += new System.EventHandler(this.button_copyDateTime_Click);
            // 
            // button_saveDateTimeToFile
            // 
            this.button_saveDateTimeToFile.Location = new System.Drawing.Point(345, 631);
            this.button_saveDateTimeToFile.Name = "button_saveDateTimeToFile";
            this.button_saveDateTimeToFile.Size = new System.Drawing.Size(164, 23);
            this.button_saveDateTimeToFile.TabIndex = 19;
            this.button_saveDateTimeToFile.Text = "Save date/time to file";
            this.button_saveDateTimeToFile.UseVisualStyleBackColor = true;
            this.button_saveDateTimeToFile.Click += new System.EventHandler(this.button_saveDateTimeToFile_Click);
            // 
            // checkBox_showDateInTitle
            // 
            this.checkBox_showDateInTitle.AutoSize = true;
            this.checkBox_showDateInTitle.Location = new System.Drawing.Point(13, 636);
            this.checkBox_showDateInTitle.Name = "checkBox_showDateInTitle";
            this.checkBox_showDateInTitle.Size = new System.Drawing.Size(149, 17);
            this.checkBox_showDateInTitle.TabIndex = 17;
            this.checkBox_showDateInTitle.Text = "Show date/time in title bar";
            this.checkBox_showDateInTitle.UseVisualStyleBackColor = true;
            this.checkBox_showDateInTitle.CheckedChanged += new System.EventHandler(this.checkBox_showDateInTitle_CheckedChanged);
            // 
            // checkBox_loadSettings
            // 
            this.checkBox_loadSettings.AutoSize = true;
            this.checkBox_loadSettings.Location = new System.Drawing.Point(758, 635);
            this.checkBox_loadSettings.Name = "checkBox_loadSettings";
            this.checkBox_loadSettings.Size = new System.Drawing.Size(284, 17);
            this.checkBox_loadSettings.TabIndex = 21;
            this.checkBox_loadSettings.Text = "Load current format settings next time app is re-opened";
            this.checkBox_loadSettings.UseVisualStyleBackColor = true;
            this.checkBox_loadSettings.CheckedChanged += new System.EventHandler(this.checkBox_loadSettings_CheckedChanged);
            // 
            // button_savePreset
            // 
            this.button_savePreset.Location = new System.Drawing.Point(515, 631);
            this.button_savePreset.Name = "button_savePreset";
            this.button_savePreset.Size = new System.Drawing.Size(102, 23);
            this.button_savePreset.TabIndex = 20;
            this.button_savePreset.Text = "Save preset";
            this.button_savePreset.UseVisualStyleBackColor = true;
            this.button_savePreset.Click += new System.EventHandler(this.button_savePreset_Click);
            // 
            // button_changeCustomDateTime
            // 
            this.button_changeCustomDateTime.Location = new System.Drawing.Point(756, 1);
            this.button_changeCustomDateTime.Name = "button_changeCustomDateTime";
            this.button_changeCustomDateTime.Size = new System.Drawing.Size(75, 23);
            this.button_changeCustomDateTime.TabIndex = 23;
            this.button_changeCustomDateTime.Text = "Chnage...";
            this.button_changeCustomDateTime.UseVisualStyleBackColor = true;
            this.button_changeCustomDateTime.Click += new System.EventHandler(this.button_changeCustomDateTime_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_deletePreset
            // 
            this.button_deletePreset.Location = new System.Drawing.Point(623, 631);
            this.button_deletePreset.Name = "button_deletePreset";
            this.button_deletePreset.Size = new System.Drawing.Size(102, 23);
            this.button_deletePreset.TabIndex = 20;
            this.button_deletePreset.Text = "Delete preset";
            this.button_deletePreset.UseVisualStyleBackColor = true;
            this.button_deletePreset.Click += new System.EventHandler(this.button_deletePreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 661);
            this.Controls.Add(this.button_changeCustomDateTime);
            this.Controls.Add(this.checkBox_loadSettings);
            this.Controls.Add(this.checkBox_showDateInTitle);
            this.Controls.Add(this.button_deletePreset);
            this.Controls.Add(this.button_savePreset);
            this.Controls.Add(this.button_saveDateTimeToFile);
            this.Controls.Add(this.button_copyDateTime);
            this.Controls.Add(this.groupBox_time);
            this.Controls.Add(this.groupBox_date);
            this.Controls.Add(this.groupBox_dateTime);
            this.Controls.Add(this.label_outputDateTime);
            this.Controls.Add(this.comboBox_displayDate);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_dateOrder.ResumeLayout(false);
            this.groupBox_dateOrder.PerformLayout();
            this.groupBox_yearFormat.ResumeLayout(false);
            this.groupBox_yearFormat.PerformLayout();
            this.groupBox_monthFormat.ResumeLayout(false);
            this.groupBox_monthFormat.PerformLayout();
            this.groupBox_dayFormat.ResumeLayout(false);
            this.groupBox_dayFormat.PerformLayout();
            this.groupBox_dateSep1.ResumeLayout(false);
            this.groupBox_dateSep1.PerformLayout();
            this.groupBox_dateSep2.ResumeLayout(false);
            this.groupBox_dateSep2.PerformLayout();
            this.groupBox_weekday.ResumeLayout(false);
            this.groupBox_weekday.PerformLayout();
            this.groupBox_weekdaySep.ResumeLayout(false);
            this.groupBox_weekdaySep.PerformLayout();
            this.groupBox_dateTimeSep.ResumeLayout(false);
            this.groupBox_dateTimeSep.PerformLayout();
            this.groupBox_timeFormat.ResumeLayout(false);
            this.groupBox_timeFormat.PerformLayout();
            this.groupBox_hrMinSep.ResumeLayout(false);
            this.groupBox_hrMinSep.PerformLayout();
            this.groupBox_minSecSep.ResumeLayout(false);
            this.groupBox_minSecSep.PerformLayout();
            this.groupBox_amPmFormat.ResumeLayout(false);
            this.groupBox_amPmFormat.PerformLayout();
            this.groupBox_amPmSep.ResumeLayout(false);
            this.groupBox_amPmSep.PerformLayout();
            this.groupBox_dateEndChar.ResumeLayout(false);
            this.groupBox_dateEndChar.PerformLayout();
            this.groupBox_showDateTime.ResumeLayout(false);
            this.groupBox_showDateTime.PerformLayout();
            this.groupBox_dateTime.ResumeLayout(false);
            this.groupBox_date.ResumeLayout(false);
            this.groupBox_weekdayFormat.ResumeLayout(false);
            this.groupBox_weekdayFormat.PerformLayout();
            this.groupBox_time.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_presets;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ISOwithSpace;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ISOwithT;
        private System.Windows.Forms.ComboBox comboBox_displayDate;
        private System.Windows.Forms.Label label_outputDateTime;
        private System.Windows.Forms.GroupBox groupBox_dateOrder;
        private System.Windows.Forms.RadioButton radioButton_mdy;
        private System.Windows.Forms.RadioButton radioButton_dmy;
        private System.Windows.Forms.RadioButton radioButton_ymd;
        private System.Windows.Forms.GroupBox groupBox_yearFormat;
        private System.Windows.Forms.RadioButton radioButton_year2digit;
        private System.Windows.Forms.RadioButton radioButton_year4digit;
        private System.Windows.Forms.GroupBox groupBox_monthFormat;
        private System.Windows.Forms.RadioButton radioButton_monthFormat_full;
        private System.Windows.Forms.RadioButton radioButton_monthFormat_3letter;
        private System.Windows.Forms.RadioButton radioButton_monthFormat_withLeadingZero;
        private System.Windows.Forms.RadioButton radioButton_monthFormat_withoutLeadingZero;
        private System.Windows.Forms.GroupBox groupBox_dayFormat;
        private System.Windows.Forms.RadioButton radioButton_dayFormat_ordinal;
        private System.Windows.Forms.RadioButton radioButton_dayFormat_withLeadingZero;
        private System.Windows.Forms.RadioButton radioButton_dayFormat_withoutLeadingZero;
        private System.Windows.Forms.RadioButton radioButton_dateSep1_hyphen;
        private System.Windows.Forms.RadioButton radioButton_dateSep1_dot;
        private System.Windows.Forms.RadioButton radioButton_dateSep1_slash;
        private System.Windows.Forms.GroupBox groupBox_dateSep1;
        private System.Windows.Forms.TextBox textBox_dateSep1_custom;
        private System.Windows.Forms.RadioButton radioButton_dateSep1_custom;
        private System.Windows.Forms.RadioButton radioButton_dateSep1_underscore;
        private System.Windows.Forms.RadioButton radioButton_dateSep1_none;
        private System.Windows.Forms.RadioButton radioButton_dateSep1_dotSpace;
        private System.Windows.Forms.RadioButton radioButton_dateSep1_commaSpace;
        private System.Windows.Forms.RadioButton radioButton_dateSep1_space;
        private System.Windows.Forms.GroupBox groupBox_dateSep2;
        private System.Windows.Forms.CheckBox checkBox_dateSep2_sameAsDateSep1;
        private System.Windows.Forms.TextBox textBox_dateSep2_custom;
        private System.Windows.Forms.RadioButton radioButton_dateSep2_custom;
        private System.Windows.Forms.RadioButton radioButton_dateSep2_underscore;
        private System.Windows.Forms.RadioButton radioButton_dateSep2_none;
        private System.Windows.Forms.RadioButton radioButton_dateSep2_dotSpace;
        private System.Windows.Forms.RadioButton radioButton_dateSep2_commaSpace;
        private System.Windows.Forms.RadioButton radioButton_dateSep2_space;
        private System.Windows.Forms.RadioButton radioButton_dateSep2_slash;
        private System.Windows.Forms.RadioButton radioButton_dateSep2_dot;
        private System.Windows.Forms.RadioButton radioButton_dateSep2_hyphen;
        private System.Windows.Forms.GroupBox groupBox_weekday;
        private System.Windows.Forms.CheckBox checkBox_showWeekday;
        private System.Windows.Forms.RadioButton radioButton_weekdayAfterDate;
        private System.Windows.Forms.RadioButton radioButton_weekdayBeforeDate;
        private System.Windows.Forms.GroupBox groupBox_weekdaySep;
        private System.Windows.Forms.TextBox textBox_weekdaySep_custom;
        private System.Windows.Forms.RadioButton radioButton_weekdaySep_custom;
        private System.Windows.Forms.RadioButton radioButton_weekdaySep_underscore;
        private System.Windows.Forms.RadioButton radioButton_weekdaySep_none;
        private System.Windows.Forms.RadioButton radioButton_weekdaySep_dotSpace;
        private System.Windows.Forms.RadioButton radioButton_weekdaySep_commaSpace;
        private System.Windows.Forms.RadioButton radioButton_weekdaySep_space;
        private System.Windows.Forms.RadioButton radioButton_weekdaySep_hyphen;
        private System.Windows.Forms.RadioButton radioButton_weekdaySep_dot;
        private System.Windows.Forms.GroupBox groupBox_dateTimeSep;
        private System.Windows.Forms.TextBox textBox_dateTimeSep_custom;
        private System.Windows.Forms.RadioButton radioButton_dateTimeSep_custom;
        private System.Windows.Forms.RadioButton radioButton_dateTimeSep_underscore;
        private System.Windows.Forms.RadioButton radioButton_dateTimeSep_none;
        private System.Windows.Forms.RadioButton radioButton_dateTimeSep_dot;
        private System.Windows.Forms.RadioButton radioButton_dateTimeSep_t;
        private System.Windows.Forms.RadioButton radioButton_dateTimeSep_commaSpace;
        private System.Windows.Forms.RadioButton radioButton_dateTimeSep_space;
        private System.Windows.Forms.RadioButton radioButton_dateTimeSep_hyphen;
        private System.Windows.Forms.GroupBox groupBox_timeFormat;
        private System.Windows.Forms.RadioButton radioButton_timeFormat_1_12amPmLast;
        private System.Windows.Forms.RadioButton radioButton_timeFormat_0_11amPmLast;
        private System.Windows.Forms.RadioButton radioButton_timeFormat_1_12amPmFirst;
        private System.Windows.Forms.RadioButton radioButton_timeFormat_0_11amPmFirst;
        private System.Windows.Forms.RadioButton radioButton_timeFormat_1_24;
        private System.Windows.Forms.RadioButton radioButton_timeFormat_0_23;
        private System.Windows.Forms.CheckBox checkBox_showSeconds;
        private System.Windows.Forms.CheckBox checkBox_zeroPadHour;
        private System.Windows.Forms.GroupBox groupBox_hrMinSep;
        private System.Windows.Forms.TextBox textBox_hrMinSep_custom;
        private System.Windows.Forms.RadioButton radioButton_hrMinSep_space;
        private System.Windows.Forms.RadioButton radioButton_hrMinSep_custom;
        private System.Windows.Forms.RadioButton radioButton_hrMinSep_none;
        private System.Windows.Forms.RadioButton radioButton_hrMinSep_hyphen;
        private System.Windows.Forms.RadioButton radioButton_hrMinSep_dot;
        private System.Windows.Forms.RadioButton radioButton_hrMinSep_colon;
        private System.Windows.Forms.GroupBox groupBox_minSecSep;
        private System.Windows.Forms.CheckBox checkBox_minSecSep_sameAsHrMin;
        private System.Windows.Forms.TextBox textBox_minSecSep_custom;
        private System.Windows.Forms.RadioButton radioButton_minSecSep_space;
        private System.Windows.Forms.RadioButton radioButton_minSecSep_custom;
        private System.Windows.Forms.RadioButton radioButton_minSecSep_none;
        private System.Windows.Forms.RadioButton radioButton_minSecSep_hyphen;
        private System.Windows.Forms.RadioButton radioButton_minSecSep_dot;
        private System.Windows.Forms.RadioButton radioButton_minSecSep_colon;
        private System.Windows.Forms.GroupBox groupBox_amPmFormat;
        private System.Windows.Forms.Label label_pmCustom;
        private System.Windows.Forms.Label label_amCustom;
        private System.Windows.Forms.TextBox textBox_pmCustom;
        private System.Windows.Forms.TextBox textBox_amCustom;
        private System.Windows.Forms.RadioButton radioButton_amPmLowercaseDots;
        private System.Windows.Forms.RadioButton radioButton_amPmCustom;
        private System.Windows.Forms.RadioButton radioButton_ap_lowercase;
        private System.Windows.Forms.RadioButton radioButton_ap_capital;
        private System.Windows.Forms.RadioButton radioButton_amPmCapitalDots;
        private System.Windows.Forms.RadioButton radioButton_amPmLowercase;
        private System.Windows.Forms.RadioButton radioButton_amPmCapital;
        private System.Windows.Forms.GroupBox groupBox_amPmSep;
        private System.Windows.Forms.TextBox textBox_amPmSep_custom;
        private System.Windows.Forms.RadioButton radioButton_amPmSep_dot;
        private System.Windows.Forms.RadioButton radioButton_amPmSep_custom;
        private System.Windows.Forms.RadioButton radioButton_amPmSep_underscore;
        private System.Windows.Forms.RadioButton radioButton_amPmSep_none;
        private System.Windows.Forms.RadioButton radioButton_amPmSep_space;
        private System.Windows.Forms.GroupBox groupBox_dateEndChar;
        private System.Windows.Forms.TextBox textBox_dateEndChar_custom;
        private System.Windows.Forms.RadioButton radioButton_dateEndChar_custom;
        private System.Windows.Forms.RadioButton radioButton_dateEndChar_dot;
        private System.Windows.Forms.RadioButton radioButton_dateEndChar_none;
        private System.Windows.Forms.GroupBox groupBox_showDateTime;
        private System.Windows.Forms.RadioButton radioButton_timeOnly;
        private System.Windows.Forms.RadioButton radioButton_dateOnly;
        private System.Windows.Forms.RadioButton radioButton_timeThenDate;
        private System.Windows.Forms.RadioButton radioButton_dateThenTime;
        private System.Windows.Forms.GroupBox groupBox_dateTime;
        private System.Windows.Forms.GroupBox groupBox_date;
        private System.Windows.Forms.GroupBox groupBox_time;
        private System.Windows.Forms.Button button_copyDateTime;
        private System.Windows.Forms.Button button_saveDateTimeToFile;
        private System.Windows.Forms.CheckBox checkBox_showDateInTitle;
        private System.Windows.Forms.CheckBox checkBox_loadSettings;
        private System.Windows.Forms.Button button_savePreset;
        private System.Windows.Forms.Button button_customizeMonthFormat;
        private System.Windows.Forms.RadioButton radioButton_monthFormat_custom;
        private System.Windows.Forms.GroupBox groupBox_weekdayFormat;
        private System.Windows.Forms.RadioButton radioButton_weekdayFull;
        private System.Windows.Forms.RadioButton radioButton_weekday_3letter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_suitableForFilenames;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_europeanShort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_europeanNumerical;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_britishMedium;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_britishFull;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_americanShort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_americanNumerical;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_americanMedium;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_americanFull;
        private System.Windows.Forms.Button button_changeCustomDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_chinese;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_hungarian;
        private System.Windows.Forms.Button button_customizeWeekdayFormat;
        private System.Windows.Forms.RadioButton radioButton_customWeekday;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_vietnamese;
        private System.Windows.Forms.Button button_deletePreset;
    }
}

