// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerCalculatedAttributeDefinitionRangeFactory(Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range>
{

    protected override Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range Create()
    {
        var rangeResult = CreateRange();
        factoryAction?.Invoke(rangeResult);

        return rangeResult;
    }

    private Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range CreateRange()
    {
        var rangeResult = new Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Range();

        return rangeResult;
    }

} // End Of Class

public static class InnerCalculatedAttributeDefinitionRangeFactoryExtensions
{
}
