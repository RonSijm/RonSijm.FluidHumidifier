// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerOwnerOwnerUserPropertiesFactory(Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.OwnerTypes.OwnerUserProperties>
{

    protected override Humidifier.DataZone.OwnerTypes.OwnerUserProperties Create()
    {
        var ownerUserPropertiesResult = CreateOwnerUserProperties();
        factoryAction?.Invoke(ownerUserPropertiesResult);

        return ownerUserPropertiesResult;
    }

    private Humidifier.DataZone.OwnerTypes.OwnerUserProperties CreateOwnerUserProperties()
    {
        var ownerUserPropertiesResult = new Humidifier.DataZone.OwnerTypes.OwnerUserProperties();

        return ownerUserPropertiesResult;
    }

} // End Of Class

public static class InnerOwnerOwnerUserPropertiesFactoryExtensions
{
}
