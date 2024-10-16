// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class RunGroupFactory(string resourceName = null, Action<Humidifier.Omics.RunGroup> factoryAction = null) : ResourceFactory<Humidifier.Omics.RunGroup>(resourceName)
{

    protected override Humidifier.Omics.RunGroup Create()
    {
        var runGroupResult = CreateRunGroup();
        factoryAction?.Invoke(runGroupResult);

        return runGroupResult;
    }

    private Humidifier.Omics.RunGroup CreateRunGroup()
    {
        var runGroupResult = new Humidifier.Omics.RunGroup
        {
            GivenName = InputResourceName,
        };

        return runGroupResult;
    }

} // End Of Class

public static class RunGroupFactoryExtensions
{
}
