// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class UsagePlanKeyFactory(string resourceName = null, Action<Humidifier.ApiGateway.UsagePlanKey> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.UsagePlanKey>(resourceName)
{

    protected override Humidifier.ApiGateway.UsagePlanKey Create()
    {
        var usagePlanKeyResult = CreateUsagePlanKey();
        factoryAction?.Invoke(usagePlanKeyResult);

        return usagePlanKeyResult;
    }

    private Humidifier.ApiGateway.UsagePlanKey CreateUsagePlanKey()
    {
        var usagePlanKeyResult = new Humidifier.ApiGateway.UsagePlanKey
        {
            GivenName = InputResourceName,
        };

        return usagePlanKeyResult;
    }

} // End Of Class

public static class UsagePlanKeyFactoryExtensions
{
}
