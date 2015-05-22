﻿using System.ComponentModel;

namespace Ignite.SharpNetSH.WLAN
{
    public enum Permission
    {
        [Description("allow")]
        Allow,
        [Description("block")]
        Block,
        [Description("denyall")]
        DenyAll
    }
}
