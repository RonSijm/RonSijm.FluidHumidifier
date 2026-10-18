// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryReadiness;

public class InnerResourceSetR53ResourceRecordFactory(Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> factoryAction = null) : SubResourceFactory<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord>
{

    protected override Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord Create()
    {
        var r53ResourceRecordResult = CreateR53ResourceRecord();
        factoryAction?.Invoke(r53ResourceRecordResult);

        return r53ResourceRecordResult;
    }

    private Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord CreateR53ResourceRecord()
    {
        var r53ResourceRecordResult = new Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord();

        return r53ResourceRecordResult;
    }

} // End Of Class

public static class InnerResourceSetR53ResourceRecordFactoryExtensions
{
}
