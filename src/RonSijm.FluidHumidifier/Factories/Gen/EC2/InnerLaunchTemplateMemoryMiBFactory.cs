// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateMemoryMiBFactory(Action<Humidifier.EC2.LaunchTemplateTypes.MemoryMiB> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.MemoryMiB>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.MemoryMiB Create()
    {
        var memoryMiBResult = CreateMemoryMiB();
        factoryAction?.Invoke(memoryMiBResult);

        return memoryMiBResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.MemoryMiB CreateMemoryMiB()
    {
        var memoryMiBResult = new Humidifier.EC2.LaunchTemplateTypes.MemoryMiB();

        return memoryMiBResult;
    }

} // End Of Class

public static class InnerLaunchTemplateMemoryMiBFactoryExtensions
{
}
