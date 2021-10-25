using TestApi.V1.Domain;
using TestApi.V1.Gateway.Interfaces;
using TestApi.V1.UseCase.Interfaces;

namespace TestApi.V1.UseCase
{
    public class AddressUseCase : IAddressUseCase
    {
        private IAddressGateway _addressGateway;

        public AddressUseCase(IAddressGateway addressGateway)
        {
            _addressGateway = addressGateway;
        }

        public AddressesApiDataResponse ExecuteGetAddresses(string postcode)
        {
            var addresses = _addressGateway.RetrieveAddresses(postcode);
            return addresses.Result;
        }
    }
}