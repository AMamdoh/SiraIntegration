using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using Newtonsoft.Json;
using SiraIntegration.DAL;
using SiraIntegration.Data.Enums;
using SiraIntegration.Entities;
using SiraIntegration.Entities.Logger;
using SiraIntegration.Entities.Settings;
using SiraIntegration.Helpers;
using SiraIntegration.Helpers.Settings;
using SiraIntegration.Helpers.UI;
using SiraIntegration.Helpers.ViewModels;
using SiraIntegration.Integration;
using SiraIntegration.Models;
using SiraIntegration.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiraIntegration
{
    public partial class FrmMain : Form
    {

        private DispatchOrderSettings dispatchSettings;
        private OrderLogService _orderLogService;


        private bool _isClearingLogs = false;
        private readonly ILogger<FrmMain> _logger;

        private BindingList<LogEntry> _logs = new BindingList<LogEntry>();
        private UiLogger _memoryLogger;

        public FrmMain(ILogger<FrmMain> logger, OrderLogService orderLogService)
        {
            InitializeComponent();
            this.Text = "Sira Integration";



            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (key != null)
            {
                key.SetValue("ROOBOST SYNC", Application.ExecutablePath);
            }

            _logger = logger;
            _orderLogService = orderLogService;
            FillTimersCmbBoxes();

            dataGridViewLogger.DataSource = _logs;

            _memoryLogger = new UiLogger(_logs);

            dataGridViewLogger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewLogger.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



        }

        #region SaveDatabaseSettingsMethod
        private void SaveDatabaseSettings()
        {
            try
            {
                DatabaseSettings settings = new DatabaseSettings
                {
                    ServerIP = txtServerIP.Text,
                    DatabaseName = txtDatabaseName.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    NewOrdersView = txtNewOrdersViewName.Text,
                    ReviewsViewName = txtReviewsViewName.Text,
                    SiraOrderTable = txtRoboostOrderTableName.Text,
                    RemoveOldOrdersInterval = numericUpDown1.Value,
                    RemoveOldOrdersUnit = UnitsComboBox.SelectedItem?.ToString()
                };

                INIHelper.SaveDatabaseSettings(settings);

                MessageBox.Show("Database settings saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving database settings", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _logger.LogError($"Error saving database settings: {ex.Message}");
                _memoryLogger.LogError($"Error saving database settings: {ex.Message}");

            }
        }

        #endregion

        #region SaveApiSettingsMethod
        private void SaveApiSettings()
        {
            string apiUrl = txtAPIURL.Text.Trim();
            string token = txtToken.Text.Trim();

            if (string.IsNullOrWhiteSpace(apiUrl) || string.IsNullOrWhiteSpace(token))
            {
                MessageBox.Show("Please fill in both API URL and Token.", "Validation");
                return;
            }
            ApiSettings settings = new ApiSettings
            {
                Url = apiUrl,
                Token = token
            };

            try
            {
                INIHelper.SaveAPISettings(settings);
                MessageBox.Show("API settings saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving API settings:");

                _logger.LogError($"Error saving API settings: {ex.Message}");
                _memoryLogger.LogError($"Error saving API settings: {ex.Message}");
            }
        }
        #endregion

        #region LoadDatabaseSettingsToForm to retrive database  saved in file
        private void LoadDatabaseSettingsToForm()
        {

            try
            {

                var settings = INIHelper.LoadDatabaseSettings();

                txtServerIP.Text = settings.ServerIP;
                txtDatabaseName.Text = settings.DatabaseName;
                txtUserName.Text = settings.UserName;
                txtPassword.Text = settings.Password;
                txtNewOrdersViewName.Text = settings.NewOrdersView;
                txtReviewsViewName.Text = settings.ReviewsViewName;
                txtRoboostOrderTableName.Text = settings.SiraOrderTable;

                numericUpDown1.Value = settings.RemoveOldOrdersInterval;
                UnitsComboBox.SelectedItem = settings.RemoveOldOrdersUnit;
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while loading the database settings:\n{ex.Message}");
             _memoryLogger.LogError("An error occurred while loading the database settings:\n{ex.Message}");
            }
        }
        #endregion

        #region LoadAPISettingsToForm to retrieve apisetting saved in file
        private void LoadAPISettingsToForm()
        {
            try
            {


                var settings = INIHelper.LoadAPISettings();
                if (settings != null)
                {
                    txtAPIURL.Text = settings.Url;
                    txtToken.Text = settings.Token;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error loading API settings: {ex.Message}", "Error");
                _memoryLogger.LogError($"Error loading API settings: {ex.Message}");
            }
        }

        #endregion

        #region LoadLogSettingsToForm
        private void LoadLogSettingsToForm()
        {
            try
            {
                var settings = INIHelper.LoadLogSettings();

                txtLogFolderName.Text = settings.Folder;
                numericClearLogInterval.Value = settings.ClearLogInterval > 0 ? settings.ClearLogInterval : 1;

                cmbClearLogInterval.SelectedIndex = settings.ClearLogUnit.GetEnumIndexFromName<TimerInterval>();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to load log settings: " + ex.Message);
                _memoryLogger.LogError($"Failed to load log settings:{ex.Message} ");

            }
        }
        #endregion

        #region LoadStoresToForm
        private void LoadStoresToForm()
        {
            try
            {
                var settings = INIHelper.LoadStores();
                textBoxStores.Text = string.Join(",", settings.StoreCodes);
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to load stores settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _memoryLogger.LogError($"Failed to load stores settings: {ex.Message}");

            }
        }
        #endregion

        #region FillRemoveUnitsComboBox
        private void FillRemoveUnitsComboBox()
        {
            foreach (TimerInterval interval in Enum.GetValues(typeof(TimerInterval)))
            {
                if (interval != TimerInterval.None)
                    UnitsComboBox.Items.Add(interval);
            }

            UnitsComboBox.SelectedItem = TimerInterval.Minutes;
        }

        #endregion

        #region FillTimersCmbBoxes
        private void FillTimersCmbBoxes()
        {
            var intervals = EnumHelper.ToSelectableList<TimerInterval>();

            cmbPostOrderInterval.DataSource = intervals.ToList();
            cmbPostReviewsInterval.DataSource = intervals.ToList();
        
            cmbClearLogInterval.DataSource = intervals.ToList();
        }
        #endregion

        #region SaveTimerSettingsFromForm
        private void SaveTimerSettingsFromForm()
        {
            try
            {
                var settings = new DispatchOrderSettings
                {
                    PostOrderInterval = (int)numericPostOrderInterval.Value,
                    PostOrderUnit = cmbPostOrderInterval.Text.Trim(),
                    ReviewOrderInterval = (int)numericReviewsOrderInterval.Value,
                    ReviewOrderUnit = cmbPostReviewsInterval.Text.Trim(),
                 
                    OrdersCount = (int)numericUpDown2.Value,
                    ReviewsCount=(int)numericUpDown3.Value
                };

                if (string.IsNullOrWhiteSpace(settings.PostOrderUnit)
                    || string.IsNullOrWhiteSpace(settings.ReviewOrderUnit)
                    || settings.PostOrderInterval <= 0
                    || settings.ReviewOrderInterval <= 0
                    || settings.OrdersCount <= 0
                    ||settings.ReviewsCount<=0)
                {
                    throw new Exception("Please fill in all fields before saving and make sure numeric values are greater than 0.");
                }

                INIHelper.SaveTimerSettings(settings);
                MessageBox.Show("Dispatched order saved successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _logger.LogError(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      
            }
        }

        #endregion

        #region LoadTimerSettingsToForm
        private void LoadTimerSettingsToForm()
        {
            try
            {
                var settings = INIHelper.LoadTimerSettings();

                numericPostOrderInterval.Value = settings.PostOrderInterval;
                numericReviewsOrderInterval.Value = settings.ReviewOrderInterval;
                numericUpDown2.Value = settings.OrdersCount;
                numericUpDown3.Value = settings.ReviewsCount;

                cmbPostOrderInterval.SelectedIndex = settings.PostOrderUnit.GetEnumIndexFromName<TimerInterval>();
                cmbPostReviewsInterval.SelectedIndex = settings.ReviewOrderUnit.GetEnumIndexFromName<TimerInterval>();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to load timer settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _memoryLogger.LogError("Failed to load timer settings: \" + ex.Message");
            }
        }
        #endregion


        #region SaveLogSettings
        private void SaveLogSettings()
        {
            try
            {
                var settings = new LogSettings
                {
                    Folder = txtLogFolderName.Text.Trim(),
                    ClearLogInterval = (int)numericClearLogInterval.Value,
                    ClearLogUnit = cmbClearLogInterval.Text.Trim()
                };

                if (
                    string.IsNullOrWhiteSpace(settings.ClearLogUnit)
                    || settings.ClearLogInterval <= 0)
                {
                    throw new Exception("Please fill in all fields before saving and make sure numeric values are greater than 0.");
                }
                if (string.IsNullOrWhiteSpace(settings.Folder))
                {
                    MessageBox.Show("Log folder is empty. Default location will be used or logs may not be saved.",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                INIHelper.SaveLogSettings(settings);

                InitializeLogCleanupTimer();

                MessageBox.Show("Log settings saved successfully and cleanup timer restarted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // _orderLogService = new OrderLogService();
            FillRemoveUnitsComboBox();
            LoadDatabaseSettingsToForm();

            LoadAPISettingsToForm();
            LoadStoresToForm();
            LoadTimerSettingsToForm();
            LoadLogSettingsToForm();
            //  var dbSettings = INIHelper.LoadDatabaseSettings();

            //  DapperHelper.SetConnection(
            //    dbSettings.ServerIP,
            //    dbSettings.DatabaseName,
            //    dbSettings.UserName,
            //    dbSettings.Password
            //);

            LoadLastErrorMsg();

            LoadLastSuccessAction();

            FillFilterStatusUnitsComboBox();
            DataGridViewStyler.Apply(dataGridViewPostedOrders);
            DataGridViewStyler.Apply(dataGridViewReviewsOrders);
            DataGridViewStyler.Apply(dataGridViewCanceledOrders);


            dataGridViewPostedOrders.CellContentClick += dataGridViewPostedOrders_CellContentClick;
     

          


            InitializeTimers();
            InitializeLogCleanupTimer();
            allowDecimalForHours();
            LoadMaxHoursSettingsToForm();

   

            Task.Run(() =>
            {
                var status = ToolStatusHelper.GetStatus();

                Invoke((Action)(() => UpdateToolStatus(status)));
            });

        }

        private int ConvertToMilliseconds(int interval, TimerInterval unit)
        {
            if (interval <= 0)
                return 0;

            switch (unit)
            {
                case TimerInterval.Seconds:
                    return interval * 1000;
                case TimerInterval.Minutes:
                    return interval * 60 * 1000;
                case TimerInterval.Hours:
                    return interval * 60 * 60 * 1000;
                default:
                    return 0;
            }
        }



        #region clear order logs 

        private async void InitializeLogCleanupTimer()
        {
            try
            {
                var logSettings = INIHelper.LoadLogSettings();
                if (logSettings == null) return;

                if (!Enum.TryParse<TimerInterval>(logSettings.ClearLogUnit, true, out var unit))
                    unit = TimerInterval.None;

                int intervalMs = ConvertToMilliseconds(logSettings.ClearLogInterval, unit);
                if (intervalMs <= 0)
                {
                    logTimer.Stop();
                    return;
                }

                logTimer.Stop();
                logTimer.Interval = intervalMs;
                logTimer.Tick -= logTimer_Tick;
                logTimer.Tick += logTimer_Tick;

                logTimer.Start();

                int deleted = await _orderLogService.ClearOldLogsAsync();
                var folder = logSettings.Folder ?? "";

            }
            catch (Exception ex)
            {
                _logger.LogError("  error ", ex);
                _memoryLogger.LogError($"error :{ex.Message}");

            }
        }
        private async void logTimer_Tick(object sender, EventArgs e)
        {
            if (_isClearingLogs) return;
            _isClearingLogs = true;

            try
            {
                logTimer.Stop();

                int deleted = await _orderLogService.ClearOldLogsAsync();

                var okMsg = $"{DateTime.Now:u}  Deleted {deleted} rows (SentTime < today).";
         
                _logger.LogInformation( "  {Message}", okMsg);
                _memoryLogger.LogInfo($"Message {okMsg}");


            }
            catch (Exception ex)
            {
                var errMsg = $"{DateTime.Now:u}  {ex}";
            
                _logger.LogError(ex, "  {Message}", errMsg);
                _memoryLogger.LogInfo($"Message {errMsg}");

            }
            finally
            {
                _isClearingLogs = false;
                logTimer.Start();
            }
        }

        #endregion


        private void FillFilterStatusUnitsComboBox()

        {
            comboBoxFilter.Items.AddRange(new[] { "all", "success orders", "fail orders" });
            comboBoxFiterReviews.Items.AddRange(new[] { "all", "success orders", "fail orders" });
            comboBoxFilterCanceled.Items.AddRange(new[] {"all", "success orders", "fail orders" });

            comboBoxFilter.SelectedIndex = 0;
            comboBoxFiterReviews.SelectedIndex = 0;
            comboBoxFilterCanceled.SelectedIndex = 0;

          


        }

        public void UpdateToolStatus((string Text, Color Color) status)
        {
            lbTextOfStatus.Text = status.Text;
            lbTextOfStatus.ForeColor = status.Color;
        }



        private void btnSaveDatabaseDetails_Click(object sender, EventArgs e)
        {
            SaveDatabaseSettings();
            LoadDatabaseSettingsToForm();


        }
        private void btnSaveAPIDetails_Click(object sender, EventArgs e)
        {
            SaveApiSettings();
            LoadAPISettingsToForm();
        }

        private void btnSaveLogs_Click(object sender, EventArgs e)
        {
            SaveLogSettings();
        }

        private void btnSaveTimers_Click(object sender, EventArgs e)
        {
            SaveTimerSettingsFromForm();
        }

        # region post order
        private void InitializeTimers()
        {
            dispatchSettings = INIHelper.LoadTimerSettings();

            // ====== Post Order Timer ======

            TimerInterval postOrderUnitEnum;
            if (!Enum.TryParse(dispatchSettings.PostOrderUnit, true,//ignoreCase
                out postOrderUnitEnum))

            {
                postOrderUnitEnum = TimerInterval.None;
            }

            int intervalInMs =
                ConvertToMilliseconds(dispatchSettings.PostOrderInterval,
                postOrderUnitEnum);
            timer1.Stop();
            timer1.Tick -= PostOrderTimer_Tick;//unregister



            if (intervalInMs > 0)
            {
                timer1.Interval = intervalInMs;
                timer1.Tick += PostOrderTimer_Tick;
                timer1.Start();

            }

            // ====== review Order Timer ======
            TimerInterval ReviewOrderUnitEnum;
            if (!Enum.TryParse(dispatchSettings.ReviewOrderUnit, true, out ReviewOrderUnitEnum))
            {
                ReviewOrderUnitEnum = TimerInterval.None;
            }

            int intervalreviewInMs =
                ConvertToMilliseconds(dispatchSettings.ReviewOrderInterval, ReviewOrderUnitEnum);

            ReviewTimer.Stop();
            ReviewTimer.Tick -= PostReviewsTimer_Tick; // unregister

            if (intervalreviewInMs > 0)
            {
                ReviewTimer.Interval = intervalreviewInMs;
                ReviewTimer.Tick += PostReviewsTimer_Tick;
                ReviewTimer.Start();
            }

           
        }

        private async void PostOrderTimer_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            _logger.LogInformation("Starting the 'Post Orders' cycle...");
            _memoryLogger.LogInfo("Checking for new orders to send...");

            try
            {
                await ProcessAndSendOrdersAsync();

                _logger.LogInformation("'Post Orders' cycle completed successfully.");
                _memoryLogger.LogInfo("Order processing cycle finished.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "A critical error occurred during the 'Post Orders' cycle.");
                _memoryLogger.LogError($"Error processing orders: {ex.Message}");
            }
            finally
            {
                _logger.LogInformation("========================================\n");
                timer1.Start();
            }
        }

        private async void PostReviewsTimer_Tick(object sender, EventArgs e)
        {
            ReviewTimer.Stop();

            _logger.LogInformation("Starting the 'Post Reviews' cycle...");
            _memoryLogger.LogInfo("Checking for new reviews to send...");

            try
            {
               //await ProcessAndSendReviewsAsync();

                _logger.LogInformation("'Post Reviews' cycle completed successfully.");
                _memoryLogger.LogInfo("Review processing cycle finished.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "A critical error occurred during the 'Post Reviews' cycle.");
                _memoryLogger.LogError($"Error processing reviews: {ex.Message}");
            }
            finally
            {
                _logger.LogInformation("========================================\n");
                ReviewTimer.Start();
            }
        }


        private async Task ProcessAndSendOrdersAsync()
        {
            var timerSettings = INIHelper.LoadTimerSettings();
            var count = timerSettings.OrdersCount;

            decimal maxHours = INIHelper.LoadRestrictionSettings();

            //logic of maxHours to send
            DateTime? cutoff = (maxHours > 0)
                ? DateTime.Now.AddHours(-(double)maxHours)
                : (DateTime?)null;

            var orders = OrderRepository.GetOrdersToSend(count, _logger, _memoryLogger, cutoff);
            if (orders == null || orders.Count == 0)
            {
                _logger.LogInformation(
                    "Skipping order dispatch cycle. No new orders found within the time window. [Cutoff: {Cutoff}, MaxHours: {MaxHours}]",
                    cutoff,
                    maxHours
                );
                _memoryLogger.LogInfo($"No new orders found. " +
                    $"Search was limited to orders after {cutoff:yyyy-MM-dd HH:mm:ss} and not older than {maxHours} hours.");

                return;
            }
            var sendTasks = orders.Select(o => RoboostService.SendSiraOrderAsync(o, _logger,_memoryLogger));

            _logger.LogInformation("Attempting to send a batch of {OrderCount} orders...", orders.Count);
            _memoryLogger.LogInfo(" Sending {orders.Count} orders to the integration partner..."); 

            try
            {
    
                await Task.WhenAll(sendTasks);


                _logger.LogInformation("Successfully dispatched a batch of {OrderCount} orders.", orders.Count);
                _memoryLogger.LogInfo($"SUCCESS Batch of {orders.Count} orders sent successfully."); 
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "An error occurred while dispatching a batch of {OrderCount} orders. One or more tasks failed.", orders.Count);
                _memoryLogger.LogError( $"Failed to send a batch of {orders.Count} orders"); 
            }
            finally
            {
          
                _logger.LogInformation("Updating UI status after processing the batch.");
                _memoryLogger.LogInfo("Updating status indicator...");

                var statusResult = ToolStatusHelper.GetStatus();

                if (this.IsHandleCreated)
                {
                    Invoke((Action)(() => UpdateToolStatus(statusResult)));
                }
            }
        }

        //private async Task ProcessAndSendReviewsAsync()
        //{
        //    _logger.LogInformation("Fetching reviews to be processed...");
        //    _memoryLogger.LogInfo("Fetching reviews to send...");

        //    var timerSettings = INIHelper.LoadTimerSettings();
        //    var count = timerSettings.ReviewsCount;
        //    decimal maxHours = INIHelper.LoadRestrictionSettings();
        //    DateTime? cutoff = (maxHours > 0)
        //        ? DateTime.Now.AddHours(-(double)maxHours)
        //        : (DateTime?)null;

        //    var reviews = OrderRepository.GetReviewsToSend(count, _logger, _memoryLogger, cutoff);
        //    if (reviews == null || !reviews.Any())
        //    {
        //        _logger.LogInformation(
        //            "No new reviews found matching the criteria. [Cutoff: {Cutoff}, MaxHours: {MaxHours}]",
        //            cutoff, maxHours);

        //        _memoryLogger.LogInfo("No new reviews to process at this time.");
        //        return;
        //    }

        //    _logger.LogInformation("Found {ReviewCount} reviews. Preparing to dispatch batch.", reviews.Count);
        //    _memoryLogger.LogInfo($"Dispatching a batch of {reviews.Count} reviews...");

        //    var sendTasks = reviews.Select(r => RoboostService.SendReviewAsync(r, _logger)); 
        //    try
        //    {
        //        await Task.WhenAll(sendTasks);

        //        _logger.LogInformation("Successfully dispatched a batch of {ReviewCount} reviews.", reviews.Count);
        //        _memoryLogger.LogInfo($"Batch of {reviews.Count} reviews sent successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "A critical error occurred while dispatching a batch of {ReviewCount} reviews.", reviews.Count);
        //        _memoryLogger.LogError($"Failed to send a batch of {reviews.Count} reviews. Check log file for details.");
        //    }
        //    finally
        //    {
        //        _logger.LogInformation("Updating UI tool status after review batch processing.");
        //        _memoryLogger.LogInfo("Updating status indicator...");

        //        var statusResult = ToolStatusHelper.GetStatus();

        //        if (this.IsHandleCreated)
        //        {
        //            Invoke((Action)(() => UpdateToolStatus(statusResult)));
        //        }
        //    }
        //}









        #endregion
        private readonly OrderLogRepository _orderLogRepo = new OrderLogRepository();

        private void LoadLastSuccessAction()
        {
            try
            {
                var row = _orderLogRepo.GetLastSuccessAction();
                if (row != null && row.ResponseTime.HasValue)
                {
                    txtLastSuccessActionTime.Text = $"ResponseTime: {row.ResponseTime:yyyy-MM-dd HH:mm:ss}";
                }
                else
                {
                    txtLastSuccessActionTime.Text = "No successful actions found.";
                }
            }
            catch (Exception ex)
            {
                txtLastSuccessActionTime.Text = "Failed to load last success action.";
                _logger?.LogError(ex, "Error loading last success action");
            }
        }

        #region LoadLastErrorMsg
        private void LoadLastErrorMsg()
        {
            var errorReader = new SimpleErrorReader();
            string lastError = errorReader.GetLastError();
            txtLastError.Text = lastError;
        }

        #endregion
        #region Store
        private void btn_Stores_Save_Click(object sender, EventArgs e)
        {
            var storeCodes = GetStoreCodesFromTextBox();
            SaveStoreCodes(storeCodes);
            LoadStoresToForm();
            MessageBox.Show(" Store codes saved successfully");
        }
        private List<string> GetStoreCodesFromTextBox()
        {
            if (string.IsNullOrWhiteSpace(textBoxStores?.Text))
                return new List<string>();

            return textBoxStores.Text
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.Trim())
                .ToList();
        }

        private void SaveStoreCodes(List<string> codes)
        {
            var allowStores = new AllowStores
            {
                StoreCodes = codes
            };

            INIHelper.SaveStores(allowStores);

        }

        #endregion

        #region dataGridView

        private void LoadOrdersGeneric<T>(
            DataGridView grid,
            Label countLabel,
            Func<string, string, IEnumerable<T>> getOrdersFunc,
            string filter,
            string referenceId = "")
        {
            var orders = getOrdersFunc(filter, referenceId);
            grid.SuspendLayout();
            try
            {
                var ordersList = orders.Take(100).ToList();

                grid.DataSource = new BindingList<T>(ordersList);

                if (grid.Name == "dataGridViewPostedOrders")
                    retryButton(filter);
                else if (grid.Name == "dataGridViewReviewsOrders")
                    retryButtonForReviewsWithOrders(filter);
               

                countLabel.Text = $" {ordersList.Count}";
            }
            finally
            {
                grid.ResumeLayout();
                grid.AllowUserToAddRows = false;

            }
        }

        //======================== retryButton
        private void retryButton(string filter)
        {
            var retryColumn = dataGridViewPostedOrders.Columns["RetryButton"];

            if (retryColumn == null)
            {
                retryColumn = new DataGridViewButtonColumn
                {
                    Name = "RetryButton",
                    HeaderText = "Retry Post",
                    Text = "Retry",
                    UseColumnTextForButtonValue = true
                };
                retryColumn.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                dataGridViewPostedOrders.Columns.Add(retryColumn);
            }

            retryColumn.Visible = (filter == "fail orders");
        }
        private void retryButtonForReviewsWithOrders(string filter)
        {
            var retryColumn = dataGridViewReviewsOrders.Columns["RetryButton"];

            if (retryColumn == null)
            {
                retryColumn = new DataGridViewButtonColumn
                {
                    Name = "RetryButton",
                    HeaderText = "Retry Post",
                    Text = "Retry",
                    UseColumnTextForButtonValue = true
                };
                retryColumn.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                dataGridViewReviewsOrders.Columns.Add(retryColumn);
            }

            retryColumn.Visible = (filter == "fail orders");
        }

 
        //=======================Grids
        private void dataGridViewPostedOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPostedOrders.Columns[e.ColumnIndex].Name == "RetryButton" && e.RowIndex >= 0) //0 الهيدر 
            {
                string referenceId = dataGridViewPostedOrders.Rows[e.RowIndex].Cells["ReferenceID"].Value.ToString();

                RetryOrder(referenceId);
            }
        }
       


        //========================RetryOrders
        private async void RetryOrder(string referenceId)
        {
            try
            {
                bool success = await _orderLogService.RetryOrderAsync(referenceId);

                if (!success)
                    MessageBox.Show("fail to send order again");

              
                LoadOrdersGeneric(dataGridViewPostedOrders, count_orders
                    , _orderLogService.GetFilteredOrders, "fail orders", referenceId);

            }
            catch (Exception ex)
            {
                _logger.LogError("Error retrying order: " + ex.Message);
            }
        }




        //==========================comboBoxFiter
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = GetSelectedFilter(comboBoxFilter);

          LoadOrdersGeneric(dataGridViewPostedOrders, count_orders, _orderLogService.GetFilteredOrders, selected, txtRefNumber.Text.Trim());

        }
        private void comboBoxFiterReviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = GetSelectedFilter(comboBoxFiterReviews);

            LoadOrdersGeneric(dataGridViewReviewsOrders, count_of_OrdersWithReviews, _orderLogService.GetFilteredReviews, selected, txtRefNumber.Text.Trim());

        }








        private string GetSelectedFilter(ComboBox comboBox)
        {
            return comboBox.SelectedItem?.ToString() ?? "all";
        }


        //=====================btnSearch
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string refId = txtRefNumber.Text.Trim();
            string currentFilter = GetSelectedFilter(comboBoxFilter);

            LoadOrdersGeneric(dataGridViewPostedOrders, count_orders, _orderLogService.GetFilteredOrders, currentFilter, refId);


        }
        private void btnSearchReviews_Click(object sender, EventArgs e)
        {
            string refId = txtRefNumberForUpdate.Text.Trim();
            string currentFilter = GetSelectedFilter(comboBoxFiterReviews);

            LoadOrdersGeneric(dataGridViewReviewsOrders, count_of_OrdersWithReviews, _orderLogService.GetFilteredReviews, currentFilter, refId);
        }
     


        //======================btnClear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRefNumber.Clear();
            comboBoxFilter.SelectedIndex = 0;
            string filter = comboBoxFilter.SelectedItem?.ToString() ?? "all";

          
        


        }

        private void btn_clear_Reviewsorder_Click(object sender, EventArgs e)
        {
            txtRefNumberForUpdate.Clear();
            comboBoxFiterReviews.SelectedIndex = 0;
            string filter = comboBoxFiterReviews.SelectedItem?.ToString() ?? "all";


            LoadOrdersGeneric(
                dataGridViewReviewsOrders,
                count_of_OrdersWithReviews,
                _orderLogService.GetFilteredReviews,
                filter,
                "");
        }

       
        #endregion


        private void tabPageSummary_Click(object sender, EventArgs e)
        {

        }
       
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageOrderWithReviews) 
            {
                LoadOrdersGeneric(
                    dataGridViewReviewsOrders,
                    count_of_OrdersWithReviews,
                    _orderLogService.GetFilteredReviews,
                    "all"
                );
            }
             else if (tabControl1.SelectedTab == tabPagePostedOrders) 
            {
                LoadOrdersGeneric(
                    dataGridViewPostedOrders,
                    count_orders,
                    _orderLogService.GetFilteredOrders,
                    "all"
                );
            }
           

        }

        private void tabPagePostedOrders_Click(object sender, EventArgs e)
        {

        }

        private void cmbPostOrderInterval_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        #region MaxHoursSettings
        private void btn_save_MaxHours_Click(object sender, EventArgs e)
        {
            decimal hours = numericUpForHours.Value;

            if (hours >= 0)
            {
                INIHelper.SaveRestrictionSettings(hours);
                MessageBox.Show("MaxHour settings saved successfully.");
            }
            else
            {
                MessageBox.Show("Enter a valid number _MaxHours");

                _logger.LogError("Enter a valid number _MaxHours");
            }
        }
        private void LoadMaxHoursSettingsToForm()
        {
            try
            {
                decimal maxHours = INIHelper.LoadRestrictionSettings(); 
                numericUpForHours.Value = maxHours;
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"An error occurred while loading the max hours setting:\n{ex.Message}","Error");
            }
        }


        private void allowDecimalForHours()
        {
            numericUpForHours.DecimalPlaces = 2; 
            numericUpForHours.Increment = 0.5M;  
            numericUpForHours.Minimum = 0.5M;      
            numericUpForHours.Maximum = 24; 
        }
        #endregion


        private void numericUpForHours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpBoxDatabaseDetails_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageSettings_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxAPIDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void count_of_updated_orders_Click(object sender, EventArgs e)
        {

        }

        private void lbl_count_updatedorders_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpBoxDispatchOrders_Enter(object sender, EventArgs e)
        {

        }

        private void panelPostedOrdersTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewLogger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void count_orders_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewReviewsOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}



       


