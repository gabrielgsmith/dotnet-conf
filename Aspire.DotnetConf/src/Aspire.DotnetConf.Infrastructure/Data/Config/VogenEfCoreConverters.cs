using Aspire.DotnetConf.Core.ContributorAggregate;
using Vogen;

namespace Aspire.DotnetConf.Infrastructure.Data.Config;

[EfCoreConverter<ContributorId>]
[EfCoreConverter<ContributorName>]
internal partial class VogenEfCoreConverters;
