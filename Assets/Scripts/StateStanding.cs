using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateStanding : IPlayerState {
	public void update(Player player){
		if(Input.GetKeyDown(KeyCode.W)){
			player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,10), ForceMode2D.Impulse);
			player.setPlayerState(player.getPlayerStates().getStatejumping());
		}
	}
}