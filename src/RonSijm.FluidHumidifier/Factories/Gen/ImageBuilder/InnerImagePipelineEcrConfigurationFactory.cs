// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImagePipelineEcrConfigurationFactory(Action<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration>
{

    protected override Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration Create()
    {
        var ecrConfigurationResult = CreateEcrConfiguration();
        factoryAction?.Invoke(ecrConfigurationResult);

        return ecrConfigurationResult;
    }

    private Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration CreateEcrConfiguration()
    {
        var ecrConfigurationResult = new Humidifier.ImageBuilder.ImagePipelineTypes.EcrConfiguration();

        return ecrConfigurationResult;
    }

} // End Of Class

public static class InnerImagePipelineEcrConfigurationFactoryExtensions
{
}
