// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerUsageProfileProfileConfigurationFactory(Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration>
{

    protected override Humidifier.Glue.UsageProfileTypes.ProfileConfiguration Create()
    {
        var profileConfigurationResult = CreateProfileConfiguration();
        factoryAction?.Invoke(profileConfigurationResult);

        return profileConfigurationResult;
    }

    private Humidifier.Glue.UsageProfileTypes.ProfileConfiguration CreateProfileConfiguration()
    {
        var profileConfigurationResult = new Humidifier.Glue.UsageProfileTypes.ProfileConfiguration();

        return profileConfigurationResult;
    }

} // End Of Class

public static class InnerUsageProfileProfileConfigurationFactoryExtensions
{
}
