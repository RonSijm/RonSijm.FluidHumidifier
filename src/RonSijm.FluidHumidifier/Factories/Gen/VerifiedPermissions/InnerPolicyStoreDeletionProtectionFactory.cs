// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerPolicyStoreDeletionProtectionFactory(Action<Humidifier.VerifiedPermissions.PolicyStoreTypes.DeletionProtection> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.PolicyStoreTypes.DeletionProtection>
{

    protected override Humidifier.VerifiedPermissions.PolicyStoreTypes.DeletionProtection Create()
    {
        var deletionProtectionResult = CreateDeletionProtection();
        factoryAction?.Invoke(deletionProtectionResult);

        return deletionProtectionResult;
    }

    private Humidifier.VerifiedPermissions.PolicyStoreTypes.DeletionProtection CreateDeletionProtection()
    {
        var deletionProtectionResult = new Humidifier.VerifiedPermissions.PolicyStoreTypes.DeletionProtection();

        return deletionProtectionResult;
    }

} // End Of Class

public static class InnerPolicyStoreDeletionProtectionFactoryExtensions
{
}
