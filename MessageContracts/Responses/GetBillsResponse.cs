using System.ServiceModel;
using ShoeboxedService.Domain.XMLResponses;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetBillsResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetBillsResponse
    {
        [MessageBodyMember(Name = "Bills")]
        public GetBillCallResponse Bills { get; set; }
    }
}

