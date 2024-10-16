// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class HubFactory(string resourceName = null, Action<Humidifier.SecurityHub.Hub> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.Hub>(resourceName)
{

    protected override Humidifier.SecurityHub.Hub Create()
    {
        var hubResult = CreateHub();
        factoryAction?.Invoke(hubResult);

        return hubResult;
    }

    private Humidifier.SecurityHub.Hub CreateHub()
    {
        var hubResult = new Humidifier.SecurityHub.Hub
        {
            GivenName = InputResourceName,
        };

        return hubResult;
    }

} // End Of Class

public static class HubFactoryExtensions
{
}
