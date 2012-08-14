﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Data.Entities
{
    public partial class ProductVendor
    {
        public ProductVendor()
        {
        }

        public int ProductID { get; set; }
        public int VendorID { get; set; }
        public int AverageLeadTime { get; set; }
        public decimal StandardPrice { get; set; }
        public decimal? LastReceiptCost { get; set; }
        public System.DateTime? LastReceiptDate { get; set; }
        public int MinOrderQty { get; set; }
        public int MaxOrderQty { get; set; }
        public int? OnOrderQty { get; set; }
        public string UnitMeasureCode { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}