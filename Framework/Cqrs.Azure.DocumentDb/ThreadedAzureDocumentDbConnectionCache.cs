﻿#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="cdmdotnet Limited">
// // 	Copyright cdmdotnet Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

using System.Runtime.Remoting.Messaging;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace Cqrs.Azure.DocumentDb
{
	public class ThreadedAzureDocumentDbConnectionCache : IAzureDocumentDbConnectionCache
	{
		public bool TryGetClient(string key, out DocumentClient client)
		{
			try
			{
				var results = CallContext.GetData(key) as DocumentClient;
				client = results;
				return true;
			}
			catch
			{
			}
			client = null;
			return false;
		}

		public void SetClient(string key, DocumentClient client)
		{
			CallContext.SetData(key, client);
		}

		public bool TryGetDatabase(string key, out Database database)
		{
			try
			{
				var results = CallContext.GetData(key) as Database;
				database = results;
				return true;
			}
			catch
			{
			}
			database = null;
			return false;
		}

		public void SetDatabase(string key, Database database)
		{
			CallContext.SetData(key, database);
		}
	}
}