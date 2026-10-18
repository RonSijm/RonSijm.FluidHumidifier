// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InstanceFactory(string resourceName = null, Action<Humidifier.SCN.Instance> factoryAction = null) : ResourceFactory<Humidifier.SCN.Instance>(resourceName)
{

    protected override Humidifier.SCN.Instance Create()
    {
        var instanceResult = CreateInstance();
        factoryAction?.Invoke(instanceResult);

        return instanceResult;
    }

    private Humidifier.SCN.Instance CreateInstance()
    {
        var instanceResult = new Humidifier.SCN.Instance
        {
            GivenName = InputResourceName,
        };

        return instanceResult;
    }

} // End Of Class

public static class InstanceFactoryExtensions
{
}
