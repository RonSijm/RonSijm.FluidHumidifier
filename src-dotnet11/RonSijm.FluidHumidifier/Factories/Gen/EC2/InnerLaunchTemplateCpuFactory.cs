// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateCpuFactory(Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.Cpu>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.Cpu Create()
    {
        var cpuResult = CreateCpu();
        factoryAction?.Invoke(cpuResult);

        return cpuResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.Cpu CreateCpu()
    {
        var cpuResult = new Humidifier.EC2.LaunchTemplateTypes.Cpu();

        return cpuResult;
    }

} // End Of Class

public static class InnerLaunchTemplateCpuFactoryExtensions
{
}
