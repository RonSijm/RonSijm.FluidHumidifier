// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobAutoMLSecurityConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLSecurityConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.AutoMLSecurityConfig>
{

    internal InnerAutoMLJobVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.SageMaker.AutoMLJobTypes.AutoMLSecurityConfig Create()
    {
        var autoMLSecurityConfigResult = CreateAutoMLSecurityConfig();
        factoryAction?.Invoke(autoMLSecurityConfigResult);

        return autoMLSecurityConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.AutoMLSecurityConfig CreateAutoMLSecurityConfig()
    {
        var autoMLSecurityConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.AutoMLSecurityConfig();

        return autoMLSecurityConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AutoMLJobTypes.AutoMLSecurityConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerAutoMLJobAutoMLSecurityConfigFactoryExtensions
{
    public static CombinedResult<InnerAutoMLJobAutoMLSecurityConfigFactory, InnerAutoMLJobVpcConfigFactory> WithVpcConfig(this InnerAutoMLJobAutoMLSecurityConfigFactory parentFactory, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerAutoMLJobVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerAutoMLJobAutoMLSecurityConfigFactory, T1, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerAutoMLJobAutoMLSecurityConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLSecurityConfigFactory, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerAutoMLJobAutoMLSecurityConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLSecurityConfigFactory, T1, T2, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerAutoMLJobAutoMLSecurityConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLSecurityConfigFactory, T2, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerAutoMLJobAutoMLSecurityConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLSecurityConfigFactory, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLSecurityConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLSecurityConfigFactory, T1, T2, T3, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerAutoMLJobAutoMLSecurityConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLSecurityConfigFactory, T2, T3, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerAutoMLJobAutoMLSecurityConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLSecurityConfigFactory, T3, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLSecurityConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLSecurityConfigFactory, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLSecurityConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLSecurityConfigFactory, T1, T2, T3, T4, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerAutoMLJobAutoMLSecurityConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLSecurityConfigFactory, T2, T3, T4, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutoMLJobAutoMLSecurityConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLSecurityConfigFactory, T3, T4, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLSecurityConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLSecurityConfigFactory, T4, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLSecurityConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAutoMLJobAutoMLSecurityConfigFactory, InnerAutoMLJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutoMLJobAutoMLSecurityConfigFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction).T2);
}
