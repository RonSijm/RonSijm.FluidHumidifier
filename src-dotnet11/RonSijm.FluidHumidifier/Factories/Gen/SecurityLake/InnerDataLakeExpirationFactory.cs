// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerDataLakeExpirationFactory(Action<Humidifier.SecurityLake.DataLakeTypes.Expiration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.DataLakeTypes.Expiration>
{

    protected override Humidifier.SecurityLake.DataLakeTypes.Expiration Create()
    {
        var expirationResult = CreateExpiration();
        factoryAction?.Invoke(expirationResult);

        return expirationResult;
    }

    private Humidifier.SecurityLake.DataLakeTypes.Expiration CreateExpiration()
    {
        var expirationResult = new Humidifier.SecurityLake.DataLakeTypes.Expiration();

        return expirationResult;
    }

} // End Of Class

public static class InnerDataLakeExpirationFactoryExtensions
{
}
