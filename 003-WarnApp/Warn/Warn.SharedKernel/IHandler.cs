using System;
using System.Collections.Generic;
using Warn.SharedKernel.Events.Contracts;

namespace Warn.SharedKernel
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
