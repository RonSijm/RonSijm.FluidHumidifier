// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateAcceleratorCountFactory(Action<Humidifier.EC2.LaunchTemplateTypes.AcceleratorCount> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.AcceleratorCount>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.AcceleratorCount Create()
    {
        var acceleratorCountResult = CreateAcceleratorCount();
        factoryAction?.Invoke(acceleratorCountResult);

        return acceleratorCountResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.AcceleratorCount CreateAcceleratorCount()
    {
        var acceleratorCountResult = new Humidifier.EC2.LaunchTemplateTypes.AcceleratorCount();

        return acceleratorCountResult;
    }

} // End Of Class

public static class InnerLaunchTemplateAcceleratorCountFactoryExtensions
{
}
