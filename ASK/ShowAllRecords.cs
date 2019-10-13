using DAL.Entities;
using DAL.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASK
{
    public partial class ShowAllRecords : Form
    {
        EDeals edeals = new EDeals();
        ODeals odeals = new ODeals();
        public ShowAllRecords()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "lnkDeleteRecord")
            {
                if (MessageBox.Show("Do you want to Delete This Record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = Convert.ToInt32(e.RowIndex); // Get the current row
                    int id = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells[1].Value);
                    odeals.DeleteRecord(id);
                    MessageBox.Show("Deleted");
                }
                dataGridView.DataSource = odeals.ShowAllRecords();
            }
            
            if (dataGridView.Columns[e.ColumnIndex].Name == "lnkViewRecord")
            {
                int rowIndex = Convert.ToInt32(e.RowIndex); // Get the current row
                int id = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells[1].Value);
                DataTable selectedRecord = odeals.ShowAllRecords(id);
                edeals.SellerName = selectedRecord.Rows[0][1].ToString();
                edeals.SellerSO = selectedRecord.Rows[0][2].ToString();
                edeals.SellerRO = selectedRecord.Rows[0][3].ToString();
                edeals.PurchaserName = selectedRecord.Rows[0][4].ToString();
                edeals.PurchaserSO = selectedRecord.Rows[0][5].ToString();
                edeals.PurchaserRO = selectedRecord.Rows[0][6].ToString();
                edeals.PlotHouseNo = selectedRecord.Rows[0][7].ToString();
                edeals.Phase = selectedRecord.Rows[0][8].ToString();
                edeals.StreetNo = selectedRecord.Rows[0][9].ToString();
                edeals.RegistrationNo = selectedRecord.Rows[0][10].ToString();
                edeals.Catagory = selectedRecord.Rows[0][11].ToString();
                edeals.Size = selectedRecord.Rows[0][12].ToString();
                edeals.TotalAmount = selectedRecord.Rows[0][13].ToString();
                edeals.Biana = selectedRecord.Rows[0][14].ToString();
                edeals.BalanceAmount = selectedRecord.Rows[0][15].ToString();
                edeals.OnOrBefore = selectedRecord.Rows[0][16].ToString();
                edeals.SellerCnic = selectedRecord.Rows[0][17].ToString();
                edeals.PurchaserCnic = selectedRecord.Rows[0][18].ToString();
                edeals.WitnessOneName = selectedRecord.Rows[0][19].ToString();
                edeals.WitnessOneCnic = selectedRecord.Rows[0][20].ToString();
                edeals.WitnessTwoName = selectedRecord.Rows[0][21].ToString();
                edeals.WitnessTwoCnic = selectedRecord.Rows[0][22].ToString();
                try
                {
                    using (PrintForm frm = new PrintForm(edeals))
                    {
                        frm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShowAllRecords_Load(object sender, EventArgs e)
        {
            DataGridViewLinkColumn dgvLink = new DataGridViewLinkColumn();

            dgvLink.UseColumnTextForLinkValue = true;
            dgvLink.LinkBehavior = LinkBehavior.SystemDefault;
            dgvLink.HeaderText = "Action";
            dgvLink.Name = "lnkViewRecord";
            dgvLink.LinkColor = Color.Blue;
            dgvLink.TrackVisitedState = true;
            dgvLink.Text = "View";
            dgvLink.UseColumnTextForLinkValue = true;
            dataGridView.DataSource = odeals.ShowAllRecords();
            dataGridView.Columns.Add(dgvLink);



            DataGridViewLinkColumn dgvLinkDelete = new DataGridViewLinkColumn();

            dgvLinkDelete.UseColumnTextForLinkValue = true;
            dgvLinkDelete.LinkBehavior = LinkBehavior.SystemDefault;
            dgvLinkDelete.HeaderText = "Action";
            dgvLinkDelete.Name = "lnkDeleteRecord";
            dgvLinkDelete.LinkColor = Color.Blue;
            dgvLinkDelete.TrackVisitedState = true;
            dgvLinkDelete.Text = "Delete";
            dgvLinkDelete.UseColumnTextForLinkValue = true;
            dataGridView.DataSource = odeals.ShowAllRecords();
            dataGridView.Columns.Add(dgvLinkDelete);
        }
    }
}
