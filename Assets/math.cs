using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class math : MonoBehaviour
{
    [SerializeField] int proficiencybonus = 2;
    [SerializeField] int DEX = 5;
    [SerializeField] string characterName = "Tav";
    [SerializeField] bool finesseweapon = false;
    [SerializeField] int STR = -5;
    // Start is called before the first frame update
    private void Start()
    {
        int enemyAC = Random.Range(10, 20);
        Debug.Log("enemyAC: " + enemyAC);
        int D20 = Random.Range(1, 21);
        Debug.Log("D20: " + D20);

        int hit = 0;

        // if finesse
        //  if str > dex
        //      hit = str + prof
        //  else
        //      hit = dex + prof

        // else
        //  then hit = str + proficienvy
        

        // Update is called once per frame
        Debug.Log("");
        if (finesseweapon == true)
        {
            if (STR > DEX)
            {
                hit = STR + proficiencybonus;
            }
            else
                hit = DEX + proficiencybonus;
            Debug.Log("finesse weapon:true");
        }
        else
        {
            Debug.Log("finesse weapon:false");
            hit = STR + proficiencybonus;
        }

        Debug.Log("hit = " + hit);

        if (hit + D20 >= enemyAC)
        {
            Debug.Log("Enemy is hit!");
        }
        else
        {
            Debug.Log("miss");
        }

    }
        
}
     
    
     