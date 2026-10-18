// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerPartnerAccountSidewalkUpdateAccountFactory(Action<Humidifier.IoTWireless.PartnerAccountTypes.SidewalkUpdateAccount> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.PartnerAccountTypes.SidewalkUpdateAccount>
{

    protected override Humidifier.IoTWireless.PartnerAccountTypes.SidewalkUpdateAccount Create()
    {
        var sidewalkUpdateAccountResult = CreateSidewalkUpdateAccount();
        factoryAction?.Invoke(sidewalkUpdateAccountResult);

        return sidewalkUpdateAccountResult;
    }

    private Humidifier.IoTWireless.PartnerAccountTypes.SidewalkUpdateAccount CreateSidewalkUpdateAccount()
    {
        var sidewalkUpdateAccountResult = new Humidifier.IoTWireless.PartnerAccountTypes.SidewalkUpdateAccount();

        return sidewalkUpdateAccountResult;
    }

} // End Of Class

public static class InnerPartnerAccountSidewalkUpdateAccountFactoryExtensions
{
}
