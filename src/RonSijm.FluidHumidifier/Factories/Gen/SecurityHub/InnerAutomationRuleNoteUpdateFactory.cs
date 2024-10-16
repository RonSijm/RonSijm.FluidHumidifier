// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerAutomationRuleNoteUpdateFactory(Action<Humidifier.SecurityHub.AutomationRuleTypes.NoteUpdate> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.AutomationRuleTypes.NoteUpdate>
{

    protected override Humidifier.SecurityHub.AutomationRuleTypes.NoteUpdate Create()
    {
        var noteUpdateResult = CreateNoteUpdate();
        factoryAction?.Invoke(noteUpdateResult);

        return noteUpdateResult;
    }

    private Humidifier.SecurityHub.AutomationRuleTypes.NoteUpdate CreateNoteUpdate()
    {
        var noteUpdateResult = new Humidifier.SecurityHub.AutomationRuleTypes.NoteUpdate();

        return noteUpdateResult;
    }

} // End Of Class

public static class InnerAutomationRuleNoteUpdateFactoryExtensions
{
}
