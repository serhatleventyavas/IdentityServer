using System.Collections.Generic;
using IdentityServer4.Models;

namespace AuthServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("resource_api1")
                {
                    Scopes = { "api1.read", "api1.write", "api1.put", "api1.delete" }
                },
                new ApiResource("resource_api2")
                {
                    Scopes = { "api2.read", "api2.write", "api2.put", "api2.delete" }
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("api1.read", "Api1 için okuma izni"),
                new ApiScope("api1.write", "Api1 için yazma izni"),
                new ApiScope("api1.put", "Api1 için güncelleme izni"),
                new ApiScope("api1.delete", "Api1 için silme izni"),
                new ApiScope("api2.read", "Api2 için okuma izni"),
                new ApiScope("api2.write", "Api2 için yazma izni"),
                new ApiScope("api2.put", "Api2 için güncelleme izni"),
                new ApiScope("api2.delete", "Api2 için silme izni")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client1",
                    ClientName = "Client 1 web uygulaması",
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = new List<string>
                    {
                        "api1.read", "api1.write", "api2.read", "api2.write"
                    }
                },
                new Client
                {
                    ClientId = "client2",
                    ClientName = "client 2 web uygulaması",
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = new List<string>
                    {
                        "api1.read", "api1.write", "api2.read", "api2.write"
                    }
                }
            };
        }
    }
}