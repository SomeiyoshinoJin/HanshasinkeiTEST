using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HanshasinkeiTEST
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            record.Text = Form1.t;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\recorddata1.csv"))
            {
                string[] lines = File.ReadAllLines(@"..\..\recorddata1.csv", Encoding.UTF8);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    recordDataSet.recordDataTable.AddrecordDataTableRow(
                        data[0], double.Parse(data[1]));
                }
            }
            record.Text = Form1.t;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> strList = new List<string>();
            foreach (DataRow row in recordDataSet.recordDataTable.Rows)
            {
                strList.Add(row["名前"] + "," + row["記録"]);
            }

            File.WriteAllLines(@"..\..\recorddata1.csv", strList, Encoding.UTF8);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (recordName.Text == "")
            {
                MessageBox.Show("名前未入力");
                return;
            }

            else
            {
                recordDataSet.recordDataTable.AddrecordDataTableRow(
                this.recordName.Text,
                double.Parse(this.record.Text));
                List<string> strList = new List<string>();
                foreach (DataRow row in recordDataSet.recordDataTable.Rows)
                {
                    strList.Add(row["名前"] + "," + row["記録"]);
                }

                File.WriteAllLines(@"..\..\recorddata1.csv", strList, Encoding.UTF8);
                Record record = new Record();
                //Form1 form1 = new Form1();
                // フォームを表示する
                record.Show();
                this.Close();


            }
            //recordDataSet.recordDataTable.AddrecordDataTableRow(
            //    this.recordName.Text,
            //    double.Parse(this.record.Text));
            //List<string> strList = new List<string>();
            //foreach (DataRow row in recordDataSet.recordDataTable.Rows)
            //{
            //    strList.Add(row["名前"] + "," + row["記録"]);
            //}

            //File.WriteAllLines(@"..\..\recorddata1.csv", strList, Encoding.UTF8);
           
        }
    }
}
