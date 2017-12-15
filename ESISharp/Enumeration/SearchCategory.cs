﻿namespace ESISharp.Enumeration
{
    public class SearchCategory : Model.Abstract.FakeEnumerator
    {
        internal SearchCategory(string value) : base(value) { }

        public static readonly SearchCategory All = new SearchCategory("agent,alliance,character,constellation,corporation,faction,inventorytype,region,solarsystem,station,wormhole");
        public static readonly SearchCategory Agent = new SearchCategory("agent");
        public static readonly SearchCategory Alliance = new SearchCategory("alliance");
        public static readonly SearchCategory Character = new SearchCategory("character");
        public static readonly SearchCategory Constellation = new SearchCategory("constellation");
        public static readonly SearchCategory Corporation = new SearchCategory("corporation");
        public static readonly SearchCategory Faction = new SearchCategory("faction");
        public static readonly SearchCategory InventoryType = new SearchCategory("inventorytype");
        public static readonly SearchCategory Region = new SearchCategory("region");
        public static readonly SearchCategory SolarSystem = new SearchCategory("solarsystem");
        public static readonly SearchCategory Station = new SearchCategory("station");
    }
}
