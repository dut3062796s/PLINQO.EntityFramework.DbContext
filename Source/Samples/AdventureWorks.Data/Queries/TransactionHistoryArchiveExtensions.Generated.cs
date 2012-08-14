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
using System.Linq;
using System.Text;

namespace AdventureWorks.Data.Queries
{
    public static partial class TransactionHistoryArchiveExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.TransactionHistoryArchive GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.TransactionHistoryArchive> queryable, int transactionID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.TransactionHistoryArchive>;
            if (dbSet != null)
                return dbSet.Find(transactionID);
                
            return queryable.FirstOrDefault(t => t.TransactionID == transactionID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.TransactionHistoryArchive> ByProductID(this IQueryable<AdventureWorks.Data.Entities.TransactionHistoryArchive> queryable, int productID)
        {
            return queryable.Where(t => t.ProductID == productID);
        }

        public static IQueryable<AdventureWorks.Data.Entities.TransactionHistoryArchive> ByReferenceOrderIDReferenceOrderLineID(this IQueryable<AdventureWorks.Data.Entities.TransactionHistoryArchive> queryable, int referenceOrderID, int referenceOrderLineID)
        {
            return queryable.Where(t => t.ReferenceOrderID == referenceOrderID
                && t.ReferenceOrderLineID == referenceOrderLineID);
        }
    }
}
