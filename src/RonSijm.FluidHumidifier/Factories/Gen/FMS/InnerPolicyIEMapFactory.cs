// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class InnerPolicyIEMapFactory(Action<Humidifier.FMS.PolicyTypes.IEMap> factoryAction = null) : SubResourceFactory<Humidifier.FMS.PolicyTypes.IEMap>
{

    protected override Humidifier.FMS.PolicyTypes.IEMap Create()
    {
        var iEMapResult = CreateIEMap();
        factoryAction?.Invoke(iEMapResult);

        return iEMapResult;
    }

    private Humidifier.FMS.PolicyTypes.IEMap CreateIEMap()
    {
        var iEMapResult = new Humidifier.FMS.PolicyTypes.IEMap();

        return iEMapResult;
    }

} // End Of Class

public static class InnerPolicyIEMapFactoryExtensions
{
}
