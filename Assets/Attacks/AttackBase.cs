using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBase: MonoBehaviour {
    [SerializeField] protected Transform spawn;

    public virtual Transform Spawn{
        get { return spawn; }
        set { spawn = value; }
    }
    [SerializeField] protected GameObject bulletPrefub;
    [SerializeField] protected float dmg;
    [SerializeField] protected float bulletLifeTime = 0f;
    protected BulletBehavior bulletBevahiar;
    protected GameObject bullet;
    public virtual void Setup(){}
    public virtual void LoadComponents(){
        bulletBevahiar = bulletPrefub.GetComponent<BulletBehavior>();
    }
    public virtual void Shoot(){}
    public virtual void Shoot(Transform spawn){
        this.spawn = spawn;
    }
    public virtual void InitBullet(){
        bullet = Instantiate(bulletPrefub,spawn.position, Quaternion.identity);
    }
    public virtual void DetsroyBullet(){
        bullet.GetComponent<BulletBehavior>().BulletDestroy(bulletLifeTime);
    }
}