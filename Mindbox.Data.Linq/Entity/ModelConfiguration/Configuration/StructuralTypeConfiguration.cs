﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Mindbox.Expressions;

namespace Mindbox.Data.Linq.Entity.ModelConfiguration.Configuration
{
	/// <summary>
	/// Allows configuration to be performed for a type in a model.
	/// </summary>
	/// <typeparam name="TStructuralType"> The type to be configured. </typeparam>
	public abstract class StructuralTypeConfiguration<TStructuralType>
		where TStructuralType : class
	{
		protected StructuralTypeConfiguration()
		{
			PropertyConfigurationsByProperty = new Dictionary<PropertyInfo, PrimitivePropertyConfiguration>();
		}


		protected Dictionary<PropertyInfo, PrimitivePropertyConfiguration> PropertyConfigurationsByProperty { get; private set; }


		/// <summary>
		/// Configures a <see cref="T:System.struct" /> property that is defined on this type.
		/// </summary>
		/// <typeparam name="T"> The type of the property being configured. </typeparam>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public PrimitivePropertyConfiguration Property<T>(
			Expression<Func<TStructuralType, T>> propertyExpression)
			where T : struct
		{
			if (propertyExpression == null)
				throw new ArgumentNullException("propertyExpression");

			var property = ReflectionExpressions.GetPropertyInfo(propertyExpression);
			PrimitivePropertyConfiguration propertyConfiguration;
			if (!PropertyConfigurationsByProperty.TryGetValue(property, out propertyConfiguration))
			{
				propertyConfiguration = new PrimitivePropertyConfiguration(property);
				PropertyConfigurationsByProperty.Add(property, propertyConfiguration);
			}
			return propertyConfiguration;
		}

		/// <summary>
		/// Configures a <see cref="T:System.struct?" /> property that is defined on this type.
		/// </summary>
		/// <typeparam name="T"> The type of the property being configured. </typeparam>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public PrimitivePropertyConfiguration Property<T>(
			Expression<Func<TStructuralType, T?>> propertyExpression)
			where T : struct
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures a <see cref="T:System.string" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public StringPropertyConfiguration Property(Expression<Func<TStructuralType, string>> propertyExpression)
		{
			if (propertyExpression == null)
				throw new ArgumentNullException("propertyExpression");

			var property = ReflectionExpressions.GetPropertyInfo(propertyExpression);
			PrimitivePropertyConfiguration propertyConfiguration;
			if (!PropertyConfigurationsByProperty.TryGetValue(property, out propertyConfiguration))
			{
				propertyConfiguration = new StringPropertyConfiguration(property);
				PropertyConfigurationsByProperty.Add(property, propertyConfiguration);
			}
			return (StringPropertyConfiguration)propertyConfiguration;
		}

		/// <summary>
		/// Configures a <see cref="T:System.byte[]" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public BinaryPropertyConfiguration Property(Expression<Func<TStructuralType, byte[]>> propertyExpression)
		{
			if (propertyExpression == null)
				throw new ArgumentNullException("propertyExpression");

			var property = ReflectionExpressions.GetPropertyInfo(propertyExpression);
			PrimitivePropertyConfiguration propertyConfiguration;
			if (!PropertyConfigurationsByProperty.TryGetValue(property, out propertyConfiguration))
			{
				propertyConfiguration = new BinaryPropertyConfiguration(property);
				PropertyConfigurationsByProperty.Add(property, propertyConfiguration);
			}
			return (BinaryPropertyConfiguration)propertyConfiguration;
		}

		/// <summary>
		/// Configures a <see cref="T:System.decimal" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public DecimalPropertyConfiguration Property(Expression<Func<TStructuralType, decimal>> propertyExpression)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures a <see cref="T:System.decimal?" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public DecimalPropertyConfiguration Property(Expression<Func<TStructuralType, decimal?>> propertyExpression)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures a <see cref="T:System.DateTime" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public DateTimePropertyConfiguration Property(Expression<Func<TStructuralType, DateTime>> propertyExpression)
		{
			if (propertyExpression == null)
				throw new ArgumentNullException("propertyExpression");

			var property = ReflectionExpressions.GetPropertyInfo(propertyExpression);
			PrimitivePropertyConfiguration propertyConfiguration;
			if (!PropertyConfigurationsByProperty.TryGetValue(property, out propertyConfiguration))
			{
				propertyConfiguration = new DateTimePropertyConfiguration(property);
				PropertyConfigurationsByProperty.Add(property, propertyConfiguration);
			}
			return (DateTimePropertyConfiguration)propertyConfiguration;
		}

		/// <summary>
		/// Configures a <see cref="T:System.DateTime?" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public DateTimePropertyConfiguration Property(Expression<Func<TStructuralType, DateTime?>> propertyExpression)
		{
			if (propertyExpression == null)
				throw new ArgumentNullException("propertyExpression");

			var property = ReflectionExpressions.GetPropertyInfo(propertyExpression);
			PrimitivePropertyConfiguration propertyConfiguration;
			if (!PropertyConfigurationsByProperty.TryGetValue(property, out propertyConfiguration))
			{
				propertyConfiguration = new DateTimePropertyConfiguration(property);
				PropertyConfigurationsByProperty.Add(property, propertyConfiguration);
			}
			return (DateTimePropertyConfiguration)propertyConfiguration;
		}

		/// <summary>
		/// Configures a <see cref="T:System.DateTimeOffset" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public DateTimePropertyConfiguration Property(
			Expression<Func<TStructuralType, DateTimeOffset>> propertyExpression)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures a <see cref="T:System.DateTimeOffset?" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public DateTimePropertyConfiguration Property(
			Expression<Func<TStructuralType, DateTimeOffset?>> propertyExpression)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures a <see cref="T:System.TimeSpan" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public DateTimePropertyConfiguration Property(Expression<Func<TStructuralType, TimeSpan>> propertyExpression)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Configures a <see cref="T:System.TimeSpan?" /> property that is defined on this type.
		/// </summary>
		/// <param name="propertyExpression"> A lambda expression representing the property to be configured. C#: t => t.MyProperty VB.Net: Function(t) t.MyProperty </param>
		/// <returns> A configuration object that can be used to configure the property. </returns>
		public DateTimePropertyConfiguration Property(Expression<Func<TStructuralType, TimeSpan?>> propertyExpression)
		{
			throw new NotImplementedException();
		}
	}
}
