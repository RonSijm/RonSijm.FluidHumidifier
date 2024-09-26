// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class MissionProfileFactory(string resourceName = null, Action<Humidifier.GroundStation.MissionProfile> factoryAction = null) : ResourceFactory<Humidifier.GroundStation.MissionProfile>(resourceName)
{

    internal List<InnerMissionProfileDataflowEdgeFactory> DataflowEdgesFactories { get; set; } = [];

    internal InnerMissionProfileStreamsKmsKeyFactory StreamsKmsKeyFactory { get; set; }

    protected override Humidifier.GroundStation.MissionProfile Create()
    {
        var missionProfileResult = CreateMissionProfile();
        factoryAction?.Invoke(missionProfileResult);

        return missionProfileResult;
    }

    private Humidifier.GroundStation.MissionProfile CreateMissionProfile()
    {
        var missionProfileResult = new Humidifier.GroundStation.MissionProfile
        {
            GivenName = InputResourceName,
        };

        return missionProfileResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.MissionProfile result)
    {
        base.CreateChildren(result);

        result.DataflowEdges = DataflowEdgesFactories.Any() ? DataflowEdgesFactories.Select(x => x.Build()).ToList() : null;
        result.StreamsKmsKey ??= StreamsKmsKeyFactory?.Build();
    }

} // End Of Class

public static class MissionProfileFactoryExtensions
{
    public static CombinedResult<MissionProfileFactory, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges(this MissionProfileFactory parentFactory, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null)
    {
        var factory = new InnerMissionProfileDataflowEdgeFactory(subFactoryAction);
        parentFactory.DataflowEdgesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MissionProfileFactory, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey(this MissionProfileFactory parentFactory, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null)
    {
        parentFactory.StreamsKmsKeyFactory = new InnerMissionProfileStreamsKmsKeyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamsKmsKeyFactory);
    }

    public static CombinedResult<MissionProfileFactory, T1, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1>(this CombinedResult<MissionProfileFactory, T1> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataflowEdges(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MissionProfileFactory, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1>(this CombinedResult<T1, MissionProfileFactory> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataflowEdges(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MissionProfileFactory, T1, T2, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2>(this CombinedResult<MissionProfileFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MissionProfileFactory, T2, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2>(this CombinedResult<T1, MissionProfileFactory, T2> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MissionProfileFactory, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2>(this CombinedResult<T1, T2, MissionProfileFactory> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MissionProfileFactory, T1, T2, T3, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2, T3>(this CombinedResult<MissionProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MissionProfileFactory, T2, T3, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2, T3>(this CombinedResult<T1, MissionProfileFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MissionProfileFactory, T3, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2, T3>(this CombinedResult<T1, T2, MissionProfileFactory, T3> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MissionProfileFactory, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2, T3>(this CombinedResult<T1, T2, T3, MissionProfileFactory> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MissionProfileFactory, T1, T2, T3, T4, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2, T3, T4>(this CombinedResult<MissionProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MissionProfileFactory, T2, T3, T4, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2, T3, T4>(this CombinedResult<T1, MissionProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MissionProfileFactory, T3, T4, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2, T3, T4>(this CombinedResult<T1, T2, MissionProfileFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MissionProfileFactory, T4, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MissionProfileFactory, T4> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MissionProfileFactory, InnerMissionProfileDataflowEdgeFactory> WithDataflowEdges<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MissionProfileFactory> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataflowEdges(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MissionProfileFactory, T1, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1>(this CombinedResult<MissionProfileFactory, T1> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MissionProfileFactory, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1>(this CombinedResult<T1, MissionProfileFactory> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MissionProfileFactory, T1, T2, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2>(this CombinedResult<MissionProfileFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MissionProfileFactory, T2, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2>(this CombinedResult<T1, MissionProfileFactory, T2> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MissionProfileFactory, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2>(this CombinedResult<T1, T2, MissionProfileFactory> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MissionProfileFactory, T1, T2, T3, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2, T3>(this CombinedResult<MissionProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MissionProfileFactory, T2, T3, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2, T3>(this CombinedResult<T1, MissionProfileFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MissionProfileFactory, T3, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2, T3>(this CombinedResult<T1, T2, MissionProfileFactory, T3> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MissionProfileFactory, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2, T3>(this CombinedResult<T1, T2, T3, MissionProfileFactory> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MissionProfileFactory, T1, T2, T3, T4, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2, T3, T4>(this CombinedResult<MissionProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MissionProfileFactory, T2, T3, T4, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2, T3, T4>(this CombinedResult<T1, MissionProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MissionProfileFactory, T3, T4, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, MissionProfileFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MissionProfileFactory, T4, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MissionProfileFactory, T4> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MissionProfileFactory, InnerMissionProfileStreamsKmsKeyFactory> WithStreamsKmsKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MissionProfileFactory> combinedResult, Action<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamsKmsKey(combinedResult.T5, subFactoryAction));
}
