// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerConnectionClientParametersFactory(Action<Humidifier.Events.ConnectionTypes.ClientParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.ConnectionTypes.ClientParameters>
{

    protected override Humidifier.Events.ConnectionTypes.ClientParameters Create()
    {
        var clientParametersResult = CreateClientParameters();
        factoryAction?.Invoke(clientParametersResult);

        return clientParametersResult;
    }

    private Humidifier.Events.ConnectionTypes.ClientParameters CreateClientParameters()
    {
        var clientParametersResult = new Humidifier.Events.ConnectionTypes.ClientParameters();

        return clientParametersResult;
    }

} // End Of Class

public static class InnerConnectionClientParametersFactoryExtensions
{
}
