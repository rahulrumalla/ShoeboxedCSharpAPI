using System;
using System.ServiceModel;
using System.Net.Security;
using ShoeboxedService.MessageContracts;

namespace ShoeboxedService.ServiceContracts
{
    [ServiceContract(Namespace = "urn:shoeboxedservice.servicecontracts/v1.0.0", Name = "ShoeboxedService",
        SessionMode = SessionMode.NotAllowed, ProtectionLevel = ProtectionLevel.None)]
    public partial interface IShoeboxedServiceContract
    {
        //[OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
        //    Action = "SetUserToken", ProtectionLevel = ProtectionLevel.None)]
        //void SetUserToken(SetUserTokenRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "GetLoginURL", ProtectionLevel = ProtectionLevel.None)]
        GetLoginURLResponse GetLoginURL(GetLoginURLRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "GetReceipts", ProtectionLevel = ProtectionLevel.None)]
        GetReceiptsResponse GetReceipts(GetReceiptsRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "GetReceiptById", ProtectionLevel = ProtectionLevel.None)]
        GetReceiptbyIdResponse GetReceiptById(GetReceiptByIdRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "GetBills", ProtectionLevel = ProtectionLevel.None)]
        GetBillsResponse GetBills(GetBillsRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "GetBillById", ProtectionLevel = ProtectionLevel.None)]
        GetBillByIdResponse GetBillById(GetBillByIdRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "GetBusinessCards", ProtectionLevel = ProtectionLevel.None)]
        GetBusinessCardResponse GetBusinessCards(GetBusinessCardCallRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "GetBusinessCardById", ProtectionLevel = ProtectionLevel.None)]
        GetBusinessCardByIdResponse GetBusinessCardById(GetBusinessCardByIdRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "GetAllCategories", ProtectionLevel = ProtectionLevel.None)]
        GetCategoriesResponse GetAllCategories(BaseRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "GetDocumentStatus", ProtectionLevel = ProtectionLevel.None)]
        GetDocumentStatusResponse GetDocumentStatus(GetDocumentStatusRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "UploadDocument", ProtectionLevel = ProtectionLevel.None)]
        void UploadDocument(UploadDocumentRequest request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
            Action = "CreateUserCategory", ProtectionLevel = ProtectionLevel.None)]
        CreateUserCategoryResponse CreateUserCategory(CreateUserCategoryRequest request);

        //[OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
        //    Action = "SetCount", ProtectionLevel = ProtectionLevel.None)]
        //void SetCount(SetCountRequest request);

        //[OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
        //    Action = "SetPage", ProtectionLevel = ProtectionLevel.None)]
        //void SetPage(SetPageRequest request);

        //[OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
        //    Action = "SetModifiedSince", ProtectionLevel = ProtectionLevel.None)]
        //void SetModifiedSince(SetModifiedSinceRequest request);

        //[OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
        //    Action = "SetStartDate", ProtectionLevel = ProtectionLevel.None)]
        //void SetStartDate(SetStartDateRequest request);

        //[OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
        //    Action = "SetEndDate", ProtectionLevel = ProtectionLevel.None)]
        //void SetEndDate(SetEndDateRequest request);

        //[OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
        //    Action = "SetUseSellDate", ProtectionLevel = ProtectionLevel.None)]
        //void SetUseSellDate(SetUseSellDate request);

        //[OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false,
        //    Action = "SetCategoryId", ProtectionLevel = ProtectionLevel.None)]
        //void SetCategoryId(SetCategoryId request);
    }
}
