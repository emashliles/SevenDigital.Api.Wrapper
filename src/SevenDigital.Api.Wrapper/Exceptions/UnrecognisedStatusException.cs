using System;
using System.Runtime.Serialization;
using SevenDigital.Api.Wrapper.Http;

namespace SevenDigital.Api.Wrapper.Exceptions
{
	[Serializable]
	public class UnrecognisedStatusException : ApiResponseException
	{
		public const string DEFAULT_ERROR_MESSAGE = "API response status must be \"ok\" or \"error\"";

		public UnrecognisedStatusException()
			: base(DEFAULT_ERROR_MESSAGE)
		{
		}

		public UnrecognisedStatusException(Response response)
			: base(DEFAULT_ERROR_MESSAGE, response)
		{
		}

		public UnrecognisedStatusException(string message)
			: base(message)
		{
		}

		protected UnrecognisedStatusException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}