// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetLookbackWindowFactory(Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.LookbackWindow>
{

    protected override Humidifier.QuickSight.DataSetTypes.LookbackWindow Create()
    {
        var lookbackWindowResult = CreateLookbackWindow();
        factoryAction?.Invoke(lookbackWindowResult);

        return lookbackWindowResult;
    }

    private Humidifier.QuickSight.DataSetTypes.LookbackWindow CreateLookbackWindow()
    {
        var lookbackWindowResult = new Humidifier.QuickSight.DataSetTypes.LookbackWindow();

        return lookbackWindowResult;
    }

} // End Of Class

public static class InnerDataSetLookbackWindowFactoryExtensions
{
}
