// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerPolicyEntityIdentifierFactory(Action<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier>
{

    protected override Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier Create()
    {
        var entityIdentifierResult = CreateEntityIdentifier();
        factoryAction?.Invoke(entityIdentifierResult);

        return entityIdentifierResult;
    }

    private Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier CreateEntityIdentifier()
    {
        var entityIdentifierResult = new Humidifier.VerifiedPermissions.PolicyTypes.EntityIdentifier();

        return entityIdentifierResult;
    }

} // End Of Class

public static class InnerPolicyEntityIdentifierFactoryExtensions
{
}
