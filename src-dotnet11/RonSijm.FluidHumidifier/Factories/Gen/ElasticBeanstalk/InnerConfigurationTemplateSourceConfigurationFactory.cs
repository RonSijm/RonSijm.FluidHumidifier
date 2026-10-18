// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerConfigurationTemplateSourceConfigurationFactory(Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration>
{

    protected override Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration Create()
    {
        var sourceConfigurationResult = CreateSourceConfiguration();
        factoryAction?.Invoke(sourceConfigurationResult);

        return sourceConfigurationResult;
    }

    private Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration CreateSourceConfiguration()
    {
        var sourceConfigurationResult = new Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration();

        return sourceConfigurationResult;
    }

} // End Of Class

public static class InnerConfigurationTemplateSourceConfigurationFactoryExtensions
{
}
