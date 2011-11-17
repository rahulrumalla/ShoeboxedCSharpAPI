
using System.ServiceModel;
using ShoeboxedService.Domain.XMLResponses;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetBusinessCardByIdResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetBusinessCardByIdResponse
    {
        [MessageBodyMember(Name = "BusinessCard")]
        public GetBusinessCardInfoCallResponse BusinessCard { get; set; }
    }
}