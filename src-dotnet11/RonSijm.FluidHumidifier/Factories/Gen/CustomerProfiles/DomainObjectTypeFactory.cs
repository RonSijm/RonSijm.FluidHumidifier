// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class DomainObjectTypeFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.DomainObjectType> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.DomainObjectType>(resourceName)
{

    protected override Humidifier.CustomerProfiles.DomainObjectType Create()
    {
        var domainObjectTypeResult = CreateDomainObjectType();
        factoryAction?.Invoke(domainObjectTypeResult);

        return domainObjectTypeResult;
    }

    private Humidifier.CustomerProfiles.DomainObjectType CreateDomainObjectType()
    {
        var domainObjectTypeResult = new Humidifier.CustomerProfiles.DomainObjectType
        {
            GivenName = InputResourceName,
        };

        return domainObjectTypeResult;
    }

} // End Of Class

public static class DomainObjectTypeFactoryExtensions
{
}
