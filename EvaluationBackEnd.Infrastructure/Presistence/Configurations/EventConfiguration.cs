using EvaluationBackEnd.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvaluationBackEnd.Infrastructure.Presistence.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.Property(e => e.Title)
            .IsRequired();

        builder.Property(e => e.Description)
            .IsRequired();
        
        builder.Property(e => e.Date)
            .IsRequired();
        
        builder.Property(e => e.Time)
            .IsRequired();
        
        builder.Property(e => e.Location)
            .IsRequired();
    }
}