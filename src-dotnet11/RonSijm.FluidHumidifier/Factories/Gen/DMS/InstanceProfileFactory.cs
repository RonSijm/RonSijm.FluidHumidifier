// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InstanceProfileFactory(string resourceName = null, Action<Humidifier.DMS.InstanceProfile> factoryAction = null) : ResourceFactory<Humidifier.DMS.InstanceProfile>(resourceName)
{

    protected override Humidifier.DMS.InstanceProfile Create()
    {
        var instanceProfileResult = CreateInstanceProfile();
        factoryAction?.Invoke(instanceProfileResult);

        return instanceProfileResult;
    }

    private Humidifier.DMS.InstanceProfile CreateInstanceProfile()
    {
        var instanceProfileResult = new Humidifier.DMS.InstanceProfile
        {
            GivenName = InputResourceName,
        };

        return instanceProfileResult;
    }

} // End Of Class

public static class InstanceProfileFactoryExtensions
{
}
