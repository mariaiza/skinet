using System;
using API.DTOs;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController : BaseApiController
{
    // [HttpGet("notfound")]
    [HttpGet("unauthorized")]
    public ActionResult<string> GetUnauthorized()
    {
        return Unauthorized("You are not authorized");
    }

    [HttpGet("badrequest")]
    public ActionResult<string> GetBadRequest()
    {
        return BadRequest("This was not a good request");
    }

    [HttpGet("notfound")]
    public ActionResult<string> GetNotFound()
    {
        return NotFound("Resource not found");
    }

    [HttpGet("internalerror")]
    public ActionResult<string> GetInternalError()
    {
        throw new Exception("This is a server error");
    }

    [HttpPost("validationerror")]
    public ActionResult GetValidationError(CreateProductDto product)
    {
        // ModelState.AddModelError("Problem1", "This is the first error");
        // ModelState.AddModelError("Problem2", "This is the second error");

        // return ValidationProblem();
        return Ok();
    }   
}
