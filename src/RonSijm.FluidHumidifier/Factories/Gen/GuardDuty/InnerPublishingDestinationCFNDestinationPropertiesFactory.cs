// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerPublishingDestinationCFNDestinationPropertiesFactory(Action<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties>
{

    protected override Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties Create()
    {
        var cFNDestinationPropertiesResult = CreateCFNDestinationProperties();
        factoryAction?.Invoke(cFNDestinationPropertiesResult);

        return cFNDestinationPropertiesResult;
    }

    private Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties CreateCFNDestinationProperties()
    {
        var cFNDestinationPropertiesResult = new Humidifier.GuardDuty.PublishingDestinationTypes.CFNDestinationProperties();

        return cFNDestinationPropertiesResult;
    }

} // End Of Class

public static class InnerPublishingDestinationCFNDestinationPropertiesFactoryExtensions
{
}
