// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory(Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail>
{

    protected override Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail Create()
    {
        var createGitLabSelfManagedIntegrationDetailResult = CreateCreateGitLabSelfManagedIntegrationDetail();
        factoryAction?.Invoke(createGitLabSelfManagedIntegrationDetailResult);

        return createGitLabSelfManagedIntegrationDetailResult;
    }

    private Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail CreateCreateGitLabSelfManagedIntegrationDetail()
    {
        var createGitLabSelfManagedIntegrationDetailResult = new Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail();

        return createGitLabSelfManagedIntegrationDetailResult;
    }

} // End Of Class

public static class InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactoryExtensions
{
}
