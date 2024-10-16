// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateValidationStrategyFactory(Action<Humidifier.QuickSight.TemplateTypes.ValidationStrategy> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.ValidationStrategy>
{

    protected override Humidifier.QuickSight.TemplateTypes.ValidationStrategy Create()
    {
        var validationStrategyResult = CreateValidationStrategy();
        factoryAction?.Invoke(validationStrategyResult);

        return validationStrategyResult;
    }

    private Humidifier.QuickSight.TemplateTypes.ValidationStrategy CreateValidationStrategy()
    {
        var validationStrategyResult = new Humidifier.QuickSight.TemplateTypes.ValidationStrategy();

        return validationStrategyResult;
    }

} // End Of Class

public static class InnerTemplateValidationStrategyFactoryExtensions
{
}
