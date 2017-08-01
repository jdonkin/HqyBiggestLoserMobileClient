using System;
using System.Collections.Generic;
using BigLMobileClient.Dtos;

namespace BigLMobileClient.Services.Interfaces
{
    public interface ITeamPoints
    {
        List<string> GetTeamNames(List<TeamDto> teams);
        decimal GetPoints(List<TeamDto> teamInfo, string teamName);
    }
}
