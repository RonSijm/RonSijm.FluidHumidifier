// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerCalculatedAttributeDefinitionAttributeDetailsFactory(Action<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails>
{

    protected override Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails Create()
    {
        var attributeDetailsResult = CreateAttributeDetails();
        factoryAction?.Invoke(attributeDetailsResult);

        return attributeDetailsResult;
    }

    private Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails CreateAttributeDetails()
    {
        var attributeDetailsResult = new Humidifier.CustomerProfiles.CalculatedAttributeDefinitionTypes.AttributeDetails();

        return attributeDetailsResult;
    }

} // End Of Class

public static class InnerCalculatedAttributeDefinitionAttributeDetailsFactoryExtensions
{
}
