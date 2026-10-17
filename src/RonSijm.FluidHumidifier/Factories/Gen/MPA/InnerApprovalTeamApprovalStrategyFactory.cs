// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MPA;

public class InnerApprovalTeamApprovalStrategyFactory(Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> factoryAction = null) : SubResourceFactory<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy>
{

    internal InnerApprovalTeamMofNApprovalStrategyFactory MofNFactory { get; set; }

    protected override Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy Create()
    {
        var approvalStrategyResult = CreateApprovalStrategy();
        factoryAction?.Invoke(approvalStrategyResult);

        return approvalStrategyResult;
    }

    private Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy CreateApprovalStrategy()
    {
        var approvalStrategyResult = new Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy();

        return approvalStrategyResult;
    }
    public override void CreateChildren(Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy result)
    {
        base.CreateChildren(result);

        result.MofN ??= MofNFactory?.Build();
    }

} // End Of Class

public static class InnerApprovalTeamApprovalStrategyFactoryExtensions
{
    public static CombinedResult<InnerApprovalTeamApprovalStrategyFactory, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN(this InnerApprovalTeamApprovalStrategyFactory parentFactory, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null)
    {
        parentFactory.MofNFactory = new InnerApprovalTeamMofNApprovalStrategyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MofNFactory);
    }

    public static CombinedResult<InnerApprovalTeamApprovalStrategyFactory, T1, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1>(this CombinedResult<InnerApprovalTeamApprovalStrategyFactory, T1> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithMofN(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApprovalTeamApprovalStrategyFactory, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1>(this CombinedResult<T1, InnerApprovalTeamApprovalStrategyFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithMofN(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerApprovalTeamApprovalStrategyFactory, T1, T2, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2>(this CombinedResult<InnerApprovalTeamApprovalStrategyFactory, T1, T2> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApprovalTeamApprovalStrategyFactory, T2, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2>(this CombinedResult<T1, InnerApprovalTeamApprovalStrategyFactory, T2> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApprovalTeamApprovalStrategyFactory, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2>(this CombinedResult<T1, T2, InnerApprovalTeamApprovalStrategyFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerApprovalTeamApprovalStrategyFactory, T1, T2, T3, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2, T3>(this CombinedResult<InnerApprovalTeamApprovalStrategyFactory, T1, T2, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApprovalTeamApprovalStrategyFactory, T2, T3, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2, T3>(this CombinedResult<T1, InnerApprovalTeamApprovalStrategyFactory, T2, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApprovalTeamApprovalStrategyFactory, T3, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2, T3>(this CombinedResult<T1, T2, InnerApprovalTeamApprovalStrategyFactory, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerApprovalTeamApprovalStrategyFactory, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApprovalTeamApprovalStrategyFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerApprovalTeamApprovalStrategyFactory, T1, T2, T3, T4, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2, T3, T4>(this CombinedResult<InnerApprovalTeamApprovalStrategyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerApprovalTeamApprovalStrategyFactory, T2, T3, T4, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2, T3, T4>(this CombinedResult<T1, InnerApprovalTeamApprovalStrategyFactory, T2, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerApprovalTeamApprovalStrategyFactory, T3, T4, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApprovalTeamApprovalStrategyFactory, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerApprovalTeamApprovalStrategyFactory, T4, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApprovalTeamApprovalStrategyFactory, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerApprovalTeamApprovalStrategyFactory, InnerApprovalTeamMofNApprovalStrategyFactory> WithMofN<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApprovalTeamApprovalStrategyFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMofN(combinedResult.T5, subFactoryAction).T2);
}
