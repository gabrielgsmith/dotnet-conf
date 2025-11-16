using Aspire.DotnetConf.Core.ContributorAggregate;

namespace Aspire.DotnetConf.UseCases.Contributors;
public record ContributorDto(ContributorId Id, ContributorName Name, PhoneNumber PhoneNumber);
