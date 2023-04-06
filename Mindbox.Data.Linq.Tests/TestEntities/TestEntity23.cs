﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Data.Linq.Entity.ModelConfiguration;

namespace Mindbox.Data.Linq.Tests
{
	public class TestEntity23
	{
		public virtual int Id { get; set; }
		public virtual int Value { get; set; }


		public class TestEntity23Configuration : EntityTypeConfiguration<TestEntity23>
		{
			public TestEntity23Configuration()
			{
				ToTable("Test23");
				HasKey(entity => entity.Id);
				Property(entity => entity.Id);
				Property(entity => entity.Value).IsRequired();
			}
		}
	}
}
