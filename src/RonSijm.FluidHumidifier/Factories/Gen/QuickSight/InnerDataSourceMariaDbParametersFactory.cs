// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceMariaDbParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.MariaDbParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.MariaDbParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.MariaDbParameters Create()
    {
        var mariaDbParametersResult = CreateMariaDbParameters();
        factoryAction?.Invoke(mariaDbParametersResult);

        return mariaDbParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.MariaDbParameters CreateMariaDbParameters()
    {
        var mariaDbParametersResult = new Humidifier.QuickSight.DataSourceTypes.MariaDbParameters();

        return mariaDbParametersResult;
    }

} // End Of Class

public static class InnerDataSourceMariaDbParametersFactoryExtensions
{
}
