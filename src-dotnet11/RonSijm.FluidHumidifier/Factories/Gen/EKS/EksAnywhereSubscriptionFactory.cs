// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class EksAnywhereSubscriptionFactory(string resourceName = null, Action<Humidifier.EKS.EksAnywhereSubscription> factoryAction = null) : ResourceFactory<Humidifier.EKS.EksAnywhereSubscription>(resourceName)
{

    internal InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory TermFactory { get; set; }

    protected override Humidifier.EKS.EksAnywhereSubscription Create()
    {
        var eksAnywhereSubscriptionResult = CreateEksAnywhereSubscription();
        factoryAction?.Invoke(eksAnywhereSubscriptionResult);

        return eksAnywhereSubscriptionResult;
    }

    private Humidifier.EKS.EksAnywhereSubscription CreateEksAnywhereSubscription()
    {
        var eksAnywhereSubscriptionResult = new Humidifier.EKS.EksAnywhereSubscription
        {
            GivenName = InputResourceName,
        };

        return eksAnywhereSubscriptionResult;
    }
    public override void CreateChildren(Humidifier.EKS.EksAnywhereSubscription result)
    {
        base.CreateChildren(result);

        result.Term ??= TermFactory?.Build();
    }

} // End Of Class

public static class EksAnywhereSubscriptionFactoryExtensions
{
    public static CombinedResult<EksAnywhereSubscriptionFactory, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm(this EksAnywhereSubscriptionFactory parentFactory, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null)
    {
        parentFactory.TermFactory = new InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TermFactory);
    }

    public static CombinedResult<EksAnywhereSubscriptionFactory, T1, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1>(this CombinedResult<EksAnywhereSubscriptionFactory, T1> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, WithTerm(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EksAnywhereSubscriptionFactory, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1>(this CombinedResult<T1, EksAnywhereSubscriptionFactory> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, WithTerm(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EksAnywhereSubscriptionFactory, T1, T2, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2>(this CombinedResult<EksAnywhereSubscriptionFactory, T1, T2> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EksAnywhereSubscriptionFactory, T2, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2>(this CombinedResult<T1, EksAnywhereSubscriptionFactory, T2> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EksAnywhereSubscriptionFactory, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2>(this CombinedResult<T1, T2, EksAnywhereSubscriptionFactory> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EksAnywhereSubscriptionFactory, T1, T2, T3, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2, T3>(this CombinedResult<EksAnywhereSubscriptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EksAnywhereSubscriptionFactory, T2, T3, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2, T3>(this CombinedResult<T1, EksAnywhereSubscriptionFactory, T2, T3> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EksAnywhereSubscriptionFactory, T3, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2, T3>(this CombinedResult<T1, T2, EksAnywhereSubscriptionFactory, T3> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EksAnywhereSubscriptionFactory, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2, T3>(this CombinedResult<T1, T2, T3, EksAnywhereSubscriptionFactory> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EksAnywhereSubscriptionFactory, T1, T2, T3, T4, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2, T3, T4>(this CombinedResult<EksAnywhereSubscriptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EksAnywhereSubscriptionFactory, T2, T3, T4, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2, T3, T4>(this CombinedResult<T1, EksAnywhereSubscriptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EksAnywhereSubscriptionFactory, T3, T4, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2, T3, T4>(this CombinedResult<T1, T2, EksAnywhereSubscriptionFactory, T3, T4> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EksAnywhereSubscriptionFactory, T4, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EksAnywhereSubscriptionFactory, T4> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EksAnywhereSubscriptionFactory, InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory> WithTerm<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EksAnywhereSubscriptionFactory> combinedResult, Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerm(combinedResult.T5, subFactoryAction).T2);
}
