// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableViewDefinitionFactory(Action<Humidifier.Glue.TableTypes.ViewDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableTypes.ViewDefinition>
{

    protected override Humidifier.Glue.TableTypes.ViewDefinition Create()
    {
        var viewDefinitionResult = CreateViewDefinition();
        factoryAction?.Invoke(viewDefinitionResult);

        return viewDefinitionResult;
    }

    private Humidifier.Glue.TableTypes.ViewDefinition CreateViewDefinition()
    {
        var viewDefinitionResult = new Humidifier.Glue.TableTypes.ViewDefinition();

        return viewDefinitionResult;
    }

} // End Of Class

public static class InnerTableViewDefinitionFactoryExtensions
{
}
