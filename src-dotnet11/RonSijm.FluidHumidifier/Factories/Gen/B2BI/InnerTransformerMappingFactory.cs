// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerMappingFactory(Action<Humidifier.B2BI.TransformerTypes.Mapping> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.Mapping>
{

    protected override Humidifier.B2BI.TransformerTypes.Mapping Create()
    {
        var mappingResult = CreateMapping();
        factoryAction?.Invoke(mappingResult);

        return mappingResult;
    }

    private Humidifier.B2BI.TransformerTypes.Mapping CreateMapping()
    {
        var mappingResult = new Humidifier.B2BI.TransformerTypes.Mapping();

        return mappingResult;
    }

} // End Of Class

public static class InnerTransformerMappingFactoryExtensions
{
}
