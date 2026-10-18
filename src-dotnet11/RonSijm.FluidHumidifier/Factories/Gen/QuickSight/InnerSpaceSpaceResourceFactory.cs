// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerSpaceSpaceResourceFactory(Action<Humidifier.QuickSight.SpaceTypes.SpaceResource> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.SpaceTypes.SpaceResource>
{

    protected override Humidifier.QuickSight.SpaceTypes.SpaceResource Create()
    {
        var spaceResourceResult = CreateSpaceResource();
        factoryAction?.Invoke(spaceResourceResult);

        return spaceResourceResult;
    }

    private Humidifier.QuickSight.SpaceTypes.SpaceResource CreateSpaceResource()
    {
        var spaceResourceResult = new Humidifier.QuickSight.SpaceTypes.SpaceResource();

        return spaceResourceResult;
    }

} // End Of Class

public static class InnerSpaceSpaceResourceFactoryExtensions
{
}
