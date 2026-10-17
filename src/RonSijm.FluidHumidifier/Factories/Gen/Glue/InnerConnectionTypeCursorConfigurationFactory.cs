// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeCursorConfigurationFactory(Action<Humidifier.Glue.ConnectionTypeTypes.CursorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.CursorConfiguration>
{

    internal InnerConnectionTypeExtractedParameterFactory LimitParameterFactory { get; set; }

    internal InnerConnectionTypeExtractedParameterFactory NextPageFactory { get; set; }

    protected override Humidifier.Glue.ConnectionTypeTypes.CursorConfiguration Create()
    {
        var cursorConfigurationResult = CreateCursorConfiguration();
        factoryAction?.Invoke(cursorConfigurationResult);

        return cursorConfigurationResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.CursorConfiguration CreateCursorConfiguration()
    {
        var cursorConfigurationResult = new Humidifier.Glue.ConnectionTypeTypes.CursorConfiguration();

        return cursorConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Glue.ConnectionTypeTypes.CursorConfiguration result)
    {
        base.CreateChildren(result);

        result.LimitParameter ??= LimitParameterFactory?.Build();
        result.NextPage ??= NextPageFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionTypeCursorConfigurationFactoryExtensions
{
    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter(this InnerConnectionTypeCursorConfigurationFactory parentFactory, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null)
    {
        parentFactory.LimitParameterFactory = new InnerConnectionTypeExtractedParameterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LimitParameterFactory);
    }

    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithNextPage(this InnerConnectionTypeCursorConfigurationFactory parentFactory, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null)
    {
        parentFactory.NextPageFactory = new InnerConnectionTypeExtractedParameterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NextPageFactory);
    }

    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1>(this CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLimitParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1>(this CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLimitParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2>(this CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2>(this CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2>(this CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, T3, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2, T3>(this CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, T3, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2, T3>(this CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, T3, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionTypeCursorConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, T3, T4, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2, T3, T4>(this CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, T3, T4, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, T3, T4, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeCursorConfigurationFactory, T4, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionTypeCursorConfigurationFactory, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithLimitParameter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionTypeCursorConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimitParameter(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1>(this CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithNextPage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1>(this CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithNextPage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2>(this CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2>(this CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2>(this CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, T3, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2, T3>(this CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, T3, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2, T3>(this CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, T3, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionTypeCursorConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, T3, T4, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2, T3, T4>(this CombinedResult<InnerConnectionTypeCursorConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, T3, T4, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionTypeCursorConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, T3, T4, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionTypeCursorConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeCursorConfigurationFactory, T4, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionTypeCursorConfigurationFactory, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionTypeCursorConfigurationFactory, InnerConnectionTypeExtractedParameterFactory> WithNextPage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionTypeCursorConfigurationFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNextPage(combinedResult.T5, subFactoryAction).T2);
}
