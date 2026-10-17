// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class CollectionIndexFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.CollectionIndex> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.CollectionIndex>(resourceName)
{

    protected override Humidifier.OpenSearchServerless.CollectionIndex Create()
    {
        var collectionIndexResult = CreateCollectionIndex();
        factoryAction?.Invoke(collectionIndexResult);

        return collectionIndexResult;
    }

    private Humidifier.OpenSearchServerless.CollectionIndex CreateCollectionIndex()
    {
        var collectionIndexResult = new Humidifier.OpenSearchServerless.CollectionIndex
        {
            GivenName = InputResourceName,
        };

        return collectionIndexResult;
    }

} // End Of Class

public static class CollectionIndexFactoryExtensions
{
}
