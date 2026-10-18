// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class SourceServerFactory(string resourceName = null, Action<Humidifier.DRS.SourceServer> factoryAction = null) : ResourceFactory<Humidifier.DRS.SourceServer>(resourceName)
{

    protected override Humidifier.DRS.SourceServer Create()
    {
        var sourceServerResult = CreateSourceServer();
        factoryAction?.Invoke(sourceServerResult);

        return sourceServerResult;
    }

    private Humidifier.DRS.SourceServer CreateSourceServer()
    {
        var sourceServerResult = new Humidifier.DRS.SourceServer
        {
            GivenName = InputResourceName,
        };

        return sourceServerResult;
    }

} // End Of Class

public static class SourceServerFactoryExtensions
{
}
