// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantAddToProjectMemberPoolPolicyGrantDetailFactory(Action<Humidifier.DataZone.PolicyGrantTypes.AddToProjectMemberPoolPolicyGrantDetail> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.AddToProjectMemberPoolPolicyGrantDetail>
{

    protected override Humidifier.DataZone.PolicyGrantTypes.AddToProjectMemberPoolPolicyGrantDetail Create()
    {
        var addToProjectMemberPoolPolicyGrantDetailResult = CreateAddToProjectMemberPoolPolicyGrantDetail();
        factoryAction?.Invoke(addToProjectMemberPoolPolicyGrantDetailResult);

        return addToProjectMemberPoolPolicyGrantDetailResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.AddToProjectMemberPoolPolicyGrantDetail CreateAddToProjectMemberPoolPolicyGrantDetail()
    {
        var addToProjectMemberPoolPolicyGrantDetailResult = new Humidifier.DataZone.PolicyGrantTypes.AddToProjectMemberPoolPolicyGrantDetail();

        return addToProjectMemberPoolPolicyGrantDetailResult;
    }

} // End Of Class

public static class InnerPolicyGrantAddToProjectMemberPoolPolicyGrantDetailFactoryExtensions
{
}
