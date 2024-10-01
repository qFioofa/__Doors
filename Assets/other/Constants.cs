using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Constants{
    public static class AttackConstants{
        public readonly static int SpecialAttackSpace = 2;
        public readonly static int GeneralAttackSpace = 4;
        public readonly static int SampleSpace = 8;
        public readonly static float PlayerSpeedCarriage = 2f;
    }

    public static class SimpleGuitarConstants{
        public readonly static string prefabPath = "Assets/Attacks/Bullet.prefab";
        public readonly static float dmg = 1f;
        public readonly static float bulletLifeTime = 2f;
    }
}
