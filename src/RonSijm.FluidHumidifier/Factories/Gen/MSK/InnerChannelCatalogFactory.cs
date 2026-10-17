// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelCatalogFactory(Action<Humidifier.MSK.ChannelTypes.Catalog> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.Catalog>
{

    protected override Humidifier.MSK.ChannelTypes.Catalog Create()
    {
        var catalogResult = CreateCatalog();
        factoryAction?.Invoke(catalogResult);

        return catalogResult;
    }

    private Humidifier.MSK.ChannelTypes.Catalog CreateCatalog()
    {
        var catalogResult = new Humidifier.MSK.ChannelTypes.Catalog();

        return catalogResult;
    }

} // End Of Class

public static class InnerChannelCatalogFactoryExtensions
{
}
