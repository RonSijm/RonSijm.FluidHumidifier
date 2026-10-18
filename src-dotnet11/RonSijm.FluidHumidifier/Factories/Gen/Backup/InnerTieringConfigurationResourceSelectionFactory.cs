// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerTieringConfigurationResourceSelectionFactory(Action<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection> factoryAction = null) : SubResourceFactory<Humidifier.Backup.TieringConfigurationTypes.ResourceSelection>
{

    protected override Humidifier.Backup.TieringConfigurationTypes.ResourceSelection Create()
    {
        var resourceSelectionResult = CreateResourceSelection();
        factoryAction?.Invoke(resourceSelectionResult);

        return resourceSelectionResult;
    }

    private Humidifier.Backup.TieringConfigurationTypes.ResourceSelection CreateResourceSelection()
    {
        var resourceSelectionResult = new Humidifier.Backup.TieringConfigurationTypes.ResourceSelection();

        return resourceSelectionResult;
    }

} // End Of Class

public static class InnerTieringConfigurationResourceSelectionFactoryExtensions
{
}
