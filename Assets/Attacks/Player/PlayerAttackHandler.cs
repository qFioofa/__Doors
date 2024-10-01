using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Constants;

public class Sample{
    private AttackBase[] specialAttacks = new AttackBase[AttackConstants.SpecialAttackSpace];
    private AttackBase[] generalAttacks = new AttackBase[AttackConstants.GeneralAttackSpace];
    public Sample(){
        for(int i=0;i<AttackConstants.SpecialAttackSpace; i++){
            specialAttacks[i] = new AttackBase();
        }
        for(int i=0;i<AttackConstants.GeneralAttackSpace; i++){
            generalAttacks[i] = new AttackBase();
        }
    }
    public void Activate(Transform spawn){
        foreach(var item in specialAttacks){
            item.Shoot(spawn);
        }
        foreach(var item in generalAttacks){
            item.Shoot(spawn);
        }
    }

    public void LoadSpecialAttack(AttackBase attack, int position){
        if(position>=0 && position<AttackConstants.SpecialAttackSpace){
            specialAttacks[position] = attack;
            specialAttacks[position].Setup();
        }
    }
    public void LoadGeneralAttack(AttackBase attack, int position){
        if(position>=0 && position<AttackConstants.GeneralAttackSpace){
            generalAttacks[position] = attack;
            specialAttacks[position].Setup();
        }
    }
}

public class PlayerAttackHandler : MonoBehaviour{
    public Sample[] Table = new Sample[AttackConstants.SampleSpace];
    private static class Carriage{
        public static float Value{
            get { return _Value; }
            set { _Value = value; }
        }
        private static float _Value = 0f;
        public static void MakeStep(){
            _Value += Time.deltaTime * AttackConstants.PlayerSpeedCarriage;
            if(_Value >AttackConstants.SampleSpace){
                _Value = 0f;
            }
        }
    }

    private void Awake(){
        for(int i=0;i<AttackConstants.SampleSpace; i++){
            Table[i] = new Sample();
        }
        Table[0].LoadSpecialAttack(new SimpleGuitar(), 0);
    }

    private void Update(){
        Carriage.MakeStep();
        ShootHandler();
    }

    private int TablePtr = 0;
    private int getPtr(){
        return TablePtr++ % AttackConstants.SampleSpace;
    }

    private static class IntHandler{
        private static int cNumber = 0;
        private static int pNumber = 0;
        public static bool pass(float number){
            pNumber = cNumber;
            cNumber = (int)number;
            return pNumber != cNumber;
        }
    }
    private void ShootHandler(){
        if(IntHandler.pass(Carriage.Value)){
            int ptr = getPtr();
            Debug.Log("Sample Number "+ ptr);
            Table[ptr].Activate(transform);
        }
    }
}
