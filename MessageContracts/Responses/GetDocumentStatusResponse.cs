using System.ServiceModel;
using ShoeboxedService.Domain.XMLResponses;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetDocumentStatusResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetDocumentStatusResponse
    {
        [MessageBodyMember(Name = "Status")]
        public GetDocumentStatusCallResponse Status { get; set; }
    }
}