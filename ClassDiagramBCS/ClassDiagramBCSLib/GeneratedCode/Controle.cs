using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Controle
{
	private string bericht
	{
		get;
		set;
	}

	public virtual OproepMelding OproepMelding
	{
		get;
		set;
	}

	public virtual bool voerControleUit()
	{
		throw new System.NotImplementedException();
	}

}

