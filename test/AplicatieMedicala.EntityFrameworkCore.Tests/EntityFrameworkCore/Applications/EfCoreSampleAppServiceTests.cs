using AplicatieMedicala.Samples;
using Xunit;

namespace AplicatieMedicala.EntityFrameworkCore.Applications;

[Collection(AplicatieMedicalaTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AplicatieMedicalaEntityFrameworkCoreTestModule>
{

}
