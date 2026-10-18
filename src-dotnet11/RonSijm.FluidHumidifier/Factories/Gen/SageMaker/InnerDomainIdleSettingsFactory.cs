// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainIdleSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.IdleSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.IdleSettings>
{

    protected override Humidifier.SageMaker.DomainTypes.IdleSettings Create()
    {
        var idleSettingsResult = CreateIdleSettings();
        factoryAction?.Invoke(idleSettingsResult);

        return idleSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.IdleSettings CreateIdleSettings()
    {
        var idleSettingsResult = new Humidifier.SageMaker.DomainTypes.IdleSettings();

        return idleSettingsResult;
    }

} // End Of Class

public static class InnerDomainIdleSettingsFactoryExtensions
{
}
