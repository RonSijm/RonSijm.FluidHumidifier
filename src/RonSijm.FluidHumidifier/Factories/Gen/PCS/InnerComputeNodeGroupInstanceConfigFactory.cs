// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerComputeNodeGroupInstanceConfigFactory(Action<Humidifier.PCS.ComputeNodeGroupTypes.InstanceConfig> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ComputeNodeGroupTypes.InstanceConfig>
{

    protected override Humidifier.PCS.ComputeNodeGroupTypes.InstanceConfig Create()
    {
        var instanceConfigResult = CreateInstanceConfig();
        factoryAction?.Invoke(instanceConfigResult);

        return instanceConfigResult;
    }

    private Humidifier.PCS.ComputeNodeGroupTypes.InstanceConfig CreateInstanceConfig()
    {
        var instanceConfigResult = new Humidifier.PCS.ComputeNodeGroupTypes.InstanceConfig();

        return instanceConfigResult;
    }

} // End Of Class

public static class InnerComputeNodeGroupInstanceConfigFactoryExtensions
{
}
