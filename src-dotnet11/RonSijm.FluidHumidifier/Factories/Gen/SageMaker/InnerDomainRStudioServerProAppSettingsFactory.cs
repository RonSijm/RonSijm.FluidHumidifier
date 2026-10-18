// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainRStudioServerProAppSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.RStudioServerProAppSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.RStudioServerProAppSettings>
{

    protected override Humidifier.SageMaker.DomainTypes.RStudioServerProAppSettings Create()
    {
        var rStudioServerProAppSettingsResult = CreateRStudioServerProAppSettings();
        factoryAction?.Invoke(rStudioServerProAppSettingsResult);

        return rStudioServerProAppSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.RStudioServerProAppSettings CreateRStudioServerProAppSettings()
    {
        var rStudioServerProAppSettingsResult = new Humidifier.SageMaker.DomainTypes.RStudioServerProAppSettings();

        return rStudioServerProAppSettingsResult;
    }

} // End Of Class

public static class InnerDomainRStudioServerProAppSettingsFactoryExtensions
{
}
