// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class InnerLaunchConfigurationTemplateLicensingFactory(Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> factoryAction = null) : SubResourceFactory<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing>
{

    protected override Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing Create()
    {
        var licensingResult = CreateLicensing();
        factoryAction?.Invoke(licensingResult);

        return licensingResult;
    }

    private Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing CreateLicensing()
    {
        var licensingResult = new Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing();

        return licensingResult;
    }

} // End Of Class

public static class InnerLaunchConfigurationTemplateLicensingFactoryExtensions
{
}
