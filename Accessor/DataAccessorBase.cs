using UnityEngine;
using UnityEditor;
using System.Collections;

namespace PAG.Accessor {
	public abstract class DataAccessorBase : IDataAccessor {
		protected Object prefab;
		
		protected GameObject GetGameObjectFromPrefab(string prefabPath) {
			Object prefab = (UnityEngine.Object)AssetDatabase.LoadAssetAtPath(prefabPath, typeof(Object));
			Object[] gameObjects = GameObject.FindObjectsOfTypeIncludingAssets(typeof(GameObject));

			foreach(Object obj in gameObjects) {
				if(AssetDatabase.GetAssetPath(obj) == prefabPath && obj.GetType() == typeof(GameObject)) {
					return (GameObject)obj;
				}
			}
			
			return null;
		}
		
		public virtual Object GetValue(string key) {
			return null;
		}
		
		public virtual void SetValue(Object val, string key) {
		}
	}
}
