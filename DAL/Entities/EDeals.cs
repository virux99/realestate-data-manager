using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EDeals
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string SellerName { get; set; }
        public string SellerSO { get; set; }
        public string SellerRO { get; set; }
        public string PurchaserName { get; set; }
        public string PurchaserSO { get; set; }
        public string PurchaserRO { get; set; }
        public string PlotHouseNo { get; set; }
        public string Phase { get; set; }
        public string StreetNo { get; set; }
        public string RegistrationNo { get; set; }
        public string Catagory { get; set; }
        public string Size { get; set; }
        public string TotalAmount { get; set; }
        public string Biana { get; set; }
        public string BalanceAmount { get; set; }
        public string OnOrBefore { get; set; }
        public string SellerCnic { get; set; }
        public string PurchaserCnic { get; set; }
        public string WitnessOneName { get; set; }
        public string WitnessOneCnic { get; set; }
        public string WitnessTwoName { get; set; }
        public string WitnessTwoCnic { get; set; }
    }
}
