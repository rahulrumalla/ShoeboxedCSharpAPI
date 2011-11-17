using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "SetUseSellDate", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class SetUseSellDate
    {
        [MessageBodyMember(Name = "UseSellDate")]
        public bool UseSellDate { get; set; }
    }
}