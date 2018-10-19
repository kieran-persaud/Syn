using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private PlayerStates playerStates;
	private IPlayerState playerState;

	void Start(){
		this.playerStates = new PlayerStates();
		this.playerState = this.playerStates.getStatestanding();
	}

	void Update(){
		playerState.update(this);
	}

	public PlayerStates getPlayerStates()
	{
		return this.playerStates;
	}

	public IPlayerState getPlayerState()
	{
		return this.playerState;
	}

	public void setPlayerState(IPlayerState playerState)
	{
		this.playerState = playerState;
	}
}
