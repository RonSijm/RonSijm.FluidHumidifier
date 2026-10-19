// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class AssignmentFactory(string resourceName = null, Action<Humidifier.QuickSight.Assignment> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Assignment>(resourceName)
{

    protected override Humidifier.QuickSight.Assignment Create()
    {
        var assignmentResult = CreateAssignment();
        factoryAction?.Invoke(assignmentResult);

        return assignmentResult;
    }

    private Humidifier.QuickSight.Assignment CreateAssignment()
    {
        var assignmentResult = new Humidifier.QuickSight.Assignment
        {
            GivenName = InputResourceName,
        };

        return assignmentResult;
    }

} // End Of Class

public static class AssignmentFactoryExtensions
{
}
