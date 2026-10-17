// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeExtractedParameterFactory(Action<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter>
{

    internal InnerConnectionTypeResponseExtractionMappingFactory ValueFactory { get; set; }

    protected override Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter Create()
    {
        var extractedParameterResult = CreateExtractedParameter();
        factoryAction?.Invoke(extractedParameterResult);

        return extractedParameterResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter CreateExtractedParameter()
    {
        var extractedParameterResult = new Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter();

        return extractedParameterResult;
    }
    public override void CreateChildren(Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter result)
    {
        base.CreateChildren(result);

        result.Value ??= ValueFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionTypeExtractedParameterFactoryExtensions
{
    public static CombinedResult<InnerConnectionTypeExtractedParameterFactory, InnerConnectionTypeResponseExtractionMappingFactory> WithValue(this InnerConnectionTypeExtractedParameterFactory parentFactory, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null)
    {
        parentFactory.ValueFactory = new InnerConnectionTypeResponseExtractionMappingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValueFactory);
    }

    public static CombinedResult<InnerConnectionTypeExtractedParameterFactory, T1, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1>(this CombinedResult<InnerConnectionTypeExtractedParameterFactory, T1> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeExtractedParameterFactory, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1>(this CombinedResult<T1, InnerConnectionTypeExtractedParameterFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeExtractedParameterFactory, T1, T2, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2>(this CombinedResult<InnerConnectionTypeExtractedParameterFactory, T1, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeExtractedParameterFactory, T2, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2>(this CombinedResult<T1, InnerConnectionTypeExtractedParameterFactory, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeExtractedParameterFactory, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2>(this CombinedResult<T1, T2, InnerConnectionTypeExtractedParameterFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeExtractedParameterFactory, T1, T2, T3, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2, T3>(this CombinedResult<InnerConnectionTypeExtractedParameterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeExtractedParameterFactory, T2, T3, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, InnerConnectionTypeExtractedParameterFactory, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeExtractedParameterFactory, T3, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionTypeExtractedParameterFactory, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeExtractedParameterFactory, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionTypeExtractedParameterFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeExtractedParameterFactory, T1, T2, T3, T4, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<InnerConnectionTypeExtractedParameterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeExtractedParameterFactory, T2, T3, T4, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionTypeExtractedParameterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeExtractedParameterFactory, T3, T4, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionTypeExtractedParameterFactory, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeExtractedParameterFactory, T4, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionTypeExtractedParameterFactory, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionTypeExtractedParameterFactory, InnerConnectionTypeResponseExtractionMappingFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionTypeExtractedParameterFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T5, subFactoryAction).T2);
}
