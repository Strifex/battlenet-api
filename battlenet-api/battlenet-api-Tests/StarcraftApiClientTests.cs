using battlenet_api;
using battlenet_api.Models.Starcraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace battlenet_api_Tests
{
    [TestClass]
    public class StarcraftApiClientTests
    {
        private string apiKey = "8y9jdy72d85dq7bvgdqwb28w3ysuxew4";
        private StarcraftApiClient client;

        [TestInitialize]
        public void Initialize()
        {
            client = new StarcraftApiClient(apiKey, Region.US, Locale.en_US);
        }

        [TestMethod]
        public async Task RetrieveAchievementListAsyncTest()
        {
            AchievementList achievements = await client.RetrieveAchievementListAsync();

            Assert.IsNotNull(achievements);
        }

        [TestMethod]
        public async Task RetrieveRewardsAsyncTest()
        {
            Rewards rewards = await client.RetrieveRewardsAsync();

            Assert.IsNotNull(rewards);
        }

        [TestCleanup]
        public void Cleanup()
        {
            client.Dispose();
        }
    }
}
