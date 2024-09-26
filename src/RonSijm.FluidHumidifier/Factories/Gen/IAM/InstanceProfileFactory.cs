// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class InstanceProfileFactory(string resourceName = null, Action<Humidifier.IAM.InstanceProfile> factoryAction = null) : ResourceFactory<Humidifier.IAM.InstanceProfile>(resourceName)
{

    protected override Humidifier.IAM.InstanceProfile Create()
    {
        var instanceProfileResult = CreateInstanceProfile();
        factoryAction?.Invoke(instanceProfileResult);

        return instanceProfileResult;
    }

    private Humidifier.IAM.InstanceProfile CreateInstanceProfile()
    {
        var instanceProfileResult = new Humidifier.IAM.InstanceProfile
        {
            GivenName = InputResourceName,
        };

        return instanceProfileResult;
    }

} // End Of Class

public static class InstanceProfileFactoryExtensions
{
}
