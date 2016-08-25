using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Capcode
{
	private string capcode
	{
		get;
		set;
	}

	private string omschrijving
	{
		get;
		set;
	}

	public virtual OproepFunctie OproepFunctie
	{
		get;
		set;
	}

	public virtual void capcodeActief()
	{
		throw new System.NotImplementedException();
	}

    public void setCapcode(string _capcode)
    {
        capcode = _capcode;
    }

    public string getCapcode()
    {
        return capcode;
    }

    public void setOmschrijving(string _omschrijving)
    {
        omschrijving = _omschrijving;
    }

    public string getOmschrijving()
    {
        return omschrijving;
    }
}

