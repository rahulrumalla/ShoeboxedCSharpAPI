using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "SetModifiedSinceRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class SetModifiedSinceRequest
    {
        [MessageBodyMember(Name = "ModifiedSince")]
        public System.DateTime ModifiedSince { get; set; }
    }
}