using System;
using BigLMobileClient.Dtos;
using System.Collections.Generic;

namespace BigLMobileClient.Services.Interfaces
{
    public interface IWeeklyChallenge
    {
        string DisplayChallenge(List<WeeklyChallenge> challenges);
    }
}
