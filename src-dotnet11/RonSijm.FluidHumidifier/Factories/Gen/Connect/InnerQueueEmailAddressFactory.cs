// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerQueueEmailAddressFactory(Action<Humidifier.Connect.QueueTypes.EmailAddress> factoryAction = null) : SubResourceFactory<Humidifier.Connect.QueueTypes.EmailAddress>
{

    protected override Humidifier.Connect.QueueTypes.EmailAddress Create()
    {
        var emailAddressResult = CreateEmailAddress();
        factoryAction?.Invoke(emailAddressResult);

        return emailAddressResult;
    }

    private Humidifier.Connect.QueueTypes.EmailAddress CreateEmailAddress()
    {
        var emailAddressResult = new Humidifier.Connect.QueueTypes.EmailAddress();

        return emailAddressResult;
    }

} // End Of Class

public static class InnerQueueEmailAddressFactoryExtensions
{
}
