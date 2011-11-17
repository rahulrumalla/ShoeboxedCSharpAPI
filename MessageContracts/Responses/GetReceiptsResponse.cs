using System.ServiceModel;
using ShoeboxedService.Domain.XMLResponses;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetReceiptsResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetReceiptsResponse
    {
        [MessageBodyMember(Name = "Receipts")]
        public GetReceiptCallResponse Receipts { get; set; }
    }
}
