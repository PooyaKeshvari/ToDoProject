using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.EntityFrameworkCore.Configurations
{
    public class ToDoConfiguration : IEntityTypeConfiguration<ToDo.Domain.Aggregations.ToDoAggregate.ToDo>
    {
        //work on Entity Props - work like Fluent-API
        #region [-Configure-]
        public void Configure(EntityTypeBuilder<Domain.Aggregations.ToDoAggregate.ToDo> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).HasMaxLength(300).IsRequired();
            builder.Property(p => p.Done).HasDefaultValue(false);
        }
        #endregion

    }
}
