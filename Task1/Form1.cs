using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapTasks {
    public partial class Form1 : Form {
        const string fileName = "alice_in_wonderland.txt";
        readonly Stopwatch sw = new();

        public Form1() {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e) {
            sw.Restart();
            int count = await GetLinesCount(fileName);
            sw.Stop();
            label1.Text = $"Lines count: {count}, elapsed: {sw.Elapsed}";
        }
        // Используется File.OpenText - плохо с производительностью
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
            int count = await GetLinesCount2(fileName);
            sw.Stop();
            label1.Text = $"Lines count: {count}, elapsed: {sw.Elapsed}";
        }
        // Открытие потока с большим буфеом и в асинхронном режиме - лучше с производительностью
        private async Task<int> GetLinesCount2(string fileName) {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("Parameter should not be null or empty!", nameof(fileName));
            using var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None, 32768, true);
            using var reader = new StreamReader(fs);
            int count = 0;
            while (true) {
                string? line = await reader.ReadLineAsync();
                if (line == null)
                    break;
                count++;
            }
            return count;
        }

        private async void Button3_Click(object sender, EventArgs e) {
            sw.Restart();
            int count = await GetLinesCount3(fileName);
            sw.Stop();
            label1.Text = $"Lines count: {count}, elapsed: {sw.Elapsed}";
        }
        // Совсем хорошо с производительностью, но с синхронным чтением и в отдельном потоке
        private Task<int> GetLinesCount3(string fileName) {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("Parameter should not be null or empty!", nameof(fileName));
            return Task.Run(() => {
                using var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None, 32768);
                using var reader = new StreamReader(fs);
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
