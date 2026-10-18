// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserHierarchyStructureLevelFourFactory(Action<Humidifier.Connect.UserHierarchyStructureTypes.LevelFour> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserHierarchyStructureTypes.LevelFour>
{

    protected override Humidifier.Connect.UserHierarchyStructureTypes.LevelFour Create()
    {
        var levelFourResult = CreateLevelFour();
        factoryAction?.Invoke(levelFourResult);

        return levelFourResult;
    }

    private Humidifier.Connect.UserHierarchyStructureTypes.LevelFour CreateLevelFour()
    {
        var levelFourResult = new Humidifier.Connect.UserHierarchyStructureTypes.LevelFour();

        return levelFourResult;
    }

} // End Of Class

public static class InnerUserHierarchyStructureLevelFourFactoryExtensions
{
}
