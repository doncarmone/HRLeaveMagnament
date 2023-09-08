using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveTypeCommand;

public class DeleteLeaveTypeCommand : IRequest<Unit>
{
    public int Id { get; set; }
}