// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableTableIdentifierFactory(Action<Humidifier.Glue.TableTypes.TableIdentifier> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.TableIdentifier>
{

    protected override Humidifier.Glue.TableTypes.TableIdentifier Create()
    {
        var tableIdentifierResult = CreateTableIdentifier();
        factoryAction?.Invoke(tableIdentifierResult);

        return tableIdentifierResult;
    }

    private Humidifier.Glue.TableTypes.TableIdentifier CreateTableIdentifier()
    {
        var tableIdentifierResult = new Humidifier.Glue.TableTypes.TableIdentifier();

        return tableIdentifierResult;
    }

} // End Of Class

public static class InnerTableTableIdentifierFactoryExtensions
{
}
