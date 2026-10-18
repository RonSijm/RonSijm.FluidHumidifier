// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerMethodIntegrationFactory(Action<Humidifier.ApiGateway.MethodTypes.Integration> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.MethodTypes.Integration>
{

    protected override Humidifier.ApiGateway.MethodTypes.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.ApiGateway.MethodTypes.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.ApiGateway.MethodTypes.Integration();

        return integrationResult;
    }

} // End Of Class

public static class InnerMethodIntegrationFactoryExtensions
{
}
