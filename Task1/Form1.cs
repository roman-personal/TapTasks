using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapTasks {
    public partial class Form1 : Form {
        readonly Stopwatch sw = new();

        public Form1() {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e) {
            sw.Restart();
            int count = await GetLinesCount("alice_in_wonderland.txt");
            sw.Stop();
            label1.Text = $"Lines count: {count}, elapsed: {sw.Elapsed}";
        }

        private async Task<int> GetLinesCount(string fileName) {
            if(string.IsNullOrEmpty(fileName))
                throw new ArgumentException("Parameter should not be null or empty!", nameof(fileName));
            using var reader = File.OpenText(fileName);
            int count = 0;
            while (true) {
                string? line = await reader.ReadLineAsync();
                if (line == null)
                    break;
                count++;
            }
            return count;
        }

        private async void Button2_Click(object sender, EventArgs e) {
            sw.Restart();
            int count = await GetLinesCount2("alice_in_wonderland.txt");
            sw.Stop();
            label1.Text = $"Lines count: {count}, elapsed: {sw.Elapsed}";
        }

        private Task<int> GetLinesCount2(string fileName) {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("Parameter should not be null or empty!", nameof(fileName));
            return Task.Run(() => {
                using var reader = File.OpenText(fileName);
                int count = 0;
                while (true) {
                    string? line = reader.ReadLine();
                    if (line == null)
                        break;
                    count++;
                }
                return count;
            });
        }
    }
}
