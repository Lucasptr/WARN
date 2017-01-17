using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warn.SharedKernel.Events;

namespace Warn.Api.Models
{
    public class JsonResult<T> where T : class
    {
        public JsonResult()
        {
            Errors = new List<DomainNotification>();
            Messages = new List<string>();
        }
        public IEnumerable<DomainNotification> Errors { get; set; }
        public ICollection<string> Messages { get; set; }
        public T Src { get; set; }
        public bool Success { get { return Errors.Count() == 0; } }

    }
}