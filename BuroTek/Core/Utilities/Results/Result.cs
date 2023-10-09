namespace BuroTek.Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool succcess, string message):this(succcess)
        {
            Message = message;
        }
        public Result(bool succcess)
        {
            IsSuccess = succcess;
        }

        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
