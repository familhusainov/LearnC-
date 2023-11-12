namespace LearnApi.Errors
{
    public class AdminError:SystemException
    {
        public AdminError()

        {

        }

        public AdminError(string? message)
            : base(message)
        {

        }

        public AdminError(string? message, Exception? innerException)
            : base(message, innerException)
        {

        }
    }
}
