// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionLogConfigurationFactory(Action<Humidifier.Batch.JobDefinitionTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.LogConfiguration>
{

    protected override Humidifier.Batch.JobDefinitionTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.Batch.JobDefinitionTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerJobDefinitionLogConfigurationFactoryExtensions
{
}
