// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class SenderIdFactory(string resourceName = null, Action<Humidifier.SMSVOICE.SenderId> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.SenderId>(resourceName)
{

    protected override Humidifier.SMSVOICE.SenderId Create()
    {
        var senderIdResult = CreateSenderId();
        factoryAction?.Invoke(senderIdResult);

        return senderIdResult;
    }

    private Humidifier.SMSVOICE.SenderId CreateSenderId()
    {
        var senderIdResult = new Humidifier.SMSVOICE.SenderId
        {
            GivenName = InputResourceName,
        };

        return senderIdResult;
    }

} // End Of Class

public static class SenderIdFactoryExtensions
{
}
