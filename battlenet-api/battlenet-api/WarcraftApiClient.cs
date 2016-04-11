using battlenet_api.Models.Warcraft;
using System.Collections.Generic;
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
        public async Task<AuctionDataStatus> RetrieveAuctionDataStatusAsync(string realm)
        {
            string url = baseURL + "/wow/auction/data/" + realm + "?locale=" + Locale + "&apiKey=" + ApiKey;

            AuctionDataStatus auctionDataStatus = await webClient.GetDataAsync<AuctionDataStatus>(url);

            return auctionDataStatus;
        }
        #endregion

        #region BOSS API
        public async Task<List<Boss>> RetrieveAllBossesAsync()
        {
            string url = baseURL + "/wow/boss/?locale=" + Locale + "&apiKey=" + ApiKey;

            BossMasterList masterList = await webClient.GetDataAsync<BossMasterList>(url);

            return masterList.bosses;
        }

        public async Task<Boss> RetrieveBossAsync(int id)
        {
            string url = baseURL + "/wow/boss/" + id + "?locale=" + Locale + "&apiKey=" + ApiKey;

            Boss boss = await webClient.GetDataAsync<Boss>(url);

            return boss;
        }
        #endregion

        #region CHALLENGE MODE API

        #endregion

        #region PET API
        public async Task<BattlePetAbility> RetrievePetAbilityAsync(string id)
        {
            string url = baseURL + "/wow/pet/ability/" + id + "?locale=" + Locale + "&apiKey=" + ApiKey;

            BattlePetAbility petAbility = await webClient.GetDataAsync<BattlePetAbility>(url);

            return petAbility;
        }
        #endregion
    }
}
