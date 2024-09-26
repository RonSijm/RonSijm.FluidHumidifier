// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserHierarchyStructureLevelFiveFactory(Action<Humidifier.Connect.UserHierarchyStructureTypes.LevelFive> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserHierarchyStructureTypes.LevelFive>
{

    protected override Humidifier.Connect.UserHierarchyStructureTypes.LevelFive Create()
    {
        var levelFiveResult = CreateLevelFive();
        factoryAction?.Invoke(levelFiveResult);

        return levelFiveResult;
    }

    private Humidifier.Connect.UserHierarchyStructureTypes.LevelFive CreateLevelFive()
    {
        var levelFiveResult = new Humidifier.Connect.UserHierarchyStructureTypes.LevelFive();

        return levelFiveResult;
    }

} // End Of Class

public static class InnerUserHierarchyStructureLevelFiveFactoryExtensions
{
}
