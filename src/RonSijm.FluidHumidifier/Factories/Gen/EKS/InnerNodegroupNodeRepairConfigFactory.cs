// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerNodegroupNodeRepairConfigFactory(Action<Humidifier.EKS.NodegroupTypes.NodeRepairConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.NodegroupTypes.NodeRepairConfig>
{

    protected override Humidifier.EKS.NodegroupTypes.NodeRepairConfig Create()
    {
        var nodeRepairConfigResult = CreateNodeRepairConfig();
        factoryAction?.Invoke(nodeRepairConfigResult);

        return nodeRepairConfigResult;
    }

    private Humidifier.EKS.NodegroupTypes.NodeRepairConfig CreateNodeRepairConfig()
    {
        var nodeRepairConfigResult = new Humidifier.EKS.NodegroupTypes.NodeRepairConfig();

        return nodeRepairConfigResult;
    }

} // End Of Class

public static class InnerNodegroupNodeRepairConfigFactoryExtensions
{
}
