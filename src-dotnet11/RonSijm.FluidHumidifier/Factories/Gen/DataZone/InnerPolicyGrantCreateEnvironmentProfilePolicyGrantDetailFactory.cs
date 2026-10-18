// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantCreateEnvironmentProfilePolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.CreateEnvironmentProfilePolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.CreateEnvironmentProfilePolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.CreateEnvironmentProfilePolicyGrantDetail Create()
    {
        var createEnvironmentProfilePolicyGrantDetailResult = CreateCreateEnvironmentProfilePolicyGrantDetail();
        factoryAction?.Invoke(createEnvironmentProfilePolicyGrantDetailResult);

        return createEnvironmentProfilePolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.CreateEnvironmentProfilePolicyGrantDetail CreateCreateEnvironmentProfilePolicyGrantDetail()
    {
        var createEnvironmentProfilePolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.CreateEnvironmentProfilePolicyGrantDetail();

        return createEnvironmentProfilePolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantCreateEnvironmentProfilePolicyGrantDetailFactoryExtensions
{
}
