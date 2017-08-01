using System;
using System.Collections.Generic;
using BigLMobileClient.Dtos;
using BigLMobileClient.Services.Interfaces;
using System.Linq;

namespace BigLMobileClient.Services
{
    public class TeamPoints : ITeamPoints
    {
        public TeamPoints(){}

        public decimal GetPoints(List<TeamDto> teamInfo, string teamName)
        {
            return teamInfo.FirstOrDefault(name => name.TeamName == teamName).Points;
        }

        public List<string> GetTeamNames(List<TeamDto> teams)
        {
            return teams.Select(name => name.TeamName).ToList();
        }
    }
}
