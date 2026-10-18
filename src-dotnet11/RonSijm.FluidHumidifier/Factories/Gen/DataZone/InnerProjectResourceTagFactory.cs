// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerProjectResourceTagFactory(Action<Humidifier.DataZone.ProjectTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ProjectTypes.ResourceTag>
{

    protected override Humidifier.DataZone.ProjectTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.DataZone.ProjectTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.DataZone.ProjectTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerProjectResourceTagFactoryExtensions
{
}
