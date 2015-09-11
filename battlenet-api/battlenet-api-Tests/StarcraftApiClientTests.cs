using battlenet_api;
using battlenet_api.Models.Starcraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace battlenet_api_Tests
{
    [TestClass]
    public class StarcraftApiClientTests
    {
        string apiKey = "8y9jdy72d85dq7bvgdqwb28w3ysuxew4";

        [TestMethod]
        public async Task RetrieveAchievementListAsyncTest()
        {
            StarcraftApiClient client = new StarcraftApiClient(apiKey, Region.US, Locale.en_US);
            AchievementList achievements = await client.RetrieveAchievementListAsync();

            Assert.IsNotNull(achievements);
        }

        [TestMethod]
        public async Task RetrieveRewardsAsyncTest()
        {
            StarcraftApiClient client = new StarcraftApiClient(apiKey, Region.US, Locale.en_US);
            Rewards rewards = await client.RetrieveRewardsAsync();

            Assert.IsNotNull(rewards);
        }
    }
}
