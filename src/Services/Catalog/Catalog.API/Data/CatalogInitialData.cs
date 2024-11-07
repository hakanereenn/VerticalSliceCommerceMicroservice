using Bogus;
using Marten.Schema;
using NetTopologySuite.IO;

namespace Catalog.API.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {

        using var session = store.LightweightSession();
        if (await session.Query<Product>().AnyAsync())
            return;

        ProductFaker _productFaker = new ProductFaker();
        session.Store<Product>(_productFaker.GenerateProductList(25));
        await session.SaveChangesAsync();
    }

    private class ProductFaker
    {
        private readonly Faker<Product> _faker;

        public ProductFaker()
        {
            _faker = new Faker<Product>()
                .RuleFor(p => p.Id, f => Guid.NewGuid())
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Price, (f, p) => f.Random.Decimal(10, 1000))
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.Category, f => f.Commerce.Categories(f.Random.Number(1, 4)).ToList());
        }

        public Product GenerateProduct()
        {
            return _faker.Generate();
        }

        public List<Product> GenerateProductList(int count)
        {
            var products = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                products.Add(GenerateProduct());
            }

            return products;
        }
    }

}