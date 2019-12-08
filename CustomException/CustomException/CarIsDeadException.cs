using System;
namespace CustomException
{   [Serializable]
    public class CarIsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime errorTimeStamp { get; set; }
        public string CauseOfError { get; set; }


        public CarIsDeadException(){}
        public CarIsDeadException(string message) 
            : base(message) { }
        public CarIsDeadException(string message, System.Exception inner)
            : base(message, inner) { }

        protected CarIsDeadException (System.Runtime.Serialization.SerializationInfo info
        , System.Runtime.Serialization.StreamingContext context)
            : base (info, context) { }


        public CarIsDeadException (string message, string cause, DateTime time)
        {
            messageDetails = message;
            CauseOfError = cause;
            errorTimeStamp = time;

        }

        public override string Message
        {
            get { return string.Format("Car Error Message: {0}", messageDetails); }
        }

    }
}
