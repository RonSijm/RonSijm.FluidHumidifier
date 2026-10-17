// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class SystemFactory(string resourceName = null, Action<Humidifier.ResilienceHubV2.System> factoryAction = null) : ResourceFactory<Humidifier.ResilienceHubV2.System>(resourceName)
{

    protected override Humidifier.ResilienceHubV2.System Create()
    {
        var systemResult = CreateSystem();
        factoryAction?.Invoke(systemResult);

        return systemResult;
    }

    private Humidifier.ResilienceHubV2.System CreateSystem()
    {
        var systemResult = new Humidifier.ResilienceHubV2.System
        {
            GivenName = InputResourceName,
        };

        return systemResult;
    }

} // End Of Class

public static class SystemFactoryExtensions
{
}
