// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class SegmentDefinitionFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.SegmentDefinition> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.SegmentDefinition>(resourceName)
{

    internal InnerSegmentDefinitionSegmentGroupFactory SegmentGroupsFactory { get; set; }

    protected override Humidifier.CustomerProfiles.SegmentDefinition Create()
    {
        var segmentDefinitionResult = CreateSegmentDefinition();
        factoryAction?.Invoke(segmentDefinitionResult);

        return segmentDefinitionResult;
    }

    private Humidifier.CustomerProfiles.SegmentDefinition CreateSegmentDefinition()
    {
        var segmentDefinitionResult = new Humidifier.CustomerProfiles.SegmentDefinition
        {
            GivenName = InputResourceName,
        };

        return segmentDefinitionResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.SegmentDefinition result)
    {
        base.CreateChildren(result);

        result.SegmentGroups ??= SegmentGroupsFactory?.Build();
    }

} // End Of Class

public static class SegmentDefinitionFactoryExtensions
{
    public static CombinedResult<SegmentDefinitionFactory, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups(this SegmentDefinitionFactory parentFactory, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null)
    {
        parentFactory.SegmentGroupsFactory = new InnerSegmentDefinitionSegmentGroupFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SegmentGroupsFactory);
    }

    public static CombinedResult<SegmentDefinitionFactory, T1, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1>(this CombinedResult<SegmentDefinitionFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithSegmentGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentDefinitionFactory, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1>(this CombinedResult<T1, SegmentDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, WithSegmentGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SegmentDefinitionFactory, T1, T2, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2>(this CombinedResult<SegmentDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentDefinitionFactory, T2, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2>(this CombinedResult<T1, SegmentDefinitionFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SegmentDefinitionFactory, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2>(this CombinedResult<T1, T2, SegmentDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SegmentDefinitionFactory, T1, T2, T3, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2, T3>(this CombinedResult<SegmentDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentDefinitionFactory, T2, T3, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2, T3>(this CombinedResult<T1, SegmentDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SegmentDefinitionFactory, T3, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2, T3>(this CombinedResult<T1, T2, SegmentDefinitionFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SegmentDefinitionFactory, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2, T3>(this CombinedResult<T1, T2, T3, SegmentDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SegmentDefinitionFactory, T1, T2, T3, T4, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<SegmentDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentDefinitionFactory, T2, T3, T4, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<T1, SegmentDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SegmentDefinitionFactory, T3, T4, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<T1, T2, SegmentDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SegmentDefinitionFactory, T4, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SegmentDefinitionFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SegmentDefinitionFactory, InnerSegmentDefinitionSegmentGroupFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SegmentDefinitionFactory> combinedResult, Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T5, subFactoryAction));
}
