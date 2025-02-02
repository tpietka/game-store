namespace ProductManagement.ValueObjects;

internal record ProductDescription(string Title, string Description, string? AdditionalInformation = null)
{
}