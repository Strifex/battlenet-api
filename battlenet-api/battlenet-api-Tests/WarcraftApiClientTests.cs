using Microsoft.VisualStudio.TestTools.UnitTesting;
using battlenet_api.Models.Warcraft;
using battlenet_api;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace battlenet_api_Tests
{
    /// <summary>
    /// Summary description for WowApiClientTests
    /// </summary>
    [TestClass]
    public class WarcraftApiClientTests
    {
        private string apiKey = "8y9jdy72d85dq7bvgdqwb28w3ysuxew4";
        private WarcraftApiClient _client;

        [TestInitialize]
        public void Initialize()
        {
            _client = new WarcraftApiClient(apiKey, Region.US, Locale.en_US);
        }

        [TestMethod]
        public async Task RetrieveAchievementAsyncTest()
        {
            Achievement achievement = await _client.RetrieveAchievementAsync("2144");

            Assert.IsNotNull(achievement);
            Assert.AreEqual(2144, achievement.id);
        }

        [TestMethod]
        public async Task RetrieveAuctionDataStatusAsyncTest()
        {
            AuctionDataStatus auctionDataStatus = await _client.RetrieveAuctionDataStatusAsync("Stormrage");

            Assert.IsNotNull(auctionDataStatus);
        }

        [TestMethod]
        public async Task RetrieveAllBossesAsyncTest()
        {
            List<Boss> bosses = await _client.RetrieveAllBossesAsync();

            Assert.IsNotNull(bosses);
            Assert.IsTrue(bosses.Count > 0);
        }

        [TestMethod]
        public async Task RetrieveBossAsyncTest()
        {
            Boss boss = await _client.RetrieveBossAsync(24723);

            Assert.IsNotNull(boss);
            Assert.AreEqual(24723, boss.id);
        }

        [TestMethod]
        public async Task RetrievePetAbilityTest()
        {
            BattlePetAbility petAbility = await _client.RetrievePetAbilityAsync("640");

            Assert.IsNotNull(petAbility);
            Assert.AreEqual(640, petAbility.id);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _client.Dispose();
        }
    }
}
