// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class AccessGrantsLocationFactory(string resourceName = null, Action<Humidifier.S3.AccessGrantsLocation> factoryAction = null) : ResourceFactory<Humidifier.S3.AccessGrantsLocation>(resourceName)
{

    protected override Humidifier.S3.AccessGrantsLocation Create()
    {
        var accessGrantsLocationResult = CreateAccessGrantsLocation();
        factoryAction?.Invoke(accessGrantsLocationResult);

        return accessGrantsLocationResult;
    }

    private Humidifier.S3.AccessGrantsLocation CreateAccessGrantsLocation()
    {
        var accessGrantsLocationResult = new Humidifier.S3.AccessGrantsLocation
        {
            GivenName = InputResourceName,
        };

        return accessGrantsLocationResult;
    }

} // End Of Class

public static class AccessGrantsLocationFactoryExtensions
{
}
