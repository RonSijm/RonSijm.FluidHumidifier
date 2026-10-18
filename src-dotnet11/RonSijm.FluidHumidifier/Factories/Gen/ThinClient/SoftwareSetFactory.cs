// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ThinClient;

public class SoftwareSetFactory(string resourceName = null, Action<Humidifier.ThinClient.SoftwareSet> factoryAction = null) : ResourceFactory<Humidifier.ThinClient.SoftwareSet>(resourceName)
{

    protected override Humidifier.ThinClient.SoftwareSet Create()
    {
        var softwareSetResult = CreateSoftwareSet();
        factoryAction?.Invoke(softwareSetResult);

        return softwareSetResult;
    }

    private Humidifier.ThinClient.SoftwareSet CreateSoftwareSet()
    {
        var softwareSetResult = new Humidifier.ThinClient.SoftwareSet
        {
            GivenName = InputResourceName,
        };

        return softwareSetResult;
    }

} // End Of Class

public static class SoftwareSetFactoryExtensions
{
}
