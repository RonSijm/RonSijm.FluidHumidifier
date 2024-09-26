// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerNodegroupUpdateConfigFactory(Action<Humidifier.EKS.NodegroupTypes.UpdateConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.NodegroupTypes.UpdateConfig>
{

    protected override Humidifier.EKS.NodegroupTypes.UpdateConfig Create()
    {
        var updateConfigResult = CreateUpdateConfig();
        factoryAction?.Invoke(updateConfigResult);

        return updateConfigResult;
    }

    private Humidifier.EKS.NodegroupTypes.UpdateConfig CreateUpdateConfig()
    {
        var updateConfigResult = new Humidifier.EKS.NodegroupTypes.UpdateConfig();

        return updateConfigResult;
    }

} // End Of Class

public static class InnerNodegroupUpdateConfigFactoryExtensions
{
}
