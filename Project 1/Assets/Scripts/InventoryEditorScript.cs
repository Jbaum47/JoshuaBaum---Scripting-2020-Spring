using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// Found this at: https://learn.unity.com/tutorial/adventure-game-phase-2-inventory-system#5c7f8528edbc2a002053b392
public class InventoryEditorScript : Editor
{
    private bool[] showItemSlots = new bool[InventoryScript.numItemSlots];
    private SerializedProperty itemImagesProperty;
    private SerializedProperty itemsProperty;
    private const string inventoryPropItemImagesName = "itemImages";
    private const string inventoryPropItemsName = "items";

    private void OnEnable()
    {
        itemImagesProperty = serializedObject.FindProperty(inventoryPropItemImagesName);
        itemsProperty = serializedObject.FindProperty(inventoryPropItemsName);
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        for (int i = 0; i < InventoryScript.numItemSlots; i++)
        {
            ItemSlotGUI(i);
        }

        serializedObject.ApplyModifiedProperties();
    }

    private void ItemSlotGUI(int i)
    {
        throw new NotImplementedException();
    }

    private void ItemSlotGui(int index)
    {
        EditorGUILayout.BeginVertical(GUI.skin.box);
        EditorGUI.indentLevel++;

        showItemSlots[index] = EditorGUILayout.Foldout(showItemSlots[index], "Item slot" + index);
        if (showItemSlots[index])
        {
            EditorGUILayout.PropertyField(itemImagesProperty.GetArrayElementAtIndex(index));
            EditorGUILayout.PropertyField(itemsProperty.GetArrayElementAtIndex(index));
        }

        EditorGUI.indentLevel--;
        EditorGUILayout.EndVertical();
    }
}

