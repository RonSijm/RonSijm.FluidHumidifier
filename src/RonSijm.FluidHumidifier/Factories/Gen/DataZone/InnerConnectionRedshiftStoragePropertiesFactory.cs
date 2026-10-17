// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionRedshiftStoragePropertiesFactory(Action<Humidifier.DataZone.ConnectionTypes.RedshiftStorageProperties> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.RedshiftStorageProperties>
{

    protected override Humidifier.DataZone.ConnectionTypes.RedshiftStorageProperties Create()
    {
        var redshiftStoragePropertiesResult = CreateRedshiftStorageProperties();
        factoryAction?.Invoke(redshiftStoragePropertiesResult);

        return redshiftStoragePropertiesResult;
    }

    private Humidifier.DataZone.ConnectionTypes.RedshiftStorageProperties CreateRedshiftStorageProperties()
    {
        var redshiftStoragePropertiesResult = new Humidifier.DataZone.ConnectionTypes.RedshiftStorageProperties();

        return redshiftStoragePropertiesResult;
    }

} // End Of Class

public static class InnerConnectionRedshiftStoragePropertiesFactoryExtensions
{
}
