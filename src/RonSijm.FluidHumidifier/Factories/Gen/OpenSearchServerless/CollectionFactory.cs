// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class CollectionFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.Collection> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.Collection>(resourceName)
{

    protected override Humidifier.OpenSearchServerless.Collection Create()
    {
        var collectionResult = CreateCollection();
        factoryAction?.Invoke(collectionResult);

        return collectionResult;
    }

    private Humidifier.OpenSearchServerless.Collection CreateCollection()
    {
        var collectionResult = new Humidifier.OpenSearchServerless.Collection
        {
            GivenName = InputResourceName,
        };

        return collectionResult;
    }

} // End Of Class

public static class CollectionFactoryExtensions
{
}
