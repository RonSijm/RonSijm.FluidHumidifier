// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerPartnerAppPartnerAppConfigFactory(Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig>
{

    protected override Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig Create()
    {
        var partnerAppConfigResult = CreatePartnerAppConfig();
        factoryAction?.Invoke(partnerAppConfigResult);

        return partnerAppConfigResult;
    }

    private Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig CreatePartnerAppConfig()
    {
        var partnerAppConfigResult = new Humidifier.SageMaker.PartnerAppTypes.PartnerAppConfig();

        return partnerAppConfigResult;
    }

} // End Of Class

public static class InnerPartnerAppPartnerAppConfigFactoryExtensions
{
}
