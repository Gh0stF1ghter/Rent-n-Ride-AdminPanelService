﻿using Mapster;
using System.Reflection;

namespace AdminPanel.BLL.MappingConfigurations;

public static class GlobalMappingSettings
{
    public static void SetMapper()
    {
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        TypeAdapterConfig.GlobalSettings.Default.MaxDepth(2);
        TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
    }
}