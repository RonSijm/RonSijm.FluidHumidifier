// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class InnerCloudFormationProductCodeStarParametersFactory(Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters> factoryAction = null) : SubResourceFactory<Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters>
{

    protected override Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters Create()
    {
        var codeStarParametersResult = CreateCodeStarParameters();
        factoryAction?.Invoke(codeStarParametersResult);

        return codeStarParametersResult;
    }

    private Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters CreateCodeStarParameters()
    {
        var codeStarParametersResult = new Humidifier.ServiceCatalog.CloudFormationProductTypes.CodeStarParameters();

        return codeStarParametersResult;
    }

} // End Of Class

public static class InnerCloudFormationProductCodeStarParametersFactoryExtensions
{
}
