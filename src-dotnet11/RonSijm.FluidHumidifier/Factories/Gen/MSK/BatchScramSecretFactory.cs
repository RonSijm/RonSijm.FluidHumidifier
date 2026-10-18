// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class BatchScramSecretFactory(string resourceName = null, Action<Humidifier.MSK.BatchScramSecret> factoryAction = null) : ResourceFactory<Humidifier.MSK.BatchScramSecret>(resourceName)
{

    protected override Humidifier.MSK.BatchScramSecret Create()
    {
        var batchScramSecretResult = CreateBatchScramSecret();
        factoryAction?.Invoke(batchScramSecretResult);

        return batchScramSecretResult;
    }

    private Humidifier.MSK.BatchScramSecret CreateBatchScramSecret()
    {
        var batchScramSecretResult = new Humidifier.MSK.BatchScramSecret
        {
            GivenName = InputResourceName,
        };

        return batchScramSecretResult;
    }

} // End Of Class

public static class BatchScramSecretFactoryExtensions
{
}
