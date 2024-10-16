// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMContacts;

public class InnerContactStageFactory(Action<Humidifier.SSMContacts.ContactTypes.Stage> factoryAction = null) : SubResourceFactory<Humidifier.SSMContacts.ContactTypes.Stage>
{

    protected override Humidifier.SSMContacts.ContactTypes.Stage Create()
    {
        var stageResult = CreateStage();
        factoryAction?.Invoke(stageResult);

        return stageResult;
    }

    private Humidifier.SSMContacts.ContactTypes.Stage CreateStage()
    {
        var stageResult = new Humidifier.SSMContacts.ContactTypes.Stage();

        return stageResult;
    }

} // End Of Class

public static class InnerContactStageFactoryExtensions
{
}
