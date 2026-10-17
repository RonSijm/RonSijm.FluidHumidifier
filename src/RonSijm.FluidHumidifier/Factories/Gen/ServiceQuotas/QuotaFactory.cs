// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceQuotas;

public class QuotaFactory(string resourceName = null, Action<Humidifier.ServiceQuotas.Quota> factoryAction = null) : ResourceFactory<Humidifier.ServiceQuotas.Quota>(resourceName)
{

    protected override Humidifier.ServiceQuotas.Quota Create()
    {
        var quotaResult = CreateQuota();
        factoryAction?.Invoke(quotaResult);

        return quotaResult;
    }

    private Humidifier.ServiceQuotas.Quota CreateQuota()
    {
        var quotaResult = new Humidifier.ServiceQuotas.Quota
        {
            GivenName = InputResourceName,
        };

        return quotaResult;
    }

} // End Of Class

public static class QuotaFactoryExtensions
{
}
