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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Data.Mapping
{
    public partial class StateProvinceMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.StateProvince>
    {
        public StateProvinceMap()
        {
            // table
            ToTable("StateProvince", "Person");

            // keys
            HasKey(t => t.StateProvinceID);

            // Properties
            Property(t => t.StateProvinceID)
                .HasColumnName("StateProvinceID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.StateProvinceCode)
                .HasColumnName("StateProvinceCode")
                .HasMaxLength(3)
                .IsRequired();
            Property(t => t.CountryRegionCode)
                .HasColumnName("CountryRegionCode")
                .HasMaxLength(3)
                .IsRequired();
            Property(t => t.IsOnlyStateProvinceFlag)
                .HasColumnName("IsOnlyStateProvinceFlag")
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                .IsRequired();
            Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.CountryRegion)
                .WithMany(t => t.StateProvinces)
                .HasForeignKey(d => d.CountryRegionCode)
                .WillCascadeOnDelete(false);
            HasRequired(t => t.SalesTerritory)
                .WithMany(t => t.StateProvinces)
                .HasForeignKey(d => d.TerritoryID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
