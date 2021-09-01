using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New MapThumbnailInfo", menuName = "Map Thumbnail Info", order = 52)]
public class MapThumbnailInfo : ScriptableObject
{
    public List<MapThumbnailInfo.Param> param = new List<MapThumbnailInfo.Param>();

    [Serializable]
    public class Param
    {
        public string Name;
        public int ID;
        public string Bundle;
        public string Asset;
    }
}
