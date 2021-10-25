using System;
using System.Net.Http;
using System.Threading.Tasks;
using TestApi.V1.Domain;
using TestApi.V1.Gateway.Interfaces;

namespace TestApi.V1.Gateway
{
    public class AddressGateway : IAddressGateway
    {
        private HttpClient _httpClient;

        public AddressGateway(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Token", "Goes here");
        }


        public async Task<AddressesApiDataResponse> RetrieveAddresses(string postcode)
        {
            var uri = new Uri($"{postcode}");

            var apiRequestCall = await _httpClient.GetAsync(uri);

            var response = await apiRequestCall.Content.ReadAsAsync<AddressesApiDataResponse>();

            return response;
        }
    }
}