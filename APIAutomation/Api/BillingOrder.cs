using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIAutomation.Api
{
  
    class BillingOrder
    {
        string baseurl = "http://localhost:8080/BillingOrder";
        public IRestResponse GetAll()
        {
            var client = new RestClient(baseurl)
            //Request post or get
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            //Execution
            IRestResponse response = client.Execute(request);
            return response;
        }
        public IRestResponse Post(string body) {
            var client = new RestClient(baseurl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(body);
            IRestResponse response = client.Execute(request);
            return response;
        }


        public IRestResponse Put(int id, string body)
        {
            var client = new RestClient(baseurl + "/" + id);
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(body);
            IRestResponse response = client.Execute(request);
            return response;
        }

            public IRestResponse Delete(int id)
        {
            var client = new RestClient(baseurl + "/" + id);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            return response;
        }

        public IRestResponse Get(int id)
        {
            var client = new RestClient(baseurl + "/" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}
