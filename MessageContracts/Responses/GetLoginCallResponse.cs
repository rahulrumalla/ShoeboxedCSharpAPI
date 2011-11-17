using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetLoginCallResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetLoginCallResponse
    {
        [MessageBodyMember(Name = "SbxToken")]
        public string SbxToken { get; set; }
    }
}
