using DAL.Entities;
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
    public partial class PrintForm : Form
    {
        string _SellerName, _SellerSO, _SellerRO, _PurchaserName, _PurchaserSO, _PurchaserRO, _PlotHouseNo, _Phase, _StreetNo, _RegistrationNo, _Catagory, _Size, _TotalAmount, _Biana, _BalanceAmount, _OnOrBefore, _SellerCnic, _PurchaserCnic, _WitnessOneName, _WitnessOneCnic, _WitnessTwoName, _WitnessTwoCnic;
        public PrintForm(EDeals deals)
        {
            InitializeComponent();
            _SellerName = deals.SellerName;
            _SellerSO = deals.SellerSO;
            _SellerRO = deals.SellerRO;
            _PurchaserName = deals.PurchaserName;
            _PurchaserSO = deals.PurchaserSO;
            _PurchaserRO = deals.PurchaserRO;
            _PlotHouseNo = deals.PlotHouseNo;
            _Phase = deals.Phase;
            _StreetNo = deals.StreetNo;
            _RegistrationNo = deals.RegistrationNo;
            _Catagory = deals.Catagory;
            _Size = deals.Size;
            _TotalAmount = deals.TotalAmount;
            _Biana = deals.Biana;
            _BalanceAmount = deals.BalanceAmount;
            _OnOrBefore = deals.OnOrBefore;
            _SellerCnic = deals.SellerCnic;
            _PurchaserCnic = deals.PurchaserCnic;
            _WitnessOneName = deals.WitnessOneName;
            _WitnessOneCnic = deals.WitnessOneCnic;
            _WitnessTwoName = deals.WitnessTwoName;
            _WitnessTwoCnic = deals.WitnessTwoCnic;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pSellerName",_SellerName),
                new Microsoft.Reporting.WinForms.ReportParameter("pSellerSO",_SellerSO),
                new Microsoft.Reporting.WinForms.ReportParameter("pSellerRO",_SellerRO),
                new Microsoft.Reporting.WinForms.ReportParameter("pPurchaserName",_PurchaserName),
                new Microsoft.Reporting.WinForms.ReportParameter("pPurchaserSO",_PurchaserSO),
                new Microsoft.Reporting.WinForms.ReportParameter("pPurchaserRO",_PurchaserRO),
                new Microsoft.Reporting.WinForms.ReportParameter("pPlotHouseNo",_PlotHouseNo),
                new Microsoft.Reporting.WinForms.ReportParameter("pPhase",_Phase),
                new Microsoft.Reporting.WinForms.ReportParameter("pStreetNo",_StreetNo),
                new Microsoft.Reporting.WinForms.ReportParameter("pRegistrationNo",_RegistrationNo),
                new Microsoft.Reporting.WinForms.ReportParameter("pCatagory",_Catagory),
                new Microsoft.Reporting.WinForms.ReportParameter("pSize",_Size),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalAmount",_TotalAmount),
                new Microsoft.Reporting.WinForms.ReportParameter("pBiana",_Biana),
                new Microsoft.Reporting.WinForms.ReportParameter("pBalanceAmount",_BalanceAmount),
                new Microsoft.Reporting.WinForms.ReportParameter("pOnOrBefore",_OnOrBefore),
                new Microsoft.Reporting.WinForms.ReportParameter("pSellerCnic",_SellerCnic),
                new Microsoft.Reporting.WinForms.ReportParameter("pPurchaserCnic",_PurchaserCnic),
                new Microsoft.Reporting.WinForms.ReportParameter("pWitnessOneName",_WitnessOneName),
                new Microsoft.Reporting.WinForms.ReportParameter("pWitnessOneCnic",_WitnessOneCnic),
                new Microsoft.Reporting.WinForms.ReportParameter("pWitnessTwoName",_WitnessTwoName),
                new Microsoft.Reporting.WinForms.ReportParameter("pWitnessTwoCnic",_WitnessTwoCnic)
            };
            this.reportViewer.LocalReport.SetParameters(para);
            this.reportViewer.RefreshReport();

        }
    }
}
