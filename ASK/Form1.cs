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
    public partial class MainForm : Form
    {
        EDeals edeals = new EDeals();
        ODeals odeals = new ODeals();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            edeals.Date = System.DateTime.Now.ToString("dd/MM/yyyy");
            edeals.BalanceAmount = txtBalanceAmount.Text;
            edeals.Biana = txtBiana.Text;
            edeals.Catagory = txtCatagory.Text;
            edeals.OnOrBefore = txtOnOrBefore.Text;
            edeals.Phase = txtPhase.Text;
            edeals.PlotHouseNo = txtPlotHouseNo.Text;
            edeals.PurchaserCnic = txtPurchaserCNIC.Text;
            edeals.PurchaserName = txtPurchaserName.Text;
            edeals.PurchaserRO = txtPurchaserRO.Text;
            edeals.PurchaserSO = txtPurchaserSO.Text;
            edeals.RegistrationNo = txtRegistrationNo.Text;
            edeals.SellerCnic = txtSellerCNIC.Text;
            edeals.SellerName = txtSellerName.Text;
            edeals.SellerRO = txtSellerRO.Text;
            edeals.SellerSO = txtSellerSonOf.Text;
            edeals.Size = txtSize.Text;
            edeals.StreetNo = txtStreetNo.Text;
            edeals.TotalAmount = txtTotalAmount.Text;
            if (!string.IsNullOrWhiteSpace(txtWitnessOneCNIC.Text) && !string.IsNullOrWhiteSpace(txtWitnessOneName.Text)&& !string.IsNullOrWhiteSpace(txtWitnessTwoCnic.Text) && !string.IsNullOrWhiteSpace(txtWitnessTwoName.Text))
            {
                edeals.WitnessOneCnic = txtWitnessOneCNIC.Text;
                edeals.WitnessOneName = txtWitnessOneName.Text;
                edeals.WitnessTwoCnic = txtWitnessTwoCnic.Text;
                edeals.WitnessTwoName = txtWitnessTwoName.Text; 
            }
            else
            {
                edeals.WitnessOneCnic = "_______________";
                edeals.WitnessOneName = "_______________";
                edeals.WitnessTwoCnic = "_______________";
                edeals.WitnessTwoName = "_______________";
            }

            try
            {

                if (!string.IsNullOrWhiteSpace(txtBalanceAmount.Text) && !string.IsNullOrWhiteSpace(txtBiana.Text) && !string.IsNullOrWhiteSpace(txtCatagory.Text) && !string.IsNullOrWhiteSpace(txtOnOrBefore.Text) && !string.IsNullOrWhiteSpace(txtPhase.Text) && !string.IsNullOrWhiteSpace(txtPlotHouseNo.Text) && !string.IsNullOrWhiteSpace(txtPurchaserCNIC.Text) && !string.IsNullOrWhiteSpace(txtPurchaserName.Text) && !string.IsNullOrWhiteSpace(txtPurchaserRO.Text) && !string.IsNullOrWhiteSpace(txtPurchaserSO.Text) && !string.IsNullOrWhiteSpace(txtRegistrationNo.Text) && !string.IsNullOrWhiteSpace(txtSellerCNIC.Text) && !string.IsNullOrWhiteSpace(txtSellerName.Text) && !string.IsNullOrWhiteSpace(txtSellerRO.Text) && !string.IsNullOrWhiteSpace(txtSellerSonOf.Text) && !string.IsNullOrWhiteSpace(txtSize.Text) && !string.IsNullOrWhiteSpace(txtStreetNo.Text) && !string.IsNullOrWhiteSpace(txtTotalAmount.Text))
                {
                    if (MessageBox.Show("Do you want to Save This in Record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        odeals.Insert(edeals);
                        MessageBox.Show("Record Saved Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                    try
                    {

                        using (PrintForm frm = new PrintForm(edeals))
                        {
                            frm.ShowDialog();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Clear();
                }
                else
                {
                    MessageBox.Show("Please Fill Out The Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllRecords showAllRecords = new ShowAllRecords();
            showAllRecords.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs abut = new AboutUs();
            abut.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Clear()
        {
            txtBalanceAmount.Text = null;
            txtBiana.Text = null;
            txtCatagory.Text = null;
            txtOnOrBefore.Text = null;
            txtPhase.Text = null;
            txtPlotHouseNo.Text = null;
            txtPurchaserCNIC.Text = null;
            txtPurchaserName.Text = null;
            txtPurchaserRO.Text = null;
            txtPurchaserSO.Text = null;
            txtRegistrationNo.Text = null;
            txtSellerCNIC.Text = null;
            txtSellerName.Text = null;
            txtSellerRO.Text = null;
            txtSellerSonOf.Text = null;
            txtSize.Text = null;
            txtStreetNo.Text = null;
            txtTotalAmount.Text = null;
            txtWitnessOneCNIC.Text = null;
            txtWitnessOneName.Text = null;
            txtWitnessTwoCnic.Text = null;
            txtWitnessTwoName.Text = null;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void deleteAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Clear All Records", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                odeals.DeleteAllRecords();
                MessageBox.Show("All records Deleted Successfully");
            }
        }


    }
}
