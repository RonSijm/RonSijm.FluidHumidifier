// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerAccessGrantAccessGrantsLocationConfigurationFactory(Action<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration>
{

    protected override Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration Create()
    {
        var accessGrantsLocationConfigurationResult = CreateAccessGrantsLocationConfiguration();
        factoryAction?.Invoke(accessGrantsLocationConfigurationResult);

        return accessGrantsLocationConfigurationResult;
    }

    private Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration CreateAccessGrantsLocationConfiguration()
    {
        var accessGrantsLocationConfigurationResult = new Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration();

        return accessGrantsLocationConfigurationResult;
    }

} // End Of Class

public static class InnerAccessGrantAccessGrantsLocationConfigurationFactoryExtensions
{
}
