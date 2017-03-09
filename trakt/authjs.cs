using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trakt
{
    class authjs
    {
        public string code { get; set; }
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string redirect_uri { get; set; }
        public string grant_type { get; set; }
    
    public authjs()
        {
            this.client_id = "356842828a7106538cfda000bbd7a6df2d7df01de76c23293288444804d690fb";
            this.client_secret = "aa00d7b2816124bfcc88c61b4a47008e57d8f32bbd8c8a05c2e7e75527bcbdd2";
            this.redirect_uri = "urn:ietf:wg:oauth:2.0:oob";
            this.grant_type = "authorization_code";
           
        }


    }
}
