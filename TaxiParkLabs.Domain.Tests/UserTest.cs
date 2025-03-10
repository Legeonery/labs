using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiParkLabs.Domain.Model;
using TaxiParkLabs.Domain.Services.InMemory;
using Xunit;

namespace TaxiParkLabs.Domain.Tests
{
    public class UserRepositoryTests
    {
        [Fact]
        public async Task GetPassengersByTripPeriod_Success()
        {
            var repo = new UserInMemoryRepository();
            var passengers = await repo.GetPassengersByTripPeriod(20230101, 20231231);

            Assert.NotNull(passengers);
        }

        [Fact]
        public async Task GetTripCountByPassenger_Success()
        {
            var repo = new UserInMemoryRepository();
            var tripCounts = await repo.GetTripCountByPassenger();

            Assert.NotNull(tripCounts);
        }

        [Fact]
        public async Task GetTopPassengersByTripPeriod_Success()
        {
            var repo = new UserInMemoryRepository();
            var topPassengers = await repo.GetTopPassengersByTripPeriod(20230101, 20231231);

            Assert.NotNull(topPassengers);
        }
    }
}
