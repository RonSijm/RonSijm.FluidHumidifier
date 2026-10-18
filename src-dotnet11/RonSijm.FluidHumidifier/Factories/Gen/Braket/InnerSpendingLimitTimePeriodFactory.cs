// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerSpendingLimitTimePeriodFactory(Action<Humidifier.Braket.SpendingLimitTypes.TimePeriod> factoryAction = null) : SubResourceFactory<Humidifier.Braket.SpendingLimitTypes.TimePeriod>
{

    protected override Humidifier.Braket.SpendingLimitTypes.TimePeriod Create()
    {
        var timePeriodResult = CreateTimePeriod();
        factoryAction?.Invoke(timePeriodResult);

        return timePeriodResult;
    }

    private Humidifier.Braket.SpendingLimitTypes.TimePeriod CreateTimePeriod()
    {
        var timePeriodResult = new Humidifier.Braket.SpendingLimitTypes.TimePeriod();

        return timePeriodResult;
    }

} // End Of Class

public static class InnerSpendingLimitTimePeriodFactoryExtensions
{
}
