// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class AssignmentFactory(string resourceName = null, Action<Humidifier.SSO.Assignment> factoryAction = null) : ResourceFactory<Humidifier.SSO.Assignment>(resourceName)
{

    protected override Humidifier.SSO.Assignment Create()
    {
        var assignmentResult = CreateAssignment();
        factoryAction?.Invoke(assignmentResult);

        return assignmentResult;
    }

    private Humidifier.SSO.Assignment CreateAssignment()
    {
        var assignmentResult = new Humidifier.SSO.Assignment
        {
            GivenName = InputResourceName,
        };

        return assignmentResult;
    }

} // End Of Class

public static class AssignmentFactoryExtensions
{
}
