using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "CreateuserCategoryCallResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class CreateUserCategoryResponse
    {
        [MessageBodyMember(Name = "CategoryId")]
        public string CategoryId { get; set; }
    }
}
