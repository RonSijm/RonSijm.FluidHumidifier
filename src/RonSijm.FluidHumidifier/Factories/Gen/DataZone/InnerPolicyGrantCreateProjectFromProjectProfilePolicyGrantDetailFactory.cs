// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantCreateProjectFromProjectProfilePolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.CreateProjectFromProjectProfilePolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.CreateProjectFromProjectProfilePolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.CreateProjectFromProjectProfilePolicyGrantDetail Create()
    {
        var createProjectFromProjectProfilePolicyGrantDetailResult = CreateCreateProjectFromProjectProfilePolicyGrantDetail();
        factoryAction?.Invoke(createProjectFromProjectProfilePolicyGrantDetailResult);

        return createProjectFromProjectProfilePolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.CreateProjectFromProjectProfilePolicyGrantDetail CreateCreateProjectFromProjectProfilePolicyGrantDetail()
    {
        var createProjectFromProjectProfilePolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.CreateProjectFromProjectProfilePolicyGrantDetail();

        return createProjectFromProjectProfilePolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantCreateProjectFromProjectProfilePolicyGrantDetailFactoryExtensions
{
}
