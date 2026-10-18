// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerNodegroupTaintFactory(Action<Humidifier.EKS.NodegroupTypes.Taint> factoryAction = null) : SubResourceFactory<Humidifier.EKS.NodegroupTypes.Taint>
{

    protected override Humidifier.EKS.NodegroupTypes.Taint Create()
    {
        var taintResult = CreateTaint();
        factoryAction?.Invoke(taintResult);

        return taintResult;
    }

    private Humidifier.EKS.NodegroupTypes.Taint CreateTaint()
    {
        var taintResult = new Humidifier.EKS.NodegroupTypes.Taint();

        return taintResult;
    }

} // End Of Class

public static class InnerNodegroupTaintFactoryExtensions
{
}
