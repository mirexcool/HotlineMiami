using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardController : MonoBehaviour {

    public Player Player;
	
	private void Start ()
	{
    }

    private void Update ()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - Player.transform.position;

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        Player.transform.rotation = Quaternion.Euler(0f, 0f, rot_z + 90);
        Camera.main.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);

        if (Player != null)
        {
            Vector3 direction = Vector3.zero;
            
            Player.move = direction;
            if (Input.GetKey(KeyCode.D))
                Player.move = direction+Vector3.right;
            if (Input.GetKey(KeyCode.A))
                Player.move = direction+ Vector3.left;
            if (Input.GetKey(KeyCode.W))
                Player.move = direction + Vector3.up;
            if (Input.GetKey(KeyCode.S))
                Player.move = direction + Vector3.down;
            Player.movePlayer();
        }
    }
}