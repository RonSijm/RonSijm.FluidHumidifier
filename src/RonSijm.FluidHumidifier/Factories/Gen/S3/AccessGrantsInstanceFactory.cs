// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class AccessGrantsInstanceFactory(string resourceName = null, Action<Humidifier.S3.AccessGrantsInstance> factoryAction = null) : ResourceFactory<Humidifier.S3.AccessGrantsInstance>(resourceName)
{

    protected override Humidifier.S3.AccessGrantsInstance Create()
    {
        var accessGrantsInstanceResult = CreateAccessGrantsInstance();
        factoryAction?.Invoke(accessGrantsInstanceResult);

        return accessGrantsInstanceResult;
    }

    private Humidifier.S3.AccessGrantsInstance CreateAccessGrantsInstance()
    {
        var accessGrantsInstanceResult = new Humidifier.S3.AccessGrantsInstance
        {
            GivenName = InputResourceName,
        };

        return accessGrantsInstanceResult;
    }

} // End Of Class

public static class AccessGrantsInstanceFactoryExtensions
{
}
