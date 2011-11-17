using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetLoginCallRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetLoginCallRequest:BaseRequest
    {
        [MessageBodyMember(Name = "UserName")]
        public string UserName { get; set; }

        [MessageBodyMember(Name = "Password")]
        public string Password { get; set; }
    }
}
