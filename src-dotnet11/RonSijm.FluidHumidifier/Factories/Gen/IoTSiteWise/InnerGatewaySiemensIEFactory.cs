// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerGatewaySiemensIEFactory(Action<Humidifier.IoTSiteWise.GatewayTypes.SiemensIE> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.GatewayTypes.SiemensIE>
{

    protected override Humidifier.IoTSiteWise.GatewayTypes.SiemensIE Create()
    {
        var siemensIEResult = CreateSiemensIE();
        factoryAction?.Invoke(siemensIEResult);

        return siemensIEResult;
    }

    private Humidifier.IoTSiteWise.GatewayTypes.SiemensIE CreateSiemensIE()
    {
        var siemensIEResult = new Humidifier.IoTSiteWise.GatewayTypes.SiemensIE();

        return siemensIEResult;
    }

} // End Of Class

public static class InnerGatewaySiemensIEFactoryExtensions
{
}
