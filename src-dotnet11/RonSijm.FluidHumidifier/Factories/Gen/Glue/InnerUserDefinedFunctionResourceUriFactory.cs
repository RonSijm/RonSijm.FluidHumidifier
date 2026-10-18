// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerUserDefinedFunctionResourceUriFactory(Action<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> factoryAction = null) : SubResourceFactory<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri>
{

    protected override Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri Create()
    {
        var resourceUriResult = CreateResourceUri();
        factoryAction?.Invoke(resourceUriResult);

        return resourceUriResult;
    }

    private Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri CreateResourceUri()
    {
        var resourceUriResult = new Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri();

        return resourceUriResult;
    }

} // End Of Class

public static class InnerUserDefinedFunctionResourceUriFactoryExtensions
{
}
