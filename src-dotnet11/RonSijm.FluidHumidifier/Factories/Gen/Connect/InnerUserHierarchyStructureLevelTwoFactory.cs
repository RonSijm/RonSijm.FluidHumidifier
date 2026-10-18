// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserHierarchyStructureLevelTwoFactory(Action<Humidifier.Connect.UserHierarchyStructureTypes.LevelTwo> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserHierarchyStructureTypes.LevelTwo>
{

    protected override Humidifier.Connect.UserHierarchyStructureTypes.LevelTwo Create()
    {
        var levelTwoResult = CreateLevelTwo();
        factoryAction?.Invoke(levelTwoResult);

        return levelTwoResult;
    }

    private Humidifier.Connect.UserHierarchyStructureTypes.LevelTwo CreateLevelTwo()
    {
        var levelTwoResult = new Humidifier.Connect.UserHierarchyStructureTypes.LevelTwo();

        return levelTwoResult;
    }

} // End Of Class

public static class InnerUserHierarchyStructureLevelTwoFactoryExtensions
{
}
