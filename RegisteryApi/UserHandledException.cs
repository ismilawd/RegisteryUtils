using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteryApi
{

    [Serializable]
    public class UserHandledException : Exception
    {
        public UserHandledException() { }
        public UserHandledException(string message) : base(message) { }
        public UserHandledException(string message, Exception inner) : base(message, inner) { }
        protected UserHandledException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
