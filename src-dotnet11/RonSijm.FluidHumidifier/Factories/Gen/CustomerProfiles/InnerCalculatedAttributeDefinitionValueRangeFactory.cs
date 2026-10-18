// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerCalculatedAttributeDefinitionValueRangeFactory(Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange>
{

    protected override Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange Create()
    {
        var valueRangeResult = CreateValueRange();
        factoryAction?.Invoke(valueRangeResult);

        return valueRangeResult;
    }

    private Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange CreateValueRange()
    {
        var valueRangeResult = new Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.ValueRange();

        return valueRangeResult;
    }

} // End Of Class

public static class InnerCalculatedAttributeDefinitionValueRangeFactoryExtensions
{
}
