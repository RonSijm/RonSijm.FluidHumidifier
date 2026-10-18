// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserHierarchyStructureLevelOneFactory(Action<Humidifier.Connect.UserHierarchyStructureTypes.LevelOne> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserHierarchyStructureTypes.LevelOne>
{

    protected override Humidifier.Connect.UserHierarchyStructureTypes.LevelOne Create()
    {
        var levelOneResult = CreateLevelOne();
        factoryAction?.Invoke(levelOneResult);

        return levelOneResult;
    }

    private Humidifier.Connect.UserHierarchyStructureTypes.LevelOne CreateLevelOne()
    {
        var levelOneResult = new Humidifier.Connect.UserHierarchyStructureTypes.LevelOne();

        return levelOneResult;
    }

} // End Of Class

public static class InnerUserHierarchyStructureLevelOneFactoryExtensions
{
}
