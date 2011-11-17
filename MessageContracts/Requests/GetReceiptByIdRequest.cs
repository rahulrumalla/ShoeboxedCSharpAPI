using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetReceiptByIdRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetReceiptByIdRequest : BaseRequest
    {
        [MessageBodyMember(Name = "ReceiptId")]
        public string ReceiptId { get; set; }
    }
}
