// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerProgramTransitionFactory(Action<Humidifier.MediaTailor.ProgramTypes.Transition> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ProgramTypes.Transition>
{

    protected override Humidifier.MediaTailor.ProgramTypes.Transition Create()
    {
        var transitionResult = CreateTransition();
        factoryAction?.Invoke(transitionResult);

        return transitionResult;
    }

    private Humidifier.MediaTailor.ProgramTypes.Transition CreateTransition()
    {
        var transitionResult = new Humidifier.MediaTailor.ProgramTypes.Transition();

        return transitionResult;
    }

} // End Of Class

public static class InnerProgramTransitionFactoryExtensions
{
}
