// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class AccessProfileFactory(string resourceName = null, Action<Humidifier.CloudWatch.AccessProfile> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.AccessProfile>(resourceName)
{

    protected override Humidifier.CloudWatch.AccessProfile Create()
    {
        var accessProfileResult = CreateAccessProfile();
        factoryAction?.Invoke(accessProfileResult);

        return accessProfileResult;
    }

    private Humidifier.CloudWatch.AccessProfile CreateAccessProfile()
    {
        var accessProfileResult = new Humidifier.CloudWatch.AccessProfile
        {
            GivenName = InputResourceName,
        };

        return accessProfileResult;
    }

} // End Of Class

public static class AccessProfileFactoryExtensions
{
}
