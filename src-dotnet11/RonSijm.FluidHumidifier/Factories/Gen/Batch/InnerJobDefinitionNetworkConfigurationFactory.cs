// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionNetworkConfigurationFactory(Action<Humidifier.Batch.JobDefinitionTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.NetworkConfiguration>
{

    protected override Humidifier.Batch.JobDefinitionTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.Batch.JobDefinitionTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }

} // End Of Class

public static class InnerJobDefinitionNetworkConfigurationFactoryExtensions
{
}
