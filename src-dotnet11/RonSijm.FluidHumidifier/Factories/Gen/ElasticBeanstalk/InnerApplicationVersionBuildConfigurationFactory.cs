// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerApplicationVersionBuildConfigurationFactory(Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.BuildConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.BuildConfiguration>
{

    protected override Humidifier.ElasticBeanstalk.ApplicationVersionTypes.BuildConfiguration Create()
    {
        var buildConfigurationResult = CreateBuildConfiguration();
        factoryAction?.Invoke(buildConfigurationResult);

        return buildConfigurationResult;
    }

    private Humidifier.ElasticBeanstalk.ApplicationVersionTypes.BuildConfiguration CreateBuildConfiguration()
    {
        var buildConfigurationResult = new Humidifier.ElasticBeanstalk.ApplicationVersionTypes.BuildConfiguration();

        return buildConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationVersionBuildConfigurationFactoryExtensions
{
}
