using System;
using UnityEngine;
using UnityEditor;
using System.Collections;

namespace PAG.Accessor {
	public abstract class DataAccessorBase : IDataAccessor {
		protected UnityEngine.Object prefab;
		
		protected GameObject GetGameObjectFromPrefab(string prefabPath) {
			UnityEngine.Object prefab = (UnityEngine.Object)AssetDatabase.LoadAssetAtPath(prefabPath, typeof(UnityEngine.Object));
			UnityEngine.Object[] gameObjects = GameObject.FindObjectsOfTypeIncludingAssets(typeof(GameObject));

			foreach(UnityEngine.Object obj in gameObjects) {
				if(AssetDatabase.GetAssetPath(obj) == prefabPath && obj.GetType() == typeof(GameObject)) {
					return (GameObject)obj;
				}
			}
			
			return null;
		}
		
		public virtual System.Object GetValue(string key) {
			return null;
		}
		
		public virtual void SetValue(System.Object val, string key) {
		}
	}
}
