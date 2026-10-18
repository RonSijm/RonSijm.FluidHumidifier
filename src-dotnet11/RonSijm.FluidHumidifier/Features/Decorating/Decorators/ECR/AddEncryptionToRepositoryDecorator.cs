using Humidifier.ECR;
using Humidifier.ECR.RepositoryTypes;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.ECR;

public class AddEncryptionToRepositoryDecorator : BaseTypeDecorator<Repository>, IWantEnvironmentName
{
    // Rank doesn't matter since it doesn't use variables that could be changed by other Decorators
    public override int Rank { get; set; } = 1;

    public override void Decorate(Repository target)
    {
        target.EncryptionConfiguration = new EncryptionConfiguration
        {
            EncryptionType = "KMS",
            KmsKey = Fn.Sub($"arn:aws:kms:${{AWS::Region}}:${{AWS::AccountId}}:alias/KMS-{EnvironmentName}-CMK") 
        };
    }

    public string EnvironmentName { get; set; }
}