// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardValidationStrategyFactory(Action<Humidifier.QuickSight.DashboardTypes.ValidationStrategy> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.ValidationStrategy>
{

    protected override Humidifier.QuickSight.DashboardTypes.ValidationStrategy Create()
    {
        var validationStrategyResult = CreateValidationStrategy();
        factoryAction?.Invoke(validationStrategyResult);

        return validationStrategyResult;
    }

    private Humidifier.QuickSight.DashboardTypes.ValidationStrategy CreateValidationStrategy()
    {
        var validationStrategyResult = new Humidifier.QuickSight.DashboardTypes.ValidationStrategy();

        return validationStrategyResult;
    }

} // End Of Class

public static class InnerDashboardValidationStrategyFactoryExtensions
{
}
