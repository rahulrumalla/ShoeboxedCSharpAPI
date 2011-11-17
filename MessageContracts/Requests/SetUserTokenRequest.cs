using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "SetUserTokenRequest", WrapperNamespace="urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class SetUserTokenRequest
    {
        [MessageBodyMember(Name = "Token")]
        public string Token { get; set; }
    }
}
