// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerAnnotationStoreTsvStoreOptionsFactory(Action<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions> factoryAction = null) : SubResourceFactory<Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions>
{

    protected override Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions Create()
    {
        var tsvStoreOptionsResult = CreateTsvStoreOptions();
        factoryAction?.Invoke(tsvStoreOptionsResult);

        return tsvStoreOptionsResult;
    }

    private Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions CreateTsvStoreOptions()
    {
        var tsvStoreOptionsResult = new Humidifier.Omics.AnnotationStoreTypes.TsvStoreOptions();

        return tsvStoreOptionsResult;
    }

} // End Of Class

public static class InnerAnnotationStoreTsvStoreOptionsFactoryExtensions
{
}
