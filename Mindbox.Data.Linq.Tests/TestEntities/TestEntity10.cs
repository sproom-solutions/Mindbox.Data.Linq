using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Data.Linq.Entity.ModelConfiguration;

namespace Mindbox.Data.Linq.Tests
{
	public sealed class TestEntity10
	{
		public int Id { get; set; }
		public byte[] Value { get; set; }


		public class TestEntity10Configuration : EntityTypeConfiguration<TestEntity10>
		{
			public TestEntity10Configuration()
			{
				ToTable("Test10");
				HasKey(entity => entity.Id);
				Property(entity => entity.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
				Property(entity => entity.Value).IsFixedLength().HasMaxLength(5).IsRequired();
			}
		}
	}
}
