﻿#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="Chinchilla Software Limited">
// // 	Copyright Chinchilla Software Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

using System;
using Cqrs.Domain;

namespace Cqrs.Commands
{
	/// <summary>
	/// A <see cref="ICommandHandle"/> for working with <see cref="DtoCommand{TAuthenticationToken,TDto}"/>.
	/// </summary>
	/// <typeparam name="TAuthenticationToken">The <see cref="Type"/> of authentication token.</typeparam>
	/// <typeparam name="TDto">The <see cref="Type"/> of <see cref="IDto"/> this command targets.</typeparam>
	public class DtoCommandHandler<TAuthenticationToken, TDto> : ICommandHandler<TAuthenticationToken, DtoCommand<TAuthenticationToken, TDto>>
		where TDto : IDto
	{
		private IUnitOfWork<TAuthenticationToken> UnitOfWork { get; set; }

		/// <summary>
		/// Instantiates a new instance of <see cref="DtoCommandHandler{TAuthenticationToken,TDto}"/>
		/// </summary>
		public DtoCommandHandler(IUnitOfWork<TAuthenticationToken> unitOfWork)
		{
			UnitOfWork = unitOfWork;
		}

		#region Implementation of IMessageHandler<in DtoCommand<UserDto>>

		/// <summary>
		/// Responds to the provided <paramref name="message"/>.
		/// </summary>
		/// <param name="message">The <see cref="DtoCommand{TAuthenticationToken,TDto}"/> to respond to or "handle"</param>
		public void Handle(DtoCommand<TAuthenticationToken, TDto> message)
		{
			var item = new DtoAggregateRoot<TAuthenticationToken, TDto>(message.Id, message.Original, message.New);
			UnitOfWork.Add(item);
			UnitOfWork.Commit();
		}

		#endregion
	}
}
