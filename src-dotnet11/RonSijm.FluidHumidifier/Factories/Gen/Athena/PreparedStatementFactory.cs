// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class PreparedStatementFactory(string resourceName = null, Action<Humidifier.Athena.PreparedStatement> factoryAction = null) : ResourceFactory<Humidifier.Athena.PreparedStatement>(resourceName)
{

    protected override Humidifier.Athena.PreparedStatement Create()
    {
        var preparedStatementResult = CreatePreparedStatement();
        factoryAction?.Invoke(preparedStatementResult);

        return preparedStatementResult;
    }

    private Humidifier.Athena.PreparedStatement CreatePreparedStatement()
    {
        var preparedStatementResult = new Humidifier.Athena.PreparedStatement
        {
            GivenName = InputResourceName,
        };

        return preparedStatementResult;
    }

} // End Of Class

public static class PreparedStatementFactoryExtensions
{
}
