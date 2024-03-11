using BlazorApp1.Entities;
using BlazorApp1.Interface;
using System.Net.Http.Json;

namespace BlazorApp1.Services
{
    public class RestauranteService : IRestauranteService
    {
        public HttpClient httpClient;

        public RestauranteService(HttpClient client)
        {
            httpClient = client;
        }

        public async Task<List<Restaurante>> findAll()
        {
            List<Restaurante> restaurantes = 
                await httpClient.GetFromJsonAsync<List<Restaurante>>
                    ("http://localhost:8080/restaurante");
            return restaurantes;
        }

        public async Task<Restaurante> findById(int id)
        {
            Restaurante restaurante =
                await httpClient.GetFromJsonAsync<Restaurante>
                    ($"http://localhost:8080/restaurante/{id}");
            return restaurante;
        }

        public async Task<Restaurante> save(Restaurante restaurante)
        {
            var response = await httpClient.PostAsJsonAsync<Restaurante>
                    ("http://localhost:8080/restaurante",restaurante);
            restaurante = await response.Content.ReadFromJsonAsync<Restaurante>();
            return restaurante;
        }

        public async Task<Restaurante> update(Restaurante restaurante)
        {
            var response = await httpClient.PutAsJsonAsync<Restaurante>
                    ($"http://localhost:8080/restaurante/{restaurante.id}", restaurante);
            restaurante = await response.Content.ReadFromJsonAsync<Restaurante>();
            return restaurante;
        }

        public async Task delete(int id)
        {
            await httpClient.DeleteAsync
                    ($"http://localhost:8080/restaurante/{id}");
        }
    }
}
