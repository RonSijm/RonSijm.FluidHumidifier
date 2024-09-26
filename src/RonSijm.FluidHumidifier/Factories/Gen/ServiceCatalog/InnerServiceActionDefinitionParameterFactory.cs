// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class InnerServiceActionDefinitionParameterFactory(Action<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter> factoryAction = null) : SubResourceFactory<Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter>
{

    protected override Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter Create()
    {
        var definitionParameterResult = CreateDefinitionParameter();
        factoryAction?.Invoke(definitionParameterResult);

        return definitionParameterResult;
    }

    private Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter CreateDefinitionParameter()
    {
        var definitionParameterResult = new Humidifier.ServiceCatalog.ServiceActionTypes.DefinitionParameter();

        return definitionParameterResult;
    }

} // End Of Class

public static class InnerServiceActionDefinitionParameterFactoryExtensions
{
}
