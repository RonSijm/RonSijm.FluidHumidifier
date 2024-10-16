// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class AccessKeyFactory(string resourceName = null, Action<Humidifier.IAM.AccessKey> factoryAction = null) : ResourceFactory<Humidifier.IAM.AccessKey>(resourceName)
{

    protected override Humidifier.IAM.AccessKey Create()
    {
        var accessKeyResult = CreateAccessKey();
        factoryAction?.Invoke(accessKeyResult);

        return accessKeyResult;
    }

    private Humidifier.IAM.AccessKey CreateAccessKey()
    {
        var accessKeyResult = new Humidifier.IAM.AccessKey
        {
            GivenName = InputResourceName,
        };

        return accessKeyResult;
    }

} // End Of Class

public static class AccessKeyFactoryExtensions
{
}
