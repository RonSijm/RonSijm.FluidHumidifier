// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerBudgetUsageTrackingResourceFactory(Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.BudgetTypes.UsageTrackingResource>
{

    protected override Humidifier.Deadline.BudgetTypes.UsageTrackingResource Create()
    {
        var usageTrackingResourceResult = CreateUsageTrackingResource();
        factoryAction?.Invoke(usageTrackingResourceResult);

        return usageTrackingResourceResult;
    }

    private Humidifier.Deadline.BudgetTypes.UsageTrackingResource CreateUsageTrackingResource()
    {
        var usageTrackingResourceResult = new Humidifier.Deadline.BudgetTypes.UsageTrackingResource();

        return usageTrackingResourceResult;
    }

} // End Of Class

public static class InnerBudgetUsageTrackingResourceFactoryExtensions
{
}
