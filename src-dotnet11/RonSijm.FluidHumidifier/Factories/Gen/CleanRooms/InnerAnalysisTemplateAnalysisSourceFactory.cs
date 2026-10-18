// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateAnalysisSourceFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource>
{

    internal InnerAnalysisTemplateAnalysisTemplateArtifactsFactory ArtifactsFactory { get; set; }

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource Create()
    {
        var analysisSourceResult = CreateAnalysisSource();
        factoryAction?.Invoke(analysisSourceResult);

        return analysisSourceResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource CreateAnalysisSource()
    {
        var analysisSourceResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource();

        return analysisSourceResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource result)
    {
        base.CreateChildren(result);

        result.Artifacts ??= ArtifactsFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisTemplateAnalysisSourceFactoryExtensions
{
    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceFactory, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts(this InnerAnalysisTemplateAnalysisSourceFactory parentFactory, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null)
    {
        parentFactory.ArtifactsFactory = new InnerAnalysisTemplateAnalysisTemplateArtifactsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ArtifactsFactory);
    }

    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceFactory, T1, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1>(this CombinedResult<InnerAnalysisTemplateAnalysisSourceFactory, T1> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifacts(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceFactory, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, WithArtifacts(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceFactory, T1, T2, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2>(this CombinedResult<InnerAnalysisTemplateAnalysisSourceFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceFactory, T2, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceFactory, T2> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceFactory, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceFactory, T1, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2, T3>(this CombinedResult<InnerAnalysisTemplateAnalysisSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceFactory, T2, T3, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceFactory, T3, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceFactory, T3> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisSourceFactory, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisSourceFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAnalysisTemplateAnalysisSourceFactory, T1, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisTemplateAnalysisSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceFactory, T2, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisTemplateAnalysisSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceFactory, T3, T4, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisTemplateAnalysisSourceFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisSourceFactory, T4, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisTemplateAnalysisSourceFactory, T4> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisSourceFactory, InnerAnalysisTemplateAnalysisTemplateArtifactsFactory> WithArtifacts<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisTemplateAnalysisSourceFactory> combinedResult, Action<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArtifacts(combinedResult.T5, subFactoryAction).T2);
}
