// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerTaskTemplateConstraintsFactory(Action<Humidifier.Connect.TaskTemplateTypes.Constraints> factoryAction = null) : SubResourceFactory<Humidifier.Connect.TaskTemplateTypes.Constraints>
{

    protected override Humidifier.Connect.TaskTemplateTypes.Constraints Create()
    {
        var constraintsResult = CreateConstraints();
        factoryAction?.Invoke(constraintsResult);

        return constraintsResult;
    }

    private Humidifier.Connect.TaskTemplateTypes.Constraints CreateConstraints()
    {
        var constraintsResult = new Humidifier.Connect.TaskTemplateTypes.Constraints();

        return constraintsResult;
    }

} // End Of Class

public static class InnerTaskTemplateConstraintsFactoryExtensions
{
}
