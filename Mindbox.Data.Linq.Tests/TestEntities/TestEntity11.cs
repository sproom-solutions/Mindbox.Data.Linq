﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Data.Linq.Entity.ModelConfiguration;

namespace Mindbox.Data.Linq.Tests
{
	public class TestEntity11
	{
		private TestEntity9 other;


		public virtual int Id { get; set; }
		public virtual int OtherId { get; set; }

		public virtual TestEntity9 Other
		{
			get { return other; }
			set
			{
				other = value;
				OtherId = value == null ? default(int) : value.Id;
			}
		}


		public class TestEntity11Configuration : EntityTypeConfiguration<TestEntity11>
		{
			public TestEntity11Configuration()
			{
				ToTable("Test11");
				HasKey(entity => entity.Id);
				Property(entity => entity.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
				HasRequired(entity => entity.Other).WithMany().HasForeignKey(entity => entity.OtherId);
			}
		}
	}
}
