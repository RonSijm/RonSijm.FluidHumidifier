// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class SourceNetworkFactory(string resourceName = null, Action<Humidifier.DRS.SourceNetwork> factoryAction = null) : ResourceFactory<Humidifier.DRS.SourceNetwork>(resourceName)
{

    protected override Humidifier.DRS.SourceNetwork Create()
    {
        var sourceNetworkResult = CreateSourceNetwork();
        factoryAction?.Invoke(sourceNetworkResult);

        return sourceNetworkResult;
    }

    private Humidifier.DRS.SourceNetwork CreateSourceNetwork()
    {
        var sourceNetworkResult = new Humidifier.DRS.SourceNetwork
        {
            GivenName = InputResourceName,
        };

        return sourceNetworkResult;
    }

} // End Of Class

public static class SourceNetworkFactoryExtensions
{
}
