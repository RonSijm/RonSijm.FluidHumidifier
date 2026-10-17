// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateAnalysisTemplateArtifactsFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts>
{

    internal InnerAnalysisTemplateAnalysisTemplateArtifactFactory EntryPointFactory { get; set; }

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts Create()
    {
        var analysisTemplateArtifactsResult = CreateAnalysisTemplateArtifacts();
        factoryAction?.Invoke(analysisTemplateArtifactsResult);

        return analysisTemplateArtifactsResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts CreateAnalysisTemplateArtifacts()
    {
        var analysisTemplateArtifactsResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts();

        return analysisTemplateArtifactsResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts result)
    {
        base.CreateChildren(result);

        result.EntryPoint ??= EntryPointFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisTemplateAnalysisTemplateArtifactsFactoryExtensions
{
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint(this InnerAnalysisTemplateAnalysisTemplateArtifactsFactory parentFactory, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null)
    {
        parentFactory.EntryPointFactory = new InnerAnalysisTemplateAnalysisTemplateArtifactFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EntryPointFactory);
    }

    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T1, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T1> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntryPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntryPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T2, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2, T3>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T3, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T1, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T4, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory, InnerAnalysisTemplateAnalysisTemplateArtifactFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T5, subFactoryAction).T2);
}
