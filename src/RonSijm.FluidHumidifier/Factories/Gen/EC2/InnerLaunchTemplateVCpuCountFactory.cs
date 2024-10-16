// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateVCpuCountFactory(Action<Humidifier.EC2.LaunchTemplateTypes.VCpuCount> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.VCpuCount>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.VCpuCount Create()
    {
        var vCpuCountResult = CreateVCpuCount();
        factoryAction?.Invoke(vCpuCountResult);

        return vCpuCountResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.VCpuCount CreateVCpuCount()
    {
        var vCpuCountResult = new Humidifier.EC2.LaunchTemplateTypes.VCpuCount();

        return vCpuCountResult;
    }

} // End Of Class

public static class InnerLaunchTemplateVCpuCountFactoryExtensions
{
}
