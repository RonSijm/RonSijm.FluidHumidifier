// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerExpressGatewayServiceExpressGatewayRepositoryCredentialsFactory(Action<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayRepositoryCredentials> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayRepositoryCredentials>
{

    protected override Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayRepositoryCredentials Create()
    {
        var expressGatewayRepositoryCredentialsResult = CreateExpressGatewayRepositoryCredentials();
        factoryAction?.Invoke(expressGatewayRepositoryCredentialsResult);

        return expressGatewayRepositoryCredentialsResult;
    }

    private Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayRepositoryCredentials CreateExpressGatewayRepositoryCredentials()
    {
        var expressGatewayRepositoryCredentialsResult = new Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayRepositoryCredentials();

        return expressGatewayRepositoryCredentialsResult;
    }

} // End Of Class

public static class InnerExpressGatewayServiceExpressGatewayRepositoryCredentialsFactoryExtensions
{
}
