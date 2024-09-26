// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AuditManager;

public class InnerAssessmentAWSAccountFactory(Action<Humidifier.AuditManager.AssessmentTypes.AWSAccount> factoryAction = null) : SubResourceFactory<Humidifier.AuditManager.AssessmentTypes.AWSAccount>
{

    protected override Humidifier.AuditManager.AssessmentTypes.AWSAccount Create()
    {
        var aWSAccountResult = CreateAWSAccount();
        factoryAction?.Invoke(aWSAccountResult);

        return aWSAccountResult;
    }

    private Humidifier.AuditManager.AssessmentTypes.AWSAccount CreateAWSAccount()
    {
        var aWSAccountResult = new Humidifier.AuditManager.AssessmentTypes.AWSAccount();

        return aWSAccountResult;
    }

} // End Of Class

public static class InnerAssessmentAWSAccountFactoryExtensions
{
}
