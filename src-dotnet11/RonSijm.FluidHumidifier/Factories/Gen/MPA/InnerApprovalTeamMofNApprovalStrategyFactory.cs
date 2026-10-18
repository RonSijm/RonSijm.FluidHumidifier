// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MPA;

public class InnerApprovalTeamMofNApprovalStrategyFactory(Action<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy> factoryAction = null) : SubResourceFactory<Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy>
{

    protected override Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy Create()
    {
        var mofNApprovalStrategyResult = CreateMofNApprovalStrategy();
        factoryAction?.Invoke(mofNApprovalStrategyResult);

        return mofNApprovalStrategyResult;
    }

    private Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy CreateMofNApprovalStrategy()
    {
        var mofNApprovalStrategyResult = new Humidifier.MPA.ApprovalTeamTypes.MofNApprovalStrategy();

        return mofNApprovalStrategyResult;
    }

} // End Of Class

public static class InnerApprovalTeamMofNApprovalStrategyFactoryExtensions
{
}
