// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerPoolTwoWayFactory(Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.PoolTypes.TwoWay>
{

    protected override Humidifier.SMSVOICE.PoolTypes.TwoWay Create()
    {
        var twoWayResult = CreateTwoWay();
        factoryAction?.Invoke(twoWayResult);

        return twoWayResult;
    }

    private Humidifier.SMSVOICE.PoolTypes.TwoWay CreateTwoWay()
    {
        var twoWayResult = new Humidifier.SMSVOICE.PoolTypes.TwoWay();

        return twoWayResult;
    }

} // End Of Class

public static class InnerPoolTwoWayFactoryExtensions
{
}
