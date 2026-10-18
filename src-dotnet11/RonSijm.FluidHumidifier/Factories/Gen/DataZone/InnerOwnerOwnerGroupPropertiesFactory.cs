// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerOwnerOwnerGroupPropertiesFactory(Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties>
{

    protected override Humidifier.DataZone.OwnerTypes.OwnerGroupProperties Create()
    {
        var ownerGroupPropertiesResult = CreateOwnerGroupProperties();
        factoryAction?.Invoke(ownerGroupPropertiesResult);

        return ownerGroupPropertiesResult;
    }

    private Humidifier.DataZone.OwnerTypes.OwnerGroupProperties CreateOwnerGroupProperties()
    {
        var ownerGroupPropertiesResult = new Humidifier.DataZone.OwnerTypes.OwnerGroupProperties();

        return ownerGroupPropertiesResult;
    }

} // End Of Class

public static class InnerOwnerOwnerGroupPropertiesFactoryExtensions
{
}
