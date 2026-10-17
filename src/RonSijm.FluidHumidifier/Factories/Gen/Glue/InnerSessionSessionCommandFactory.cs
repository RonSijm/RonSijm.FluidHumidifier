// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerSessionSessionCommandFactory(Action<Humidifier.Glue.SessionTypes.SessionCommand> factoryAction = null) : SubResourceFactory<Humidifier.Glue.SessionTypes.SessionCommand>
{

    protected override Humidifier.Glue.SessionTypes.SessionCommand Create()
    {
        var sessionCommandResult = CreateSessionCommand();
        factoryAction?.Invoke(sessionCommandResult);

        return sessionCommandResult;
    }

    private Humidifier.Glue.SessionTypes.SessionCommand CreateSessionCommand()
    {
        var sessionCommandResult = new Humidifier.Glue.SessionTypes.SessionCommand();

        return sessionCommandResult;
    }

} // End Of Class

public static class InnerSessionSessionCommandFactoryExtensions
{
}
