// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerPhoneNumberTwoWayFactory(Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay>
{

    protected override Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay Create()
    {
        var twoWayResult = CreateTwoWay();
        factoryAction?.Invoke(twoWayResult);

        return twoWayResult;
    }

    private Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay CreateTwoWay()
    {
        var twoWayResult = new Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay();

        return twoWayResult;
    }

} // End Of Class

public static class InnerPhoneNumberTwoWayFactoryExtensions
{
}
