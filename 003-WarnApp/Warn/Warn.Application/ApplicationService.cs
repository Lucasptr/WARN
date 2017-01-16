using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warn.Data;
using Warn.SharedKernel;
using Warn.SharedKernel.Events;

namespace Warn.ApplicationService
{
    public class ApplicationService
    {
        private IUnityOfWork _unitOfWork;
        private IHandler<DomainNotification> _notifications;

        public ApplicationService(IUnityOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications())
                return false;

            _unitOfWork.Commit();
            return true;
        }
    }
}
