// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateCpuOptionsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.CpuOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.CpuOptions>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.CpuOptions Create()
    {
        var cpuOptionsResult = CreateCpuOptions();
        factoryAction?.Invoke(cpuOptionsResult);

        return cpuOptionsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.CpuOptions CreateCpuOptions()
    {
        var cpuOptionsResult = new Humidifier.EC2.LaunchTemplateTypes.CpuOptions();

        return cpuOptionsResult;
    }

} // End Of Class

public static class InnerLaunchTemplateCpuOptionsFactoryExtensions
{
}
