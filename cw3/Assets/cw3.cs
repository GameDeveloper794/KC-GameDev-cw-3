using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{



    // hero stuff
    string heroName = "Mahmoud";
    int heroPower = 99;


    // villian stuff
    string villainName = "Thanos";
    int villainPower = 50;

    float playerSpeed = 0;


    //Start is called before the first frame update 
    void start()
    {
        if (villainPower > heroPower)
        {
            print("villain is stronger");
        }
        else if (heroPower > villainPower)
        {
            print("hero is stronger");
        }
        else
        {
            print("both are equal");
        }
        SetSpeed(2.5f);
        CompareSpeed(0f);

    }
    //Update is called upon per frame    
    void Update()
    {

    }

    void SetSpeed(float speed)
    {
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }
    void CompareSpeed(float speed)
    {
        print(playerSpeed);
        float ComapareSpeed = 18f;

        if (ComapareSpeed >= speed)
        {

            print(ComapareSpeed);
        }
        else
        {
            print("Both are equal");

        }

    }


}