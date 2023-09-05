using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject {

    // Personal rule - never write to a Scriptable object
    // May revrite it to private and add get function
    public Transform prefab;
    public Sprite sprite;
    public string objectName;
}
