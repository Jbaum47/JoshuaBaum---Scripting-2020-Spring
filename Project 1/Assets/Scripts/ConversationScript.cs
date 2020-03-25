using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
  public int intelligence = 5;

  void Greet()
  {
    switch (intelligence)
    {
      case 5:
        print("Why hello there good sir! Let me teach ou about Trigonometry!");
        break;
      case 4:
        print("");
        break;
      case 3:
        print("");
        break;
      case 2:
        print("");
        break;
      case 1:
        print("");
        break;
      default:
        print("");
        break;
    }
  }
}
