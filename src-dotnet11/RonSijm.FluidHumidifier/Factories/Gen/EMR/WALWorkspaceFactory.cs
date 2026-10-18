// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class WALWorkspaceFactory(string resourceName = null, Action<Humidifier.EMR.WALWorkspace> factoryAction = null) : ResourceFactory<Humidifier.EMR.WALWorkspace>(resourceName)
{

    protected override Humidifier.EMR.WALWorkspace Create()
    {
        var wALWorkspaceResult = CreateWALWorkspace();
        factoryAction?.Invoke(wALWorkspaceResult);

        return wALWorkspaceResult;
    }

    private Humidifier.EMR.WALWorkspace CreateWALWorkspace()
    {
        var wALWorkspaceResult = new Humidifier.EMR.WALWorkspace
        {
            GivenName = InputResourceName,
        };

        return wALWorkspaceResult;
    }

} // End Of Class

public static class WALWorkspaceFactoryExtensions
{
}
