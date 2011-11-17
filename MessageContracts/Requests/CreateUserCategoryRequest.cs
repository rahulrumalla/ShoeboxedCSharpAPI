using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "CreateUserCategoryRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class CreateUserCategoryRequest : BaseRequest
    {
        [MessageBodyMember(Name = "Name")]
        public string Name { get; set; }

        [MessageBodyMember(Name = "Description")]
        public string Description { get; set; }
    }
}