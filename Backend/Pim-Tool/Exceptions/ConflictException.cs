using System;
using System.Globalization;

namespace Pim_Tool.Exceptions {
    public class ConflictException:BusinessException {
        public object NewObject { get; set; }
        public ConflictException () : base() {
        }
        public ConflictException (string message) : base(message) {
        }
        public ConflictException (string message, params object[] args) : base(string.Format(CultureInfo.CurrentCulture, message, args)) {
        }

        public ConflictException (string message, string key) : base(message,key) {
        }
    }
}
