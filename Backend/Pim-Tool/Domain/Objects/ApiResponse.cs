namespace Pim_Tool.Controllers {
    public class ApiResponse<T> {
        public T Data { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public object Error { get; set; }
        public static ApiResponse<T> Fail (string errorMessage) {
            return new ApiResponse<T> {
                Succeeded = false,
                Message = errorMessage
            };
        }
        public static ApiResponse<T> Fail (string errorMessage,string key) {
            var name = $"{key}";
            return new ApiResponse<T> {
                Succeeded = false,
                Error = new {
                   Field = key,
                   Message=errorMessage
                },
            };
        }
        public static ApiResponse<T> Success (T data) {
            return new ApiResponse<T> { Succeeded = true, Data = data };
        }
    }
}
