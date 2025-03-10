using TaxiParkLabs.Domain.Services.InMemory;
using TaxiParkLabs.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TaxiParkLabs.Domain.Tests;

public class TripRepositoryTests
{
    [Fact]
    public async Task GetDriverTripStatistics_Success()
    {
        var repo = new TripInMemoryRepository();
        var statistics = await repo.GetDriverTripStatistics();

        Assert.NotNull(statistics);
    }
}
