using Microsoft.VisualStudio.TestTools.UnitTesting;
using battlenet_api.Models.Warcraft;
using battlenet_api;
using System.Threading.Tasks;

namespace battlenet_api_Tests
{
    /// <summary>
    /// Summary description for WowApiClientTests
    /// </summary>
    [TestClass]
    public class WarcraftApiClientTests
    {
        string apiKey = "8y9jdy72d85dq7bvgdqwb28w3ysuxew4";

        [TestMethod]
        public async Task RetrieveAchievementAsyncTest()
        {
            WarcraftApiClient client = new WarcraftApiClient(apiKey, Region.US, Locale.en_US);
            Achievement achievement = await client.RetrieveAchievementAsync("2144");

            Assert.IsNotNull(achievement);
            Assert.AreEqual(2144, achievement.id);
        }

        [TestMethod]
        public async Task RetrieveAuctionDataStatusAsync()
        {
            WarcraftApiClient client = new WarcraftApiClient(apiKey, Region.US, Locale.en_US);
            AuctionDataStatus auctionDataStatus = await client.RetrieveAuctionDataStatus("Stormrage");

            Assert.IsNotNull(auctionDataStatus);
        }

        [TestMethod]
        public async Task RetrieveBattlePetAbility()
        {
            WarcraftApiClient client = new WarcraftApiClient(apiKey, Region.US, Locale.en_US);
            BattlePetAbility petAbility = await client.RetrieveBattlePetAbility("640");

            Assert.IsNotNull(petAbility);
            Assert.AreEqual(640, petAbility.id);
        }
    }
}
