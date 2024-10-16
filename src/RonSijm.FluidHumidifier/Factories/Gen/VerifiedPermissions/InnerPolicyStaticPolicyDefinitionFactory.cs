// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerPolicyStaticPolicyDefinitionFactory(Action<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition>
{

    protected override Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition Create()
    {
        var staticPolicyDefinitionResult = CreateStaticPolicyDefinition();
        factoryAction?.Invoke(staticPolicyDefinitionResult);

        return staticPolicyDefinitionResult;
    }

    private Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition CreateStaticPolicyDefinition()
    {
        var staticPolicyDefinitionResult = new Humidifier.VerifiedPermissions.PolicyTypes.StaticPolicyDefinition();

        return staticPolicyDefinitionResult;
    }

} // End Of Class

public static class InnerPolicyStaticPolicyDefinitionFactoryExtensions
{
}
