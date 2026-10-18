// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class LogGroupFactory(string resourceName = null, Action<Humidifier.Logs.LogGroup> factoryAction = null) : ResourceFactory<Humidifier.Logs.LogGroup>(resourceName)
{

    protected override Humidifier.Logs.LogGroup Create()
    {
        var logGroupResult = CreateLogGroup();
        factoryAction?.Invoke(logGroupResult);

        return logGroupResult;
    }

    private Humidifier.Logs.LogGroup CreateLogGroup()
    {
        var logGroupResult = new Humidifier.Logs.LogGroup
        {
            GivenName = InputResourceName,
        };

        return logGroupResult;
    }

} // End Of Class

public static class LogGroupFactoryExtensions
{
}
