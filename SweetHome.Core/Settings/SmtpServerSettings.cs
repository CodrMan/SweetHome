﻿using SweetHome.Core.Reflection;

namespace SweetHome.Core.Settings
{
    public class SmtpServerSettings
    {
        [SettingProperty("SmtpServerAddress")]
        public string ServerName { get; set; }

        [SettingProperty("SmtpServerPort")]
        public int ServerPort { get; set; }

        [SettingProperty("SmtpUseSSL")]
        public bool UseSSL { get; set; }
    }
}
