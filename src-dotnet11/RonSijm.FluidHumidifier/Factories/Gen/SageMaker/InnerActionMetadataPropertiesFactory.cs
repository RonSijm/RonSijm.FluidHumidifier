// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerActionMetadataPropertiesFactory(Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ActionTypes.MetadataProperties>
{

    protected override Humidifier.SageMaker.ActionTypes.MetadataProperties Create()
    {
        var metadataPropertiesResult = CreateMetadataProperties();
        factoryAction?.Invoke(metadataPropertiesResult);

        return metadataPropertiesResult;
    }

    private Humidifier.SageMaker.ActionTypes.MetadataProperties CreateMetadataProperties()
    {
        var metadataPropertiesResult = new Humidifier.SageMaker.ActionTypes.MetadataProperties();

        return metadataPropertiesResult;
    }

} // End Of Class

public static class InnerActionMetadataPropertiesFactoryExtensions
{
}
