using UnityEngine;
using UnityEditor;

namespace U.Universal.Sound
{
    [CustomEditor(typeof(AudioEventsListener))]
    [CanEditMultipleObjects()]
    public class AudioEventsListenerCustomInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            AudioEventsListener c = (AudioEventsListener)target;

            if (!Application.isPlaying) 
            { 
                GUILayout.Label("This component is added automatically when necesary.");
                GUILayout.Label("Dont try to add it manually !");
            }
            else
            {
                GUILayout.Label("I'm working, Dont remove me !");
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
