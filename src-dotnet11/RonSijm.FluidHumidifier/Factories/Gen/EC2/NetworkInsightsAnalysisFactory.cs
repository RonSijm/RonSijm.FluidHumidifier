// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NetworkInsightsAnalysisFactory(string resourceName = null, Action<Humidifier.EC2.NetworkInsightsAnalysis> factoryAction = null) : ResourceFactory<Humidifier.EC2.NetworkInsightsAnalysis>(resourceName)
{

    protected override Humidifier.EC2.NetworkInsightsAnalysis Create()
    {
        var networkInsightsAnalysisResult = CreateNetworkInsightsAnalysis();
        factoryAction?.Invoke(networkInsightsAnalysisResult);

        return networkInsightsAnalysisResult;
    }

    private Humidifier.EC2.NetworkInsightsAnalysis CreateNetworkInsightsAnalysis()
    {
        var networkInsightsAnalysisResult = new Humidifier.EC2.NetworkInsightsAnalysis
        {
            GivenName = InputResourceName,
        };

        return networkInsightsAnalysisResult;
    }

} // End Of Class

public static class NetworkInsightsAnalysisFactoryExtensions
{
}
