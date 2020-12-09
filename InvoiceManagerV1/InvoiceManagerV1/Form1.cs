using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagerV1
{
    public partial class Form1 : Form
    {
        public string Path { get; set; }
        // C:\Users\Asanali\Desktop\Projects\Uni\Programming-Languages-3LID-A\InvoiceManagerV1\invoices.txt
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var path = openFileDialog1.FileName;

            if (!File.Exists(path))
            {
                MessageBox.Show("File is not exist");
            }


            var fileText = File.ReadAllText(path);
            resultTextBox.Text = fileText;
            Path = path;





            //string[] fileTextSplited = fileText.Split('\n');

            //resultTextBox.Text = fileTextSplited.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void totalByNamesButton_Click(object sender, EventArgs e)
        {
            // var path = pathTextBox.Text;

            if (!File.Exists(Path))
            {
                MessageBox.Show("File is not exist");
            }


            var fileText = File.ReadAllLines(Path).Skip(1);
            var invoices = new List<Invoice>();

            foreach (var line in fileText)
            {
                var split = line.Split('\t');
                var name = split[0];
                var date = DateTime.ParseExact(split[1], "yyyy-MM-dd", null);
                var amount = Convert.ToDecimal(split[2].Replace(",",
                    CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));

                var invoice = new Invoice(name, date, amount);
                invoices.Add(invoice);

            }
            
            var newList = invoices.GroupBy(x => x.Name).Select(x => $"{x.Key}: {x.Sum(y => y.Amount)}\r\n");

            resultTextBox.Text = string.Join("\r\n", newList);
        }

        private void totalByYear_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path))
            {
                MessageBox.Show("File is not exist");
            }


            var fileText = File.ReadAllLines(Path).Skip(1);
            var invoices = new List<Invoice>();

            foreach (var line in fileText)
            {
                var split = line.Split('\t');
                var name = split[0];
                var date = DateTime.ParseExact(split[1], "yyyy-MM-dd", null);
                var amount = Convert.ToDecimal(split[2].Replace(",",
                    CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));

                var invoice = new Invoice(name, date, amount);
                invoices.Add(invoice);

            }

            var newList = invoices.GroupBy(x => x.DateTime.Year).Select(x => $"{x.Key}: {x.Sum(y => y.Amount)}\r\n");

            resultTextBox.Text = string.Join("\r\n", newList);
        }

        private void totalByDate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path))
            {
                MessageBox.Show("File is not exist");
            }


            var fileText = File.ReadAllLines(Path).Skip(1);
            var invoices = new List<Invoice>();

            foreach (var line in fileText)
            {
                var split = line.Split('\t');
                var name = split[0];
                var date = DateTime.ParseExact(split[1], "yyyy-MM-dd", null);
                var amount = Convert.ToDecimal(split[2].Replace(",",
                    CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));

                var invoice = new Invoice(name, date, amount);
                invoices.Add(invoice);

            }

            var newList = invoices.GroupBy(x => x.DateTime).Select(x => $"{x.Key}: {x.Sum(y => y.Amount)}\r\n");

            resultTextBox.Text = string.Join("\r\n", newList);
        }
    }


    public class Invoice
    {
        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Amount { get; set; }

        public Invoice(string name, DateTime dateTime, decimal amount)
        {
            Name = name;
            DateTime = dateTime;
            Amount = amount;
        }


    }
}
