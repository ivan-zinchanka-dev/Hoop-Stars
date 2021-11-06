using UnityEngine;
using UnityEditor;

public class PluginManager : MonoBehaviour
{
    public ToastPlugin ToastPlug { get; private set; } = null;


    public class ToastPlugin {

        private const string ClassName = "com.ivan.hoop_stars_android_plugin.ToastPlugin";
        private const string ShowMethodName = "Show";

        private AndroidJavaClass _javaClass = null;

        public ToastPlugin() {

            _javaClass = new AndroidJavaClass(ClassName);
        }

        public void Show(string text, bool isLong) {

            _javaClass.CallStatic(ShowMethodName, text, isLong);       
        }

    }


    private void Awake()
    {
#if UNITY_ANDROID && !UNITY_EDITOR

        ToastPlug = new ToastPlugin();         
#endif
    }

    private void Start()
    {
#if UNITY_ANDROID && !UNITY_EDITOR


        Hoop.Goal += () => ToastPlug.Show("Goal!", false);

#endif

    }

}
