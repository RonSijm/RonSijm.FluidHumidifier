// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerFHIRDatastoreProfileConfigurationFactory(Action<Humidifier.HealthLake.FHIRDatastoreTypes.ProfileConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.FHIRDatastoreTypes.ProfileConfiguration>
{

    protected override Humidifier.HealthLake.FHIRDatastoreTypes.ProfileConfiguration Create()
    {
        var profileConfigurationResult = CreateProfileConfiguration();
        factoryAction?.Invoke(profileConfigurationResult);

        return profileConfigurationResult;
    }

    private Humidifier.HealthLake.FHIRDatastoreTypes.ProfileConfiguration CreateProfileConfiguration()
    {
        var profileConfigurationResult = new Humidifier.HealthLake.FHIRDatastoreTypes.ProfileConfiguration();

        return profileConfigurationResult;
    }

} // End Of Class

public static class InnerFHIRDatastoreProfileConfigurationFactoryExtensions
{
}
