// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateEnclaveOptionsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.EnclaveOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.EnclaveOptions>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.EnclaveOptions Create()
    {
        var enclaveOptionsResult = CreateEnclaveOptions();
        factoryAction?.Invoke(enclaveOptionsResult);

        return enclaveOptionsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.EnclaveOptions CreateEnclaveOptions()
    {
        var enclaveOptionsResult = new Humidifier.EC2.LaunchTemplateTypes.EnclaveOptions();

        return enclaveOptionsResult;
    }

} // End Of Class

public static class InnerLaunchTemplateEnclaveOptionsFactoryExtensions
{
}
