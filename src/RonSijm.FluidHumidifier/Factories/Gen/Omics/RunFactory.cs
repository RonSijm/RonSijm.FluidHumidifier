// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class RunFactory(string resourceName = null, Action<Humidifier.Omics.Run> factoryAction = null) : ResourceFactory<Humidifier.Omics.Run>(resourceName)
{

    protected override Humidifier.Omics.Run Create()
    {
        var runResult = CreateRun();
        factoryAction?.Invoke(runResult);

        return runResult;
    }

    private Humidifier.Omics.Run CreateRun()
    {
        var runResult = new Humidifier.Omics.Run
        {
            GivenName = InputResourceName,
        };

        return runResult;
    }

} // End Of Class

public static class RunFactoryExtensions
{
}
