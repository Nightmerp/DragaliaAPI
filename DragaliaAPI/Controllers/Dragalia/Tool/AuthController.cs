﻿using DragaliaAPI.Models;
using DragaliaAPI.Models.Database;
using DragaliaAPI.Models.Dragalia.Requests;
using DragaliaAPI.Models.Dragalia.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DragaliaAPI.Controllers.Dragalia.Tool;

[Route("tool/auth")]
[Consumes("application/octet-stream")]
[Produces("application/octet-stream")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly ISessionService _sessionService;
    public AuthController(ISessionService sessionService)
    {
        _sessionService = sessionService;
    }

    [HttpPost]
    public async Task<DragaliaResult> Post(IdTokenRequest request)
    {
        string? sessionId = _sessionService.GetSessionIdFromIdToken(request.id_token);
        if (sessionId is null) { return Ok(new ServerErrorResponse()); }

        DbPlayerSavefile savefile = await _sessionService.GetSavefile(sessionId);
        AuthResponse response = new(savefile.ViewerId, sessionId);
        return Ok(response);
    }
}