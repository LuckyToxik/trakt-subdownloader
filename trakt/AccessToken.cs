using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trakt
{
    class AccessToken
    {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string refresh_token { get; set; }
            public string scope { get; set; }
            public int created_at { get; set; }

        public AccessToken()
        {
            this.access_token = "5623ea415ab68f6f02fb29fae7e2615e414067672b4fe91ba417a0ee52c3091e";
        }


    }
}
