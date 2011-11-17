using System;
using System.ServiceModel;
using ShoeboxedService.Domain;

namespace ShoeboxedService.MessageContracts
{
    [MessageContract(WrapperName = "UploadDocumentRequest", WrapperNamespace = "urn:shoeboxedservice.servicecontracts/v1.0.0")]
    public class UploadDocumentRequest : BaseRequest
    {
        [MessageBodyMember(Name = "ImageURL")]
        public string ImageURL { get; set; }

        [MessageBodyMember(Name = "CategoryId")]
        public string CategoryId { get; set; }

        [MessageBodyMember(Name = "Note")]
        public string Note { get; set; }

        [MessageBodyMember(Name = "InserterId")]
        public Guid? InserterId { get; set; }

        [MessageBodyMember(Name = "ExportAfterProcessing")]
        public string ExportAfterProcessing { get; set; }
    }
}

