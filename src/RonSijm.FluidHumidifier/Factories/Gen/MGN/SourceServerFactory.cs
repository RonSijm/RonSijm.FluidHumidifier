// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class SourceServerFactory(string resourceName = null, Action<Humidifier.MGN.SourceServer> factoryAction = null) : ResourceFactory<Humidifier.MGN.SourceServer>(resourceName)
{

    protected override Humidifier.MGN.SourceServer Create()
    {
        var sourceServerResult = CreateSourceServer();
        factoryAction?.Invoke(sourceServerResult);

        return sourceServerResult;
    }

    private Humidifier.MGN.SourceServer CreateSourceServer()
    {
        var sourceServerResult = new Humidifier.MGN.SourceServer
        {
            GivenName = InputResourceName,
        };

        return sourceServerResult;
    }

} // End Of Class

public static class SourceServerFactoryExtensions
{
}
