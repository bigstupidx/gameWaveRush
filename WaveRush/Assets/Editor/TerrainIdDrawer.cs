﻿using UnityEditor;
using UnityEngine;

//[CustomPropertyDrawer(typeof(Map.TerrainObjectIds))]
public class TerrainIdDrawer : PropertyDrawer {
	
	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label) {
		label = EditorGUI.BeginProperty (position, label, property);
		Rect contentPosition = EditorGUI.PrefixLabel(position, label);
		contentPosition.width *= 0.5f;
		EditorGUI.indentLevel = 0;
		EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("sprite"), GUIContent.none);
		contentPosition.x += contentPosition.width;
		//contentPosition.width /= 0.5f;
		EditorGUIUtility.labelWidth = 40f;
		EditorGUI.PropertyField(contentPosition, property.FindPropertyRelative("name"), new GUIContent("Name"));
		EditorGUI.EndProperty ();
	}
}