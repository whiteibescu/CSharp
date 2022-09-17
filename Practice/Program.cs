using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Resources;

/* ScriptableObject와 MonoBehaviour의 파생 클래스는 [Serializable]이 디폴트다. */
// 직렬화 대상 필드 : "{Players[{Name, Color, BrainName}], NumberOfRounds}"
[CreateAssetMenu]
public class GameSettings : ScriptableObject
{

    [Serializable]
    public class PlayerInfo
    {
        /* [Serializable] class의 public 필드는 직렬화 대상이다. (프로퍼티 제외) */
        // 3가지 필드(Name, Color, BrainName)가 직렬화된다.
        public string Name;
        public Color Color;

        private TankBrain _cachedBrain;
        // 필드 Brain은 프로퍼티이므로 직렬화 대상에서 제외된다.
        public TankBrain Brain
        {
            get
            {
                if (!_cachedBrain && !String.IsNullOrEmpty(BrainName))
                {
                    TankBrain[] availableBrains;

#if UNITY_EDITOR
                    // 에디터에서 플레이 시에는 메모리에서 찾을 수 없으므로 AssetDatabase를 사용한다.
                    availableBrains = UnityEditor.AssetDatabase.FindAssets("t:TankBrain")
                                    .Select(guid => UnityEditor.AssetDatabase.GUIDToAssetPath(guid))
                                    .Select(path => UnityEditor.AssetDatabase.LoadAssetAtPath<TankBrain>(path))
                                    .Where(b => b).ToArray();
#else
                    // 빌드 런타임 시에는 에셋들이 메모리에 로드됐으므로 Find로 찾을 수 있다.
                    availableBrains = Resources.FindObjectsOfTypeAll<TankBrain>();
#endif

                    _cachedBrain = availableBrains.FirstOrDefault(b => b.name == BrainName);
                }
                return _cachedBrain;
            }
            set
            {
                _cachedBrain = value;
                BrainName = value ? value.name : String.Empty;
            }
        }

        /* 에셋을 참조하는 것을 직접 JSON으로 직렬화하면 Instance ID가 저장되는데,
         Instance ID는 모든 Session(프로젝트가 위치할 수 있는 경로)에서 고정된 값이 아니다.
         Instance ID는 Session(프로젝트가 위치할 수 있는 경로)에 따라 가변하는 값이므로
         고정값인 string을 저장하는 것이 안정적이다. ('파일명'도 경로에 포함된다)*/

        // priavate이지만 [SerializeField]의 필드이므로 직렬화 대상에 포함된다.
        [SerializeField] private string BrainName;

        public string GetColoredName()
        {
            return "<color=#" + ColorUtility.ToHtmlStringRGBA(Color) + ">" + Name + "</color>";
        }
    }

    // 직렬화 대상
    public List<PlayerInfo> players;

    private static GameSettings _instance;
    public static GameSettings Instance
    {
        // GameSettings는 싱글톤이다.
        get
        {
            // 런타임 상에서는 에셋이 메모리에 로드됐으므로 가져올 수 있다.
            if (!_instance)
                // 싱글톤이므로 에셋들 중 하나만 가지고 초기화한다.
                _instance = Resources.FindObjectsOfTypeAll<GameSettings>().FirstOrDefault();
            // 에디터 상에서는 AssetDatabase를 사용한다
#if UNITY_EDITOR
            if (!_instance)
                // Test game settings.asset을 사용한다.
                InitializeFromDefault(UnityEditor.AssetDatabase.LoadAssetAtPath<GameSettings>("Assets/Test game settings.asset"));
#endif
            return _instance;
        }
    }

    public int NumberOfRounds;

    public static void LoadFromJSON(string path)
    {
        // 기존 인스턴스는 제거 "cf. Mono에서는 DestroyImmediate보다 Destroy 함수가 더 안전하다"
        if (_instance) DestroyImmediate(_instance);
        // 인스턴스 생성
        _instance = ScriptableObject.CreateInstance<GameSettings>();
        // 인스턴스의 직렬화 필드에 JSON 문자열 덮어쓰기
        JsonUtility.FromJsonOverwrite(System.IO.File.ReadAllText(path), _instance);
        _instance.hideFlags = HideFlags.HideAndDontSave;
    }

    public void SaveToJSON(string path)
    {
        Debug.LogFormat("Saving game settings to {0}", path);
        // 이 인스턴스를 JSON 파일로 변환 후 path에 저장
        System.IO.File.WriteAllText(path, JsonUtility.ToJson(this, true));
    }

    public static void InitializeFromDefault(GameSettings settings)
    {
        // 기존 인스턴스 제거
        if (_instance) DestroyImmediate(_instance);
        // 에셋의 인스턴스 할당. 
        // 인스턴스를 그대로 안쓰고 복사본을 생성하는 이유는 HideFlag 설정 때문이다.
        _instance = Instantiate(settings);
        _instance.hideFlags = HideFlags.HideAndDontSave;
    }
}