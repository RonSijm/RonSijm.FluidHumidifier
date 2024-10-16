// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerPartnerAccountSidewalkAccountInfoFactory(Action<Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfo> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfo>
{

    protected override Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfo Create()
    {
        var sidewalkAccountInfoResult = CreateSidewalkAccountInfo();
        factoryAction?.Invoke(sidewalkAccountInfoResult);

        return sidewalkAccountInfoResult;
    }

    private Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfo CreateSidewalkAccountInfo()
    {
        var sidewalkAccountInfoResult = new Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfo();

        return sidewalkAccountInfoResult;
    }

} // End Of Class

public static class InnerPartnerAccountSidewalkAccountInfoFactoryExtensions
{
}
