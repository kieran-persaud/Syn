using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterUpdatePackage : MonoBehaviour {
	private int level;

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

	public int getLevel()
	{
		return this.level;
	}

	public void setLevel(int level)
	{
		this.level = level;
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

	public Resistances[] getResistances()
	{
		return this.resistances;
	}

	public void setResistances(Resistances[] resistances)
	{
		this.resistances = resistances;
	}
}