// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RolesAnywhere;

public class SubjectFactory(string resourceName = null, Action<Humidifier.RolesAnywhere.Subject> factoryAction = null) : ResourceFactory<Humidifier.RolesAnywhere.Subject>(resourceName)
{

    protected override Humidifier.RolesAnywhere.Subject Create()
    {
        var subjectResult = CreateSubject();
        factoryAction?.Invoke(subjectResult);

        return subjectResult;
    }

    private Humidifier.RolesAnywhere.Subject CreateSubject()
    {
        var subjectResult = new Humidifier.RolesAnywhere.Subject
        {
            GivenName = InputResourceName,
        };

        return subjectResult;
    }

} // End Of Class

public static class SubjectFactoryExtensions
{
}
