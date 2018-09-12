using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour {
	private string characterName;

	private int level;

	private Classes characterClass;

	private Races characterRace;

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

	private BaseCharacter templateCharacter;

	public string getCharactername()
	{
		return this.characterName;
	}

	public void setCharactername(string characterName)
	{
		this.characterName = characterName;
	}

	public int getLevel()
	{
		return this.level;
	}

	public void setLevel(int level)
	{
		this.level = level;
	}

	public Classes getCharacterclass()
	{
		return this.characterClass;
	}

	public void setCharacterclass(Classes characterClass)
	{
		this.characterClass = characterClass;
	}

	public Races getCharacterrace()
	{
		return this.characterRace;
	}

	public void setCharacterrace(Races characterRace)
	{
		this.characterRace = characterRace;
	}

	public int getExperience()
	{
		return this.experience;
	}

	public void setExperience(int experience)
	{
		this.experience = experience;
	}

	public int getStrength()
	{
		return this.strength;
	}

	public void setStrength(int strength)
	{
		this.strength = strength;
	}

	public int getDexterity()
	{
		return this.dexterity;
	}

	public void setDexterity(int dexterity)
	{
		this.dexterity = dexterity;
	}

	public int getConstitution()
	{
		return this.constitution;
	}

	public void setConstitution(int constitution)
	{
		this.constitution = constitution;
	}

	public int getIntelligence()
	{
		return this.intelligence;
	}

	public void setIntelligence(int intelligence)
	{
		this.intelligence = intelligence;
	}

	public int getWisdom()
	{
		return this.wisdom;
	}

	public void setWisdom(int wisdom)
	{
		this.wisdom = wisdom;
	}

	public int getCharisma()
	{
		return this.charisma;
	}

	public void setCharisma(int charisma)
	{
		this.charisma = charisma;
	}

	public int getArmorclass()
	{
		return this.armorClass;
	}

	public void setArmorclass(int armorClass)
	{
		this.armorClass = armorClass;
	}

	public int getInitiative()
	{
		return this.initiative;
	}

	public void setInitiative(int initiative)
	{
		this.initiative = initiative;
	}

	public int getSpeed()
	{
		return this.speed;
	}

	public void setSpeed(int speed)
	{
		this.speed = speed;
	}

	public int getHitpoints()
	{
		return this.hitPoints;
	}

	public void setHitpoints(int hitPoints)
	{
		this.hitPoints = hitPoints;
	}

	public BaseCharacter getTemplatecharacter()
	{
		return this.templateCharacter;
	}

	public void setTemplatecharacter(BaseCharacter templateCharacter)
	{
		this.templateCharacter = templateCharacter;
	}
}
