// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterUpgradePolicyFactory(Action<Humidifier.EKS.ClusterTypes.UpgradePolicy> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.UpgradePolicy>
{

    protected override Humidifier.EKS.ClusterTypes.UpgradePolicy Create()
    {
        var upgradePolicyResult = CreateUpgradePolicy();
        factoryAction?.Invoke(upgradePolicyResult);

        return upgradePolicyResult;
    }

    private Humidifier.EKS.ClusterTypes.UpgradePolicy CreateUpgradePolicy()
    {
        var upgradePolicyResult = new Humidifier.EKS.ClusterTypes.UpgradePolicy();

        return upgradePolicyResult;
    }

} // End Of Class

public static class InnerClusterUpgradePolicyFactoryExtensions
{
}
