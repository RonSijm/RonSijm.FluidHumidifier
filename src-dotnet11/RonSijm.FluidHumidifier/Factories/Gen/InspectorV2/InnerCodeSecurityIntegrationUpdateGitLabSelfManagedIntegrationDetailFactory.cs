// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCodeSecurityIntegrationUpdateGitLabSelfManagedIntegrationDetailFactory(Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitLabSelfManagedIntegrationDetail> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitLabSelfManagedIntegrationDetail>
{

    protected override Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitLabSelfManagedIntegrationDetail Create()
    {
        var updateGitLabSelfManagedIntegrationDetailResult = CreateUpdateGitLabSelfManagedIntegrationDetail();
        factoryAction?.Invoke(updateGitLabSelfManagedIntegrationDetailResult);

        return updateGitLabSelfManagedIntegrationDetailResult;
    }

    private Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitLabSelfManagedIntegrationDetail CreateUpdateGitLabSelfManagedIntegrationDetail()
    {
        var updateGitLabSelfManagedIntegrationDetailResult = new Humidifier.InspectorV2.CodeSecurityIntegrationTypes.UpdateGitLabSelfManagedIntegrationDetail();

        return updateGitLabSelfManagedIntegrationDetailResult;
    }

} // End Of Class

public static class InnerCodeSecurityIntegrationUpdateGitLabSelfManagedIntegrationDetailFactoryExtensions
{
}
