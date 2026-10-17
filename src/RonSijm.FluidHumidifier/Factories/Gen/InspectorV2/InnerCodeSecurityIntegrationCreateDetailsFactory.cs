// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCodeSecurityIntegrationCreateDetailsFactory(Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails>
{

    internal InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory gitlabSelfManagedFactory { get; set; }

    protected override Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails Create()
    {
        var createDetailsResult = CreateCreateDetails();
        factoryAction?.Invoke(createDetailsResult);

        return createDetailsResult;
    }

    private Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails CreateCreateDetails()
    {
        var createDetailsResult = new Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails();

        return createDetailsResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateDetails result)
    {
        base.CreateChildren(result);

        result.gitlabSelfManaged ??= gitlabSelfManagedFactory?.Build();
    }

} // End Of Class

public static class InnerCodeSecurityIntegrationCreateDetailsFactoryExtensions
{
    public static CombinedResult<InnerCodeSecurityIntegrationCreateDetailsFactory, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged(this InnerCodeSecurityIntegrationCreateDetailsFactory parentFactory, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null)
    {
        parentFactory.gitlabSelfManagedFactory = new InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.gitlabSelfManagedFactory);
    }

    public static CombinedResult<InnerCodeSecurityIntegrationCreateDetailsFactory, T1, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1>(this CombinedResult<InnerCodeSecurityIntegrationCreateDetailsFactory, T1> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeSecurityIntegrationCreateDetailsFactory, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1>(this CombinedResult<T1, InnerCodeSecurityIntegrationCreateDetailsFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCodeSecurityIntegrationCreateDetailsFactory, T1, T2, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2>(this CombinedResult<InnerCodeSecurityIntegrationCreateDetailsFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeSecurityIntegrationCreateDetailsFactory, T2, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2>(this CombinedResult<T1, InnerCodeSecurityIntegrationCreateDetailsFactory, T2> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodeSecurityIntegrationCreateDetailsFactory, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2>(this CombinedResult<T1, T2, InnerCodeSecurityIntegrationCreateDetailsFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCodeSecurityIntegrationCreateDetailsFactory, T1, T2, T3, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2, T3>(this CombinedResult<InnerCodeSecurityIntegrationCreateDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeSecurityIntegrationCreateDetailsFactory, T2, T3, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2, T3>(this CombinedResult<T1, InnerCodeSecurityIntegrationCreateDetailsFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodeSecurityIntegrationCreateDetailsFactory, T3, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2, T3>(this CombinedResult<T1, T2, InnerCodeSecurityIntegrationCreateDetailsFactory, T3> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodeSecurityIntegrationCreateDetailsFactory, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCodeSecurityIntegrationCreateDetailsFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCodeSecurityIntegrationCreateDetailsFactory, T1, T2, T3, T4, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2, T3, T4>(this CombinedResult<InnerCodeSecurityIntegrationCreateDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodeSecurityIntegrationCreateDetailsFactory, T2, T3, T4, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2, T3, T4>(this CombinedResult<T1, InnerCodeSecurityIntegrationCreateDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodeSecurityIntegrationCreateDetailsFactory, T3, T4, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCodeSecurityIntegrationCreateDetailsFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodeSecurityIntegrationCreateDetailsFactory, T4, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCodeSecurityIntegrationCreateDetailsFactory, T4> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCodeSecurityIntegrationCreateDetailsFactory, InnerCodeSecurityIntegrationCreateGitLabSelfManagedIntegrationDetailFactory> WithgitlabSelfManaged<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCodeSecurityIntegrationCreateDetailsFactory> combinedResult, Action<Humidifier.InspectorV2.CodeSecurityIntegrationTypes.CreateGitLabSelfManagedIntegrationDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithgitlabSelfManaged(combinedResult.T5, subFactoryAction).T2);
}
