using EnsaioAPI.Context;
using EnsaioAPI.ViewModels;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace EnsaioAppTests
{
    public class EnsaioTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        private HttpClient _client;
        private readonly EnsaioDbContext _context;

        public EnsaioTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();

            using (var scoped = _factory.Services.CreateScope())
            {
                var serviceProvider = scoped.ServiceProvider;
                _context = serviceProvider.GetRequiredService<EnsaioDbContext>();

                foreach (var item in Enumerable.Range(0,10))
                {
                    var client = new EnsaioAPI.Models.Cliente()
                    {
                        Cnpj = $"57.094.179/000{item}-00",
                        Nome = $"Mackenzie {item}"
                    };
                    _context.Cliente.Add(client);
                }

                _context.SaveChanges();
            }
        }

        [Fact(DisplayName = "Deve cadastrar empresa com sucesso")]
        public async Task CadastrarEmpresa()
        {
            var response = await _client.PostAsync("/empresa",
                new StringContent(
                    System.Text.Json.JsonSerializer.Serialize(
                        new ClienteViewModel()
                        {
                            Cnpj = "11.702.708/0001-00",
                            Nome = "STAR LINK"
                        }),
                    System.Text.Encoding.UTF8,
                    mediaType: "application/json"));
            
            Assert.True(response.StatusCode == System.Net.HttpStatusCode.OK);
        }

        [Fact(DisplayName = "Deve deletar empresa com sucesso")]
        public async Task DeletarEmpresa()
        {
            var response = await _client.DeleteAsync("/empresa/1");
            Assert.True(response.StatusCode == System.Net.HttpStatusCode.OK);
        }

        [Fact(DisplayName = "Deve consultar empresa com sucesso")]
        public async Task ConsultarEmpresa()
        {
            var response = await _client.GetAsync("/empresa/5");
            Assert.True(response.StatusCode == System.Net.HttpStatusCode.OK);
        }
    }
}