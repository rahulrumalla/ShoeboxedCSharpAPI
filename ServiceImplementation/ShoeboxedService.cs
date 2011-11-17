using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using ShoeboxedService.Domain.XMLResponses;
using ShoeboxedService.MessageContracts;
using System.Configuration;

namespace ShoeboxedService.ServiceImplementation
{
    public partial class ShoeboxedService : ShoeboxedServiceBase
    {
        /// <summary>
        /// Returns the contructed URL to Shoeboxed for authentication based on the user provided parameters.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override GetLoginURLResponse GetLoginURL(GetLoginURLRequest request)
        {
            var response = new GetLoginURLResponse();

            try
            {
                if (string.IsNullOrEmpty(request.ApiUserToken))
                    response.URL = null;
                else
                    response.URL = ShoeboxedEndpointURL + "?appname=" + request.AppName + "&appurl=" + request.AppURL +
                                   "&appparams=" + request.AppParams + "&SignIn=" + request.SignIn;
            }
            catch
            {
                throw new Exception("Error in Service.");
            }
            return response;
        }

        /// <summary>
        /// Returns all the saved Receipts
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override GetReceiptsResponse GetReceipts(GetReceiptsRequest request)
        {

            var response = new GetReceiptsResponse();

            try
            {
                var xml = ConstructXMLRequest(request, RequestTypeEnum.GetReceiptCall);
                var responseStream = SendRequest(xml);
                var reader = new StreamReader(responseStream);
                //string a = reader.ReadToEnd();
                response.Receipts = (GetReceiptCallResponse)Deserialize(typeof (GetReceiptCallResponse), reader);
            }
            catch
            {
                throw new Exception("Error in Service.");
            }

            return response;
        }

        /// <summary>
        /// Returns a single receipt associated with the provided identifier
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override GetReceiptbyIdResponse GetReceiptById(GetReceiptByIdRequest request)
        {
            var response = new GetReceiptbyIdResponse();

            try
            {
                var xml = ConstructXMLRequest(request, RequestTypeEnum.GetReceiptInfoCall);
                var responseStream = SendRequest(xml);
                var reader = new StreamReader(responseStream);
                //string a = reader.ReadToEnd();
                response.Receipt = (GetReceiptInfoCallResponse)Deserialize(typeof(GetReceiptInfoCallResponse), reader);
            }
            catch
            {
                throw new Exception("Error in Service.");
            }

            return response;
        }

        /// <summary>
        /// Returns all the saved Bills
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override GetBillsResponse GetBills(GetBillsRequest request)
        {

            var response = new GetBillsResponse();

            try
            {
                var xml = ConstructXMLRequest(request, RequestTypeEnum.GetBillCall);
                var responseStream = SendRequest(xml);
                var reader = new StreamReader(responseStream);
                response.Bills = (GetBillCallResponse)Deserialize(typeof(GetBillCallResponse), reader);
            }
            catch
            {
                throw new Exception("Error in Service.");
            }

            return response;
        }

        /// <summary>
        /// Returns a single Bill associated with the provided identifier
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override GetBillByIdResponse GetBillById(GetBillByIdRequest request)
        {
            var response = new GetBillByIdResponse();

            try
            {
                var xml = ConstructXMLRequest(request, RequestTypeEnum.GetBillInfoCall);
                var responseStream = SendRequest(xml);
                var reader = new StreamReader(responseStream);
                response.Bill = (GetBillInfoCallResponse)Deserialize(typeof(GetBillInfoCallResponse), reader);
            }
            catch
            {
                throw new Exception("Error in Service.");
            }

            return response;
        }

        /// <summary>
        /// Returns all the saved Business Cards
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override GetBusinessCardResponse GetBusinessCards(GetBusinessCardCallRequest request)
        {
            var response = new GetBusinessCardResponse();

            try
            {
                var xml = ConstructXMLRequest(request, RequestTypeEnum.GetBusinessCardCall);
                var responseStream = SendRequest(xml);
                var reader = new StreamReader(responseStream);
                response.BusinessCards = (GetBusinessCardCallResponse)Deserialize(typeof(GetBusinessCardCallResponse), reader);
            }
            catch
            {
                throw new Exception("Error in Service.");
            }

            return response;
        }

        /// <summary>
        /// Returns a single Business Card associated with the provided identifier
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override GetBusinessCardByIdResponse GetBusinessCardById(GetBusinessCardByIdRequest request)
        {
            var response = new GetBusinessCardByIdResponse();

            try
            {
                var xml = ConstructXMLRequest(request, RequestTypeEnum.GetBusinessCardInfoCall);
                var responseStream = SendRequest(xml);
                var reader = new StreamReader(responseStream);
                response.BusinessCard = (GetBusinessCardInfoCallResponse)Deserialize(typeof(GetBusinessCardInfoCallResponse), reader);
            }
            catch
            {
                throw new Exception("Error in Service.");
            }

            return response;
        }

        //Todo:: ERROR on request sent. Because the url attribute is dafault added and is NOT supposed to do so. Figure out a way to delete attribute.
        /// <summary>
        /// Returns all the available categories
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override GetCategoriesResponse GetAllCategories(BaseRequest request)
        {
            var response = new GetCategoriesResponse();

            try
            {
                var xml = ConstructXMLRequest(request, RequestTypeEnum.GetCategoryCall);
                var responseStream = SendRequest(xml);
                var reader = new StreamReader(responseStream);
                string a = reader.ReadToEnd();
                
                //.Categories = (GetCategoryCallResponse)Deserialize(typeof(GetCategoryCallResponse), reader);
            }
            catch
            {
                throw new Exception("Error in Service.");
            }
            return response;
        }

        /// <summary>
        /// Creates a custom specified category.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override CreateUserCategoryResponse CreateUserCategory(CreateUserCategoryRequest request)
        {
            var response = new CreateUserCategoryResponse();

            try
            {
                var xml = ConstructXMLRequest(request, RequestTypeEnum.GetCategoryCall);
                var responseStream = SendRequest(xml);
                var reader = new StreamReader(responseStream);
                response.CategoryId = reader.ReadToEnd();
            }
            catch
            {
                throw new Exception("Error in Service.");
            }
            return response;
        }

        /// <summary>
        /// Returns the status of the document using the provided identifier. Ex:Unkown, Done, Pending etc.,
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override GetDocumentStatusResponse GetDocumentStatus(GetDocumentStatusRequest request)
        {
            var response = new GetDocumentStatusResponse();

            try
            {
                var xml = ConstructXMLRequest(request, RequestTypeEnum.GetDocumentStatusCall);
                var responseStream = SendRequest(xml);
                var reader = new StreamReader(responseStream);
                response.Status = (GetDocumentStatusCallResponse)Deserialize(typeof(GetDocumentStatusCallResponse), reader);
            }
            catch
            {
                throw new Exception("Error in Service.");
            }

            return response;
        }


        private static XmlDocument ConstructXMLRequest(BaseRequest request, RequestTypeEnum requestType)
        {
            var xmlDoc = new XmlDocument();
            try
            {

                xmlDoc.LoadXml("<Request xmlns=\"urn:sbx:apis:SbxBaseComponents\"><RequesterCredentials><ApiUserToken>"
                            + request.ApiUserToken + "</ApiUserToken><SbxUserToken>" + request.SbxUserToken +
                            "</SbxUserToken></RequesterCredentials></Request>");
                xmlDoc.PrependChild(xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null));

                var xmlRequestNode = xmlDoc.GetElementsByTagName("Request").Item(0);
                
                var xmlGetRequestTypeCallNode = xmlDoc.CreateElement(requestType.ToString());
                xmlGetRequestTypeCallNode.SetAttribute("xmlns", "urn:sbx:apis:SbxBaseComponents");
                xmlRequestNode.AppendChild(xmlGetRequestTypeCallNode);

                ConstructXMLCallNode(xmlDoc, request, requestType, xmlGetRequestTypeCallNode);
            }
            catch
            {
                throw new Exception("Error in Service.");
            }

            return xmlDoc;
        }

        private static void ConstructXMLCallNode(XmlDocument xmlDoc, BaseRequest request, RequestTypeEnum requestType,
            XmlElement xmlGetRequestTypeCallNode)
        {
            switch (requestType)
            {
                case RequestTypeEnum.GetReceiptCall:
                    GetReceiptCallXMLRequest(xmlGetRequestTypeCallNode, xmlDoc, (GetReceiptsRequest)request);
                    break;
                case RequestTypeEnum.GetReceiptInfoCall:
                    GetReceiptInfoCallXMLRequest(xmlGetRequestTypeCallNode, xmlDoc, (GetReceiptByIdRequest)request);
                    break;
                case RequestTypeEnum.GetDocumentStatusCall:
                    GetDocumentStatusCallXMLRequest(xmlGetRequestTypeCallNode, xmlDoc, (GetDocumentStatusRequest)request);
                    break;
                case RequestTypeEnum.GetCategoryCall:
                    break;
                case RequestTypeEnum.CreateUserCategoryCall:
                    CreateUsercategoryCallXMLRequest(xmlGetRequestTypeCallNode, xmlDoc, (CreateUserCategoryRequest)request);
                    break;
                case RequestTypeEnum.GetBillCall:
                    GetBillCallXMLRequest(xmlGetRequestTypeCallNode, xmlDoc, (GetBillsRequest)request);
                    break;
                case RequestTypeEnum.GetBillInfoCall:
                    GetBillInfoCallXMLRequest(xmlGetRequestTypeCallNode, xmlDoc, (GetBillByIdRequest)request);
                    break;
                case RequestTypeEnum.GetLoginCall:
                    break;
                case RequestTypeEnum.GetBusinessCardCall:
                    GetBusinessCardCallXMLRequest(xmlGetRequestTypeCallNode, xmlDoc, (GetBusinessCardCallRequest)request);
                    break;
                case RequestTypeEnum.GetBusinessCardInfoCall:
                    GetBusinessCardInfoCallXMLRequest(xmlGetRequestTypeCallNode, xmlDoc, (GetBusinessCardByIdRequest)request);
                    break;
                default:
                    break;
            }
        }

        private static void GetLoginCallXMLRequest(XmlNode xmlGetLoginCallNode, XmlDocument xmlDoc, GetLoginCallRequest request)
        {

        }

        private static void GetReceiptCallXMLRequest(XmlNode xmlGetReceiptCallNode, XmlDocument xmlDoc, GetReceiptsRequest request)
        {
            var receiptFilterNode = xmlDoc.CreateElement("ReceiptFilter");
            xmlGetReceiptCallNode.AppendChild(receiptFilterNode);

            var resultsNode = xmlDoc.CreateElement("Results");
            resultsNode.InnerText = request.Results.ToString();
            receiptFilterNode.AppendChild(resultsNode);

            var pageNumberNode = xmlDoc.CreateElement("PageNo");
            pageNumberNode.InnerText = request.PageNumber.ToString();
            receiptFilterNode.AppendChild(pageNumberNode);

            if (!string.IsNullOrEmpty(request.ModifiedSince.ToString()))
            {
                var modifiedSinceNode = xmlDoc.CreateElement("ModifiedSince");
                modifiedSinceNode.InnerText = request.ModifiedSince.ToString();
                receiptFilterNode.AppendChild(modifiedSinceNode);
            }

            if (!string.IsNullOrEmpty(request.CategoryId))
            {
                var categoryIdNode = xmlDoc.CreateElement("Category");
                categoryIdNode.InnerText = request.CategoryId;
                receiptFilterNode.AppendChild(categoryIdNode);
            }
        }

        private static void GetReceiptInfoCallXMLRequest(XmlNode xmlGetReceiptInfoCallNode, XmlDocument xmlDoc, GetReceiptByIdRequest request)
        {
            var receiptFilterNode = xmlDoc.CreateElement("ReceiptFilter");
            xmlGetReceiptInfoCallNode.AppendChild(receiptFilterNode);

            var receiptIdNode = xmlDoc.CreateElement("ReceiptId");
            receiptIdNode.InnerText = request.ReceiptId;
            receiptFilterNode.AppendChild(receiptIdNode);
        }

        private static void GetDocumentStatusCallXMLRequest(XmlNode xmlDocumentStatusCallNode, XmlDocument xmlDoc, GetDocumentStatusRequest request)
        {
            var InserterIdNode = xmlDoc.CreateElement("InserterId");
            InserterIdNode.InnerText = request.InserterId;
            xmlDocumentStatusCallNode.AppendChild(InserterIdNode);
        }

        private static void CreateUsercategoryCallXMLRequest(XmlNode CreateUserCategoryCallNode, XmlDocument xmlDoc, 
            CreateUserCategoryRequest request)
        {
            var NameNode = xmlDoc.CreateElement("Name");
            NameNode.InnerText = request.Name;
            CreateUserCategoryCallNode.AppendChild(NameNode);

            var DescriptionNode = xmlDoc.CreateElement("Description");
            DescriptionNode.InnerText = request.Description;
            CreateUserCategoryCallNode.AppendChild(DescriptionNode);
        }

        private static void GetBillCallXMLRequest(XmlNode xmlGetBillCallNode, XmlDocument xmlDoc, GetBillsRequest request)
        {
            var billFilterNode = xmlDoc.CreateElement("BillFilter");
            xmlGetBillCallNode.AppendChild(billFilterNode);

            var resultsNode = xmlDoc.CreateElement("Results");
            resultsNode.InnerText = request.Results.ToString();
            billFilterNode.AppendChild(resultsNode);

            var pageNumberNode = xmlDoc.CreateElement("PageNo");
            pageNumberNode.InnerText = request.PageNumber.ToString();
            billFilterNode.AppendChild(pageNumberNode);

            if (!string.IsNullOrEmpty(request.ModifiedSince.ToString()))
            {
                var modifiedSinceNode = xmlDoc.CreateElement("ModifiedSince");
                modifiedSinceNode.InnerText = request.ModifiedSince.ToString();
                billFilterNode.AppendChild(modifiedSinceNode);
            }
        }

        private static void GetBillInfoCallXMLRequest(XmlNode xmlGetBillInfoCallNode, XmlDocument xmlDoc, GetBillByIdRequest request)
        {
            var receiptFilterNode = xmlDoc.CreateElement("BillFilter");
            xmlGetBillInfoCallNode.AppendChild(receiptFilterNode);

            var billIdNode = xmlDoc.CreateElement("BillId");
            billIdNode.InnerText = request.BillId;
            receiptFilterNode.AppendChild(billIdNode);
        }

        private static void GetBusinessCardCallXMLRequest(XmlNode xmlGetBusinessCardCallNode, XmlDocument xmlDoc,
            GetBusinessCardCallRequest request)
        {
            var businessCardFilterNode = xmlDoc.CreateElement("BusinessCardFilter");
            xmlGetBusinessCardCallNode.AppendChild(businessCardFilterNode);

            var resultsNode = xmlDoc.CreateElement("Results");
            resultsNode.InnerText = request.Results.ToString();
            businessCardFilterNode.AppendChild(resultsNode);

            var pageNumberNode = xmlDoc.CreateElement("PageNo");
            pageNumberNode.InnerText = request.PageNumber.ToString();
            businessCardFilterNode.AppendChild(pageNumberNode);

            if (!string.IsNullOrEmpty(request.ModifiedSince.ToString()))
            {
                var modifiedSinceNode = xmlDoc.CreateElement("ModifiedSince");
                modifiedSinceNode.InnerText = request.ModifiedSince.ToString();
                businessCardFilterNode.AppendChild(modifiedSinceNode);
            }
        }

        private static void GetBusinessCardInfoCallXMLRequest(XmlNode xmlGetBusinessCardInfoCallNode, XmlDocument xmlDoc,
            GetBusinessCardByIdRequest request)
        {
            var businessCardFilterNode = xmlDoc.CreateElement("BusinessCardFilter");
            xmlGetBusinessCardInfoCallNode.AppendChild(businessCardFilterNode);

            var businessCardIdNode = xmlDoc.CreateElement("BusinessCardId");
            businessCardIdNode.InnerText = request.BusinessCardId;
            businessCardFilterNode.AppendChild(businessCardIdNode);
        }

        /// <summary>
        /// Uploads a document. Ex: Receipt, Bill, Business card etc. Only supports single image to be added as of now.
        /// </summary>
        /// <param name="request"></param>
        public override void UploadDocument(UploadDocumentRequest request)
        {
            var boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
            const string formDataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
            const string headerTemplate =
                "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";

            var httpWebRequest = (HttpWebRequest) WebRequest.Create(ShoeboxedUploadURL);
            httpWebRequest.ContentType = "multipart/form-data; boundary=" + boundary;
            httpWebRequest.Method = "POST";
            httpWebRequest.KeepAlive = true;

            var boundaryBytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            var requestStream = httpWebRequest.GetRequestStream();

            requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
            var apiUserToken = string.Format(formDataTemplate, "apiUserToken", request.ApiUserToken);
            var apiUserTokenBytes = Encoding.UTF8.GetBytes(apiUserToken);
            requestStream.Write(apiUserTokenBytes, 0, apiUserTokenBytes.Length);

            requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
            var sbxUserToken = string.Format(formDataTemplate, "sbxUserToken", request.SbxUserToken);
            var sbxUserTokenBytes = Encoding.UTF8.GetBytes(sbxUserToken);
            requestStream.Write(sbxUserTokenBytes, 0, sbxUserTokenBytes.Length);

            requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
            var imageType = string.Format(formDataTemplate, "imageType", "receipt");
            var imageTypeBytes = Encoding.UTF8.GetBytes(imageType);
            requestStream.Write(imageTypeBytes, 0, imageTypeBytes.Length);

            if (!string.IsNullOrEmpty(request.Note))
            {
                requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                var note = string.Format(formDataTemplate, "note", request.Note);
                var noteBytes = Encoding.UTF8.GetBytes(note);
                requestStream.Write(noteBytes, 0, noteBytes.Length);
            }

            if (request.InserterId != null)
            {
                requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                var inserterId = string.Format(formDataTemplate, "inserterId", request.InserterId);
                var inserterIdBytes = Encoding.UTF8.GetBytes(inserterId);
                requestStream.Write(inserterIdBytes, 0, inserterIdBytes.Length);
            }

            if (request.CategoryId != null)
            {
                requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                var categories = string.Format(formDataTemplate, "categories", request.CategoryId);
                var categoriesBytes = Encoding.UTF8.GetBytes(categories);
                requestStream.Write(categoriesBytes, 0, categoriesBytes.Length);
            }

            if (!string.IsNullOrEmpty(request.ExportAfterProcessing))
            {
                requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                var exportAfterProcessing = string.Format(formDataTemplate, "exportAfterProcessing", request.ExportAfterProcessing);
                var exportAfterProcessingBytes = Encoding.UTF8.GetBytes(exportAfterProcessing);
                requestStream.Write(exportAfterProcessingBytes, 0, exportAfterProcessingBytes.Length);
            }

            requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);

            var header = string.Format(headerTemplate, "images", request.ImageURL.Substring(request.ImageURL.IndexOf("Capture")), "image/jpeg");
            var headerBytes = Encoding.UTF8.GetBytes(header);
            requestStream.Write(headerBytes, 0, headerBytes.Length);

            using (var fileStream = new FileStream(request.ImageURL, FileMode.Open, FileAccess.Read))
            {
                var buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    requestStream.Write(buffer, 0, bytesRead);
                }
            }

            var trailer = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
            requestStream.Write(trailer, 0, trailer.Length);
            requestStream.Close();
        }

        private static Stream SendRequest(XmlDocument xml)
        {
            try
            {
                var UrlEncodedXML = HttpUtility.UrlEncode(xml.OuterXml);
                
                var data = new UTF8Encoding().GetBytes(xml.OuterXml);

                var request = WebRequest.Create(ShoeboxedEndpointURL + "?xml=" + UrlEncodedXML);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                var requestStream = request.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                requestStream.Close();

                var response = request.GetResponse();

                if (response != null)
                    return response.GetResponseStream();
            }
            catch
            {
                throw new Exception("Error in Service.");
            }

            return null;
        }

        private static string ShoeboxedEndpointURL
        {
            get { return ConfigurationSettings.AppSettings["SHOEBOXED_ENDPOINT_URL"]; }
        }

        private static string ShoeboxedUploadURL
        {
            get { return ConfigurationSettings.AppSettings["SHOEBOXED_UPLOAD_URL"]; }
        }


        private static object Deserialize(Type responseType, StreamReader responseStream)
        {
            return new XmlSerializer(responseType).Deserialize(responseStream);
        }

    }
}
