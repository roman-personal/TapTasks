using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2 {
    public partial class Form1 : Form {
        CancellationTokenSource? cts;

        public Form1() {
            InitializeComponent();
        }

        async Task CopyFilesAsync(string sourceFolder, string targetFolder, CancellationToken cancellationToken, IProgress<string> progress) {
            foreach (string filepath in Directory.EnumerateFiles(sourceFolder)) {
                string filename = Path.GetFileName(filepath);
                using var sourceStream = File.Open(filepath, FileMode.Open);
                using var targetStream = File.Create(Path.Combine(targetFolder, filename));
                await sourceStream.CopyToAsync(targetStream, cancellationToken);
                progress.Report(filename);
            }
        }

        private async void butRun_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            cts = new CancellationTokenSource();
            try {
                await CopyFilesAsync("SourceFolder", "TargetFolder", cts.Token,
                    new Progress<string>((filename) => listBox1.Items.Add(filename)));
            }
            catch (OperationCanceledException ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                cts.Dispose();
                cts = null;
            }
        }

        private void butCancel_Click(object sender, EventArgs e) {
            cts?.Cancel();
        }
    }
}
