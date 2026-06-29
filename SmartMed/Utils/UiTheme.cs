using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Utils
{
    public static class UiTheme
    {
        public static readonly Color Header = Color.FromArgb(31, 42, 68);
        public static readonly Color Primary = Color.FromArgb(64, 84, 178);
        public static readonly Color Success = Color.FromArgb(46, 158, 107);
        public static readonly Color Warning = Color.FromArgb(232, 169, 59);
        public static readonly Color Danger = Color.FromArgb(219, 75, 75);
        public static readonly Color Canvas = Color.FromArgb(244, 246, 251);
        public static readonly Color BodyText = Color.FromArgb(51, 65, 92);
        public static readonly Color Muted = Color.FromArgb(138, 147, 166);

        private static readonly Color GridHeaderBack = Color.FromArgb(237, 240, 248);
        private static readonly Color GridAltRow = Color.FromArgb(247, 249, 252);
        private static readonly Color GridSelection = Color.FromArgb(220, 227, 245);
        private static readonly Color GridLines = Color.FromArgb(226, 230, 239);

        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = GridLines;
            grid.RowHeadersVisible = false;
            grid.AllowUserToResizeRows = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.RowTemplate.Height = 30;

            grid.ColumnHeadersDefaultCellStyle.BackColor = GridHeaderBack;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Header;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = GridHeaderBack;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Header;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = BodyText;
            grid.DefaultCellStyle.SelectionBackColor = GridSelection;
            grid.DefaultCellStyle.SelectionForeColor = Header;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            grid.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            grid.AlternatingRowsDefaultCellStyle.BackColor = GridAltRow;
            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = GridSelection;
            grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Header;
        }

        public static void FormatMoneyColumns(DataGridView grid, params string[] columns)
        {
            foreach (string name in columns)
            {
                if (grid.Columns[name] != null)
                {
                    grid.Columns[name].DefaultCellStyle.Format = "C2";
                    grid.Columns[name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }
    }
}
