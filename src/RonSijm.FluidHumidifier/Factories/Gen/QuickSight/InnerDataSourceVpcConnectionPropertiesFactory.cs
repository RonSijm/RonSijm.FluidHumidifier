// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceVpcConnectionPropertiesFactory(Action<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties>
{

    protected override Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties Create()
    {
        var vpcConnectionPropertiesResult = CreateVpcConnectionProperties();
        factoryAction?.Invoke(vpcConnectionPropertiesResult);

        return vpcConnectionPropertiesResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties CreateVpcConnectionProperties()
    {
        var vpcConnectionPropertiesResult = new Humidifier.QuickSight.DataSourceTypes.VpcConnectionProperties();

        return vpcConnectionPropertiesResult;
    }

} // End Of Class

public static class InnerDataSourceVpcConnectionPropertiesFactoryExtensions
{
}
