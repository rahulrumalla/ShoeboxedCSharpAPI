using System.ServiceModel;
using ShoeboxedService.ServiceContracts;
using ShoeboxedService.MessageContracts;

namespace ShoeboxedService.ServiceImplementation
{
    [ServiceBehavior(Name="ShoeboxedService", Namespace="urn:shoeboxedservice.servicecontracts/v1.0.0",
        InstanceContextMode=InstanceContextMode.PerCall,ConcurrencyMode=ConcurrencyMode.Single)]
    public abstract class ShoeboxedServiceBase : IShoeboxedServiceContract 
    {

        #region IShoeboxedServiceContract Members

        //public virtual void SetUserToken(SetUserTokenRequest request)
        //{
        //}

        public virtual GetLoginURLResponse GetLoginURL(GetLoginURLRequest request)
        {
            return null;
        }

        public virtual GetReceiptsResponse GetReceipts(GetReceiptsRequest request)
        {
            return null;
        }

        public virtual GetReceiptbyIdResponse GetReceiptById(GetReceiptByIdRequest request)
        {
            return null;
        }

        public virtual GetBillsResponse GetBills(GetBillsRequest request)
        {
            return null;
        }

        public virtual GetBillByIdResponse GetBillById(GetBillByIdRequest request)
        {
            return null;
        }

        public virtual GetCategoriesResponse GetAllCategories(BaseRequest request)
        {
            return null;
        }

        public virtual void UploadDocument(UploadDocumentRequest request)
        {
            
        }

        //public virtual void SetCount(SetCountRequest request)
        //{
        //}

        //public virtual void SetPage(SetPageRequest request)
        //{
        //}

        //public virtual void SetModifiedSince(SetModifiedSinceRequest request)
        //{
        //}

        //public virtual void SetStartDate(SetStartDateRequest request)
        //{
        //}

        //public virtual void SetEndDate(SetEndDateRequest request)
        //{
        //}

        //public virtual void SetUseSellDate(SetUseSellDate request)
        //{
        //}

        //public virtual void SetCategoryId(SetCategoryId request)
        //{
        //}

        public virtual GetBusinessCardResponse GetBusinessCards(GetBusinessCardCallRequest request)
        {
            return null;
        }

        public virtual GetBusinessCardByIdResponse GetBusinessCardById(GetBusinessCardByIdRequest request)
        {
            return null;
        }

        public virtual CreateUserCategoryResponse CreateUserCategory(CreateUserCategoryRequest request)
        {
            return null;
        }

        public virtual GetDocumentStatusResponse GetDocumentStatus(GetDocumentStatusRequest request)
        {
            return null;
        }

        #endregion
    }
}
