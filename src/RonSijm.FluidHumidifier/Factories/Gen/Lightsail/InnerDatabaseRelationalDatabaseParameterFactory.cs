// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDatabaseRelationalDatabaseParameterFactory(Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter>
{

    protected override Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter Create()
    {
        var relationalDatabaseParameterResult = CreateRelationalDatabaseParameter();
        factoryAction?.Invoke(relationalDatabaseParameterResult);

        return relationalDatabaseParameterResult;
    }

    private Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter CreateRelationalDatabaseParameter()
    {
        var relationalDatabaseParameterResult = new Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter();

        return relationalDatabaseParameterResult;
    }

} // End Of Class

public static class InnerDatabaseRelationalDatabaseParameterFactoryExtensions
{
}
