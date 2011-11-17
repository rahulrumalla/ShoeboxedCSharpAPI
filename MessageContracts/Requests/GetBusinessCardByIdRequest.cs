using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetBusinessCardInfoRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetBusinessCardByIdRequest : BaseRequest
    {
        [MessageBodyMember(Name = "BusinessCardId")]
        public string BusinessCardId { get; set; }
    }
}
