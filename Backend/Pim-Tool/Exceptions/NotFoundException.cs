using System;
using System.Globalization;

namespace Pim_Tool.Exceptions {
    [Serializable]
    public class NotFoundException : BusinessException {
        public NotFoundException () : base() {
        }
        public NotFoundException (string message) : base(message) {
        }
        public NotFoundException (string message, params object[] args) : base(string.Format(CultureInfo.CurrentCulture, message, args)) {
        }

        public NotFoundException (string message, string key) : base(message,key) {
        }
    }
}
