// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInsightsAccessScopeResourceStatementRequestFactory(Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest>
{

    protected override Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest Create()
    {
        var resourceStatementRequestResult = CreateResourceStatementRequest();
        factoryAction?.Invoke(resourceStatementRequestResult);

        return resourceStatementRequestResult;
    }

    private Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest CreateResourceStatementRequest()
    {
        var resourceStatementRequestResult = new Humidifier.EC2.NetworkInsightsAccessScopeTypes.ResourceStatementRequest();

        return resourceStatementRequestResult;
    }

} // End Of Class

public static class InnerNetworkInsightsAccessScopeResourceStatementRequestFactoryExtensions
{
}
