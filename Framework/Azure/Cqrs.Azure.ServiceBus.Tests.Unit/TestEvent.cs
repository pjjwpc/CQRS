﻿using System;
using System.Runtime.Serialization;
using Cqrs.Events;
using Cqrs.Messages;

namespace Cqrs.Azure.ServiceBus.Tests.Unit
{
	public class TestEvent : IEvent<Guid>
	{
		#region Implementation of IMessageWithAuthenticationToken<Guid>

		[DataMember]
		public Guid AuthenticationToken { get; set; }

		#endregion

		#region Implementation of IEvent<Guid>

		[DataMember]
		public Guid Id { get; set; }

		[DataMember]
		public int Version { get; set; }

		[DataMember]
		public DateTimeOffset TimeStamp { get; set; }

		#endregion

		#region Implementation of IMessage

		[DataMember]
		public Guid CorrelationId { get; set; }

		[Obsolete("Use CorrelationId")]
		[DataMember]
		public Guid CorrolationId
		{
			get { return CorrelationId; }
			set { CorrelationId = value; }
		}

		[DataMember]
		public FrameworkType Framework { get; set; }

		#endregion
	}
}