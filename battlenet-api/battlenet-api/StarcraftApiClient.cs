using battlenet_api.Models.Starcraft;
using System.Threading.Tasks;

namespace battlenet_api
{
    public class StarcraftApiClient : BattleNetApiClient
    {
        public StarcraftApiClient(string apiKey, Region region, Locale locale) : base(apiKey, region, locale)
        {

        }
            
        public async Task<AchievementList> RetrieveAchievementListAsync()
        {
            string url = baseURL + "/sc2/data/achievements" + "?locale=" + Locale + "&apiKey=" + ApiKey;

            AchievementList achievements = await webClient.GetDataAsync<AchievementList>(url);

            return achievements;
        }

        public async Task<Rewards> RetrieveRewardsAsync()
        {
            string url = baseURL + "/sc2/data/rewards" + "?locale=" + Locale + "&apiKey=" + ApiKey;

            Rewards rewards = await webClient.GetDataAsync<Rewards>(url);

            return rewards;
        }
    }
}
