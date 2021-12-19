using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public bool m_isMain=false;
    
    [ContextMenu("EnterPortal")]
    public void EnterPortal()
    {
        var player = GameWorld.Instance.Character.Player;
        if (player == null)
            return;

        GameObject target=null;
        if (m_isMain)
        {
            target = GameWorld.Instance.Potral.GetRandPortal();
        }
        else
        {
            target = GameWorld.Instance.Potral.GetMainPortal();
        }

        if (target != null)
        {
            GameWorld.Instance.Character.StopAgent();
            player.transform.position = target.transform.position;
            GameWorld.Instance.Character.OpenAgent();
            
        }
    }

}
