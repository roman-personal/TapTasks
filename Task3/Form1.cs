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
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK) {
                CleanWorkbookStat();
                butRun.Enabled = false;
                lblFile.Text = $"File: {openFileDialog1.FileName}";
                try {
                    using var workbook = new Workbook();
                    await workbook.LoadDocumentAsync(openFileDialog1.FileName,
                        new Progress<int>(progress => {
                            progressBar1.Value = progress;
                            progressBar1.Visible = true;
                        }));
                    var stat = await GetWorkbookStat(workbook, new Progress<WorkbookStat>(s => DisplayWorkbookStat(s)));
                    DisplayWorkbookStat(stat);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    progressBar1.Visible = false;
                    butRun.Enabled = true;
                }
            }
        }

        private Task<WorkbookStat> GetWorkbookStat(Workbook workbook, IProgress<WorkbookStat> progress) {
            return Task.Run(() => {
                var stat = new WorkbookStat();
                var existingCells = workbook.Worksheets.SelectMany(sheet => sheet.GetExistingCells());
                int progressCounter = 1000;
                foreach (var cell in existingCells) {
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
                        progressCounter = 1000;
                        progress.Report(stat);
                    }
                }
                return stat;
            });
        }

        private void DisplayWorkbookStat(WorkbookStat stat) {
            lblTotal.Text = $"Total: {stat.Total}";
            lblFormulas.Text = $"Formulas: {stat.Formulas}";
            lblStrings.Text = $"Strings: {stat.Strings}";
            lblNumerics.Text = $"Numerics: {stat.Numerics}";
            lblErrors.Text = $"Errors: {stat.Errors}";
            lblBooleans.Text = $"Booleans: {stat.Booleans}";
        }

        private void CleanWorkbookStat() {
            lblTotal.Text = "Total: unknown";
            lblFormulas.Text = "Formulas: unknown";
            lblStrings.Text = "Strings: unknown";
            lblNumerics.Text = "Numerics: unknown";
            lblErrors.Text = "Errors: unknown";
            lblBooleans.Text = "Booleans: unknown";
        }
    }
}
