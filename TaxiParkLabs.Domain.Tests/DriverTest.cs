using TaxiParkLabs.Domain.Model;
using TaxiParkLabs.Domain.Services.InMemory;

namespace TaxiParkLabs.Domain.Tests;

public class DriverRepositoryTests
{
    /// <summary>
    /// ���� ��������� �������� ��������� �������� ������ � ��� �����������.
    /// </summary>
    [Fact]
    public async Task GetDriverWithCar_Success()
    {
        var repo = new DriverInMemoryRepository();
        var driverCar = await repo.GetDriverWithCar(1);

        Assert.NotNull(driverCar);
        Assert.NotNull(driverCar?.driver); 
        Assert.NotNull(driverCar?.car); 
    }
    /// <summary>
    /// ���� ��������� �������� ��������� ���-5 ��������� �� ���������� �������.
    /// </summary>
    [Fact]
    public async Task GetTop5DriversByTripCount_Success()
    {
        var repo = new DriverInMemoryRepository();
        var topDrivers = await repo.GetTop5DriversByTripCount();

        Assert.NotNull(topDrivers);
        Assert.True(topDrivers.Count <= 5);
    }
    /// <summary>
    /// ���� ��������� �������� ��������� ���������� �� �������� ���������.
    /// </summary>
    [Fact]
    public async Task GetDriverTripStatistics_Success()
    {
        var repo = new DriverInMemoryRepository();
        var statistics = await repo.GetDriverTripStatistics();

        Assert.NotNull(statistics);
    }
}