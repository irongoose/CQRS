﻿using System.Collections.Generic;
using Cqrs.Domain;
using Cqrs.Events;

namespace Cqrs.Akka.Domain
{
	public interface IAkkaSagaRepository<TAuthenticationToken> : ISagaRepository<TAuthenticationToken>
	{
		void LoadSagaHistory<TSaga>(TSaga saga, IList<ISagaEvent<TAuthenticationToken>> events = null, bool throwExceptionOnNoEvents = true)
			where TSaga : ISaga<TAuthenticationToken>;
	}
}