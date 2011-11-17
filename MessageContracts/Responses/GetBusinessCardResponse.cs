using System.ServiceModel;
using ShoeboxedService.Domain.XMLResponses;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetBusinessCardResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetBusinessCardResponse
    {
        [MessageBodyMember(Name = "BusinessCards")]
        public GetBusinessCardCallResponse BusinessCards { get; set; }
    }
}
