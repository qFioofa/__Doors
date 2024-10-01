using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Constants;
using Utility;
using UnityEditor;
public class SimpleGuitar: AttackBase{
    public override void Setup(){
        base.Setup();

        bulletPrefub = gUtility.GetPrefab(SimpleGuitarConstants.prefabPath);
        bulletLifeTime = SimpleGuitarConstants.bulletLifeTime;
        dmg = SimpleGuitarConstants.dmg;

        base.LoadComponents();
    }
    public override void Shoot(){
        InitBullet();
        bulletBevahiar.Direction = gUtility.vectorFromObjToCursor(spawn).normalized;
        base.DetsroyBullet();
    }

    public override void Shoot(Transform spawn){
        this.spawn = spawn;
        this.Shoot();
    }

    public override void InitBullet(){
        base.InitBullet();
    }
}