using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "SetPageRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class SetPageRequest
    {
        [MessageBodyMember(Name = "Page")]
        public int Page { get; set; }
    }
}