// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerBrowserCustomBrowserEnterprisePolicyFactory(Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserEnterprisePolicy> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserEnterprisePolicy>
{

    internal InnerBrowserCustomS3LocationFactory LocationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserEnterprisePolicy Create()
    {
        var browserEnterprisePolicyResult = CreateBrowserEnterprisePolicy();
        factoryAction?.Invoke(browserEnterprisePolicyResult);

        return browserEnterprisePolicyResult;
    }

    private Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserEnterprisePolicy CreateBrowserEnterprisePolicy()
    {
        var browserEnterprisePolicyResult = new Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserEnterprisePolicy();

        return browserEnterprisePolicyResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserEnterprisePolicy result)
    {
        base.CreateChildren(result);

        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class InnerBrowserCustomBrowserEnterprisePolicyFactoryExtensions
{
    public static CombinedResult<InnerBrowserCustomBrowserEnterprisePolicyFactory, InnerBrowserCustomS3LocationFactory> WithLocation(this InnerBrowserCustomBrowserEnterprisePolicyFactory parentFactory, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerBrowserCustomS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<InnerBrowserCustomBrowserEnterprisePolicyFactory, T1, InnerBrowserCustomS3LocationFactory> WithLocation<T1>(this CombinedResult<InnerBrowserCustomBrowserEnterprisePolicyFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomBrowserEnterprisePolicyFactory, InnerBrowserCustomS3LocationFactory> WithLocation<T1>(this CombinedResult<T1, InnerBrowserCustomBrowserEnterprisePolicyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomBrowserEnterprisePolicyFactory, T1, T2, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<InnerBrowserCustomBrowserEnterprisePolicyFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomBrowserEnterprisePolicyFactory, T2, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, InnerBrowserCustomBrowserEnterprisePolicyFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomBrowserEnterprisePolicyFactory, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, InnerBrowserCustomBrowserEnterprisePolicyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomBrowserEnterprisePolicyFactory, T1, T2, T3, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<InnerBrowserCustomBrowserEnterprisePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomBrowserEnterprisePolicyFactory, T2, T3, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, InnerBrowserCustomBrowserEnterprisePolicyFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomBrowserEnterprisePolicyFactory, T3, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrowserCustomBrowserEnterprisePolicyFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrowserCustomBrowserEnterprisePolicyFactory, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrowserCustomBrowserEnterprisePolicyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrowserCustomBrowserEnterprisePolicyFactory, T1, T2, T3, T4, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<InnerBrowserCustomBrowserEnterprisePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrowserCustomBrowserEnterprisePolicyFactory, T2, T3, T4, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrowserCustomBrowserEnterprisePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrowserCustomBrowserEnterprisePolicyFactory, T3, T4, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrowserCustomBrowserEnterprisePolicyFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrowserCustomBrowserEnterprisePolicyFactory, T4, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrowserCustomBrowserEnterprisePolicyFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrowserCustomBrowserEnterprisePolicyFactory, InnerBrowserCustomS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrowserCustomBrowserEnterprisePolicyFactory> combinedResult, Action<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction).T2);
}
