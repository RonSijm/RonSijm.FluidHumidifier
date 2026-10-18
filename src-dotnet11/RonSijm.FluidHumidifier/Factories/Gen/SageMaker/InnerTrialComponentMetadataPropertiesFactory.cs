// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrialComponentMetadataPropertiesFactory(Action<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrialComponentTypes.MetadataProperties>
{

    protected override Humidifier.SageMaker.TrialComponentTypes.MetadataProperties Create()
    {
        var metadataPropertiesResult = CreateMetadataProperties();
        factoryAction?.Invoke(metadataPropertiesResult);

        return metadataPropertiesResult;
    }

    private Humidifier.SageMaker.TrialComponentTypes.MetadataProperties CreateMetadataProperties()
    {
        var metadataPropertiesResult = new Humidifier.SageMaker.TrialComponentTypes.MetadataProperties();

        return metadataPropertiesResult;
    }

} // End Of Class

public static class InnerTrialComponentMetadataPropertiesFactoryExtensions
{
}
