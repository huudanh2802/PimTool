using System;
using System.Globalization;

namespace Pim_Tool.Exceptions {
    [Serializable]
    public class BusinessException : Exception {
        public string Key { get; set; } = "Message";
        public BusinessException () : base() {
        }
        public BusinessException (string message) : base(message) {
        }
        public BusinessException (string message, params object[] args) : base(string.Format(CultureInfo.CurrentCulture, message, args)) {
        }

        public BusinessException (string message, string key) : base(message) {
            this.Key = key;
        }
    }
}
