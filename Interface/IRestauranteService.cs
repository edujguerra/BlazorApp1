using BlazorApp1.Entities;

namespace BlazorApp1.Interface
{
    public interface IRestauranteService
    {
        Task<List<Restaurante>> findAll();
        Task<Restaurante> findById(int id);
        Task<Restaurante> save(Restaurante restaurante);
        Task<Restaurante> update(Restaurante restaurante);
        Task delete(int id);

    }
}
