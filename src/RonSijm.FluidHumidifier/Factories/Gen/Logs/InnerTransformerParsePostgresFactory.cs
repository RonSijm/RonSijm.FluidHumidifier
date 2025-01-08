// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerParsePostgresFactory(Action<Humidifier.Logs.TransformerTypes.ParsePostgres> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.ParsePostgres>
{

    protected override Humidifier.Logs.TransformerTypes.ParsePostgres Create()
    {
        var parsePostgresResult = CreateParsePostgres();
        factoryAction?.Invoke(parsePostgresResult);

        return parsePostgresResult;
    }

    private Humidifier.Logs.TransformerTypes.ParsePostgres CreateParsePostgres()
    {
        var parsePostgresResult = new Humidifier.Logs.TransformerTypes.ParsePostgres();

        return parsePostgresResult;
    }

} // End Of Class

public static class InnerTransformerParsePostgresFactoryExtensions
{
}
