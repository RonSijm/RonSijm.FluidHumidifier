// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantCreateProjectPolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.CreateProjectPolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.CreateProjectPolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.CreateProjectPolicyGrantDetail Create()
    {
        var createProjectPolicyGrantDetailResult = CreateCreateProjectPolicyGrantDetail();
        factoryAction?.Invoke(createProjectPolicyGrantDetailResult);

        return createProjectPolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.CreateProjectPolicyGrantDetail CreateCreateProjectPolicyGrantDetail()
    {
        var createProjectPolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.CreateProjectPolicyGrantDetail();

        return createProjectPolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantCreateProjectPolicyGrantDetailFactoryExtensions
{
}
