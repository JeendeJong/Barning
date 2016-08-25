using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HulpdienstLocatie
{
	private string naam
	{
		get;
		set;
	}

	private string wachtwoord
	{
		get;
		set;
	}

	private DateTime geldigVanaf
	{
		get;
		set;
	}

	private DateTime geldigTot
	{
		get;
		set;
	}

	private bool uitgeschakeld
	{
		get;
		set;
	}

	public virtual OproepMelding OproepMelding
	{
		get;
		set;
	}
}
