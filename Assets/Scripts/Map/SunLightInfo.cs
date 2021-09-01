using Illusion.Component.UI;
using System;
using System.Collections.Generic;
using UnityEngine;

public class SunLightInfo : MonoBehaviour
{
    [Tooltip("サンライト")]
    [SerializeField]
    private Light _targetLight;

    [Tooltip("2D背景パラメータ")]
    [SerializeField]
    private BackGroundParam _bgParam;

    [SerializeField]
    private SunLightInfo.Info[] _infos;

    [Serializable]
    public class Info
    {
        [Tooltip("時間帯")]
        public SunLightInfo.Info.Type type;

        [Header("2D背景画像の設定")]
        [Tooltip("BackTexture")]
        public Texture2D backTexture;

        [Header("表示オブジェクトの設定")]
        public List<GameObject> visibleList = new List<GameObject>();

        [Header("サンライトの設定")]
        [Tooltip("角度")]
        public Vector3 angle;

        [Tooltip("色")]
        public Color color;

        [Tooltip("強さ")]
        public float intensity;

        [Header("Lighting Windowの設定")]
        [ColorUsage(false, true)]
        [Tooltip("SkyColor")]
        public Color ambientSkyColor = Color.white;

        [ColorUsage(false, true)]
        [Tooltip("EquatorColor")]
        public Color ambientEquatorColor = Color.white;

        [ColorUsage(false, true)]
        [Tooltip("GroundColor")]
        public Color ambientGroundColor = Color.white;

        [Header("フォグの設定")]
        [Tooltip("使用するか")]
        public bool fogUse;

        [Tooltip("色")]
        public Color fogColor;

        [Tooltip("開始距離")]
        public float fogStart;

        [Tooltip("終了距離")]
        public float fogEnd;

        [Tooltip("密度")]
        public float fogDensity;

        [Header("グローバルフォグの設定")]
        [Tooltip("distanceFog")]
        public bool glFogDistanceFog = true;

        [Tooltip("heightFog")]
        public bool glFogHeightFog = true;

        [Tooltip("height")]
        public float glFogHeight;

        [Tooltip("startDistance")]
        public float glFogStartDistance;

        [Header("カメラのサンシャフト(SunShafts)設定")]
        [Tooltip("Shafts caster")]
        public Transform sunShaftsTransform;

        [Tooltip("Shafts color")]
        public Color sunShaftsColor;

        [Tooltip("Threshold color")]
        public Color sunThresholdColor;

        [Tooltip("Distance falloff")]
        public float sunMaxRadius;

        [Tooltip("Blur size")]
        public float sunShaftBlurRadius;

        [Tooltip("Blur iterations")]
        public int sunRadialBlurIterations;

        [Tooltip("Intensity")]
        public float sunShaftIntensity;

        [Header("カメラのカラーエフェクト(AmplifyColorEffect)設定")]
        [Tooltip("LutTexture")]
        public Texture aceLutTexture;

        [Tooltip("LutBlendTexture")]
        public Texture aceLutBlendTexture;

        [Tooltip("BlendAmount")]
        public float aceBlendAmount;

        [Header("カメラのオクルージョンエフェクト(AmplifyOcclusionEffect)設定")]
        [Tooltip("Tint")]
        public Color aoeTint;

        [Tooltip("Radius")]
        public float aoeRadius;

        [Tooltip("PowerExponent")]
        public float aoePowerExponent;

        [Tooltip("Bias")]
        public float aoeBias;

        [Header("ブルームとフレア(BloomAndFlares)設定")]
        [Tooltip("Intensity")]
        public float bafBloomIntensity;

        [Tooltip("threshold")]
        public float bafBloomThreshold;

        [Tooltip("Blur spread")]
        public float bafSepBlurSpread;

        [Header("デプスオブフィールド(DepthOfField)設定")]
        [Tooltip("Focus on Transform")]
        public Transform dofFocalTransform;

        [Tooltip("focalSize")]
        public float dofFocalSize;

        [Tooltip("Aperture")]
        public float dofAperture;

        [Header("Vignette(VignetteAndChromaticAberration)設定")]
        [Tooltip("Vignetting")]
        public float vignetteIntensity;

        [Tooltip("Blurred Corners")]
        public float vignetteBlur;

        [Tooltip("Blur Distance")]
        public float vignetteBlurSpread;

        public enum Type
        {
            Morning,
            DayTime,
            Evening,
            Night
        }
    }
}