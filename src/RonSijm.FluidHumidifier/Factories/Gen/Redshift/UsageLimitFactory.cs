// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class UsageLimitFactory(string resourceName = null, Action<Humidifier.Redshift.UsageLimit> factoryAction = null) : ResourceFactory<Humidifier.Redshift.UsageLimit>(resourceName)
{

    protected override Humidifier.Redshift.UsageLimit Create()
    {
        var usageLimitResult = CreateUsageLimit();
        factoryAction?.Invoke(usageLimitResult);

        return usageLimitResult;
    }

    private Humidifier.Redshift.UsageLimit CreateUsageLimit()
    {
        var usageLimitResult = new Humidifier.Redshift.UsageLimit
        {
            GivenName = InputResourceName,
        };

        return usageLimitResult;
    }

} // End Of Class

public static class UsageLimitFactoryExtensions
{
}
