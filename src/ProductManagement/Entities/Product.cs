using ProductManagement.ValueObjects;
using Shared.ValueObjects;

namespace ProductManagement.Entities;
internal class Product
{
    internal ProductId Id { get; set; }
    internal ProductName Name { get; set; }
    internal ProductDescription Description { get; set; }
    internal CategoryId CategoryId { get; set; }
}
