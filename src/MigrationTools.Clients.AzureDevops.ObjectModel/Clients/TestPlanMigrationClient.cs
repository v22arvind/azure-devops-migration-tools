﻿using System;
using System.Collections.Generic;
using MigrationTools.Configuration;

namespace MigrationTools.Clients.AzureDevops.ObjectModel.Clients
{
    public class TestPlanMigrationClient : ITestPlanMigrationClient
    {
        public IMigrationClientConfig Config => throw new NotImplementedException();

        public void Configure(IMigrationClient migrationClient, bool bypassRules = true)
        {
            // No current config
        }

        public TestPlanData CreateTestPlan()
        {
            throw new NotImplementedException();
        }

        public List<TestPlanData> GetTestPlans()
        {
            throw new NotImplementedException();
        }
    }
}