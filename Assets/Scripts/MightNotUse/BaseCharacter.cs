using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour {
	private string characterName;

	private int level;

	private IBaseClass characterClass;

	private IBaseRace characterRace;

	private int experience;

	private int strength;

	private int dexterity;

	private int constitution;

	private int intelligence;

	private int wisdom;

	private int charisma;

	private int armorClass;

	private int initiative;

	private int speed;

	private int hitPoints;

	private Resistances[] resistances;

	private BaseCharacter templateCharacter;
}
