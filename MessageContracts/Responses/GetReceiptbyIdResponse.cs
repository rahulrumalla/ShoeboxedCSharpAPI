using System.ServiceModel;
using ShoeboxedService.Domain.XMLResponses;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetReceiptbyIdResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetReceiptbyIdResponse
    {
        [MessageBodyMember(Name = "Receipt")]
        public GetReceiptInfoCallResponse Receipt { get; set; }
    }
}