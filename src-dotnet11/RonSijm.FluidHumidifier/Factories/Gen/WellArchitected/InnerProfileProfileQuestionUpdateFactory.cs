// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class InnerProfileProfileQuestionUpdateFactory(Action<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate> factoryAction = null) : SubResourceFactory<Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate>
{

    protected override Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate Create()
    {
        var profileQuestionUpdateResult = CreateProfileQuestionUpdate();
        factoryAction?.Invoke(profileQuestionUpdateResult);

        return profileQuestionUpdateResult;
    }

    private Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate CreateProfileQuestionUpdate()
    {
        var profileQuestionUpdateResult = new Humidifier.WellArchitected.ProfileTypes.ProfileQuestionUpdate();

        return profileQuestionUpdateResult;
    }

} // End Of Class

public static class InnerProfileProfileQuestionUpdateFactoryExtensions
{
}
