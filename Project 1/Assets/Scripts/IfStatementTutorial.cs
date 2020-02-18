using UnityEngine;
using System.Collections;

//Found tutorial guide at: https://learn.unity.com/tutorial/if-statements#5c8a31e4edbc2a00a9df2f46
public class IfStatementTutorial : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
           print("Coffee is too hot."); 
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}
