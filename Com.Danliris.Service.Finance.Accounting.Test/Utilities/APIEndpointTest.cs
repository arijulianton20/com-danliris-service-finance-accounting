﻿using Com.Danliris.Service.Finance.Accounting.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Danliris.Service.Finance.Accounting.Test.Utilities
{
   public class APIEndpointTest
    {


        [Fact]
        public void Should_succes_intantiate_APIEndpoint()
        {
            string core = "core test";
            string inventory = "Inventory test";
            string production = "Production test";
            string purchasing = "Purchasing test";
            string finishing = "Finishing test";
            string finance = "Finance test";

            APIEndpoint.Core = core;
            APIEndpoint.Inventory = inventory;
            APIEndpoint.Production = production;
            APIEndpoint.Purchasing = purchasing;
            APIEndpoint.Finishing = finishing;
            APIEndpoint.Finance = finance;

            Assert.Equal(core, APIEndpoint.Core);
            Assert.Equal(inventory, APIEndpoint.Inventory);
            Assert.Equal(production, APIEndpoint.Production);
            Assert.Equal(purchasing, APIEndpoint.Purchasing);
            Assert.Equal(finishing, APIEndpoint.Finishing);
            Assert.Equal(finance,APIEndpoint.Finance);
            
        }
        
    }
}
