// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisValidationStrategyFactory(Action<Humidifier.QuickSight.AnalysisTypes.ValidationStrategy> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.ValidationStrategy>
{

    protected override Humidifier.QuickSight.AnalysisTypes.ValidationStrategy Create()
    {
        var validationStrategyResult = CreateValidationStrategy();
        factoryAction?.Invoke(validationStrategyResult);

        return validationStrategyResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.ValidationStrategy CreateValidationStrategy()
    {
        var validationStrategyResult = new Humidifier.QuickSight.AnalysisTypes.ValidationStrategy();

        return validationStrategyResult;
    }

} // End Of Class

public static class InnerAnalysisValidationStrategyFactoryExtensions
{
}
