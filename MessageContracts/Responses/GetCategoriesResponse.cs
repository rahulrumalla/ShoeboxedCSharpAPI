using ShoeboxedService.Domain.XMLResponses;
using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetCategoriesResponse", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetCategoriesResponse
    {
        [MessageBodyMember(Name = "Categories")]
        public GetCategoryCallResponse Categories { get; set; }
    }
}
