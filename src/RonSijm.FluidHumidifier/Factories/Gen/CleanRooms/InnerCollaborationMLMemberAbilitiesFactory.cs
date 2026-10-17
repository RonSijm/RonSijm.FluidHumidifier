// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerCollaborationMLMemberAbilitiesFactory(Action<Humidifier.CleanRooms.CollaborationTypes.MLMemberAbilities> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.CollaborationTypes.MLMemberAbilities>
{

    protected override Humidifier.CleanRooms.CollaborationTypes.MLMemberAbilities Create()
    {
        var mLMemberAbilitiesResult = CreateMLMemberAbilities();
        factoryAction?.Invoke(mLMemberAbilitiesResult);

        return mLMemberAbilitiesResult;
    }

    private Humidifier.CleanRooms.CollaborationTypes.MLMemberAbilities CreateMLMemberAbilities()
    {
        var mLMemberAbilitiesResult = new Humidifier.CleanRooms.CollaborationTypes.MLMemberAbilities();

        return mLMemberAbilitiesResult;
    }

} // End Of Class

public static class InnerCollaborationMLMemberAbilitiesFactoryExtensions
{
}
