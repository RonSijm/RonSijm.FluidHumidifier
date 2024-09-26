// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class InstanceFactory(string resourceName = null, Action<Humidifier.SSO.Instance> factoryAction = null) : ResourceFactory<Humidifier.SSO.Instance>(resourceName)
{

    protected override Humidifier.SSO.Instance Create()
    {
        var instanceResult = CreateInstance();
        factoryAction?.Invoke(instanceResult);

        return instanceResult;
    }

    private Humidifier.SSO.Instance CreateInstance()
    {
        var instanceResult = new Humidifier.SSO.Instance
        {
            GivenName = InputResourceName,
        };

        return instanceResult;
    }

} // End Of Class

public static class InstanceFactoryExtensions
{
}
