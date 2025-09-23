using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SiraIntegration.Helpers.UI
{
    public static class DataGridViewStyler
    {
        public static void Apply(DataGridView grid, string headerHex = "#2F80E7")
        {
            if (grid == null) return;

            //grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = true;
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.GridColor = Color.LightGray;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            //grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.SelectionMode = DataGridViewSelectionMode.CellSelect;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml(headerHex);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            grid.ColumnHeadersHeight = 36;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.DefaultCellStyle.Padding = new Padding(12, 6, 12, 6); 
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            grid.RowTemplate.Height = 36;
            grid.ScrollBars = ScrollBars.Both;

            var alt = Color.FromArgb(245, 247, 250);
            grid.AlternatingRowsDefaultCellStyle.BackColor = alt;
            grid.DefaultCellStyle.SelectionBackColor = Color.White;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = alt;
            grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, grid, new object[] { true });

            grid.ClearSelection();
            grid.CurrentCell = null;
        }

        public static void ConfigurePostedOrdersColumns(DataGridView grid, bool wrapJson = false)
        {
            if (grid == null) return;

            SetHeader(grid, "ReferenceID", "Reference #");
            SetHeader(grid, "Payload", "Payload");
            SetHeader(grid, "Response", "Response");
            SetHeader(grid, "IsSuccess", "Success?");
            SetHeader(grid, "SentTime", "Sent Time");
            SetHeader(grid, "ResponseTime", "Response Time");

            SetCol(grid, "ReferenceID",
                align: DataGridViewContentAlignment.MiddleLeft,
                padding: new Padding(12, 0, 8, 0),
                fillWeight: 90);

            SetCol(grid, "Payload",
                align: DataGridViewContentAlignment.TopLeft,
                padding: new Padding(12, 6, 12, 6),
                wrap: wrapJson,
                fillWeight: 230);

            SetCol(grid, "Response",
                align: DataGridViewContentAlignment.TopLeft,
                padding: new Padding(12, 6, 12, 6),
                wrap: wrapJson,
                fillWeight: 230);

            SetCol(grid, "IsSuccess",
                align: DataGridViewContentAlignment.MiddleCenter,
                padding: new Padding(0, 0, 0, 0),
                fillWeight: 70);

            SetCol(grid, "SentTime",
                align: DataGridViewContentAlignment.MiddleRight,
                padding: new Padding(8, 0, 12, 0),
                fillWeight: 120,
                format: "g");

            SetCol(grid, "ResponseTime",
                align: DataGridViewContentAlignment.MiddleRight,
                padding: new Padding(8, 0, 12, 0),
                fillWeight: 120,
                format: "g");
        }

        private static void SetHeader(DataGridView grid, string colName, string header)
        {
            if (grid.Columns.Contains(colName))
                grid.Columns[colName].HeaderText = header;
        }

        private static void SetCol(
            DataGridView grid,
            string colName,
            DataGridViewContentAlignment align,
            Padding padding,
            int fillWeight = 0,
            bool wrap = false,
            string format = null)
        {
            if (!grid.Columns.Contains(colName)) return;

            var col = grid.Columns[colName];
            col.DefaultCellStyle.Alignment = align;
            col.DefaultCellStyle.Padding = padding;
            col.DefaultCellStyle.WrapMode = wrap ? DataGridViewTriState.True : DataGridViewTriState.False;

            if (!string.IsNullOrEmpty(format))
                col.DefaultCellStyle.Format = format;

            if (fillWeight > 0)
                col.FillWeight = fillWeight;
        }
    }
}
