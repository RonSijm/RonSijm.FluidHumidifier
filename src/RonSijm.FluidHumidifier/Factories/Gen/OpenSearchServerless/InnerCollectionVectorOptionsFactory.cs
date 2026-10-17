// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerCollectionVectorOptionsFactory(Action<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions>
{

    protected override Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions Create()
    {
        var vectorOptionsResult = CreateVectorOptions();
        factoryAction?.Invoke(vectorOptionsResult);

        return vectorOptionsResult;
    }

    private Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions CreateVectorOptions()
    {
        var vectorOptionsResult = new Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions();

        return vectorOptionsResult;
    }

} // End Of Class

public static class InnerCollectionVectorOptionsFactoryExtensions
{
}
