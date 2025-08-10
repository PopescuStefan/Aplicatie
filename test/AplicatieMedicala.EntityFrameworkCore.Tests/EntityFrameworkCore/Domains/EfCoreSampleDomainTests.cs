using AplicatieMedicala.Samples;
using Xunit;

namespace AplicatieMedicala.EntityFrameworkCore.Domains;

[Collection(AplicatieMedicalaTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AplicatieMedicalaEntityFrameworkCoreTestModule>
{

}
