// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainRStudioServerProDomainSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings>
{

    internal InnerDomainResourceSpecFactory DefaultResourceSpecFactory { get; set; }

    protected override Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings Create()
    {
        var rStudioServerProDomainSettingsResult = CreateRStudioServerProDomainSettings();
        factoryAction?.Invoke(rStudioServerProDomainSettingsResult);

        return rStudioServerProDomainSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings CreateRStudioServerProDomainSettings()
    {
        var rStudioServerProDomainSettingsResult = new Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings();

        return rStudioServerProDomainSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings result)
    {
        base.CreateChildren(result);

        result.DefaultResourceSpec ??= DefaultResourceSpecFactory?.Build();
    }

} // End Of Class

public static class InnerDomainRStudioServerProDomainSettingsFactoryExtensions
{
    public static CombinedResult<InnerDomainRStudioServerProDomainSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec(this InnerDomainRStudioServerProDomainSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.DefaultResourceSpecFactory = new InnerDomainResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResourceSpecFactory);
    }

    public static CombinedResult<InnerDomainRStudioServerProDomainSettingsFactory, T1, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<InnerDomainRStudioServerProDomainSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainRStudioServerProDomainSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1>(this CombinedResult<T1, InnerDomainRStudioServerProDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainRStudioServerProDomainSettingsFactory, T1, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<InnerDomainRStudioServerProDomainSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainRStudioServerProDomainSettingsFactory, T2, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, InnerDomainRStudioServerProDomainSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainRStudioServerProDomainSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2>(this CombinedResult<T1, T2, InnerDomainRStudioServerProDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainRStudioServerProDomainSettingsFactory, T1, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<InnerDomainRStudioServerProDomainSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainRStudioServerProDomainSettingsFactory, T2, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, InnerDomainRStudioServerProDomainSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainRStudioServerProDomainSettingsFactory, T3, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainRStudioServerProDomainSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainRStudioServerProDomainSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainRStudioServerProDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainRStudioServerProDomainSettingsFactory, T1, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<InnerDomainRStudioServerProDomainSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainRStudioServerProDomainSettingsFactory, T2, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainRStudioServerProDomainSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainRStudioServerProDomainSettingsFactory, T3, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainRStudioServerProDomainSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainRStudioServerProDomainSettingsFactory, T4, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainRStudioServerProDomainSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainRStudioServerProDomainSettingsFactory, InnerDomainResourceSpecFactory> WithDefaultResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainRStudioServerProDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResourceSpec(combinedResult.T5, subFactoryAction));
}
