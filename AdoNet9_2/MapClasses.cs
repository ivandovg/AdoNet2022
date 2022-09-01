using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdoNet9_2
{
    public class PaticipantMap : EntityTypeConfiguration<Paticipant>
    {
        public PaticipantMap()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                .IsRequired().HasColumnName("Name")
                .HasColumnType("nvarchar").HasMaxLength(100);

            Property(p => p.Birth)
                            .IsRequired().HasColumnName("Birth")
                            .HasColumnType("date");

            Property(p => p.Country)
                            .IsRequired().HasColumnName("CountryName")
                            .HasColumnType("nvarchar").HasMaxLength(100);

            Property(p => p.Weight)
                            .IsRequired().HasColumnName("Weight")
                            .HasColumnType("float");
            Property(p => p.Height)
                            .IsRequired().HasColumnName("Height")
                            .HasColumnType("float");

            ToTable("Paticipants", "dbo");
        }
    }
    public class CompetitionMap : EntityTypeConfiguration<Competition>
    {
        public CompetitionMap()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Date)
                            .IsRequired().HasColumnName("Date")
                            .HasColumnType("date");

            Property(p => p.City)
                            .IsRequired().HasColumnName("CityName")
                            .HasColumnType("nvarchar").HasMaxLength(100);

            ToTable("Competitions", "dbo");
        }
    }
    public class ResultMap : EntityTypeConfiguration<Result>
    {
        public ResultMap()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Place)
                            .IsRequired().HasColumnName("Place")
                            .HasColumnType("int");

            ToTable("Results", "dbo");
        }
    }
}
