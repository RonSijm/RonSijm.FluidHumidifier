// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateAcceleratorTotalMemoryMiBFactory(Action<Humidifier.EC2.LaunchTemplateTypes.AcceleratorTotalMemoryMiB> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.AcceleratorTotalMemoryMiB>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.AcceleratorTotalMemoryMiB Create()
    {
        var acceleratorTotalMemoryMiBResult = CreateAcceleratorTotalMemoryMiB();
        factoryAction?.Invoke(acceleratorTotalMemoryMiBResult);

        return acceleratorTotalMemoryMiBResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.AcceleratorTotalMemoryMiB CreateAcceleratorTotalMemoryMiB()
    {
        var acceleratorTotalMemoryMiBResult = new Humidifier.EC2.LaunchTemplateTypes.AcceleratorTotalMemoryMiB();

        return acceleratorTotalMemoryMiBResult;
    }

} // End Of Class

public static class InnerLaunchTemplateAcceleratorTotalMemoryMiBFactoryExtensions
{
}
