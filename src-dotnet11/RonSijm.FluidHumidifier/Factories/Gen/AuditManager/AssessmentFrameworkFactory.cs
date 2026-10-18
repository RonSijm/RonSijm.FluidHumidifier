// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AuditManager;

public class AssessmentFrameworkFactory(string resourceName = null, Action<Humidifier.AuditManager.AssessmentFramework> factoryAction = null) : ResourceFactory<Humidifier.AuditManager.AssessmentFramework>(resourceName)
{

    internal List<InnerAssessmentFrameworkControlSetFactory> ControlSetsFactories { get; set; } = [];

    protected override Humidifier.AuditManager.AssessmentFramework Create()
    {
        var assessmentFrameworkResult = CreateAssessmentFramework();
        factoryAction?.Invoke(assessmentFrameworkResult);

        return assessmentFrameworkResult;
    }

    private Humidifier.AuditManager.AssessmentFramework CreateAssessmentFramework()
    {
        var assessmentFrameworkResult = new Humidifier.AuditManager.AssessmentFramework
        {
            GivenName = InputResourceName,
        };

        return assessmentFrameworkResult;
    }
    public override void CreateChildren(Humidifier.AuditManager.AssessmentFramework result)
    {
        base.CreateChildren(result);

        result.ControlSets = ControlSetsFactories.Any() ? ControlSetsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AssessmentFrameworkFactoryExtensions
{
    public static CombinedResult<AssessmentFrameworkFactory, InnerAssessmentFrameworkControlSetFactory> WithControlSets(this AssessmentFrameworkFactory parentFactory, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null)
    {
        var factory = new InnerAssessmentFrameworkControlSetFactory(subFactoryAction);
        parentFactory.ControlSetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AssessmentFrameworkFactory, T1, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1>(this CombinedResult<AssessmentFrameworkFactory, T1> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithControlSets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssessmentFrameworkFactory, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1>(this CombinedResult<T1, AssessmentFrameworkFactory> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithControlSets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AssessmentFrameworkFactory, T1, T2, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2>(this CombinedResult<AssessmentFrameworkFactory, T1, T2> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssessmentFrameworkFactory, T2, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2>(this CombinedResult<T1, AssessmentFrameworkFactory, T2> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AssessmentFrameworkFactory, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2>(this CombinedResult<T1, T2, AssessmentFrameworkFactory> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AssessmentFrameworkFactory, T1, T2, T3, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2, T3>(this CombinedResult<AssessmentFrameworkFactory, T1, T2, T3> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssessmentFrameworkFactory, T2, T3, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2, T3>(this CombinedResult<T1, AssessmentFrameworkFactory, T2, T3> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AssessmentFrameworkFactory, T3, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2, T3>(this CombinedResult<T1, T2, AssessmentFrameworkFactory, T3> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AssessmentFrameworkFactory, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2, T3>(this CombinedResult<T1, T2, T3, AssessmentFrameworkFactory> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AssessmentFrameworkFactory, T1, T2, T3, T4, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2, T3, T4>(this CombinedResult<AssessmentFrameworkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AssessmentFrameworkFactory, T2, T3, T4, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2, T3, T4>(this CombinedResult<T1, AssessmentFrameworkFactory, T2, T3, T4> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AssessmentFrameworkFactory, T3, T4, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2, T3, T4>(this CombinedResult<T1, T2, AssessmentFrameworkFactory, T3, T4> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AssessmentFrameworkFactory, T4, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AssessmentFrameworkFactory, T4> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AssessmentFrameworkFactory, InnerAssessmentFrameworkControlSetFactory> WithControlSets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AssessmentFrameworkFactory> combinedResult, Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlSets(combinedResult.T5, subFactoryAction).T2);
}
