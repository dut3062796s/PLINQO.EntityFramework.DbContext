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
    public partial class DatabaseLog
    {
        public DatabaseLog()
        {
        }

        public int DatabaseLogID { get; set; }
        public System.DateTime PostTime { get; set; }
        public string DatabaseUser { get; set; }
        public string Event { get; set; }
        public string Schema { get; set; }
        public string Object { get; set; }
        public string Tsql { get; set; }
        public string XmlEvent { get; set; }

    }
}