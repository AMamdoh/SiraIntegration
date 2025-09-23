namespace SiraIntegration
{
    partial class FrmMain
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
            this.count_of_canceled_orders = new System.Windows.Forms.Label();
            this.lbl_count_of_canceled_orders = new System.Windows.Forms.Label();
            this.dataGridViewCanceledOrders = new System.Windows.Forms.DataGridView();
            this.panelCanceledOrdersTop = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBoxFilterCanceled = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_clear_canceledorder = new System.Windows.Forms.Button();
            this.btnSearchCanceled = new System.Windows.Forms.Button();
            this.txtRefNumberForCanceled = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logTimer = new System.Windows.Forms.Timer(this.components);
            this.ReviewTimer = new System.Windows.Forms.Timer(this.components);
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.gpBoxMaxHoursToSend = new System.Windows.Forms.GroupBox();
            this.numericUpForHours = new System.Windows.Forms.NumericUpDown();
            this.btn_save_MaxHours = new System.Windows.Forms.Button();
            this.lblMaxHours = new System.Windows.Forms.Label();
            this.grpBoxAllowedStores = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_Stores_Save = new System.Windows.Forms.Button();
            this.textBoxStores = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.grpBoxLogDetails = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numericClearLogInterval = new System.Windows.Forms.NumericUpDown();
            this.cmbClearLogInterval = new System.Windows.Forms.ComboBox();
            this.btnSaveLogs = new System.Windows.Forms.Button();
            this.txtLogFolderName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpBoxDispatchOrders = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericReviewsOrderInterval = new System.Windows.Forms.NumericUpDown();
            this.cmbPostReviewsInterval = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnSaveTimers = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericPostOrderInterval = new System.Windows.Forms.NumericUpDown();
            this.cmbPostOrderInterval = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBoxAPIDetails = new System.Windows.Forms.GroupBox();
            this.btnSaveAPIDetails = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtAPIURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBoxDatabaseDetails = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRoboostOrderTableName = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.UnitsComboBox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtReviewsViewName = new System.Windows.Forms.TextBox();
            this.lblReviewName = new System.Windows.Forms.Label();
            this.txtNewOrdersViewName = new System.Windows.Forms.TextBox();
            this.lblOrdersViewName = new System.Windows.Forms.Label();
            this.btnSaveDatabaseDetails = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageOrderWithReviews = new System.Windows.Forms.TabPage();
            this.count_of_OrdersWithReviews = new System.Windows.Forms.Label();
            this.lbl_count_orderswithreview = new System.Windows.Forms.Label();
            this.dataGridViewReviewsOrders = new System.Windows.Forms.DataGridView();
            this.panelUpdatedOrdersTop = new System.Windows.Forms.Panel();
            this.lblRefNumnerForUpdate = new System.Windows.Forms.Label();
            this.btn_clear_updatedorder = new System.Windows.Forms.Button();
            this.btnSearchUpdatedOrder = new System.Windows.Forms.Button();
            this.lblFilterForUpdate = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRefNumberForUpdate = new System.Windows.Forms.TextBox();
            this.comboBoxFiterReviews = new System.Windows.Forms.ComboBox();
            this.tabPagePostedOrders = new System.Windows.Forms.TabPage();
            this.count_orders = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.dataGridViewPostedOrders = new System.Windows.Forms.DataGridView();
            this.panelPostedOrdersTop = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblRefNumber = new System.Windows.Forms.Label();
            this.txtRefNumber = new System.Windows.Forms.TextBox();
            this.lblOrderStatusFilter = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.txtLastError = new System.Windows.Forms.TextBox();
            this.txtLastSuccessActionTime = new System.Windows.Forms.TextBox();
            this.lbl_LastSuccessActionTime = new System.Windows.Forms.Label();
            this.lbTextOfStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.dataGridViewLogger = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanceledOrders)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            this.gpBoxMaxHoursToSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpForHours)).BeginInit();
            this.grpBoxAllowedStores.SuspendLayout();
            this.grpBoxLogDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericClearLogInterval)).BeginInit();
            this.grpBoxDispatchOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReviewsOrderInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPostOrderInterval)).BeginInit();
            this.grpBoxAPIDetails.SuspendLayout();
            this.grpBoxDatabaseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPageOrderWithReviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviewsOrders)).BeginInit();
            this.panelUpdatedOrdersTop.SuspendLayout();
            this.tabPagePostedOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostedOrders)).BeginInit();
            this.panelPostedOrdersTop.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogger)).BeginInit();
            this.SuspendLayout();
            // 
            // count_of_canceled_orders
            // 
            this.count_of_canceled_orders.Location = new System.Drawing.Point(0, 0);
            this.count_of_canceled_orders.Name = "count_of_canceled_orders";
            this.count_of_canceled_orders.Size = new System.Drawing.Size(100, 23);
            this.count_of_canceled_orders.TabIndex = 0;
            // 
            // lbl_count_of_canceled_orders
            // 
            this.lbl_count_of_canceled_orders.Location = new System.Drawing.Point(0, 0);
            this.lbl_count_of_canceled_orders.Name = "lbl_count_of_canceled_orders";
            this.lbl_count_of_canceled_orders.Size = new System.Drawing.Size(100, 23);
            this.lbl_count_of_canceled_orders.TabIndex = 0;
            // 
            // dataGridViewCanceledOrders
            // 
            this.dataGridViewCanceledOrders.ColumnHeadersHeight = 29;
            this.dataGridViewCanceledOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCanceledOrders.Name = "dataGridViewCanceledOrders";
            this.dataGridViewCanceledOrders.RowHeadersWidth = 51;
            this.dataGridViewCanceledOrders.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCanceledOrders.TabIndex = 0;
            // 
            // panelCanceledOrdersTop
            // 
            this.panelCanceledOrdersTop.Location = new System.Drawing.Point(0, 0);
            this.panelCanceledOrdersTop.Name = "panelCanceledOrdersTop";
            this.panelCanceledOrdersTop.Size = new System.Drawing.Size(200, 100);
            this.panelCanceledOrdersTop.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(70, 25);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(272, 31);
            this.label28.TabIndex = 19;
            this.label28.Text = "Filter by Order Status";
            // 
            // comboBoxFilterCanceled
            // 
            this.comboBoxFilterCanceled.Location = new System.Drawing.Point(0, 0);
            this.comboBoxFilterCanceled.Name = "comboBoxFilterCanceled";
            this.comboBoxFilterCanceled.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilterCanceled.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label26.Location = new System.Drawing.Point(515, 24);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(258, 31);
            this.label26.TabIndex = 17;
            this.label26.Text = "Reference Number :";
            // 
            // btn_clear_canceledorder
            // 
            this.btn_clear_canceledorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear_canceledorder.BackColor = System.Drawing.Color.Gray;
            this.btn_clear_canceledorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_canceledorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_canceledorder.ForeColor = System.Drawing.Color.White;
            this.btn_clear_canceledorder.Location = new System.Drawing.Point(1013, 20);
            this.btn_clear_canceledorder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear_canceledorder.Name = "btn_clear_canceledorder";
            this.btn_clear_canceledorder.Size = new System.Drawing.Size(82, 32);
            this.btn_clear_canceledorder.TabIndex = 16;
            this.btn_clear_canceledorder.Text = "Clear";
            this.btn_clear_canceledorder.UseVisualStyleBackColor = false;
            // 
            // btnSearchCanceled
            // 
            this.btnSearchCanceled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchCanceled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(231)))));
            this.btnSearchCanceled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCanceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCanceled.ForeColor = System.Drawing.Color.White;
            this.btnSearchCanceled.Location = new System.Drawing.Point(900, 20);
            this.btnSearchCanceled.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCanceled.Name = "btnSearchCanceled";
            this.btnSearchCanceled.Size = new System.Drawing.Size(96, 32);
            this.btnSearchCanceled.TabIndex = 15;
            this.btnSearchCanceled.Text = "Search";
            this.btnSearchCanceled.UseVisualStyleBackColor = false;
            // 
            // txtRefNumberForCanceled
            // 
            this.txtRefNumberForCanceled.Location = new System.Drawing.Point(727, 23);
            this.txtRefNumberForCanceled.Margin = new System.Windows.Forms.Padding(2);
            this.txtRefNumberForCanceled.Name = "txtRefNumberForCanceled";
            this.txtRefNumberForCanceled.Size = new System.Drawing.Size(76, 22);
            this.txtRefNumberForCanceled.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.PostOrderTimer_Tick);
            // 
            // logTimer
            // 
            this.logTimer.Interval = 1000;
            this.logTimer.Tick += new System.EventHandler(this.logTimer_Tick);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.gpBoxMaxHoursToSend);
            this.tabPageSettings.Controls.Add(this.grpBoxAllowedStores);
            this.tabPageSettings.Controls.Add(this.grpBoxLogDetails);
            this.tabPageSettings.Controls.Add(this.grpBoxDispatchOrders);
            this.tabPageSettings.Controls.Add(this.grpBoxAPIDetails);
            this.tabPageSettings.Controls.Add(this.grpBoxDatabaseDetails);
            this.tabPageSettings.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSettings.Location = new System.Drawing.Point(4, 44);
            this.tabPageSettings.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(1192, 752);
            this.tabPageSettings.TabIndex = 4;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            this.tabPageSettings.Click += new System.EventHandler(this.tabPageSettings_Click);
            // 
            // gpBoxMaxHoursToSend
            // 
            this.gpBoxMaxHoursToSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpBoxMaxHoursToSend.Controls.Add(this.numericUpForHours);
            this.gpBoxMaxHoursToSend.Controls.Add(this.btn_save_MaxHours);
            this.gpBoxMaxHoursToSend.Controls.Add(this.lblMaxHours);
            this.gpBoxMaxHoursToSend.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxMaxHoursToSend.ForeColor = System.Drawing.Color.DarkRed;
            this.gpBoxMaxHoursToSend.Location = new System.Drawing.Point(6, 530);
            this.gpBoxMaxHoursToSend.Margin = new System.Windows.Forms.Padding(2);
            this.gpBoxMaxHoursToSend.Name = "gpBoxMaxHoursToSend";
            this.gpBoxMaxHoursToSend.Padding = new System.Windows.Forms.Padding(2);
            this.gpBoxMaxHoursToSend.Size = new System.Drawing.Size(525, 180);
            this.gpBoxMaxHoursToSend.TabIndex = 18;
            this.gpBoxMaxHoursToSend.TabStop = false;
            this.gpBoxMaxHoursToSend.Text = "Max Hours For Sending";
            // 
            // numericUpForHours
            // 
            this.numericUpForHours.Location = new System.Drawing.Point(190, 73);
            this.numericUpForHours.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpForHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpForHours.Name = "numericUpForHours";
            this.numericUpForHours.Size = new System.Drawing.Size(90, 34);
            this.numericUpForHours.TabIndex = 18;
            this.numericUpForHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpForHours.ValueChanged += new System.EventHandler(this.numericUpForHours_ValueChanged);
            // 
            // btn_save_MaxHours
            // 
            this.btn_save_MaxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_MaxHours.Location = new System.Drawing.Point(302, 67);
            this.btn_save_MaxHours.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save_MaxHours.Name = "btn_save_MaxHours";
            this.btn_save_MaxHours.Size = new System.Drawing.Size(98, 40);
            this.btn_save_MaxHours.TabIndex = 20;
            this.btn_save_MaxHours.Text = "Save";
            this.btn_save_MaxHours.UseVisualStyleBackColor = true;
            this.btn_save_MaxHours.Click += new System.EventHandler(this.btn_save_MaxHours_Click);
            // 
            // lblMaxHours
            // 
            this.lblMaxHours.AutoSize = true;
            this.lblMaxHours.ForeColor = System.Drawing.Color.Black;
            this.lblMaxHours.Location = new System.Drawing.Point(52, 75);
            this.lblMaxHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxHours.Name = "lblMaxHours";
            this.lblMaxHours.Size = new System.Drawing.Size(125, 29);
            this.lblMaxHours.TabIndex = 18;
            this.lblMaxHours.Text = "Max Hours :";
            // 
            // grpBoxAllowedStores
            // 
            this.grpBoxAllowedStores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxAllowedStores.Controls.Add(this.label23);
            this.grpBoxAllowedStores.Controls.Add(this.btn_Stores_Save);
            this.grpBoxAllowedStores.Controls.Add(this.textBoxStores);
            this.grpBoxAllowedStores.Controls.Add(this.label24);
            this.grpBoxAllowedStores.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAllowedStores.ForeColor = System.Drawing.Color.DarkRed;
            this.grpBoxAllowedStores.Location = new System.Drawing.Point(554, 522);
            this.grpBoxAllowedStores.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxAllowedStores.Name = "grpBoxAllowedStores";
            this.grpBoxAllowedStores.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxAllowedStores.Size = new System.Drawing.Size(568, 188);
            this.grpBoxAllowedStores.TabIndex = 10;
            this.grpBoxAllowedStores.TabStop = false;
            this.grpBoxAllowedStores.Text = "Allowed stores";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.OrangeRed;
            this.label23.Location = new System.Drawing.Point(24, 166);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(678, 29);
            this.label23.TabIndex = 10;
            this.label23.Text = "write a comma seperated codes [1,2,3, ...]. Leave empty to get all stores";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // btn_Stores_Save
            // 
            this.btn_Stores_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stores_Save.Location = new System.Drawing.Point(456, 75);
            this.btn_Stores_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Stores_Save.Name = "btn_Stores_Save";
            this.btn_Stores_Save.Size = new System.Drawing.Size(97, 54);
            this.btn_Stores_Save.TabIndex = 9;
            this.btn_Stores_Save.Text = "Save";
            this.btn_Stores_Save.UseVisualStyleBackColor = true;
            this.btn_Stores_Save.Click += new System.EventHandler(this.btn_Stores_Save_Click);
            // 
            // textBoxStores
            // 
            this.textBoxStores.Location = new System.Drawing.Point(182, 20);
            this.textBoxStores.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStores.Multiline = true;
            this.textBoxStores.Name = "textBoxStores";
            this.textBoxStores.Size = new System.Drawing.Size(260, 130);
            this.textBoxStores.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(10, 71);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(149, 29);
            this.label24.TabIndex = 0;
            this.label24.Text = "Stores codes :";
            // 
            // grpBoxLogDetails
            // 
            this.grpBoxLogDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxLogDetails.Controls.Add(this.label15);
            this.grpBoxLogDetails.Controls.Add(this.numericClearLogInterval);
            this.grpBoxLogDetails.Controls.Add(this.cmbClearLogInterval);
            this.grpBoxLogDetails.Controls.Add(this.btnSaveLogs);
            this.grpBoxLogDetails.Controls.Add(this.txtLogFolderName);
            this.grpBoxLogDetails.Controls.Add(this.label13);
            this.grpBoxLogDetails.Controls.Add(this.label14);
            this.grpBoxLogDetails.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxLogDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.grpBoxLogDetails.Location = new System.Drawing.Point(554, 249);
            this.grpBoxLogDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxLogDetails.Name = "grpBoxLogDetails";
            this.grpBoxLogDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxLogDetails.Size = new System.Drawing.Size(568, 137);
            this.grpBoxLogDetails.TabIndex = 10;
            this.grpBoxLogDetails.TabStop = false;
            this.grpBoxLogDetails.Text = "Log Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(117, 103);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 29);
            this.label15.TabIndex = 14;
            this.label15.Text = "Occurs every";
            // 
            // numericClearLogInterval
            // 
            this.numericClearLogInterval.Location = new System.Drawing.Point(264, 103);
            this.numericClearLogInterval.Margin = new System.Windows.Forms.Padding(2);
            this.numericClearLogInterval.Name = "numericClearLogInterval";
            this.numericClearLogInterval.Size = new System.Drawing.Size(58, 34);
            this.numericClearLogInterval.TabIndex = 13;
            // 
            // cmbClearLogInterval
            // 
            this.cmbClearLogInterval.DisplayMember = "Name";
            this.cmbClearLogInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClearLogInterval.FormattingEnabled = true;
            this.cmbClearLogInterval.Location = new System.Drawing.Point(350, 102);
            this.cmbClearLogInterval.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClearLogInterval.Name = "cmbClearLogInterval";
            this.cmbClearLogInterval.Size = new System.Drawing.Size(92, 35);
            this.cmbClearLogInterval.TabIndex = 12;
            this.cmbClearLogInterval.ValueMember = "ID";
            // 
            // btnSaveLogs
            // 
            this.btnSaveLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLogs.Location = new System.Drawing.Point(456, 42);
            this.btnSaveLogs.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveLogs.Name = "btnSaveLogs";
            this.btnSaveLogs.Size = new System.Drawing.Size(103, 48);
            this.btnSaveLogs.TabIndex = 9;
            this.btnSaveLogs.Text = "Save";
            this.btnSaveLogs.UseVisualStyleBackColor = true;
            this.btnSaveLogs.Click += new System.EventHandler(this.btnSaveLogs_Click);
            // 
            // txtLogFolderName
            // 
            this.txtLogFolderName.Location = new System.Drawing.Point(157, 37);
            this.txtLogFolderName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogFolderName.Name = "txtLogFolderName";
            this.txtLogFolderName.Size = new System.Drawing.Size(261, 34);
            this.txtLogFolderName.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(20, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "Clear Log:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(15, 40);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Log folder:";
            // 
            // grpBoxDispatchOrders
            // 
            this.grpBoxDispatchOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxDispatchOrders.Controls.Add(this.numericUpDown3);
            this.grpBoxDispatchOrders.Controls.Add(this.label11);
            this.grpBoxDispatchOrders.Controls.Add(this.label5);
            this.grpBoxDispatchOrders.Controls.Add(this.numericReviewsOrderInterval);
            this.grpBoxDispatchOrders.Controls.Add(this.cmbPostReviewsInterval);
            this.grpBoxDispatchOrders.Controls.Add(this.label9);
            this.grpBoxDispatchOrders.Controls.Add(this.numericUpDown2);
            this.grpBoxDispatchOrders.Controls.Add(this.btnSaveTimers);
            this.grpBoxDispatchOrders.Controls.Add(this.label16);
            this.grpBoxDispatchOrders.Controls.Add(this.label10);
            this.grpBoxDispatchOrders.Controls.Add(this.numericPostOrderInterval);
            this.grpBoxDispatchOrders.Controls.Add(this.cmbPostOrderInterval);
            this.grpBoxDispatchOrders.Controls.Add(this.label6);
            this.grpBoxDispatchOrders.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDispatchOrders.ForeColor = System.Drawing.Color.DarkRed;
            this.grpBoxDispatchOrders.Location = new System.Drawing.Point(554, 18);
            this.grpBoxDispatchOrders.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxDispatchOrders.Name = "grpBoxDispatchOrders";
            this.grpBoxDispatchOrders.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxDispatchOrders.Size = new System.Drawing.Size(568, 227);
            this.grpBoxDispatchOrders.TabIndex = 5;
            this.grpBoxDispatchOrders.TabStop = false;
            this.grpBoxDispatchOrders.Text = "Dispatch Orders";
            this.grpBoxDispatchOrders.Enter += new System.EventHandler(this.grpBoxDispatchOrders_Enter);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(298, 87);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(58, 34);
            this.numericUpDown3.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(10, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "Number of Reviews to Fetch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(177, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Occurs every";
            // 
            // numericReviewsOrderInterval
            // 
            this.numericReviewsOrderInterval.Location = new System.Drawing.Point(301, 186);
            this.numericReviewsOrderInterval.Margin = new System.Windows.Forms.Padding(2);
            this.numericReviewsOrderInterval.Name = "numericReviewsOrderInterval";
            this.numericReviewsOrderInterval.Size = new System.Drawing.Size(58, 34);
            this.numericReviewsOrderInterval.TabIndex = 16;
            // 
            // cmbPostReviewsInterval
            // 
            this.cmbPostReviewsInterval.DisplayMember = "Name";
            this.cmbPostReviewsInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPostReviewsInterval.FormattingEnabled = true;
            this.cmbPostReviewsInterval.Location = new System.Drawing.Point(397, 188);
            this.cmbPostReviewsInterval.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPostReviewsInterval.Name = "cmbPostReviewsInterval";
            this.cmbPostReviewsInterval.Size = new System.Drawing.Size(92, 35);
            this.cmbPostReviewsInterval.TabIndex = 15;
            this.cmbPostReviewsInterval.ValueMember = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(13, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Post Reviews:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(295, 45);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 34);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btnSaveTimers
            // 
            this.btnSaveTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTimers.Location = new System.Drawing.Point(456, 102);
            this.btnSaveTimers.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveTimers.Name = "btnSaveTimers";
            this.btnSaveTimers.Size = new System.Drawing.Size(97, 45);
            this.btnSaveTimers.TabIndex = 10;
            this.btnSaveTimers.Text = "Save";
            this.btnSaveTimers.UseVisualStyleBackColor = true;
            this.btnSaveTimers.Click += new System.EventHandler(this.btnSaveTimers_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(10, 45);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(271, 29);
            this.label16.TabIndex = 12;
            this.label16.Text = "Number of Orders to Fetch:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(163, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Occurs every";
            // 
            // numericPostOrderInterval
            // 
            this.numericPostOrderInterval.Location = new System.Drawing.Point(274, 141);
            this.numericPostOrderInterval.Margin = new System.Windows.Forms.Padding(2);
            this.numericPostOrderInterval.Name = "numericPostOrderInterval";
            this.numericPostOrderInterval.Size = new System.Drawing.Size(58, 34);
            this.numericPostOrderInterval.TabIndex = 4;
            // 
            // cmbPostOrderInterval
            // 
            this.cmbPostOrderInterval.DisplayMember = "Name";
            this.cmbPostOrderInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPostOrderInterval.FormattingEnabled = true;
            this.cmbPostOrderInterval.Location = new System.Drawing.Point(346, 140);
            this.cmbPostOrderInterval.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPostOrderInterval.Name = "cmbPostOrderInterval";
            this.cmbPostOrderInterval.Size = new System.Drawing.Size(92, 35);
            this.cmbPostOrderInterval.TabIndex = 3;
            this.cmbPostOrderInterval.ValueMember = "ID";
            this.cmbPostOrderInterval.SelectedIndexChanged += new System.EventHandler(this.cmbPostOrderInterval_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(13, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Post Orders:";
            // 
            // grpBoxAPIDetails
            // 
            this.grpBoxAPIDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxAPIDetails.Controls.Add(this.btnSaveAPIDetails);
            this.grpBoxAPIDetails.Controls.Add(this.txtToken);
            this.grpBoxAPIDetails.Controls.Add(this.txtAPIURL);
            this.grpBoxAPIDetails.Controls.Add(this.label7);
            this.grpBoxAPIDetails.Controls.Add(this.label8);
            this.grpBoxAPIDetails.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAPIDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.grpBoxAPIDetails.Location = new System.Drawing.Point(554, 390);
            this.grpBoxAPIDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxAPIDetails.Name = "grpBoxAPIDetails";
            this.grpBoxAPIDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxAPIDetails.Size = new System.Drawing.Size(568, 128);
            this.grpBoxAPIDetails.TabIndex = 4;
            this.grpBoxAPIDetails.TabStop = false;
            this.grpBoxAPIDetails.Text = "API Details";
            this.grpBoxAPIDetails.Enter += new System.EventHandler(this.grpBoxAPIDetails_Enter);
            // 
            // btnSaveAPIDetails
            // 
            this.btnSaveAPIDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAPIDetails.Location = new System.Drawing.Point(456, 66);
            this.btnSaveAPIDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAPIDetails.Name = "btnSaveAPIDetails";
            this.btnSaveAPIDetails.Size = new System.Drawing.Size(97, 41);
            this.btnSaveAPIDetails.TabIndex = 9;
            this.btnSaveAPIDetails.Text = "Save";
            this.btnSaveAPIDetails.UseVisualStyleBackColor = true;
            this.btnSaveAPIDetails.Click += new System.EventHandler(this.btnSaveAPIDetails_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(133, 91);
            this.txtToken.Margin = new System.Windows.Forms.Padding(2);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(242, 34);
            this.txtToken.TabIndex = 6;
            // 
            // txtAPIURL
            // 
            this.txtAPIURL.Location = new System.Drawing.Point(133, 49);
            this.txtAPIURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtAPIURL.Name = "txtAPIURL";
            this.txtAPIURL.Size = new System.Drawing.Size(242, 34);
            this.txtAPIURL.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(9, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Token:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(10, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "API URL:";
            // 
            // grpBoxDatabaseDetails
            // 
            this.grpBoxDatabaseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBoxDatabaseDetails.Controls.Add(this.label21);
            this.grpBoxDatabaseDetails.Controls.Add(this.txtRoboostOrderTableName);
            this.grpBoxDatabaseDetails.Controls.Add(this.numericUpDown1);
            this.grpBoxDatabaseDetails.Controls.Add(this.label20);
            this.grpBoxDatabaseDetails.Controls.Add(this.UnitsComboBox);
            this.grpBoxDatabaseDetails.Controls.Add(this.label22);
            this.grpBoxDatabaseDetails.Controls.Add(this.txtReviewsViewName);
            this.grpBoxDatabaseDetails.Controls.Add(this.lblReviewName);
            this.grpBoxDatabaseDetails.Controls.Add(this.txtNewOrdersViewName);
            this.grpBoxDatabaseDetails.Controls.Add(this.lblOrdersViewName);
            this.grpBoxDatabaseDetails.Controls.Add(this.btnSaveDatabaseDetails);
            this.grpBoxDatabaseDetails.Controls.Add(this.txtPassword);
            this.grpBoxDatabaseDetails.Controls.Add(this.txtUserName);
            this.grpBoxDatabaseDetails.Controls.Add(this.txtDatabaseName);
            this.grpBoxDatabaseDetails.Controls.Add(this.txtServerIP);
            this.grpBoxDatabaseDetails.Controls.Add(this.label4);
            this.grpBoxDatabaseDetails.Controls.Add(this.label3);
            this.grpBoxDatabaseDetails.Controls.Add(this.label2);
            this.grpBoxDatabaseDetails.Controls.Add(this.label1);
            this.grpBoxDatabaseDetails.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDatabaseDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.grpBoxDatabaseDetails.Location = new System.Drawing.Point(6, 18);
            this.grpBoxDatabaseDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxDatabaseDetails.Name = "grpBoxDatabaseDetails";
            this.grpBoxDatabaseDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxDatabaseDetails.Size = new System.Drawing.Size(525, 508);
            this.grpBoxDatabaseDetails.TabIndex = 0;
            this.grpBoxDatabaseDetails.TabStop = false;
            this.grpBoxDatabaseDetails.Text = "Database Details";
            this.grpBoxDatabaseDetails.Enter += new System.EventHandler(this.grpBoxDatabaseDetails_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(220, 375);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 29);
            this.label21.TabIndex = 17;
            this.label21.Text = "Occurs every";
            // 
            // txtRoboostOrderTableName
            // 
            this.txtRoboostOrderTableName.Location = new System.Drawing.Point(272, 320);
            this.txtRoboostOrderTableName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoboostOrderTableName.Name = "txtRoboostOrderTableName";
            this.txtRoboostOrderTableName.Size = new System.Drawing.Size(232, 34);
            this.txtRoboostOrderTableName.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(352, 373);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 34);
            this.numericUpDown1.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(6, 323);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 29);
            this.label20.TabIndex = 15;
            this.label20.Text = "Sira Orders Table:";
            // 
            // UnitsComboBox
            // 
            this.UnitsComboBox.DisplayMember = "Name";
            this.UnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitsComboBox.FormattingEnabled = true;
            this.UnitsComboBox.Location = new System.Drawing.Point(420, 372);
            this.UnitsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UnitsComboBox.Name = "UnitsComboBox";
            this.UnitsComboBox.Size = new System.Drawing.Size(84, 35);
            this.UnitsComboBox.TabIndex = 15;
            this.UnitsComboBox.ValueMember = "ID";
            this.UnitsComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitsComboBox_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(7, 375);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(204, 29);
            this.label22.TabIndex = 14;
            this.label22.Text = "Remove Old Orders:";
            // 
            // txtReviewsViewName
            // 
            this.txtReviewsViewName.Location = new System.Drawing.Point(272, 276);
            this.txtReviewsViewName.Margin = new System.Windows.Forms.Padding(2);
            this.txtReviewsViewName.Name = "txtReviewsViewName";
            this.txtReviewsViewName.Size = new System.Drawing.Size(232, 34);
            this.txtReviewsViewName.TabIndex = 12;
            // 
            // lblReviewName
            // 
            this.lblReviewName.AutoSize = true;
            this.lblReviewName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReviewName.Location = new System.Drawing.Point(6, 276);
            this.lblReviewName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReviewName.Name = "lblReviewName";
            this.lblReviewName.Size = new System.Drawing.Size(196, 29);
            this.lblReviewName.TabIndex = 11;
            this.lblReviewName.Text = "ReviewsViewName:";
            // 
            // txtNewOrdersViewName
            // 
            this.txtNewOrdersViewName.Location = new System.Drawing.Point(272, 222);
            this.txtNewOrdersViewName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewOrdersViewName.Name = "txtNewOrdersViewName";
            this.txtNewOrdersViewName.Size = new System.Drawing.Size(232, 34);
            this.txtNewOrdersViewName.TabIndex = 10;
            // 
            // lblOrdersViewName
            // 
            this.lblOrdersViewName.AutoSize = true;
            this.lblOrdersViewName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOrdersViewName.Location = new System.Drawing.Point(6, 218);
            this.lblOrdersViewName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdersViewName.Name = "lblOrdersViewName";
            this.lblOrdersViewName.Size = new System.Drawing.Size(176, 58);
            this.lblOrdersViewName.TabIndex = 9;
            this.lblOrdersViewName.Text = "OrdersViewName\n\n";
            // 
            // btnSaveDatabaseDetails
            // 
            this.btnSaveDatabaseDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDatabaseDetails.Location = new System.Drawing.Point(194, 442);
            this.btnSaveDatabaseDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveDatabaseDetails.Name = "btnSaveDatabaseDetails";
            this.btnSaveDatabaseDetails.Size = new System.Drawing.Size(86, 37);
            this.btnSaveDatabaseDetails.TabIndex = 8;
            this.btnSaveDatabaseDetails.Text = "Save";
            this.btnSaveDatabaseDetails.UseVisualStyleBackColor = true;
            this.btnSaveDatabaseDetails.Click += new System.EventHandler(this.btnSaveDatabaseDetails_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(272, 167);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 34);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(272, 111);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(232, 34);
            this.txtUserName.TabIndex = 6;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(272, 71);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(232, 34);
            this.txtDatabaseName.TabIndex = 5;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(272, 31);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(232, 34);
            this.txtServerIP.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP:";
            // 
            // tabPageOrderWithReviews
            // 
            this.tabPageOrderWithReviews.Controls.Add(this.count_of_OrdersWithReviews);
            this.tabPageOrderWithReviews.Controls.Add(this.lbl_count_orderswithreview);
            this.tabPageOrderWithReviews.Controls.Add(this.dataGridViewReviewsOrders);
            this.tabPageOrderWithReviews.Controls.Add(this.panelUpdatedOrdersTop);
            this.tabPageOrderWithReviews.Location = new System.Drawing.Point(4, 44);
            this.tabPageOrderWithReviews.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageOrderWithReviews.Name = "tabPageOrderWithReviews";
            this.tabPageOrderWithReviews.Size = new System.Drawing.Size(1192, 752);
            this.tabPageOrderWithReviews.TabIndex = 2;
            this.tabPageOrderWithReviews.Text = "Orders With Reviews";
            this.tabPageOrderWithReviews.UseVisualStyleBackColor = true;
            // 
            // count_of_OrdersWithReviews
            // 
            this.count_of_OrdersWithReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.count_of_OrdersWithReviews.AutoSize = true;
            this.count_of_OrdersWithReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_of_OrdersWithReviews.Location = new System.Drawing.Point(553, 540);
            this.count_of_OrdersWithReviews.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count_of_OrdersWithReviews.Name = "count_of_OrdersWithReviews";
            this.count_of_OrdersWithReviews.Size = new System.Drawing.Size(24, 25);
            this.count_of_OrdersWithReviews.TabIndex = 12;
            this.count_of_OrdersWithReviews.Text = "0";
            // 
            // lbl_count_orderswithreview
            // 
            this.lbl_count_orderswithreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_count_orderswithreview.AutoSize = true;
            this.lbl_count_orderswithreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count_orderswithreview.Location = new System.Drawing.Point(400, 540);
            this.lbl_count_orderswithreview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_count_orderswithreview.Name = "lbl_count_orderswithreview";
            this.lbl_count_orderswithreview.Size = new System.Drawing.Size(133, 25);
            this.lbl_count_orderswithreview.TabIndex = 11;
            this.lbl_count_orderswithreview.Text = "Total Orders";
            // 
            // dataGridViewReviewsOrders
            // 
            this.dataGridViewReviewsOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewReviewsOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviewsOrders.Location = new System.Drawing.Point(2, 82);
            this.dataGridViewReviewsOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReviewsOrders.Name = "dataGridViewReviewsOrders";
            this.dataGridViewReviewsOrders.RowHeadersWidth = 51;
            this.dataGridViewReviewsOrders.RowTemplate.Height = 24;
            this.dataGridViewReviewsOrders.Size = new System.Drawing.Size(1188, 638);
            this.dataGridViewReviewsOrders.TabIndex = 4;
            this.dataGridViewReviewsOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReviewsOrders_CellContentClick);
            // 
            // panelUpdatedOrdersTop
            // 
            this.panelUpdatedOrdersTop.Controls.Add(this.lblRefNumnerForUpdate);
            this.panelUpdatedOrdersTop.Controls.Add(this.btn_clear_updatedorder);
            this.panelUpdatedOrdersTop.Controls.Add(this.btnSearchUpdatedOrder);
            this.panelUpdatedOrdersTop.Controls.Add(this.lblFilterForUpdate);
            this.panelUpdatedOrdersTop.Controls.Add(this.label25);
            this.panelUpdatedOrdersTop.Controls.Add(this.txtRefNumberForUpdate);
            this.panelUpdatedOrdersTop.Controls.Add(this.comboBoxFiterReviews);
            this.panelUpdatedOrdersTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdatedOrdersTop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUpdatedOrdersTop.Location = new System.Drawing.Point(0, 0);
            this.panelUpdatedOrdersTop.Name = "panelUpdatedOrdersTop";
            this.panelUpdatedOrdersTop.Size = new System.Drawing.Size(1192, 80);
            this.panelUpdatedOrdersTop.TabIndex = 11;
            // 
            // lblRefNumnerForUpdate
            // 
            this.lblRefNumnerForUpdate.AutoSize = true;
            this.lblRefNumnerForUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefNumnerForUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRefNumnerForUpdate.Location = new System.Drawing.Point(553, 31);
            this.lblRefNumnerForUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRefNumnerForUpdate.Name = "lblRefNumnerForUpdate";
            this.lblRefNumnerForUpdate.Size = new System.Drawing.Size(182, 25);
            this.lblRefNumnerForUpdate.TabIndex = 13;
            this.lblRefNumnerForUpdate.Text = "Reference Number :";
            // 
            // btn_clear_updatedorder
            // 
            this.btn_clear_updatedorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear_updatedorder.BackColor = System.Drawing.Color.Gray;
            this.btn_clear_updatedorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_updatedorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_updatedorder.ForeColor = System.Drawing.Color.White;
            this.btn_clear_updatedorder.Location = new System.Drawing.Point(1000, 20);
            this.btn_clear_updatedorder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear_updatedorder.Name = "btn_clear_updatedorder";
            this.btn_clear_updatedorder.Size = new System.Drawing.Size(115, 36);
            this.btn_clear_updatedorder.TabIndex = 10;
            this.btn_clear_updatedorder.Text = "Clear";
            this.btn_clear_updatedorder.UseVisualStyleBackColor = false;
            this.btn_clear_updatedorder.Click += new System.EventHandler(this.btn_clear_Reviewsorder_Click);
            // 
            // btnSearchUpdatedOrder
            // 
            this.btnSearchUpdatedOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchUpdatedOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(231)))));
            this.btnSearchUpdatedOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUpdatedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUpdatedOrder.ForeColor = System.Drawing.Color.White;
            this.btnSearchUpdatedOrder.Location = new System.Drawing.Point(870, 20);
            this.btnSearchUpdatedOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchUpdatedOrder.Name = "btnSearchUpdatedOrder";
            this.btnSearchUpdatedOrder.Size = new System.Drawing.Size(112, 36);
            this.btnSearchUpdatedOrder.TabIndex = 9;
            this.btnSearchUpdatedOrder.Text = "Search";
            this.btnSearchUpdatedOrder.UseVisualStyleBackColor = false;
            this.btnSearchUpdatedOrder.Click += new System.EventHandler(this.btnSearchReviews_Click);
            // 
            // lblFilterForUpdate
            // 
            this.lblFilterForUpdate.AutoSize = true;
            this.lblFilterForUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterForUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFilterForUpdate.Location = new System.Drawing.Point(81, 29);
            this.lblFilterForUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterForUpdate.Name = "lblFilterForUpdate";
            this.lblFilterForUpdate.Size = new System.Drawing.Size(193, 25);
            this.lblFilterForUpdate.TabIndex = 2;
            this.lblFilterForUpdate.Text = "Filter by Order Status";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(15, 87);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(224, 31);
            this.label25.TabIndex = 1;
            this.label25.Text = "Last Action Time:";
            // 
            // txtRefNumberForUpdate
            // 
            this.txtRefNumberForUpdate.Location = new System.Drawing.Point(754, 26);
            this.txtRefNumberForUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRefNumberForUpdate.Name = "txtRefNumberForUpdate";
            this.txtRefNumberForUpdate.Size = new System.Drawing.Size(76, 31);
            this.txtRefNumberForUpdate.TabIndex = 1;
            // 
            // comboBoxFiterReviews
            // 
            this.comboBoxFiterReviews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiterReviews.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiterReviews.FormattingEnabled = true;
            this.comboBoxFiterReviews.Location = new System.Drawing.Point(307, 26);
            this.comboBoxFiterReviews.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFiterReviews.Name = "comboBoxFiterReviews";
            this.comboBoxFiterReviews.Size = new System.Drawing.Size(170, 33);
            this.comboBoxFiterReviews.TabIndex = 0;
            this.comboBoxFiterReviews.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiterReviews_SelectedIndexChanged);
            // 
            // tabPagePostedOrders
            // 
            this.tabPagePostedOrders.Controls.Add(this.count_orders);
            this.tabPagePostedOrders.Controls.Add(this.lblTotalOrders);
            this.tabPagePostedOrders.Controls.Add(this.dataGridViewPostedOrders);
            this.tabPagePostedOrders.Controls.Add(this.panelPostedOrdersTop);
            this.tabPagePostedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePostedOrders.Location = new System.Drawing.Point(4, 44);
            this.tabPagePostedOrders.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePostedOrders.Name = "tabPagePostedOrders";
            this.tabPagePostedOrders.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePostedOrders.Size = new System.Drawing.Size(1192, 752);
            this.tabPagePostedOrders.TabIndex = 1;
            this.tabPagePostedOrders.Text = "Posted Orders only";
            this.tabPagePostedOrders.UseVisualStyleBackColor = true;
            this.tabPagePostedOrders.Click += new System.EventHandler(this.tabPagePostedOrders_Click);
            // 
            // count_orders
            // 
            this.count_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.count_orders.AutoSize = true;
            this.count_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_orders.Location = new System.Drawing.Point(662, 727);
            this.count_orders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count_orders.Name = "count_orders";
            this.count_orders.Size = new System.Drawing.Size(24, 25);
            this.count_orders.TabIndex = 5;
            this.count_orders.Text = "0";
            this.count_orders.Click += new System.EventHandler(this.count_orders_Click);
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(551, 727);
            this.lblTotalOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(133, 25);
            this.lblTotalOrders.TabIndex = 3;
            this.lblTotalOrders.Text = "Total Orders";
            // 
            // dataGridViewPostedOrders
            // 
            this.dataGridViewPostedOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPostedOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPostedOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridViewPostedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostedOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPostedOrders.Location = new System.Drawing.Point(2, 82);
            this.dataGridViewPostedOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPostedOrders.Name = "dataGridViewPostedOrders";
            this.dataGridViewPostedOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPostedOrders.RowTemplate.Height = 24;
            this.dataGridViewPostedOrders.Size = new System.Drawing.Size(1188, 638);
            this.dataGridViewPostedOrders.TabIndex = 0;
            // 
            // panelPostedOrdersTop
            // 
            this.panelPostedOrdersTop.Controls.Add(this.btnClear);
            this.panelPostedOrdersTop.Controls.Add(this.btnSearch);
            this.panelPostedOrdersTop.Controls.Add(this.lblRefNumber);
            this.panelPostedOrdersTop.Controls.Add(this.txtRefNumber);
            this.panelPostedOrdersTop.Controls.Add(this.lblOrderStatusFilter);
            this.panelPostedOrdersTop.Controls.Add(this.comboBoxFilter);
            this.panelPostedOrdersTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPostedOrdersTop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPostedOrdersTop.Location = new System.Drawing.Point(2, 2);
            this.panelPostedOrdersTop.Name = "panelPostedOrdersTop";
            this.panelPostedOrdersTop.Size = new System.Drawing.Size(1188, 80);
            this.panelPostedOrdersTop.TabIndex = 10;
            this.panelPostedOrdersTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPostedOrdersTop_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1051, 21);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 41);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(231)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(913, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 41);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblRefNumber
            // 
            this.lblRefNumber.AutoSize = true;
            this.lblRefNumber.Location = new System.Drawing.Point(390, 30);
            this.lblRefNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRefNumber.Name = "lblRefNumber";
            this.lblRefNumber.Size = new System.Drawing.Size(182, 25);
            this.lblRefNumber.TabIndex = 7;
            this.lblRefNumber.Text = "Reference Number :";
            // 
            // txtRefNumber
            // 
            this.txtRefNumber.Location = new System.Drawing.Point(592, 21);
            this.txtRefNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtRefNumber.Multiline = true;
            this.txtRefNumber.Name = "txtRefNumber";
            this.txtRefNumber.Size = new System.Drawing.Size(236, 42);
            this.txtRefNumber.TabIndex = 6;
            // 
            // lblOrderStatusFilter
            // 
            this.lblOrderStatusFilter.AutoSize = true;
            this.lblOrderStatusFilter.Location = new System.Drawing.Point(20, 30);
            this.lblOrderStatusFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderStatusFilter.Name = "lblOrderStatusFilter";
            this.lblOrderStatusFilter.Size = new System.Drawing.Size(193, 25);
            this.lblOrderStatusFilter.TabIndex = 2;
            this.lblOrderStatusFilter.Text = "Filter by Order Status";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(242, 30);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(134, 33);
            this.comboBoxFilter.TabIndex = 1;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.txtLastError);
            this.tabPageSummary.Controls.Add(this.txtLastSuccessActionTime);
            this.tabPageSummary.Controls.Add(this.lbl_LastSuccessActionTime);
            this.tabPageSummary.Controls.Add(this.lbTextOfStatus);
            this.tabPageSummary.Controls.Add(this.lblStatus);
            this.tabPageSummary.Controls.Add(this.label27);
            this.tabPageSummary.Location = new System.Drawing.Point(4, 44);
            this.tabPageSummary.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSummary.Size = new System.Drawing.Size(1192, 752);
            this.tabPageSummary.TabIndex = 0;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            this.tabPageSummary.Click += new System.EventHandler(this.tabPageSummary_Click);
            // 
            // txtLastError
            // 
            this.txtLastError.Location = new System.Drawing.Point(406, 140);
            this.txtLastError.Multiline = true;
            this.txtLastError.Name = "txtLastError";
            this.txtLastError.Size = new System.Drawing.Size(299, 101);
            this.txtLastError.TabIndex = 6;
            // 
            // txtLastSuccessActionTime
            // 
            this.txtLastSuccessActionTime.Location = new System.Drawing.Point(406, 381);
            this.txtLastSuccessActionTime.Multiline = true;
            this.txtLastSuccessActionTime.Name = "txtLastSuccessActionTime";
            this.txtLastSuccessActionTime.Size = new System.Drawing.Size(299, 101);
            this.txtLastSuccessActionTime.TabIndex = 5;
            // 
            // lbl_LastSuccessActionTime
            // 
            this.lbl_LastSuccessActionTime.AutoSize = true;
            this.lbl_LastSuccessActionTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastSuccessActionTime.Location = new System.Drawing.Point(47, 412);
            this.lbl_LastSuccessActionTime.Name = "lbl_LastSuccessActionTime";
            this.lbl_LastSuccessActionTime.Size = new System.Drawing.Size(262, 31);
            this.lbl_LastSuccessActionTime.TabIndex = 7;
            this.lbl_LastSuccessActionTime.Text = "LastSuccessActionTime";
            // 
            // lbTextOfStatus
            // 
            this.lbTextOfStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTextOfStatus.AutoSize = true;
            this.lbTextOfStatus.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextOfStatus.Location = new System.Drawing.Point(145, 35);
            this.lbTextOfStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTextOfStatus.Name = "lbTextOfStatus";
            this.lbTextOfStatus.Size = new System.Drawing.Size(0, 36);
            this.lbTextOfStatus.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(29, 34);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 37);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status :";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(46, 165);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(156, 37);
            this.label27.TabIndex = 3;
            this.label27.Text = "Last Error:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSummary);
            this.tabControl1.Controls.Add(this.tabPagePostedOrders);
            this.tabControl1.Controls.Add(this.tabPageOrderWithReviews);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageLogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(140, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 800);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.Controls.Add(this.dataGridViewLogger);
            this.tabPageLogs.Location = new System.Drawing.Point(4, 44);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Size = new System.Drawing.Size(1192, 752);
            this.tabPageLogs.TabIndex = 5;
            this.tabPageLogs.Text = "Logs";
            this.tabPageLogs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLogger
            // 
            this.dataGridViewLogger.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridViewLogger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLogger.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLogger.Name = "dataGridViewLogger";
            this.dataGridViewLogger.RowHeadersWidth = 51;
            this.dataGridViewLogger.RowTemplate.Height = 24;
            this.dataGridViewLogger.Size = new System.Drawing.Size(1192, 752);
            this.dataGridViewLogger.TabIndex = 0;
            this.dataGridViewLogger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLogger_CellContentClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmMain";
            this.Text = "Roboost Integration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanceledOrders)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.gpBoxMaxHoursToSend.ResumeLayout(false);
            this.gpBoxMaxHoursToSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpForHours)).EndInit();
            this.grpBoxAllowedStores.ResumeLayout(false);
            this.grpBoxAllowedStores.PerformLayout();
            this.grpBoxLogDetails.ResumeLayout(false);
            this.grpBoxLogDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericClearLogInterval)).EndInit();
            this.grpBoxDispatchOrders.ResumeLayout(false);
            this.grpBoxDispatchOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReviewsOrderInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPostOrderInterval)).EndInit();
            this.grpBoxAPIDetails.ResumeLayout(false);
            this.grpBoxAPIDetails.PerformLayout();
            this.grpBoxDatabaseDetails.ResumeLayout(false);
            this.grpBoxDatabaseDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPageOrderWithReviews.ResumeLayout(false);
            this.tabPageOrderWithReviews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviewsOrders)).EndInit();
            this.panelUpdatedOrdersTop.ResumeLayout(false);
            this.panelUpdatedOrdersTop.PerformLayout();
            this.tabPagePostedOrders.ResumeLayout(false);
            this.tabPagePostedOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostedOrders)).EndInit();
            this.panelPostedOrdersTop.ResumeLayout(false);
            this.panelPostedOrdersTop.PerformLayout();
            this.tabPageSummary.ResumeLayout(false);
            this.tabPageSummary.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer logTimer;
        private System.Windows.Forms.Timer ReviewTimer;
        private System.Windows.Forms.DataGridView dataGridViewCanceledOrders;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_clear_canceledorder;
        private System.Windows.Forms.Button btnSearchCanceled;
        private System.Windows.Forms.TextBox txtRefNumberForCanceled;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox comboBoxFilterCanceled;
        private System.Windows.Forms.Label count_of_canceled_orders;
        private System.Windows.Forms.Label lbl_count_of_canceled_orders;
        private System.Windows.Forms.Panel panelCanceledOrdersTop;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.GroupBox gpBoxMaxHoursToSend;
        private System.Windows.Forms.NumericUpDown numericUpForHours;
        private System.Windows.Forms.Button btn_save_MaxHours;
        private System.Windows.Forms.Label lblMaxHours;
        private System.Windows.Forms.GroupBox grpBoxAllowedStores;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_Stores_Save;
        private System.Windows.Forms.TextBox textBoxStores;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox grpBoxLogDetails;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericClearLogInterval;
        private System.Windows.Forms.ComboBox cmbClearLogInterval;
        private System.Windows.Forms.Button btnSaveLogs;
        private System.Windows.Forms.TextBox txtLogFolderName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grpBoxDispatchOrders;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericReviewsOrderInterval;
        private System.Windows.Forms.ComboBox cmbPostReviewsInterval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnSaveTimers;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericPostOrderInterval;
        private System.Windows.Forms.ComboBox cmbPostOrderInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBoxAPIDetails;
        private System.Windows.Forms.Button btnSaveAPIDetails;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtAPIURL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpBoxDatabaseDetails;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRoboostOrderTableName;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox UnitsComboBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtReviewsViewName;
        private System.Windows.Forms.Label lblReviewName;
        private System.Windows.Forms.TextBox txtNewOrdersViewName;
        private System.Windows.Forms.Label lblOrdersViewName;
        private System.Windows.Forms.Button btnSaveDatabaseDetails;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageOrderWithReviews;
        private System.Windows.Forms.Label count_of_OrdersWithReviews;
        private System.Windows.Forms.Label lbl_count_orderswithreview;
        private System.Windows.Forms.DataGridView dataGridViewReviewsOrders;
        private System.Windows.Forms.Panel panelUpdatedOrdersTop;
        private System.Windows.Forms.Label lblRefNumnerForUpdate;
        private System.Windows.Forms.Button btn_clear_updatedorder;
        private System.Windows.Forms.Button btnSearchUpdatedOrder;
        private System.Windows.Forms.Label lblFilterForUpdate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtRefNumberForUpdate;
        private System.Windows.Forms.ComboBox comboBoxFiterReviews;
        private System.Windows.Forms.TabPage tabPagePostedOrders;
        private System.Windows.Forms.Label count_orders;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.DataGridView dataGridViewPostedOrders;
        private System.Windows.Forms.Panel panelPostedOrdersTop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblRefNumber;
        private System.Windows.Forms.TextBox txtRefNumber;
        private System.Windows.Forms.Label lblOrderStatusFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.Label lbTextOfStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLogs;
        private System.Windows.Forms.DataGridView dataGridViewLogger;
        private System.Windows.Forms.TextBox txtLastSuccessActionTime;
        private System.Windows.Forms.Label lbl_LastSuccessActionTime;
        private System.Windows.Forms.TextBox txtLastError;

        //private System.Windows.Forms.Label label27;
        //private System.Windows.Forms.Label label26;
        //private System.Windows.Forms.Label label25;
    }
}

