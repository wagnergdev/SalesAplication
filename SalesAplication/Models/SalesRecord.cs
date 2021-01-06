using System;
using SalesAplication.Models.Enums;

namespace SalesAplication.Models
{
    public class SalesRecord
    {
        public int SalesRecordId { get; set; }

        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public SaleSatus Status { get; set; }

        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int salesRecordId, DateTime date, double amount, SaleSatus status, Seller seller)
        {
            SalesRecordId = salesRecordId;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }

}
