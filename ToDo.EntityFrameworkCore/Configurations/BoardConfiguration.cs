using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Domain.Aggregations.BoardAggregate;

namespace ToDo.EntityFrameworkCore.Configurations
{
    public class BoardConfiguration : IEntityTypeConfiguration<Board>
    {

        #region [-Configure-]
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.BoardTitle).HasMaxLength(300).IsRequired();

        }
        #endregion

    }
}
