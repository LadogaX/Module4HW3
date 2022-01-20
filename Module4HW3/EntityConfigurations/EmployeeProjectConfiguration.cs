using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntityConfigurations
{
   public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProjectEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeProjectEntity> entityTypeBuilder)
        {
        }
    }
}
