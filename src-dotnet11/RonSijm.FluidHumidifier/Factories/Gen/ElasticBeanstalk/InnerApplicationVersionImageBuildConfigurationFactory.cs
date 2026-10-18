// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerApplicationVersionImageBuildConfigurationFactory(Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageBuildConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageBuildConfiguration>
{

    protected override Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageBuildConfiguration Create()
    {
        var imageBuildConfigurationResult = CreateImageBuildConfiguration();
        factoryAction?.Invoke(imageBuildConfigurationResult);

        return imageBuildConfigurationResult;
    }

    private Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageBuildConfiguration CreateImageBuildConfiguration()
    {
        var imageBuildConfigurationResult = new Humidifier.ElasticBeanstalk.ApplicationVersionTypes.ImageBuildConfiguration();

        return imageBuildConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationVersionImageBuildConfigurationFactoryExtensions
{
}
