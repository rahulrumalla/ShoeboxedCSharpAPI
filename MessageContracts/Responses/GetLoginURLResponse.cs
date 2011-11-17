using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetLoginURLResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetLoginURLResponse
    {
        [MessageBodyMember(Name = "URL")]
        public string URL { get; set;} 
    }
}
