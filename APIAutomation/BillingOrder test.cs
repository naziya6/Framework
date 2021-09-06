using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using RestSharp;

namespace APIAutomation
{
    class Billingorder_test
    {
        string jsonBody = "{\"addressLine1\":\"address1\",\"addressLine2\":\"address2\",\"city\":\"london\",\"comment\":\"test comment\"," +
            "\"email\":\"naziya6@gmail.com\",\"firstName\":\"naziya\",\"itemNumber\":0,\"lastName\":\"abdul\",\"phone\":\"1234567891\",\"state\":\"AL\",\"zipCode\":\"121212\"}";
        string baseurl = "http://localhost:8080/BillingOrder";

        [Test]
        public void CreateBillingOrder()
        {
            IRestResponse response = Post(jsonBody);

            //printing
            TestContext.WriteLine(response.StatusCode);
            TestContext.WriteLine(response.Content);
        }



        public IRestResponse Post(string body)
        {
            var client = new RestClient(baseurl);

            //Request post or get
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(body);

            //Execution
            IRestResponse response = client.Execute(request);
            return response;


        }



    }
}




