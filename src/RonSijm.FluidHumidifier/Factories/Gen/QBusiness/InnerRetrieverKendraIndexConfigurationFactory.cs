// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerRetrieverKendraIndexConfigurationFactory(Action<Humidifier.QBusiness.RetrieverTypes.KendraIndexConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.RetrieverTypes.KendraIndexConfiguration>
{

    protected override Humidifier.QBusiness.RetrieverTypes.KendraIndexConfiguration Create()
    {
        var kendraIndexConfigurationResult = CreateKendraIndexConfiguration();
        factoryAction?.Invoke(kendraIndexConfigurationResult);

        return kendraIndexConfigurationResult;
    }

    private Humidifier.QBusiness.RetrieverTypes.KendraIndexConfiguration CreateKendraIndexConfiguration()
    {
        var kendraIndexConfigurationResult = new Humidifier.QBusiness.RetrieverTypes.KendraIndexConfiguration();

        return kendraIndexConfigurationResult;
    }

} // End Of Class

public static class InnerRetrieverKendraIndexConfigurationFactoryExtensions
{
}
