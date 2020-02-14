using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button buttonObj;
    public void Start()
    {
        buttonObj.onClick.AddListener(TaskOnClick);
        buttonObj.onClick.AddListener(ButtonClicked(42));
    }

    void TaskOnClick()
    {
        Debug.Log("You just clicked!");
    }

    void ButtonClicked(int buttonNo)
    {
        Debug.Log("Button clicked = " + buttonNo);
    }
    void Update()
    {
        
    }
}
