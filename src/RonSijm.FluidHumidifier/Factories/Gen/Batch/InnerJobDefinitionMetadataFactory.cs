// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionMetadataFactory(Action<Humidifier.Batch.JobDefinitionTypes.Metadata> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.Metadata>
{

    protected override Humidifier.Batch.JobDefinitionTypes.Metadata Create()
    {
        var metadataResult = CreateMetadata();
        factoryAction?.Invoke(metadataResult);

        return metadataResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.Metadata CreateMetadata()
    {
        var metadataResult = new Humidifier.Batch.JobDefinitionTypes.Metadata();

        return metadataResult;
    }

} // End Of Class

public static class InnerJobDefinitionMetadataFactoryExtensions
{
}
