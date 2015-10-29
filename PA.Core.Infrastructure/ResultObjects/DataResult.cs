namespace PA.Core.Infrastructure.ResultObjects
{
    public class DataResult<T> : BaseResult
    {
        public T Data { get; set; }
    }
}
