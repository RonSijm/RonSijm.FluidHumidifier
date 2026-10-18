// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateMemoryGiBPerVCpuFactory(Action<Humidifier.EC2.LaunchTemplateTypes.MemoryGiBPerVCpu> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.MemoryGiBPerVCpu>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.MemoryGiBPerVCpu Create()
    {
        var memoryGiBPerVCpuResult = CreateMemoryGiBPerVCpu();
        factoryAction?.Invoke(memoryGiBPerVCpuResult);

        return memoryGiBPerVCpuResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.MemoryGiBPerVCpu CreateMemoryGiBPerVCpu()
    {
        var memoryGiBPerVCpuResult = new Humidifier.EC2.LaunchTemplateTypes.MemoryGiBPerVCpu();

        return memoryGiBPerVCpuResult;
    }

} // End Of Class

public static class InnerLaunchTemplateMemoryGiBPerVCpuFactoryExtensions
{
}
