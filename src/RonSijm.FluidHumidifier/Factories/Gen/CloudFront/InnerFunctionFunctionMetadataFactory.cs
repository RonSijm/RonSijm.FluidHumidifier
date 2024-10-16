// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerFunctionFunctionMetadataFactory(Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.FunctionTypes.FunctionMetadata>
{

    protected override Humidifier.CloudFront.FunctionTypes.FunctionMetadata Create()
    {
        var functionMetadataResult = CreateFunctionMetadata();
        factoryAction?.Invoke(functionMetadataResult);

        return functionMetadataResult;
    }

    private Humidifier.CloudFront.FunctionTypes.FunctionMetadata CreateFunctionMetadata()
    {
        var functionMetadataResult = new Humidifier.CloudFront.FunctionTypes.FunctionMetadata();

        return functionMetadataResult;
    }

} // End Of Class

public static class InnerFunctionFunctionMetadataFactoryExtensions
{
}
