// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class TableVersionFactory(string resourceName = null, Action<Humidifier.Glue.TableVersion> factoryAction = null) : ResourceFactory<Humidifier.Glue.TableVersion>(resourceName)
{

    protected override Humidifier.Glue.TableVersion Create()
    {
        var tableVersionResult = CreateTableVersion();
        factoryAction?.Invoke(tableVersionResult);

        return tableVersionResult;
    }

    private Humidifier.Glue.TableVersion CreateTableVersion()
    {
        var tableVersionResult = new Humidifier.Glue.TableVersion
        {
            GivenName = InputResourceName,
        };

        return tableVersionResult;
    }

} // End Of Class

public static class TableVersionFactoryExtensions
{
}
