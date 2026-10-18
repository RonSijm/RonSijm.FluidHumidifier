// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainSharingSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.SharingSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.SharingSettings>
{

    protected override Humidifier.SageMaker.DomainTypes.SharingSettings Create()
    {
        var sharingSettingsResult = CreateSharingSettings();
        factoryAction?.Invoke(sharingSettingsResult);

        return sharingSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.SharingSettings CreateSharingSettings()
    {
        var sharingSettingsResult = new Humidifier.SageMaker.DomainTypes.SharingSettings();

        return sharingSettingsResult;
    }

} // End Of Class

public static class InnerDomainSharingSettingsFactoryExtensions
{
}
