using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "BaseRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class BaseRequest
    {
        [MessageBodyMember(Name = "ApiUserToken")]
        public string ApiUserToken { get; set; }

        [MessageBodyMember(Name = "SbxUserToken")]
        public string SbxUserToken { get; set; }
    }
}
