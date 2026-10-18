// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateSyntheticDataParametersFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataParameters> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataParameters>
{

    internal InnerAnalysisTemplateMLSyntheticDataParametersFactory MlSyntheticDataParametersFactory { get; set; }

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataParameters Create()
    {
        var syntheticDataParametersResult = CreateSyntheticDataParameters();
        factoryAction?.Invoke(syntheticDataParametersResult);

        return syntheticDataParametersResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataParameters CreateSyntheticDataParameters()
    {
        var syntheticDataParametersResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataParameters();

        return syntheticDataParametersResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataParameters result)
    {
        base.CreateChildren(result);

        result.MlSyntheticDataParameters ??= MlSyntheticDataParametersFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisTemplateSyntheticDataParametersFactoryExtensions
{
    public static CombinedResult<InnerAnalysisTemplateSyntheticDataParametersFactory, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters(this InnerAnalysisTemplateSyntheticDataParametersFactory parentFactory, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null)
    {
        parentFactory.MlSyntheticDataParametersFactory = new InnerAnalysisTemplateMLSyntheticDataParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MlSyntheticDataParametersFactory);
    }

    public static CombinedResult<InnerAnalysisTemplateSyntheticDataParametersFactory, T1, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1>(this CombinedResult<InnerAnalysisTemplateSyntheticDataParametersFactory, T1> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateSyntheticDataParametersFactory, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1>(this CombinedResult<T1, InnerAnalysisTemplateSyntheticDataParametersFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateSyntheticDataParametersFactory, T1, T2, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2>(this CombinedResult<InnerAnalysisTemplateSyntheticDataParametersFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateSyntheticDataParametersFactory, T2, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2>(this CombinedResult<T1, InnerAnalysisTemplateSyntheticDataParametersFactory, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateSyntheticDataParametersFactory, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisTemplateSyntheticDataParametersFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateSyntheticDataParametersFactory, T1, T2, T3, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2, T3>(this CombinedResult<InnerAnalysisTemplateSyntheticDataParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateSyntheticDataParametersFactory, T2, T3, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisTemplateSyntheticDataParametersFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateSyntheticDataParametersFactory, T3, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisTemplateSyntheticDataParametersFactory, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateSyntheticDataParametersFactory, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateSyntheticDataParametersFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateSyntheticDataParametersFactory, T1, T2, T3, T4, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisTemplateSyntheticDataParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateSyntheticDataParametersFactory, T2, T3, T4, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisTemplateSyntheticDataParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateSyntheticDataParametersFactory, T3, T4, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisTemplateSyntheticDataParametersFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateSyntheticDataParametersFactory, T4, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateSyntheticDataParametersFactory, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateSyntheticDataParametersFactory, InnerAnalysisTemplateMLSyntheticDataParametersFactory> WithMlSyntheticDataParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateSyntheticDataParametersFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMlSyntheticDataParameters(combinedResult.T5, subFactoryAction).T2);
}
