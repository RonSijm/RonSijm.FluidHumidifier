// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MPA;

public class InnerApprovalTeamApproverFactory(Action<Humidifier.MPA.ApprovalTeamTypes.Approver> factoryAction = null) : SubResourceFactory<Humidifier.MPA.ApprovalTeamTypes.Approver>
{

    protected override Humidifier.MPA.ApprovalTeamTypes.Approver Create()
    {
        var approverResult = CreateApprover();
        factoryAction?.Invoke(approverResult);

        return approverResult;
    }

    private Humidifier.MPA.ApprovalTeamTypes.Approver CreateApprover()
    {
        var approverResult = new Humidifier.MPA.ApprovalTeamTypes.Approver();

        return approverResult;
    }

} // End Of Class

public static class InnerApprovalTeamApproverFactoryExtensions
{
}
