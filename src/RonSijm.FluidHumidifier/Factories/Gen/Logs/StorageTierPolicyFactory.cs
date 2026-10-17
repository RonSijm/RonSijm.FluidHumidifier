// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class StorageTierPolicyFactory(string resourceName = null, Action<Humidifier.Logs.StorageTierPolicy> factoryAction = null) : ResourceFactory<Humidifier.Logs.StorageTierPolicy>(resourceName)
{

    protected override Humidifier.Logs.StorageTierPolicy Create()
    {
        var storageTierPolicyResult = CreateStorageTierPolicy();
        factoryAction?.Invoke(storageTierPolicyResult);

        return storageTierPolicyResult;
    }

    private Humidifier.Logs.StorageTierPolicy CreateStorageTierPolicy()
    {
        var storageTierPolicyResult = new Humidifier.Logs.StorageTierPolicy
        {
            GivenName = InputResourceName,
        };

        return storageTierPolicyResult;
    }

} // End Of Class

public static class StorageTierPolicyFactoryExtensions
{
}
