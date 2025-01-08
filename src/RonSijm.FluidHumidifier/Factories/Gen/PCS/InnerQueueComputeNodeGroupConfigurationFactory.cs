// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerQueueComputeNodeGroupConfigurationFactory(Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration>
{

    protected override Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration Create()
    {
        var computeNodeGroupConfigurationResult = CreateComputeNodeGroupConfiguration();
        factoryAction?.Invoke(computeNodeGroupConfigurationResult);

        return computeNodeGroupConfigurationResult;
    }

    private Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration CreateComputeNodeGroupConfiguration()
    {
        var computeNodeGroupConfigurationResult = new Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration();

        return computeNodeGroupConfigurationResult;
    }

} // End Of Class

public static class InnerQueueComputeNodeGroupConfigurationFactoryExtensions
{
}
