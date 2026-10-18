// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerKeyValueStoreImportSourceFactory(Action<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.KeyValueStoreTypes.ImportSource>
{

    protected override Humidifier.CloudFront.KeyValueStoreTypes.ImportSource Create()
    {
        var importSourceResult = CreateImportSource();
        factoryAction?.Invoke(importSourceResult);

        return importSourceResult;
    }

    private Humidifier.CloudFront.KeyValueStoreTypes.ImportSource CreateImportSource()
    {
        var importSourceResult = new Humidifier.CloudFront.KeyValueStoreTypes.ImportSource();

        return importSourceResult;
    }

} // End Of Class

public static class InnerKeyValueStoreImportSourceFactoryExtensions
{
}
