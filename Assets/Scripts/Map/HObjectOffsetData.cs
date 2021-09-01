using System;
using UnityEngine;

namespace H
{
    public class HObjectOffsetData : MonoBehaviour
    {
        [SerializeField]
        private Transform[] trsTargets;

        [SerializeField]
        private Transform[] trsGroups;

        [Header("オフセット")]
        [SerializeField]
        private HObjectOffsetData.OffsetData[] targetOffsets;

        [SerializeField]
        private HObjectOffsetData.OffsetData[] groupOffsets;

        [Header("バックアップ位置・回転")]
        [SerializeField]
        private Vector3[] _targetBackupPos;

        [SerializeField]
        private Vector3[] _targetBackupAng;

        [SerializeField]
        private Vector3[] _groupBackupPos;

        [SerializeField]
        private Vector3[] _groupBackupAng;

        [Header("デバッグ用")]
        [SerializeField]
        private Transform _map;

        public int MoveOffsetButton;

        [Serializable]
        public class OffsetData
        {
            public bool usePos;

            public bool useAng;

            public Vector3 pos = Vector3.zero;

            public Vector3 ang = Vector3.zero;
        }
    }
}
