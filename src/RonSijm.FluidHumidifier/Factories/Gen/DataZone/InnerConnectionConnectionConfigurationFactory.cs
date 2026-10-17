// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionConnectionConfigurationFactory(Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration>
{

    protected override Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration Create()
    {
        var connectionConfigurationResult = CreateConnectionConfiguration();
        factoryAction?.Invoke(connectionConfigurationResult);

        return connectionConfigurationResult;
    }

    private Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration CreateConnectionConfiguration()
    {
        var connectionConfigurationResult = new Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration();

        return connectionConfigurationResult;
    }

} // End Of Class

public static class InnerConnectionConnectionConfigurationFactoryExtensions
{
}
