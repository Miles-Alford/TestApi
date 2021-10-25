using System.Threading.Tasks;
using TestApi.V1.Domain;

namespace TestApi.V1.Gateway.Interfaces
{
    public interface IAddressGateway
    {
        Task<AddressesApiDataResponse> RetrieveAddresses(string postcode);
    }
}