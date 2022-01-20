﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntityConfigurations
{
   public class ProjectConfiguration : IEntityTypeConfiguration<ProjectEntity>
    {
        public void Configure(EntityTypeBuilder<ProjectEntity> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Project").HasKey(t => t.ProjectId);
            entityTypeBuilder.Property(t => t.ProjectId).HasColumnName("ProjectId").ValueGeneratedOnAdd();
            entityTypeBuilder.Property(t => t.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
            entityTypeBuilder.Property(t => t.Budget).IsRequired().HasColumnName("Budget").HasColumnType("double");
            entityTypeBuilder.Property(t => t.StartedDate).IsRequired().HasColumnName("StartedDate").HasColumnType("datetime2(7)");
        }
    }
}
