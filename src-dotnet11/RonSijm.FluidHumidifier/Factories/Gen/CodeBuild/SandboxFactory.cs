// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class SandboxFactory(string resourceName = null, Action<Humidifier.CodeBuild.Sandbox> factoryAction = null) : ResourceFactory<Humidifier.CodeBuild.Sandbox>(resourceName)
{

    protected override Humidifier.CodeBuild.Sandbox Create()
    {
        var sandboxResult = CreateSandbox();
        factoryAction?.Invoke(sandboxResult);

        return sandboxResult;
    }

    private Humidifier.CodeBuild.Sandbox CreateSandbox()
    {
        var sandboxResult = new Humidifier.CodeBuild.Sandbox
        {
            GivenName = InputResourceName,
        };

        return sandboxResult;
    }

} // End Of Class

public static class SandboxFactoryExtensions
{
}
