using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "SetCountRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class SetCountRequest
    {
        [MessageBodyMember(Name = "Count")]
        public int Count { get; set; }
    }
}
