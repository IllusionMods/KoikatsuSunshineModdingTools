using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New MapInfo", menuName = "Map List Info", order = 51)]
public class MapInfo : ScriptableObject
{
    public List<MapInfo.Param> param = new List<MapInfo.Param>();

    [Serializable]
	public class Param
	{
		public string MapName;
		public string DisplayName;
		public int No;
		public int Sort;
		public string AssetBundleName;
		public string AssetName;
		public bool isGate;
		public bool is2D;
		public bool isWarning;
		public int State;
		public int LookFor;
		public bool isOutdoors;
		public bool isFreeH;
		public bool isSpH;
		public bool isSky;
		public bool isH;
		public int ThumbnailMorningID = -1;
		public int ThumbnailDayTimeID = -1;
		public int ThumbnailEveningID = -1;
		public int ThumbnailNightID = -1;
	}
}
