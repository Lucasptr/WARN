using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warn.Api.Models
{
    public class JsonResult<T> where T : class
    {
        public JsonResult()
        {
            Errors = new List<string>();
            Messages = new List<string>();
        }
        public ICollection<string> Errors { get; set; }
        public ICollection<string> Messages { get; set; }
        public T Src { get; set; }
        public bool Success { get { return Errors.Count() == 0; } }

    }
}