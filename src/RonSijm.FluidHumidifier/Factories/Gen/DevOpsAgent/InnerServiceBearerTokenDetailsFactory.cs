// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceBearerTokenDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails Create()
    {
        var bearerTokenDetailsResult = CreateBearerTokenDetails();
        factoryAction?.Invoke(bearerTokenDetailsResult);

        return bearerTokenDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails CreateBearerTokenDetails()
    {
        var bearerTokenDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails();

        return bearerTokenDetailsResult;
    }

} // End Of Class

public static class InnerServiceBearerTokenDetailsFactoryExtensions
{
}
