using DevExpress.Spreadsheet;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void butRun_Click(object sender, EventArgs e) {
            using var workbook = new Workbook();
            await workbook.LoadDocumentAsync("test.xlsx");
            var stat = await GetWorkbookStat(workbook, new Progress<WorkbookStat>((s) => DisplayWorkbookStat(s)));
            DisplayWorkbookStat(stat);
        }

        Task<WorkbookStat> GetWorkbookStat(Workbook workbook, IProgress<WorkbookStat> progress) {
            return Task.Run(() => {
                var stat = new WorkbookStat();
                var query = workbook.Worksheets.SelectMany(sheet => sheet.GetExistingCells());
                int progressCounter = 100;
                foreach (var cell in query) {
                    stat.Total++;
                    if (cell.HasFormula)
                        stat.Formulas++;
                    if (cell.Value.IsText)
                        stat.Strings++;
                    else if (cell.Value.IsNumeric)
                        stat.Numerics++;
                    else if (cell.Value.IsNumeric)
                        stat.Numerics++;
                    else if (cell.Value.IsError)
                        stat.Errors++;
                    else if (cell.Value.IsBoolean)
                        stat.Booleans++;
                    progressCounter--;
                    if (progressCounter <= 0) {
                        progressCounter = 100;
                        progress.Report(stat);
                    }
                }
                return stat;
            });
        }

        void DisplayWorkbookStat(WorkbookStat stat) {
            lblTotal.Text = $"Total: {stat.Total}";
            lblFormulas.Text = $"Formulas: {stat.Formulas}";
            lblStrings.Text = $"Strings: {stat.Strings}";
            lblNumerics.Text = $"Numerics: {stat.Numerics}";
            lblErrors.Text = $"Error: {stat.Errors}";
            lblBooleans.Text = $"Booleans: {stat.Booleans}";
        }
    }
}
