﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Mindbox.Data.Linq.Entity.ModelConfiguration.Configuration
{
	/// <summary>
	/// Configures a many relationship from an entity type.
	/// </summary>
	/// <typeparam name="TEntityType"> The entity type that the relationship originates from. </typeparam>
	/// <typeparam name="TTargetEntityType"> The entity type that the relationship targets. </typeparam>
	public class ManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType>
		where TEntityType : class
		where TTargetEntityType : class
	{
		/// <summary>
		/// Configures the relationship to be many:many with a navigation property on the other side of the relationship.
		/// </summary>
		/// <param name="navigationPropertyExpression"> An lambda expression representing the navigation property on the other end of the relationship. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to further configure the relationship. </returns>
		public ManyToManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType> WithMany(
			Expression<Func<TTargetEntityType, ICollection<TEntityType>>> navigationPropertyExpression)
		{
			if (navigationPropertyExpression == null)
				throw new ArgumentNullException("navigationPropertyExpression");

			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the relationship to be many:many without a navigation property on the other side of the relationship.
		/// </summary>
		/// <returns> A configuration object that can be used to further configure the relationship. </returns>
		public ManyToManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType> WithMany()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the relationship to be many:required with a navigation property on the other side of the relationship.
		/// </summary>
		/// <param name="navigationPropertyExpression"> An lambda expression representing the navigation property on the other end of the relationship. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to further configure the relationship. </returns>
		public DependentNavigationPropertyConfiguration<TTargetEntityType> WithRequired(
			Expression<Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			if (navigationPropertyExpression == null)
				throw new ArgumentNullException("navigationPropertyExpression");

			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the relationship to be many:required without a navigation property on the other side of the relationship.
		/// </summary>
		/// <returns> A configuration object that can be used to further configure the relationship. </returns>
		public DependentNavigationPropertyConfiguration<TTargetEntityType> WithRequired()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the relationship to be many:optional with a navigation property on the other side of the relationship.
		/// </summary>
		/// <param name="navigationPropertyExpression"> An lambda expression representing the navigation property on the other end of the relationship. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to further configure the relationship. </returns>
		public DependentNavigationPropertyConfiguration<TTargetEntityType> WithOptional(
			Expression<Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			if (navigationPropertyExpression == null)
				throw new ArgumentNullException("navigationPropertyExpression");

			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures the relationship to be many:optional without a navigation property on the other side of the relationship.
		/// </summary>
		/// <returns> A configuration object that can be used to further configure the relationship. </returns>
		public DependentNavigationPropertyConfiguration<TTargetEntityType> WithOptional()
		{
			throw new NotImplementedException();
		}
	}
}
