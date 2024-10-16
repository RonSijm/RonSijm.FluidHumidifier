// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class CustomResourceFactory(string resourceName = null, Action<Humidifier.CloudFormation.CustomResource> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.CustomResource>(resourceName)
{

    protected override Humidifier.CloudFormation.CustomResource Create()
    {
        var customResourceResult = CreateCustomResource();
        factoryAction?.Invoke(customResourceResult);

        return customResourceResult;
    }

    private Humidifier.CloudFormation.CustomResource CreateCustomResource()
    {
        var customResourceResult = new Humidifier.CloudFormation.CustomResource
        {
            GivenName = InputResourceName,
        };

        return customResourceResult;
    }

} // End Of Class

public static class CustomResourceFactoryExtensions
{
}
