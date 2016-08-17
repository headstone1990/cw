namespace CW.Backend.UserExceptions
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class PlayerAlreadyExistException : ApplicationException
    {
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        public PlayerAlreadyExistException()
        {
        }

        public PlayerAlreadyExistException(string message)
            : base(message)
        {
        }

        public PlayerAlreadyExistException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected PlayerAlreadyExistException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}