// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeResponseExtractionMappingFactory(Action<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping>
{

    protected override Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping Create()
    {
        var responseExtractionMappingResult = CreateResponseExtractionMapping();
        factoryAction?.Invoke(responseExtractionMappingResult);

        return responseExtractionMappingResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping CreateResponseExtractionMapping()
    {
        var responseExtractionMappingResult = new Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping();

        return responseExtractionMappingResult;
    }

} // End Of Class

public static class InnerConnectionTypeResponseExtractionMappingFactoryExtensions
{
}
