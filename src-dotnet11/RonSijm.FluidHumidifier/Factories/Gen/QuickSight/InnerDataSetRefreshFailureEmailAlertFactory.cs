// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetRefreshFailureEmailAlertFactory(Action<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert>
{

    protected override Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert Create()
    {
        var refreshFailureEmailAlertResult = CreateRefreshFailureEmailAlert();
        factoryAction?.Invoke(refreshFailureEmailAlertResult);

        return refreshFailureEmailAlertResult;
    }

    private Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert CreateRefreshFailureEmailAlert()
    {
        var refreshFailureEmailAlertResult = new Humidifier.QuickSight.DataSetTypes.RefreshFailureEmailAlert();

        return refreshFailureEmailAlertResult;
    }

} // End Of Class

public static class InnerDataSetRefreshFailureEmailAlertFactoryExtensions
{
}
