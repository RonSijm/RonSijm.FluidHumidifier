// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MWAAServerless;

public class InnerWorkflowCodeS3LocationFactory(Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> factoryAction = null) : SubResourceFactory<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location>
{

    protected override Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location Create()
    {
        var codeS3LocationResult = CreateCodeS3Location();
        factoryAction?.Invoke(codeS3LocationResult);

        return codeS3LocationResult;
    }

    private Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location CreateCodeS3Location()
    {
        var codeS3LocationResult = new Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location();

        return codeS3LocationResult;
    }

} // End Of Class

public static class InnerWorkflowCodeS3LocationFactoryExtensions
{
}
