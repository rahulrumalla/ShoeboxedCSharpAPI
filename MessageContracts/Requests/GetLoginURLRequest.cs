using System.ServiceModel;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "GetLoginURLRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class GetLoginURLRequest : BaseRequest
    {
        [MessageBodyMember(Name = "AppName")]
        public string AppName { get; set; }

        [MessageBodyMember(Name = "AppURL")]
        public string AppURL { get; set; }

        [MessageBodyMember(Name = "AppParams")]
        public string AppParams { get; set; }

        [MessageBodyMember(Name = "SignIn")]
        public short SignIn { get; set; }
    }
}
