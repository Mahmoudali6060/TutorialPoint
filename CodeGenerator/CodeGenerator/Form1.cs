using CodeGenerator.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string originalText = txtOriginalText.Text;
            string convertedText;
            convertedText = originalText.Replace("public", "")
                .Replace("int", "")
                .Replace("string", "")
                .Replace("decimal", "")
                .Replace("DateTime", "")
                .Replace("byte", "")
                .Replace("{ get; set; }", ",");
            txtConverted.Text = convertedText;
            MessageBox.Show("Done");

        }

        private string PrepareProperties(string originalText)
        {
            List<string> originalTextList = originalText.Split(new[] { "\r\n" }, StringSplitOptions.None)
                             .ToList();
            string convertedProperties = "";
            foreach (string text in originalTextList)
            {
                string convertedText = null;

                if (text.Contains("int") || text.Contains("decimal") || text.Contains("byte"))
                {
                    convertedText = text.Replace("int", "")
                        .Replace("decimal", "")
                        .Replace("byte", "")
                        .Replace("{ get; set; }", ":number;");
                }

                else if (text.Contains("string"))
                {
                    convertedText = text.Replace("string", "")
                        .Replace("{ get; set; }", ":string;");
                }

                else if (text.Contains("DateTime"))
                {
                    convertedText = text.Replace("DateTime", "")
                        .Replace("{ get; set; }", ":Date;");
                }
                convertedProperties = convertedProperties + Environment.NewLine + convertedText;
                convertedText = null;

            }
            return convertedProperties;
        }

        private void btnConvertToFrontend_Click(object sender, EventArgs e)
        {
            string convertedText = PrepareProperties(txtOriginalText.Text);
            txtConverted.Text = convertedText; ;

        }
    }
}
