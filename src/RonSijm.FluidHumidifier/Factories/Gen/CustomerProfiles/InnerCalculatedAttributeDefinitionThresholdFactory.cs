// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerCalculatedAttributeDefinitionThresholdFactory(Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Threshold> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Threshold>
{

    protected override Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Threshold Create()
    {
        var thresholdResult = CreateThreshold();
        factoryAction?.Invoke(thresholdResult);

        return thresholdResult;
    }

    private Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Threshold CreateThreshold()
    {
        var thresholdResult = new Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.Threshold();

        return thresholdResult;
    }

} // End Of Class

public static class InnerCalculatedAttributeDefinitionThresholdFactoryExtensions
{
}
