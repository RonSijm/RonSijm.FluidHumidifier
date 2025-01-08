// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerPartnerAppPartnerAppMaintenanceConfigFactory(Action<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig>
{

    protected override Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig Create()
    {
        var partnerAppMaintenanceConfigResult = CreatePartnerAppMaintenanceConfig();
        factoryAction?.Invoke(partnerAppMaintenanceConfigResult);

        return partnerAppMaintenanceConfigResult;
    }

    private Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig CreatePartnerAppMaintenanceConfig()
    {
        var partnerAppMaintenanceConfigResult = new Humidifier.SageMaker.PartnerAppTypes.PartnerAppMaintenanceConfig();

        return partnerAppMaintenanceConfigResult;
    }

} // End Of Class

public static class InnerPartnerAppPartnerAppMaintenanceConfigFactoryExtensions
{
}
