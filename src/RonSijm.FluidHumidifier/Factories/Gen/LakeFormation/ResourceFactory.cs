// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class ResourceFactory(string resourceName = null, Action<Humidifier.LakeFormation.Resource> factoryAction = null) : ResourceFactory<Humidifier.LakeFormation.Resource>(resourceName)
{

    protected override Humidifier.LakeFormation.Resource Create()
    {
        var resourceResult = CreateResource();
        factoryAction?.Invoke(resourceResult);

        return resourceResult;
    }

    private Humidifier.LakeFormation.Resource CreateResource()
    {
        var resourceResult = new Humidifier.LakeFormation.Resource
        {
            GivenName = InputResourceName,
        };

        return resourceResult;
    }

} // End Of Class

public static class ResourceFactoryExtensions
{
}
