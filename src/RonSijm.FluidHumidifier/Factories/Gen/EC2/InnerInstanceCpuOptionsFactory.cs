// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceCpuOptionsFactory(Action<Humidifier.EC2.InstanceTypes.CpuOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.CpuOptions>
{

    protected override Humidifier.EC2.InstanceTypes.CpuOptions Create()
    {
        var cpuOptionsResult = CreateCpuOptions();
        factoryAction?.Invoke(cpuOptionsResult);

        return cpuOptionsResult;
    }

    private Humidifier.EC2.InstanceTypes.CpuOptions CreateCpuOptions()
    {
        var cpuOptionsResult = new Humidifier.EC2.InstanceTypes.CpuOptions();

        return cpuOptionsResult;
    }

} // End Of Class

public static class InnerInstanceCpuOptionsFactoryExtensions
{
}
