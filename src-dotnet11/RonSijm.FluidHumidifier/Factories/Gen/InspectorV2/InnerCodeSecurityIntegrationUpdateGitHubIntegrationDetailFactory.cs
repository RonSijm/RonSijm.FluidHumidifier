// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCodeSecurityIntegrationUpdateGitHubIntegrationDetailFactory(Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitHubIntegrationDetail> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitHubIntegrationDetail>
{

    protected override Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitHubIntegrationDetail Create()
    {
        var updateGitHubIntegrationDetailResult = CreateUpdateGitHubIntegrationDetail();
        factoryAction?.Invoke(updateGitHubIntegrationDetailResult);

        return updateGitHubIntegrationDetailResult;
    }

    private Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitHubIntegrationDetail CreateUpdateGitHubIntegrationDetail()
    {
        var updateGitHubIntegrationDetailResult = new Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitHubIntegrationDetail();

        return updateGitHubIntegrationDetailResult;
    }

} // End Of Class

public static class InnerCodeSecurityIntegrationUpdateGitHubIntegrationDetailFactoryExtensions
{
}
