using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetDocumentStatusRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetDocumentStatusRequest : BaseRequest
    {
        [MessageBodyMember(Name = "InserterId")]
        public string InserterId { get; set; }
    }
}