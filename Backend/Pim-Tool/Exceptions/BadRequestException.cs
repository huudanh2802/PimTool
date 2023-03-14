using System;
using System.Globalization;

namespace Pim_Tool.Exceptions {
    [Serializable]
    public class BadRequestException : BusinessException {
        public BadRequestException () : base() {
        }
        public BadRequestException (string message) : base(message) {
        }
        public BadRequestException (string message, params object[] args) : base(string.Format(CultureInfo.CurrentCulture, message, args)) {
        }

        public BadRequestException (string message, string key) : base(message,key) {
        }
    }
}
