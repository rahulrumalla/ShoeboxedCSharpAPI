using System.ServiceModel;
using ShoeboxedService.Domain.XMLResponses;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetBillByIdResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetBillByIdResponse
    {
        [MessageBodyMember(Name = "Bill")]
        public GetBillInfoCallResponse Bill { get; set; }
    }
}