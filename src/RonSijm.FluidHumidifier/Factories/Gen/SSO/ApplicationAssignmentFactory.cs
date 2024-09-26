// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSO;

public class ApplicationAssignmentFactory(string resourceName = null, Action<Humidifier.SSO.ApplicationAssignment> factoryAction = null) : ResourceFactory<Humidifier.SSO.ApplicationAssignment>(resourceName)
{

    protected override Humidifier.SSO.ApplicationAssignment Create()
    {
        var applicationAssignmentResult = CreateApplicationAssignment();
        factoryAction?.Invoke(applicationAssignmentResult);

        return applicationAssignmentResult;
    }

    private Humidifier.SSO.ApplicationAssignment CreateApplicationAssignment()
    {
        var applicationAssignmentResult = new Humidifier.SSO.ApplicationAssignment
        {
            GivenName = InputResourceName,
        };

        return applicationAssignmentResult;
    }

} // End Of Class

public static class ApplicationAssignmentFactoryExtensions
{
}
