// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewaySubjectAlternativeNamesFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNames> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNames>
{

    internal InnerVirtualGatewaySubjectAlternativeNameMatchersFactory MatchFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNames Create()
    {
        var subjectAlternativeNamesResult = CreateSubjectAlternativeNames();
        factoryAction?.Invoke(subjectAlternativeNamesResult);

        return subjectAlternativeNamesResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNames CreateSubjectAlternativeNames()
    {
        var subjectAlternativeNamesResult = new Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNames();

        return subjectAlternativeNamesResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNames result)
    {
        base.CreateChildren(result);

        result.Match ??= MatchFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualGatewaySubjectAlternativeNamesFactoryExtensions
{
    public static CombinedResult<InnerVirtualGatewaySubjectAlternativeNamesFactory, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch(this InnerVirtualGatewaySubjectAlternativeNamesFactory parentFactory, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null)
    {
        parentFactory.MatchFactory = new InnerVirtualGatewaySubjectAlternativeNameMatchersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchFactory);
    }

    public static CombinedResult<InnerVirtualGatewaySubjectAlternativeNamesFactory, T1, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1>(this CombinedResult<InnerVirtualGatewaySubjectAlternativeNamesFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewaySubjectAlternativeNamesFactory, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1>(this CombinedResult<T1, InnerVirtualGatewaySubjectAlternativeNamesFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewaySubjectAlternativeNamesFactory, T1, T2, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2>(this CombinedResult<InnerVirtualGatewaySubjectAlternativeNamesFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewaySubjectAlternativeNamesFactory, T2, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2>(this CombinedResult<T1, InnerVirtualGatewaySubjectAlternativeNamesFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewaySubjectAlternativeNamesFactory, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2>(this CombinedResult<T1, T2, InnerVirtualGatewaySubjectAlternativeNamesFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewaySubjectAlternativeNamesFactory, T1, T2, T3, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3>(this CombinedResult<InnerVirtualGatewaySubjectAlternativeNamesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewaySubjectAlternativeNamesFactory, T2, T3, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, InnerVirtualGatewaySubjectAlternativeNamesFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewaySubjectAlternativeNamesFactory, T3, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualGatewaySubjectAlternativeNamesFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewaySubjectAlternativeNamesFactory, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualGatewaySubjectAlternativeNamesFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewaySubjectAlternativeNamesFactory, T1, T2, T3, T4, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<InnerVirtualGatewaySubjectAlternativeNamesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewaySubjectAlternativeNamesFactory, T2, T3, T4, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualGatewaySubjectAlternativeNamesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewaySubjectAlternativeNamesFactory, T3, T4, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualGatewaySubjectAlternativeNamesFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewaySubjectAlternativeNamesFactory, T4, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualGatewaySubjectAlternativeNamesFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualGatewaySubjectAlternativeNamesFactory, InnerVirtualGatewaySubjectAlternativeNameMatchersFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualGatewaySubjectAlternativeNamesFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T5, subFactoryAction));
}
