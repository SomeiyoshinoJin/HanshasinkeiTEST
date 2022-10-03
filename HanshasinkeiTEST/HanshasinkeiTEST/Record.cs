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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
            
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("お疲れさまでした！", "反射神経テスト",　　//メッセージボックス表示（OK）
                MessageBoxButtons.OK);

            Application.Exit(); 　　//アプリケーション閉じる
        }

        private void Record_Load(object sender, EventArgs e)
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

                if (dataGridView1.CurrentCell == null)
                    return;

                //並び替える列を決める
                dataGridView1.CurrentCell = dataGridView1[1, 0];   //早いもの順に並べ替える　/* = dataGridView1[1, 0]; */
                DataGridViewColumn sortColumn = dataGridView1.CurrentCell.OwningColumn;

                //並び替えの方向（昇順か降順か）を決める
                ListSortDirection sortDirection = ListSortDirection.Ascending;

                if (dataGridView1.SortedColumn != null &&
                    dataGridView1.SortedColumn.Equals(sortColumn))
                {
                    sortDirection =
                        dataGridView1.SortOrder == SortOrder.Ascending ?
                        ListSortDirection.Descending : ListSortDirection.Ascending; //Ascending＝昇順 Decending=降順
                }

                //並び替えを行う
                dataGridView1.Sort(sortColumn, sortDirection);

            }
        }
    }
}
