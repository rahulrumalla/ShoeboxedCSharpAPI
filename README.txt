SHOEBOXED API C#
================

This document explains how this service can be used to talk to the Shoeboxed endpoint. Please note this wrapper is 
basically a WCF Service. All the service and message contracts are descibed and defined already.

This service is limited to catering the following functionalities as of now. Additions will be made in time.

1. Checking the status of a document.
2. Uploading document(s).
3. Reading the already uploaded documents on a profile.

NOTE: Please go this address to find out the authentication process. http://developer.shoeboxed.com/authentication
For every request you make to the endpoint, you are required to provide a ApiUserToken and a SbxUserToken. 

USAGE
=====

There 2 ways for the initial setup. 

1. Import and localize the projects
2. Run the .msi and install

Either way, make a 'Service Reference' into your project from which you wish to make the calls, then use it like follows.,

GetReceiptCall
--------------

        static void Main(string[] args)
        {
            var proxy = new ShoeboxedServiceClient();
            
            var receiptsResponse = proxy.GetReceipts("ApiUserToken", "", null, 1, 50, 
                "SbxUserToken");
        }

The response entities(deserialized xml responses) were constructed from the raw xml responses itself not the ACTUAL .xsd
file and hence are not very elegantly structured. But here's how one can use to iterate through the responses

        foreach (var receipt in receiptsResponse.itemsField[0].receiptField)
        {
            //your code here
        }
        

UPLOAD A DOCUMENT
=================

        proxy.UploadDocument("ApiUserToken", "9121023","DEFAULT",
                                @"C:\Users\username\Desktop\Capture.jpeg"
                                , System.Guid.NewGuid(), "This is a test document", "SbxUserToken");

Please refer to the actual documentation available at http://developer.shoeboxed.com/general#uploadcall 
for what the parameters are.

