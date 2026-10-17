// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class TransactionSearchConfigFactory(string resourceName = null, Action<Humidifier.XRay.TransactionSearchConfig> factoryAction = null) : ResourceFactory<Humidifier.XRay.TransactionSearchConfig>(resourceName)
{

    protected override Humidifier.XRay.TransactionSearchConfig Create()
    {
        var transactionSearchConfigResult = CreateTransactionSearchConfig();
        factoryAction?.Invoke(transactionSearchConfigResult);

        return transactionSearchConfigResult;
    }

    private Humidifier.XRay.TransactionSearchConfig CreateTransactionSearchConfig()
    {
        var transactionSearchConfigResult = new Humidifier.XRay.TransactionSearchConfig
        {
            GivenName = InputResourceName,
        };

        return transactionSearchConfigResult;
    }

} // End Of Class

public static class TransactionSearchConfigFactoryExtensions
{
}
