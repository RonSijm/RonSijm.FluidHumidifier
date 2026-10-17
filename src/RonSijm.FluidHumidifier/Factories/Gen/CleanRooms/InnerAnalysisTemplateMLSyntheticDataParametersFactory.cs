// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateMLSyntheticDataParametersFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters>
{

    internal InnerAnalysisTemplateColumnClassificationDetailsFactory ColumnClassificationFactory { get; set; }

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters Create()
    {
        var mLSyntheticDataParametersResult = CreateMLSyntheticDataParameters();
        factoryAction?.Invoke(mLSyntheticDataParametersResult);

        return mLSyntheticDataParametersResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters CreateMLSyntheticDataParameters()
    {
        var mLSyntheticDataParametersResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters();

        return mLSyntheticDataParametersResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters result)
    {
        base.CreateChildren(result);

        result.ColumnClassification ??= ColumnClassificationFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisTemplateMLSyntheticDataParametersFactoryExtensions
{
    public static CombinedResult<InnerAnalysisTemplateMLSyntheticDataParametersFactory, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification(this InnerAnalysisTemplateMLSyntheticDataParametersFactory parentFactory, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null)
    {
        parentFactory.ColumnClassificationFactory = new InnerAnalysisTemplateColumnClassificationDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ColumnClassificationFactory);
    }

    public static CombinedResult<InnerAnalysisTemplateMLSyntheticDataParametersFactory, T1, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1>(this CombinedResult<InnerAnalysisTemplateMLSyntheticDataParametersFactory, T1> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumnClassification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateMLSyntheticDataParametersFactory, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1>(this CombinedResult<T1, InnerAnalysisTemplateMLSyntheticDataParametersFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithColumnClassification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateMLSyntheticDataParametersFactory, T1, T2, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2>(this CombinedResult<InnerAnalysisTemplateMLSyntheticDataParametersFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T2, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2>(this CombinedResult<T1, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateMLSyntheticDataParametersFactory, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisTemplateMLSyntheticDataParametersFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateMLSyntheticDataParametersFactory, T1, T2, T3, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2, T3>(this CombinedResult<InnerAnalysisTemplateMLSyntheticDataParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T2, T3, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T3, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateMLSyntheticDataParametersFactory, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateMLSyntheticDataParametersFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateMLSyntheticDataParametersFactory, T1, T2, T3, T4, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisTemplateMLSyntheticDataParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T2, T3, T4, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T3, T4, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T4, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateMLSyntheticDataParametersFactory, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateMLSyntheticDataParametersFactory, InnerAnalysisTemplateColumnClassificationDetailsFactory> WithColumnClassification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateMLSyntheticDataParametersFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColumnClassification(combinedResult.T5, subFactoryAction).T2);
}
