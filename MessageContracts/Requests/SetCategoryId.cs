
using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "SetCategoryId", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class SetCategoryId
    {
        [MessageBodyMember(Name = "CategoryId")]
        public int CategoryId { get; set; }
    }
}