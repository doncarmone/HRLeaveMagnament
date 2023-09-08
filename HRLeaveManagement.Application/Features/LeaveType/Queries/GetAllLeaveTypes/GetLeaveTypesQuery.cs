using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

 //Records are inmutable                                //IRequest is expecting for respond
public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;
