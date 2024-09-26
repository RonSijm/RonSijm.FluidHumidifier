// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class PublicTypeVersionFactory(string resourceName = null, Action<Humidifier.CloudFormation.PublicTypeVersion> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.PublicTypeVersion>(resourceName)
{

    protected override Humidifier.CloudFormation.PublicTypeVersion Create()
    {
        var publicTypeVersionResult = CreatePublicTypeVersion();
        factoryAction?.Invoke(publicTypeVersionResult);

        return publicTypeVersionResult;
    }

    private Humidifier.CloudFormation.PublicTypeVersion CreatePublicTypeVersion()
    {
        var publicTypeVersionResult = new Humidifier.CloudFormation.PublicTypeVersion
        {
            GivenName = InputResourceName,
        };

        return publicTypeVersionResult;
    }

} // End Of Class

public static class PublicTypeVersionFactoryExtensions
{
}
