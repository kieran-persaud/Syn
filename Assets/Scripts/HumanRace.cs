using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanRace : MonoBehaviour, IBaseRace {
	public CharacterUpdatePackage racialStats(){
		CharacterUpdatePackage update = new CharacterUpdatePackage();
		
		update.setStrength(1);
		update.setDexterity(1);
		update.setConstitution(1);
		update.setIntelligence(1);
		update.setWisdom(1);
		update.setCharisma(1);

		return update;
	}

	//public CharacterUpdatePackage racialPassive();
}
