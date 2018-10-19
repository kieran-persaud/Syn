using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates {
	private IPlayerState stateJumping;
	private IPlayerState stateStanding;

	public PlayerStates(){
		stateJumping = new StateJumping();
		stateStanding = new StateStanding();
	}

	public IPlayerState getStatejumping()
	{
		return this.stateJumping;
	}

	public IPlayerState getStatestanding()
	{
		return this.stateStanding;
	}
}
