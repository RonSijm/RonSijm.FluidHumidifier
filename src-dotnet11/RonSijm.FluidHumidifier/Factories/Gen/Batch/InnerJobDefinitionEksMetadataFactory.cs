// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionEksMetadataFactory(Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.EksMetadata>
{

    protected override Humidifier.Batch.JobDefinitionTypes.EksMetadata Create()
    {
        var eksMetadataResult = CreateEksMetadata();
        factoryAction?.Invoke(eksMetadataResult);

        return eksMetadataResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.EksMetadata CreateEksMetadata()
    {
        var eksMetadataResult = new Humidifier.Batch.JobDefinitionTypes.EksMetadata();

        return eksMetadataResult;
    }

} // End Of Class

public static class InnerJobDefinitionEksMetadataFactoryExtensions
{
}
