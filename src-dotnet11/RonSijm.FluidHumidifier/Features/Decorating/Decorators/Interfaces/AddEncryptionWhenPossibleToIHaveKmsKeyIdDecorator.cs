using Humidifier.Interfaces;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.Interfaces;

public class AddEncryptionWhenPossibleToIHaveKmsKeyIdDecorator : BaseTypeDecorator<IHaveKmsKeyId>, IWantEnvironmentName
{
    // Rank doesn't matter since it doesn't use variables that could be changed by other Decorators
    public override int Rank { get; set; } = 1;

    public override void Decorate(IHaveKmsKeyId target)
    {
        // If a database instance is part of a cluster, the instance itself does not need KMS
        if (target is Humidifier.RDS.DBInstance dbInstance)
        {
            if (dbInstance.DBClusterIdentifier != null)
            {
                return;
            }
        }

        target.KmsKeyId = Fn.Sub($"arn:aws:kms:${{AWS::Region}}:${{AWS::AccountId}}:alias/KMS-{EnvironmentName}-CMK");
    }

    public string EnvironmentName { get; set; }
}