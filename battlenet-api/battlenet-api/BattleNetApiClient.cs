using battlenet_api.Utilities;
using System;

namespace battlenet_api
{
    public abstract class BattleNetApiClient : IDisposable
    {
        private Region region;

        public string ApiKey { get; set; }
        public Region Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
                SetRegionURL(value);
            }
        }
        public Locale Locale { get; set; }

        protected string baseURL;
        protected WebRequestUtility webClient = new WebRequestUtility();

        public BattleNetApiClient(string apiKey, Region region, Locale locale)
        {
            ApiKey = apiKey;
            Region = region;
            Locale = locale;
        }

        private void SetRegionURL(Region region)
        {
            switch (region)
            {
                case Region.US:
                    baseURL = "https://us.api.battle.net";
                    break;
                case Region.EU:
                    baseURL = "https://eu.api.battle.net";
                    break;
                case Region.KR:
                    baseURL = "https://kr.api.battle.net";
                    break;
                case Region.TW:
                    baseURL = "https://tw.api.battle.net";
                    break;
                case Region.CN:
                    baseURL = "https://www.battlenet.com.cn";
                    break;
            }
        }

        public void Dispose()
        {
            if (webClient != null)
            {
                webClient.Dispose();
            }
        }
    }
}
