using battlenet_api.Models.Warcraft;
using System.Threading.Tasks;

namespace battlenet_api
{
    public class WarcraftApiClient : BattleNetApiClient
    {
        public WarcraftApiClient(string apiKey, Region region, Locale locale) : base (apiKey, region, locale)
        {

        }

        #region ACHIEVEMENT API
        public async Task<Achievement> RetrieveAchievementAsync(string id)
        {
            string url = baseURL + "/wow/achievement/" + id + "?locale=" + Locale + "&apiKey=" + ApiKey;

            Achievement achievement = await webClient.GetDataAsync<Achievement>(url);

            return achievement;
        }
        #endregion

        #region AUCTION API
        public async Task<AuctionDataStatus> RetrieveAuctionDataStatus(string realm)
        {
            string url = baseURL + "/wow/auction/data/" + realm + "?locale=" + Locale + "&apiKey=" + ApiKey;

            AuctionDataStatus auctionDataStatus = await webClient.GetDataAsync<AuctionDataStatus>(url);

            return auctionDataStatus;
        }
        #endregion

        #region BATTLEPET API
        public async Task<BattlePetAbility> RetrieveBattlePetAbility(string id)
        {
            string url = baseURL + "/wow/battlePet/ability/" + id + "?locale=" + Locale + "&apiKey=" + ApiKey;

            BattlePetAbility petAbility = await webClient.GetDataAsync<BattlePetAbility>(url);

            return petAbility;
        }
        #endregion
    }
}
