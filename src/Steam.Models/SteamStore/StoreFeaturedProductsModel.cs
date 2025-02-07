﻿namespace Steam.Models.SteamStore
{
    public class StoreFeaturedProductsModel
    {
        public StoreLargeCapsuleModel[] LargeCapsules { get; set; }
        
        public StoreFeaturedWinModel[] FeaturedWin { get; set; }
        
        public StoreFeaturedMacModel[] FeaturedMac { get; set; }
        
        public StoreFeaturedLinuxModel[] FeaturedLinux { get; set; }
        
        public string Layout { get; set; }
        
        public uint Status { get; set; }
    }
}
