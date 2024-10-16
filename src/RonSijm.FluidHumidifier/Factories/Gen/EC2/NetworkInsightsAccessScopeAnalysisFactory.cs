// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NetworkInsightsAccessScopeAnalysisFactory(string resourceName = null, Action<Humidifier.EC2.NetworkInsightsAccessScopeAnalysis> factoryAction = null) : ResourceFactory<Humidifier.EC2.NetworkInsightsAccessScopeAnalysis>(resourceName)
{

    protected override Humidifier.EC2.NetworkInsightsAccessScopeAnalysis Create()
    {
        var networkInsightsAccessScopeAnalysisResult = CreateNetworkInsightsAccessScopeAnalysis();
        factoryAction?.Invoke(networkInsightsAccessScopeAnalysisResult);

        return networkInsightsAccessScopeAnalysisResult;
    }

    private Humidifier.EC2.NetworkInsightsAccessScopeAnalysis CreateNetworkInsightsAccessScopeAnalysis()
    {
        var networkInsightsAccessScopeAnalysisResult = new Humidifier.EC2.NetworkInsightsAccessScopeAnalysis
        {
            GivenName = InputResourceName,
        };

        return networkInsightsAccessScopeAnalysisResult;
    }

} // End Of Class

public static class NetworkInsightsAccessScopeAnalysisFactoryExtensions
{
}
