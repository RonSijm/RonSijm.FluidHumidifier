// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeSubjectAlternativeNamesFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNames> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNames>
{

    internal InnerVirtualNodeSubjectAlternativeNameMatchersFactory MatchFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNames Create()
    {
        var subjectAlternativeNamesResult = CreateSubjectAlternativeNames();
        factoryAction?.Invoke(subjectAlternativeNamesResult);

        return subjectAlternativeNamesResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNames CreateSubjectAlternativeNames()
    {
        var subjectAlternativeNamesResult = new Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNames();

        return subjectAlternativeNamesResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNames result)
    {
        base.CreateChildren(result);

        result.Match ??= MatchFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeSubjectAlternativeNamesFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeSubjectAlternativeNamesFactory, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch(this InnerVirtualNodeSubjectAlternativeNamesFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null)
    {
        parentFactory.MatchFactory = new InnerVirtualNodeSubjectAlternativeNameMatchersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchFactory);
    }

    public static CombinedResult<InnerVirtualNodeSubjectAlternativeNamesFactory, T1, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1>(this CombinedResult<InnerVirtualNodeSubjectAlternativeNamesFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeSubjectAlternativeNamesFactory, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1>(this CombinedResult<T1, InnerVirtualNodeSubjectAlternativeNamesFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeSubjectAlternativeNamesFactory, T1, T2, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2>(this CombinedResult<InnerVirtualNodeSubjectAlternativeNamesFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeSubjectAlternativeNamesFactory, T2, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2>(this CombinedResult<T1, InnerVirtualNodeSubjectAlternativeNamesFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeSubjectAlternativeNamesFactory, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeSubjectAlternativeNamesFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeSubjectAlternativeNamesFactory, T1, T2, T3, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3>(this CombinedResult<InnerVirtualNodeSubjectAlternativeNamesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeSubjectAlternativeNamesFactory, T2, T3, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeSubjectAlternativeNamesFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeSubjectAlternativeNamesFactory, T3, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeSubjectAlternativeNamesFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeSubjectAlternativeNamesFactory, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeSubjectAlternativeNamesFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeSubjectAlternativeNamesFactory, T1, T2, T3, T4, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeSubjectAlternativeNamesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeSubjectAlternativeNamesFactory, T2, T3, T4, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeSubjectAlternativeNamesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeSubjectAlternativeNamesFactory, T3, T4, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeSubjectAlternativeNamesFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeSubjectAlternativeNamesFactory, T4, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeSubjectAlternativeNamesFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeSubjectAlternativeNamesFactory, InnerVirtualNodeSubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeSubjectAlternativeNamesFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T5, subFactoryAction));
}
