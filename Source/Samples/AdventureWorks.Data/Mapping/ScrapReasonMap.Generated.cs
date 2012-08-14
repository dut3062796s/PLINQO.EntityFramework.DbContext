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
    public partial class ScrapReasonMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.ScrapReason>
    {
        public ScrapReasonMap()
        {
            // table
            ToTable("ScrapReason", "Production");

            // keys
            HasKey(t => t.ScrapReasonID);

            // Properties
            Property(t => t.ScrapReasonID)
                .HasColumnName("ScrapReasonID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}
