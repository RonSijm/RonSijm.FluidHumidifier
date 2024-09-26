// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerConnectionBasicAuthParametersFactory(Action<Humidifier.Events.ConnectionTypes.BasicAuthParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.ConnectionTypes.BasicAuthParameters>
{

    protected override Humidifier.Events.ConnectionTypes.BasicAuthParameters Create()
    {
        var basicAuthParametersResult = CreateBasicAuthParameters();
        factoryAction?.Invoke(basicAuthParametersResult);

        return basicAuthParametersResult;
    }

    private Humidifier.Events.ConnectionTypes.BasicAuthParameters CreateBasicAuthParameters()
    {
        var basicAuthParametersResult = new Humidifier.Events.ConnectionTypes.BasicAuthParameters();

        return basicAuthParametersResult;
    }

} // End Of Class

public static class InnerConnectionBasicAuthParametersFactoryExtensions
{
}
