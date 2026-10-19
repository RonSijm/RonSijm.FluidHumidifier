// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerIntegrationIntegrationCredentialFactory(Action<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential>
{

    internal InnerIntegrationApiKeyCredentialFactory ApiKeyCredentialFactory { get; set; }

    protected override Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential Create()
    {
        var integrationCredentialResult = CreateIntegrationCredential();
        factoryAction?.Invoke(integrationCredentialResult);

        return integrationCredentialResult;
    }

    private Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential CreateIntegrationCredential()
    {
        var integrationCredentialResult = new Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential();

        return integrationCredentialResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.IntegrationTypes.IntegrationCredential result)
    {
        base.CreateChildren(result);

        result.ApiKeyCredential ??= ApiKeyCredentialFactory?.Build();
    }

} // End Of Class

public static class InnerIntegrationIntegrationCredentialFactoryExtensions
{
    public static CombinedResult<InnerIntegrationIntegrationCredentialFactory, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential(this InnerIntegrationIntegrationCredentialFactory parentFactory, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null)
    {
        parentFactory.ApiKeyCredentialFactory = new InnerIntegrationApiKeyCredentialFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApiKeyCredentialFactory);
    }

    public static CombinedResult<InnerIntegrationIntegrationCredentialFactory, T1, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1>(this CombinedResult<InnerIntegrationIntegrationCredentialFactory, T1> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntegrationIntegrationCredentialFactory, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1>(this CombinedResult<T1, InnerIntegrationIntegrationCredentialFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIntegrationIntegrationCredentialFactory, T1, T2, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2>(this CombinedResult<InnerIntegrationIntegrationCredentialFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntegrationIntegrationCredentialFactory, T2, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2>(this CombinedResult<T1, InnerIntegrationIntegrationCredentialFactory, T2> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntegrationIntegrationCredentialFactory, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2>(this CombinedResult<T1, T2, InnerIntegrationIntegrationCredentialFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIntegrationIntegrationCredentialFactory, T1, T2, T3, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3>(this CombinedResult<InnerIntegrationIntegrationCredentialFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntegrationIntegrationCredentialFactory, T2, T3, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3>(this CombinedResult<T1, InnerIntegrationIntegrationCredentialFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntegrationIntegrationCredentialFactory, T3, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3>(this CombinedResult<T1, T2, InnerIntegrationIntegrationCredentialFactory, T3> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntegrationIntegrationCredentialFactory, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIntegrationIntegrationCredentialFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIntegrationIntegrationCredentialFactory, T1, T2, T3, T4, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<InnerIntegrationIntegrationCredentialFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIntegrationIntegrationCredentialFactory, T2, T3, T4, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<T1, InnerIntegrationIntegrationCredentialFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIntegrationIntegrationCredentialFactory, T3, T4, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIntegrationIntegrationCredentialFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIntegrationIntegrationCredentialFactory, T4, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIntegrationIntegrationCredentialFactory, T4> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIntegrationIntegrationCredentialFactory, InnerIntegrationApiKeyCredentialFactory> WithApiKeyCredential<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIntegrationIntegrationCredentialFactory> combinedResult, Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKeyCredential(combinedResult.T5, subFactoryAction).T2);
}
