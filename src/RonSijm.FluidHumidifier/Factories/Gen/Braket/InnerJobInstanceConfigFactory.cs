// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobInstanceConfigFactory(Action<Humidifier.Braket.JobTypes.InstanceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.InstanceConfig>
{

    protected override Humidifier.Braket.JobTypes.InstanceConfig Create()
    {
        var instanceConfigResult = CreateInstanceConfig();
        factoryAction?.Invoke(instanceConfigResult);

        return instanceConfigResult;
    }

    private Humidifier.Braket.JobTypes.InstanceConfig CreateInstanceConfig()
    {
        var instanceConfigResult = new Humidifier.Braket.JobTypes.InstanceConfig();

        return instanceConfigResult;
    }

} // End Of Class

public static class InnerJobInstanceConfigFactoryExtensions
{
}
