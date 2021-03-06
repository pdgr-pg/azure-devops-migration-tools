﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationTools.Configuration
{
    public interface IEngineConfigurationBuilder
    {
        EngineConfiguration BuildFromFile(string configFile = "configuration.json");
        EngineConfiguration BuildDefault();
        EngineConfiguration BuildWorkItemMigration();
        EngineConfiguration CreateEmptyConfig();

    }
}
