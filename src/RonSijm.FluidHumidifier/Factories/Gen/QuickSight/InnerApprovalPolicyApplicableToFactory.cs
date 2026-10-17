// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerApprovalPolicyApplicableToFactory(Action<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo>
{

    protected override Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo Create()
    {
        var applicableToResult = CreateApplicableTo();
        factoryAction?.Invoke(applicableToResult);

        return applicableToResult;
    }

    private Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo CreateApplicableTo()
    {
        var applicableToResult = new Humidifier.QuickSight.ApprovalPolicyTypes.ApplicableTo();

        return applicableToResult;
    }

} // End Of Class

public static class InnerApprovalPolicyApplicableToFactoryExtensions
{
}
