// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageMetadataPropertiesFactory(Action<Humidifier.SageMaker.ModelPackageTypes.MetadataProperties> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.MetadataProperties>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.MetadataProperties Create()
    {
        var metadataPropertiesResult = CreateMetadataProperties();
        factoryAction?.Invoke(metadataPropertiesResult);

        return metadataPropertiesResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.MetadataProperties CreateMetadataProperties()
    {
        var metadataPropertiesResult = new Humidifier.SageMaker.ModelPackageTypes.MetadataProperties();

        return metadataPropertiesResult;
    }

} // End Of Class

public static class InnerModelPackageMetadataPropertiesFactoryExtensions
{
}
