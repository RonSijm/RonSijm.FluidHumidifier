// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainJobScheduleFactory(Action<Humidifier.CustomerProfiles.DomainTypes.JobSchedule> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.JobSchedule>
{

    protected override Humidifier.CustomerProfiles.DomainTypes.JobSchedule Create()
    {
        var jobScheduleResult = CreateJobSchedule();
        factoryAction?.Invoke(jobScheduleResult);

        return jobScheduleResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.JobSchedule CreateJobSchedule()
    {
        var jobScheduleResult = new Humidifier.CustomerProfiles.DomainTypes.JobSchedule();

        return jobScheduleResult;
    }

} // End Of Class

public static class InnerDomainJobScheduleFactoryExtensions
{
}
