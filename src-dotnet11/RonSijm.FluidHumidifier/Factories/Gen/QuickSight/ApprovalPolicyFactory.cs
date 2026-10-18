// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class ApprovalPolicyFactory(string resourceName = null, Action<Humidifier.QuickSight.ApprovalPolicy> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.ApprovalPolicy>(resourceName)
{

    internal InnerApprovalPolicyApplicableToFactory ApplicableToFactory { get; set; }

    protected override Humidifier.QuickSight.ApprovalPolicy Create()
    {
        var approvalPolicyResult = CreateApprovalPolicy();
        factoryAction?.Invoke(approvalPolicyResult);

        return approvalPolicyResult;
    }

    private Humidifier.QuickSight.ApprovalPolicy CreateApprovalPolicy()
    {
        var approvalPolicyResult = new Humidifier.QuickSight.ApprovalPolicy
        {
            GivenName = InputResourceName,
        };

        return approvalPolicyResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ApprovalPolicy result)
    {
        base.CreateChildren(result);

        result.ApplicableTo ??= ApplicableToFactory?.Build();
    }

} // End Of Class

public static class ApprovalPolicyFactoryExtensions
{
    public static CombinedResult<ApprovalPolicyFactory, InnerApprovalPolicyApplicableToFactory> WithApplicableTo(this ApprovalPolicyFactory parentFactory, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null)
    {
        parentFactory.ApplicableToFactory = new InnerApprovalPolicyApplicableToFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicableToFactory);
    }

    public static CombinedResult<ApprovalPolicyFactory, T1, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1>(this CombinedResult<ApprovalPolicyFactory, T1> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicableTo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalPolicyFactory, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1>(this CombinedResult<T1, ApprovalPolicyFactory> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicableTo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ApprovalPolicyFactory, T1, T2, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2>(this CombinedResult<ApprovalPolicyFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalPolicyFactory, T2, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2>(this CombinedResult<T1, ApprovalPolicyFactory, T2> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalPolicyFactory, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2>(this CombinedResult<T1, T2, ApprovalPolicyFactory> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ApprovalPolicyFactory, T1, T2, T3, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2, T3>(this CombinedResult<ApprovalPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalPolicyFactory, T2, T3, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2, T3>(this CombinedResult<T1, ApprovalPolicyFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalPolicyFactory, T3, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2, T3>(this CombinedResult<T1, T2, ApprovalPolicyFactory, T3> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApprovalPolicyFactory, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApprovalPolicyFactory> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ApprovalPolicyFactory, T1, T2, T3, T4, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2, T3, T4>(this CombinedResult<ApprovalPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalPolicyFactory, T2, T3, T4, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2, T3, T4>(this CombinedResult<T1, ApprovalPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalPolicyFactory, T3, T4, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApprovalPolicyFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApprovalPolicyFactory, T4, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApprovalPolicyFactory, T4> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ApprovalPolicyFactory, InnerApprovalPolicyApplicableToFactory> WithApplicableTo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApprovalPolicyFactory> combinedResult, Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicableTo(combinedResult.T5, subFactoryAction).T2);
}
