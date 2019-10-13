using DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Operations
{
    public class ODeals
    {
        DBAccess db = new DBAccess();
        public void Insert(EDeals edeals)
        {
            string query = "INSERT INTO [Table](Date,SellerName,SellerSO,SellerRO,PurchaserName,PurchaserSO,PurchaserRO,PlotHouseNo,Phase,StreetNo,RegistrationNo,Catagory,Size,TotalAmount,Biana,BalanceAmount,OnOrBefore,SellerCnic,PurchaserCnic,WitnessOneName,WitnessOneCnic,WitnessTwoName,WitnessTwoCnic)VALUES (@Date,@SellerName,@SellerSO,@SellerRO,@PurchaserName,@PurchaserSO,@PurchaserRO,@PlotHouseNo,@Phase,@StreetNo,@RegistrationNo,@Catagory,@Size,@TotalAmount,@Biana,@BalanceAmount,@OnOrBefore,@SellerCnic,@PurchaserCnic,@WitnessOneName,@WitnessOneCnic,@WitnessTwoName,@WitnessTwoCnic)";
            Hashtable paramters = new Hashtable();
            paramters.Add("@Date", edeals.Date);
            paramters.Add("@SellerName", edeals.SellerName);
            paramters.Add("@SellerSO", edeals.SellerSO);
            paramters.Add("@SellerRO", edeals.SellerRO);
            paramters.Add("@PurchaserName", edeals.PurchaserName);
            paramters.Add("@PurchaserSO", edeals.PurchaserSO);
            paramters.Add("@PurchaserRO", edeals.PurchaserRO);
            paramters.Add("@PlotHouseNo", edeals.PlotHouseNo);
            paramters.Add("@Phase", edeals.Phase);
            paramters.Add("@StreetNo", edeals.StreetNo);
            paramters.Add("@RegistrationNo", edeals.RegistrationNo);
            paramters.Add("@Catagory", edeals.Catagory);
            paramters.Add("@Size", edeals.Size);
            paramters.Add("@TotalAmount", edeals.TotalAmount);
            paramters.Add("@Biana", edeals.Biana);
            paramters.Add("@BalanceAmount", edeals.BalanceAmount);
            paramters.Add("@OnOrBefore", edeals.OnOrBefore);
            paramters.Add("@SellerCnic", edeals.SellerCnic);
            paramters.Add("@PurchaserCnic", edeals.PurchaserCnic);
            paramters.Add("@WitnessOneName", edeals.WitnessOneName);
            paramters.Add("@WitnessOneCnic", edeals.WitnessOneCnic);
            paramters.Add("@WitnessTwoName", edeals.WitnessTwoName);
            paramters.Add("@WitnessTwoCnic", edeals.WitnessTwoCnic);
            db.ExecuteQuery(query, paramters);
        }
        public DataTable ShowAllRecords()
        {
            string query = "SELECT Id,Date,SellerName,PurchaserName,PlotHouseNo,Phase FROM [Table]";
            DataTable dt = new DataTable();
            dt = db.GetDataTable(query);
            return dt;
        }
        public DataTable ShowAllRecords(int id)
        {
            string query = "SELECT * FROM [Table] WHERE Id="+id;
            DataTable dt = new DataTable();
            dt = db.GetDataTable(query);
            return dt;
        }
        public void DeleteRecord( int id)
        {
            string query = "DELETE FROM [Table] WHERE Id="+id;
            db.ExecuteQuery(query);
        }
        public void DeleteAllRecords()
        {
            string query = "DELETE FROM [Table]";
            db.ExecuteQuery(query);
        }
    }
}