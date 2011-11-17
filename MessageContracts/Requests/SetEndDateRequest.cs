using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "SetEndDate", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class SetEndDateRequest
    {
        [MessageBodyMember(Name = "EndDate")]
        public System.DateTime EndDate { get; set; }
    }
}