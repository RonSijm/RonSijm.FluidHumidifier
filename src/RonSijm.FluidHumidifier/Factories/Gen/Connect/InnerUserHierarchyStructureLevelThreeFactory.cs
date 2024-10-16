// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserHierarchyStructureLevelThreeFactory(Action<Humidifier.Connect.UserHierarchyStructureTypes.LevelThree> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserHierarchyStructureTypes.LevelThree>
{

    protected override Humidifier.Connect.UserHierarchyStructureTypes.LevelThree Create()
    {
        var levelThreeResult = CreateLevelThree();
        factoryAction?.Invoke(levelThreeResult);

        return levelThreeResult;
    }

    private Humidifier.Connect.UserHierarchyStructureTypes.LevelThree CreateLevelThree()
    {
        var levelThreeResult = new Humidifier.Connect.UserHierarchyStructureTypes.LevelThree();

        return levelThreeResult;
    }

} // End Of Class

public static class InnerUserHierarchyStructureLevelThreeFactoryExtensions
{
}
