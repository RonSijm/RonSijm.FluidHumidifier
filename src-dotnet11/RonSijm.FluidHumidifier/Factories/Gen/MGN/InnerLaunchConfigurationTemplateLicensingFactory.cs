// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class InnerLaunchConfigurationTemplateLicensingFactory(Action<Humidifier.MGN.LaunchConfigurationTemplateTypes.Licensing> factoryAction = null) : SubResourceFactory<Humidifier.MGN.LaunchConfigurationTemplateTypes.Licensing>
{

    protected override Humidifier.MGN.LaunchConfigurationTemplateTypes.Licensing Create()
    {
        var licensingResult = CreateLicensing();
        factoryAction?.Invoke(licensingResult);

        return licensingResult;
    }

    private Humidifier.MGN.LaunchConfigurationTemplateTypes.Licensing CreateLicensing()
    {
        var licensingResult = new Humidifier.MGN.LaunchConfigurationTemplateTypes.Licensing();

        return licensingResult;
    }

} // End Of Class

public static class InnerLaunchConfigurationTemplateLicensingFactoryExtensions
{
}
