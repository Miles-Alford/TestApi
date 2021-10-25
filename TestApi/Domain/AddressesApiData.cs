
using System.Collections.Generic;

namespace TestApi.V1.Domain
{
    public class AddressesApiDataResponse
    {
        public AddressesApiData Data { get; set; }
    }
    public class AddressesApiData
    {
        public List<Address> Address { get; set; }
    }
}