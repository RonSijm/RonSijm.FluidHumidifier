// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerConnectionConnectionHttpParametersFactory(Action<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.ConnectionTypes.ConnectionHttpParameters>
{

    protected override Humidifier.Events.ConnectionTypes.ConnectionHttpParameters Create()
    {
        var connectionHttpParametersResult = CreateConnectionHttpParameters();
        factoryAction?.Invoke(connectionHttpParametersResult);

        return connectionHttpParametersResult;
    }

    private Humidifier.Events.ConnectionTypes.ConnectionHttpParameters CreateConnectionHttpParameters()
    {
        var connectionHttpParametersResult = new Humidifier.Events.ConnectionTypes.ConnectionHttpParameters();

        return connectionHttpParametersResult;
    }

} // End Of Class

public static class InnerConnectionConnectionHttpParametersFactoryExtensions
{
}
