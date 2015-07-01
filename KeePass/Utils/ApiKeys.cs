﻿using System;

namespace KeePass.Utils
{
    internal static class ApiKeys
    {
#warning WinPass needs API Keys to use web services
        public const string DROPBOX_KEY = "YOUR_DROPBOX_KEY";
        public const string DROPBOX_SECRET = "YOUR_DROPBOX_SECRET";
        public const string MIXPANEL_TOKEN = "YOUR_MIXPANEL_TOKEN";
        public const string ONEDRIVE_SECRET = "YOUR_ONEDRIVE_SECRET";
        public const string ONEDRIVE_CLIENT_ID = "YOUR_ONEDRIVE_CLIENT_ID";
        public const string ONEDRIVE_REDIRECT = "https://login.live.com/oauth20_desktop.srf";
    }
}