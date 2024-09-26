// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainDockerSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.DockerSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.DockerSettings>
{

    protected override Humidifier.SageMaker.DomainTypes.DockerSettings Create()
    {
        var dockerSettingsResult = CreateDockerSettings();
        factoryAction?.Invoke(dockerSettingsResult);

        return dockerSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.DockerSettings CreateDockerSettings()
    {
        var dockerSettingsResult = new Humidifier.SageMaker.DomainTypes.DockerSettings();

        return dockerSettingsResult;
    }

} // End Of Class

public static class InnerDomainDockerSettingsFactoryExtensions
{
}
