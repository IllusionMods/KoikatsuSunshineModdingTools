using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New HCameraVanishData", menuName = "H Camera Vanish Data", order = 53)]
public class HCameraVanishData : ScriptableObject
{
    public List<HCameraVanishData.Param> param = new List<HCameraVanishData.Param>();

    [Serializable]
    public class Param
    {
        public string nameCollider = "";
        public List<string> nameVisibleObj = new List<string>();
    }
}
