// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class InnerBillingGroupAccountGroupingFactory(Action<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping> factoryAction = null) : SubResourceFactory<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping>
{

    protected override Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping Create()
    {
        var accountGroupingResult = CreateAccountGrouping();
        factoryAction?.Invoke(accountGroupingResult);

        return accountGroupingResult;
    }

    private Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping CreateAccountGrouping()
    {
        var accountGroupingResult = new Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping();

        return accountGroupingResult;
    }

} // End Of Class

public static class InnerBillingGroupAccountGroupingFactoryExtensions
{
}
