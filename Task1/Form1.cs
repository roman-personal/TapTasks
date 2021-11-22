using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapTasks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e) {
            int count = await GetLinesCount("alice_in_wonderland.txt");
            label1.Text = $"Lines count: {count}";
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
    }
}
