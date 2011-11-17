using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "SetDateStart", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class SetStartDateRequest
    {
        [MessageBodyMember(Name = "StartDate")]
        public System.DateTime StartDate { get; set; }
    }
}