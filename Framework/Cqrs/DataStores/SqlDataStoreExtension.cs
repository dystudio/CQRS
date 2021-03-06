﻿#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="Chinchilla Software Limited">
// // 	Copyright Chinchilla Software Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

using System;
using System.Data.Linq;
using Cqrs.Entities;

namespace Cqrs.DataStores
{
	/// <summary>
	/// A collection of extension methods for <see cref="Table{TData}"/>
	/// </summary>
	public static class SqlDataStoreExtension
	{
		/*
		public static int DeleteBatch<TEntity>(this Table<TEntity> table, IQueryable<TEntity> entities)
			where TEntity : class
		{
			DbCommand delete = table.GetDeleteBatchCommand<TEntity>(entities);

			var parameters =
				from p in delete.Parameters.Cast<DbParameter>()
				select p.Value;

			return table.Context.ExecuteCommand(
				delete.CommandText,
				parameters.ToArray());
		}

		public static int UpdateBatch<TEntity>(this Table<TEntity> table, IQueryable<TEntity> entities, object evaluator)
			where TEntity : class
		{
			DbCommand update = table.GetUpdateBatchCommand<TEntity>(entities, evaluator);

			var parameters =
				from p in update.Parameters.Cast<DbParameter>()
				select p.Value;

			return table.Context.ExecuteCommand(
				update.CommandText,
				parameters.ToArray());
		}
		*/

		/// <summary>
		/// Calls the TRUNCATE SQL command on the <see cref="Table{TEntity}"/>.
		/// </summary>
		/// <typeparam name="TEntity">The <see cref="Type"/> of <see cref="IEntity"/> to truncate all data of.</typeparam>
		/// <param name="table">The <see cref="Table{TEntity}"/> to truncate all data of.</param>
		public static void Truncate<TEntity>(this Table<TEntity> table) where TEntity : class
		{
			Type rowType = table.GetType().GetGenericArguments()[0];
			string tableName = table.Context.Mapping.GetTable(rowType).TableName;
			const string sqlCommand = "TRUNCATE TABLE {0}";
			table.Context.ExecuteCommand(string.Format(sqlCommand, tableName));
		}
	}
}