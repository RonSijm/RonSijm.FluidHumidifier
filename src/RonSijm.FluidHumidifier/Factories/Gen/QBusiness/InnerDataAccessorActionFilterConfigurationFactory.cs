// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataAccessorActionFilterConfigurationFactory(Action<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration>
{

    internal InnerDataAccessorAttributeFilterFactory DocumentAttributeFilterFactory { get; set; }

    protected override Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration Create()
    {
        var actionFilterConfigurationResult = CreateActionFilterConfiguration();
        factoryAction?.Invoke(actionFilterConfigurationResult);

        return actionFilterConfigurationResult;
    }

    private Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration CreateActionFilterConfiguration()
    {
        var actionFilterConfigurationResult = new Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration();

        return actionFilterConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataAccessorTypes.ActionFilterConfiguration result)
    {
        base.CreateChildren(result);

        result.DocumentAttributeFilter ??= DocumentAttributeFilterFactory?.Build();
    }

} // End Of Class

public static class InnerDataAccessorActionFilterConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataAccessorActionFilterConfigurationFactory, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter(this InnerDataAccessorActionFilterConfigurationFactory parentFactory, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null)
    {
        parentFactory.DocumentAttributeFilterFactory = new InnerDataAccessorAttributeFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DocumentAttributeFilterFactory);
    }

    public static CombinedResult<InnerDataAccessorActionFilterConfigurationFactory, T1, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1>(this CombinedResult<InnerDataAccessorActionFilterConfigurationFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorActionFilterConfigurationFactory, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1>(this CombinedResult<T1, InnerDataAccessorActionFilterConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataAccessorActionFilterConfigurationFactory, T1, T2, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2>(this CombinedResult<InnerDataAccessorActionFilterConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorActionFilterConfigurationFactory, T2, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2>(this CombinedResult<T1, InnerDataAccessorActionFilterConfigurationFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataAccessorActionFilterConfigurationFactory, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2>(this CombinedResult<T1, T2, InnerDataAccessorActionFilterConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataAccessorActionFilterConfigurationFactory, T1, T2, T3, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2, T3>(this CombinedResult<InnerDataAccessorActionFilterConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorActionFilterConfigurationFactory, T2, T3, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2, T3>(this CombinedResult<T1, InnerDataAccessorActionFilterConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataAccessorActionFilterConfigurationFactory, T3, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataAccessorActionFilterConfigurationFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataAccessorActionFilterConfigurationFactory, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataAccessorActionFilterConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataAccessorActionFilterConfigurationFactory, T1, T2, T3, T4, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2, T3, T4>(this CombinedResult<InnerDataAccessorActionFilterConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataAccessorActionFilterConfigurationFactory, T2, T3, T4, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataAccessorActionFilterConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataAccessorActionFilterConfigurationFactory, T3, T4, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataAccessorActionFilterConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataAccessorActionFilterConfigurationFactory, T4, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataAccessorActionFilterConfigurationFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataAccessorActionFilterConfigurationFactory, InnerDataAccessorAttributeFilterFactory> WithDocumentAttributeFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataAccessorActionFilterConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.AttributeFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeFilter(combinedResult.T5, subFactoryAction));
}
