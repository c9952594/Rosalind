using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Rosalind {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            AllowDrop = true;
            DragEnter += Form1_DragEnter;
            DragDrop += Form1_DragDrop;
        }

        void Form1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        readonly Dictionary<string, Func<string, string>> _problems = new Dictionary<string, Func<string, string>> {
            ["rosalind_dna"] = CountingDnaNucleotides,
            ["rosalind_rna"] = TranscribingDnaIntoRna,
            ["rosalind_revc"] = ComplementingAStrandOfDna,
            ["rosalind_fib"] = RabbitsAndRecurrenceRelations
        };

        void Form1_DragDrop(object sender, DragEventArgs e) {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files) {
                var content = File.ReadAllText(file).Trim();
                var filename = Path.GetFileNameWithoutExtension(file);
                var problem = _problems.First(m => filename.StartsWith(m.Key)).Value;
                Output.Text = problem(content);
            }
        }

        private static string CountingDnaNucleotides(string content) {
            // http://rosalind.info/problems/dna/
            return
                content
                    .ToCharArray()
                    .OrderBy(m => m)
                    .GroupBy(m => m)
                    .Select(m => m.Count())
                    .Aggregate("", (result, count) => result + count + " ")
                    .TrimEnd();
        }

        private static string TranscribingDnaIntoRna(string content) {
            // http://rosalind.info/problems/rna/
            return content.Replace('T', 'U');
        }

        private static string ComplementingAStrandOfDna(string content) {
            // http://rosalind.info/problems/revc/
            var compliment = new Dictionary<char, char>() {
                ['A'] = 'T',
                ['T'] = 'A',
                ['C'] = 'G',
                ['G'] = 'C'
                
            };
            return new string(content.ToCharArray().Select(c => compliment[c]).Reverse().ToArray());
        }

        private static string RabbitsAndRecurrenceRelations(string content) {
            // http://rosalind.info/problems/fib/
            return "";
        }
    }
}
