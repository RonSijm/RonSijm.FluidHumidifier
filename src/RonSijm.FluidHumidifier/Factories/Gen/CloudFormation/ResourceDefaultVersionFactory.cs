// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class ResourceDefaultVersionFactory(string resourceName = null, Action<Humidifier.CloudFormation.ResourceDefaultVersion> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.ResourceDefaultVersion>(resourceName)
{

    protected override Humidifier.CloudFormation.ResourceDefaultVersion Create()
    {
        var resourceDefaultVersionResult = CreateResourceDefaultVersion();
        factoryAction?.Invoke(resourceDefaultVersionResult);

        return resourceDefaultVersionResult;
    }

    private Humidifier.CloudFormation.ResourceDefaultVersion CreateResourceDefaultVersion()
    {
        var resourceDefaultVersionResult = new Humidifier.CloudFormation.ResourceDefaultVersion
        {
            GivenName = InputResourceName,
        };

        return resourceDefaultVersionResult;
    }

} // End Of Class

public static class ResourceDefaultVersionFactoryExtensions
{
}
