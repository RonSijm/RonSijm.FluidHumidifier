// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerApplicationPersonalizationConfigurationFactory(Action<Humidifier.QBusiness.ApplicationTypes.PersonalizationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.ApplicationTypes.PersonalizationConfiguration>
{

    protected override Humidifier.QBusiness.ApplicationTypes.PersonalizationConfiguration Create()
    {
        var personalizationConfigurationResult = CreatePersonalizationConfiguration();
        factoryAction?.Invoke(personalizationConfigurationResult);

        return personalizationConfigurationResult;
    }

    private Humidifier.QBusiness.ApplicationTypes.PersonalizationConfiguration CreatePersonalizationConfiguration()
    {
        var personalizationConfigurationResult = new Humidifier.QBusiness.ApplicationTypes.PersonalizationConfiguration();

        return personalizationConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationPersonalizationConfigurationFactoryExtensions
{
}
