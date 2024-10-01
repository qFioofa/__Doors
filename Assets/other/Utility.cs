using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Utility{
    public static class gUtility{
        public static bool IsInt(float number){
            return number %1 ==0;
        }

        private readonly static float sCursorFix = 2.5f;
        public static Vector3 sGetCursorPosition(Camera camera, float zValue = 0){
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = camera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, sCursorFix));
            mousePosition.z = zValue;
            return mousePosition;
        }

        public static Vector3 sGetCursorPosition(float zValue = 0){
            return sGetCursorPosition(Camera.main,zValue);
        }

        public static Vector3 vectorFromObjToCursor(Transform obj, Camera camera){
            return sGetCursorPosition(camera) - obj.position;
        }

        public static Vector3 vectorFromObjToCursor(Transform obj){
            return sGetCursorPosition() - obj.position;
        }
        public static float AngleFromVector(Vector3 vec){
            vec = vec.normalized;
            float n = Mathf.Atan2(vec.y,vec.x)*Mathf.Rad2Deg;
            if(n<0){
                n+=360;
            }
            return n;
        }
        public static GameObject GetPrefab(string path){
            return (GameObject)AssetDatabase.LoadAssetAtPath(path, typeof(GameObject));
        }
    }
}