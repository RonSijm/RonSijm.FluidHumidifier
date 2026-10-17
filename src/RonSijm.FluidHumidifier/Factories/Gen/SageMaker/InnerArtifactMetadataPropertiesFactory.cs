// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerArtifactMetadataPropertiesFactory(Action<Humidifier.SageMaker.ArtifactTypes.MetadataProperties> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ArtifactTypes.MetadataProperties>
{

    protected override Humidifier.SageMaker.ArtifactTypes.MetadataProperties Create()
    {
        var metadataPropertiesResult = CreateMetadataProperties();
        factoryAction?.Invoke(metadataPropertiesResult);

        return metadataPropertiesResult;
    }

    private Humidifier.SageMaker.ArtifactTypes.MetadataProperties CreateMetadataProperties()
    {
        var metadataPropertiesResult = new Humidifier.SageMaker.ArtifactTypes.MetadataProperties();

        return metadataPropertiesResult;
    }

} // End Of Class

public static class InnerArtifactMetadataPropertiesFactoryExtensions
{
}
