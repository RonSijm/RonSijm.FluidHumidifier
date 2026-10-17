// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkNoBidModuleParametersFactory(Action<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters>
{

    protected override Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters Create()
    {
        var noBidModuleParametersResult = CreateNoBidModuleParameters();
        factoryAction?.Invoke(noBidModuleParametersResult);

        return noBidModuleParametersResult;
    }

    private Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters CreateNoBidModuleParameters()
    {
        var noBidModuleParametersResult = new Humidifier.RTBFabric.LinkTypes.NoBidModuleParameters();

        return noBidModuleParametersResult;
    }

} // End Of Class

public static class InnerLinkNoBidModuleParametersFactoryExtensions
{
}
