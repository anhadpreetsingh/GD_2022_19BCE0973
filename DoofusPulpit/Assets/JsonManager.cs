using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JsonManager : MonoBehaviour
{
    public TextAsset textJSON;
   
   [System.Serializable]
   public class PlayerData
   {
        public float speed;
   }

   [System.Serializable]
   public class PulpitData
   {
        public float min_pulpit_destroy_time;
        public float max_pulpit_destroy_time;
        public float pulpit_spawn_time;
   }

   [System.Serializable]
   public class RootObject
   {
        public PlayerData player_data;
        public PulpitData pulpit_data;
   }

   public RootObject rootObject;

   void Start()
   {
        rootObject = JsonUtility.FromJson<RootObject>(textJSON.text);
        //Debug.Log(rootObject.player_data.speed);
   }

}
