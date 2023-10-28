using HRLeaveManagement.Application.Contracts.Identity;
using HRLeaveManagement.Domain;
using HRLeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;

namespace HRLeaveManagement.Persistance.Integration;

public class HrDatabaseContextTests
{
    private HrDatabaseContext _hrDatabaseContext;
    private readonly string _userId;
    private readonly Mock<IUserService> _userServiceMock;
    public HrDatabaseContextTests()
    {
        var dbOptions = new DbContextOptionsBuilder<HrDatabaseContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
        _hrDatabaseContext = new HrDatabaseContext(dbOptions);
    }
    [Fact]
    public async void Save_SetDateCreatedValue()
    {
        //Arrage
        var leaveTypes = new LeaveType
        {
            Id = 1,
            DefaultDays = 10,
            Name = "Test Vacation"
        };
        //Act
        await _hrDatabaseContext.LeaveTypes.AddAsync(leaveTypes);
        await _hrDatabaseContext.SaveChangesAsync();

        //Assert

        leaveTypes.DateCreated.ShouldNotBeNull();
    }
    
    [Fact]
    public async void Save_SetDateModifiedValue()
    {
        //Arrage
        var leaveTypes = new LeaveType
        {
            Id = 1,
            DefaultDays = 10,
            Name = "Test Vacation"
        };
        //Act
        await _hrDatabaseContext.LeaveTypes.AddAsync(leaveTypes);
        await _hrDatabaseContext.SaveChangesAsync();

        //Assert

        leaveTypes.DateModified.ShouldNotBeNull();
        
    }
}
