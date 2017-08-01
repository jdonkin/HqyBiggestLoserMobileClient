using System;
using System.Linq;
using BigLMobileClient.Dtos;
using BigLMobileClient.Services.Interfaces;
using System.Collections.Generic;

namespace BigLMobileClient.Services
{
    public class ChallengeActions : IWeeklyChallenge
    {
        public ChallengeActions()
        {
        }

        public string DisplayChallenge(List<WeeklyChallenge> challenges)
        {
            var reorderedChallenges = challenges.OrderByDescending(w => w.Week);
            return reorderedChallenges.FirstOrDefault().ChallengeName;
        }
    }
}
