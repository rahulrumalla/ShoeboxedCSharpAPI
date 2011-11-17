using System;
using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetBillsRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetBillsRequest : BaseRequest
    {
        [MessageBodyMember(Name = "Results")]
        public int Results { get; set; }

        [MessageBodyMember(Name = "PageNumber")]
        public int PageNumber { get; set; }

        [MessageBodyMember(Name = "ModifiedSince")]
        public DateTime? ModifiedSince { get; set; }
    }
}

