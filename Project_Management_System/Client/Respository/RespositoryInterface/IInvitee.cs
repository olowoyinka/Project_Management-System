﻿using EndPoint.Request.ViewModelRequest;
using EndPoint.Response.UserResponse;
using EndPoint.Response.ViewModelResponse;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project_Management_System.Client.Respository.RespositoryInterface
{
    public interface IInvitee
    {
        Task<PaginationResponse<List<InviteeResponse>>> GetAcceptedUser(Guid Id, PaginationRequest request, string name);

        Task<PaginationResponse<List<InviteeResponse>>> GetPendingUser(Guid? Id, PaginationRequest request, string name);

        Task<PaginationResponse<List<InviteeResponse>>> GetAccepted(PaginationRequest request, string name);

        Task<PaginationResponse<List<InviteeResponse>>> GetPending(PaginationRequest request, string name);

        Task<AuthResponse> RemoveInvitation(Guid? topicId, InviteeAcceptRequest inviteeAccept);

        Task<AuthResponse> SentInvitation(Guid? topicId, InviteeSentRequest inviteeSent);
    }  
}