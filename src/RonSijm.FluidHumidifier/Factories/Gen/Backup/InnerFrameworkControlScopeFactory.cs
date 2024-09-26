// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerFrameworkControlScopeFactory(Action<Humidifier.Backup.FrameworkTypes.ControlScope> factoryAction = null) : SubResourceFactory<Humidifier.Backup.FrameworkTypes.ControlScope>
{

    protected override Humidifier.Backup.FrameworkTypes.ControlScope Create()
    {
        var controlScopeResult = CreateControlScope();
        factoryAction?.Invoke(controlScopeResult);

        return controlScopeResult;
    }

    private Humidifier.Backup.FrameworkTypes.ControlScope CreateControlScope()
    {
        var controlScopeResult = new Humidifier.Backup.FrameworkTypes.ControlScope();

        return controlScopeResult;
    }

} // End Of Class

public static class InnerFrameworkControlScopeFactoryExtensions
{
}
