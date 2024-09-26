// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainAttributeTypesSelectorFactory(Action<Humidifier.CustomerProfiles.DomainTypes.AttributeTypesSelector> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.AttributeTypesSelector>
{

    protected override Humidifier.CustomerProfiles.DomainTypes.AttributeTypesSelector Create()
    {
        var attributeTypesSelectorResult = CreateAttributeTypesSelector();
        factoryAction?.Invoke(attributeTypesSelectorResult);

        return attributeTypesSelectorResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.AttributeTypesSelector CreateAttributeTypesSelector()
    {
        var attributeTypesSelectorResult = new Humidifier.CustomerProfiles.DomainTypes.AttributeTypesSelector();

        return attributeTypesSelectorResult;
    }

} // End Of Class

public static class InnerDomainAttributeTypesSelectorFactoryExtensions
{
}
