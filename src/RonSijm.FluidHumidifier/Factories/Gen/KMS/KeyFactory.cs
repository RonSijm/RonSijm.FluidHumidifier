// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KMS;

public class KeyFactory(string resourceName = null, Action<Humidifier.KMS.Key> factoryAction = null) : ResourceFactory<Humidifier.KMS.Key>(resourceName)
{

    protected override Humidifier.KMS.Key Create()
    {
        var keyResult = CreateKey();
        factoryAction?.Invoke(keyResult);

        return keyResult;
    }

    private Humidifier.KMS.Key CreateKey()
    {
        var keyResult = new Humidifier.KMS.Key
        {
            GivenName = InputResourceName,
        };

        return keyResult;
    }

} // End Of Class

public static class KeyFactoryExtensions
{
}
