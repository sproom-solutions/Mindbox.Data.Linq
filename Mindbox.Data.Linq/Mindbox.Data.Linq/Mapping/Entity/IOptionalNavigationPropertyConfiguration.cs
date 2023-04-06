using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Data.Linq.Entity;

namespace Mindbox.Data.Linq.Mapping.Entity
{
	internal interface IOptionalNavigationPropertyConfiguration
	{
		ColumnAttributeByMember TryGetColumnAttribute(DbModelBuilder dbModelBuilder);

		AssociationAttributeByMember GetAssociationAttribute(DbModelBuilder dbModelBuilder);
	}
}
