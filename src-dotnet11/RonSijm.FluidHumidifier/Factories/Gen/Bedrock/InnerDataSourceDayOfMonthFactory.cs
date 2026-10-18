// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceDayOfMonthFactory(Action<Humidifier.Bedrock.DataSourceTypes.DayOfMonth> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.DayOfMonth>
{

    protected override Humidifier.Bedrock.DataSourceTypes.DayOfMonth Create()
    {
        var dayOfMonthResult = CreateDayOfMonth();
        factoryAction?.Invoke(dayOfMonthResult);

        return dayOfMonthResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.DayOfMonth CreateDayOfMonth()
    {
        var dayOfMonthResult = new Humidifier.Bedrock.DataSourceTypes.DayOfMonth();

        return dayOfMonthResult;
    }

} // End Of Class

public static class InnerDataSourceDayOfMonthFactoryExtensions
{
}
