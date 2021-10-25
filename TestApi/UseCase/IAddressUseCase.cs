using TestApi.V1.Domain;

namespace TestApi.V1.UseCase.Interfaces
{
    public interface IAddressUseCase
    {
        AddressesApiDataResponse ExecuteGetAddresses(string postcode);
    }
}