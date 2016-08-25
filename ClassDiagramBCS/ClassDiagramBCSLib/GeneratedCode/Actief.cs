using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Actief
{
	private bool actief
	{
		get;
		set;
	}

    /*
	private Array dagen
	{
		private get;
		private set;
	}
    */ 

	private DateTime uurVanaf
	{
		get;
		set;
	}

	private DateTime uurTot
	{
		get;
		set;
	}

	public virtual Capcode capcode
	{
		get;
		set;
	}

    public void setActief(bool _actief)
    {
        actief = _actief;
    }

    public bool getActief()
    {
        return actief;
    }
}

