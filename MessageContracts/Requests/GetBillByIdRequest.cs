using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetBillByIdRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetBillByIdRequest : BaseRequest
    {
        [MessageBodyMember(Name = "BillId")]
        public string BillId { get; set; }
    }
}
