// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class FlywheelDatasetFactory(string resourceName = null, Action<Humidifier.Comprehend.FlywheelDataset> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.FlywheelDataset>(resourceName)
{

    protected override Humidifier.Comprehend.FlywheelDataset Create()
    {
        var flywheelDatasetResult = CreateFlywheelDataset();
        factoryAction?.Invoke(flywheelDatasetResult);

        return flywheelDatasetResult;
    }

    private Humidifier.Comprehend.FlywheelDataset CreateFlywheelDataset()
    {
        var flywheelDatasetResult = new Humidifier.Comprehend.FlywheelDataset
        {
            GivenName = InputResourceName,
        };

        return flywheelDatasetResult;
    }

} // End Of Class

public static class FlywheelDatasetFactoryExtensions
{
}
