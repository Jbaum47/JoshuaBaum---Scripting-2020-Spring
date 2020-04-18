using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Idamageable<T>
{
    //Must implement into every new script ( add , after inherited class)
    void Damage(T damageAmount);
}
