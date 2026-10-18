// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class CollectionFactory(string resourceName = null, Action<Humidifier.Rekognition.Collection> factoryAction = null) : ResourceFactory<Humidifier.Rekognition.Collection>(resourceName)
{

    protected override Humidifier.Rekognition.Collection Create()
    {
        var collectionResult = CreateCollection();
        factoryAction?.Invoke(collectionResult);

        return collectionResult;
    }

    private Humidifier.Rekognition.Collection CreateCollection()
    {
        var collectionResult = new Humidifier.Rekognition.Collection
        {
            GivenName = InputResourceName,
        };

        return collectionResult;
    }

} // End Of Class

public static class CollectionFactoryExtensions
{
}
