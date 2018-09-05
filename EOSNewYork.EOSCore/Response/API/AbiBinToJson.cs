﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EOSNewYork.EOSCore.Params;
using EOSNewYork.EOSCore.Lib;

namespace EOSNewYork.EOSCore.Response.API
{
    public class AbiBinToJson : IEOAPI
    {
        public object args { get; set; }
        
        public EOSAPIMetadata GetMetaData()
        {
            var meta = new EOSAPIMetadata
            {
                uri = "/v1/chain/abi_bin_to_json"
            };

            return meta;
        }
    }
}
