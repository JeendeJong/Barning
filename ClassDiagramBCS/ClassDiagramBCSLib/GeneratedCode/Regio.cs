using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Regio
{
	private string regio;

    public void setRegio(string _regio)
    {
        regio = _regio;
    }

    public string getRegio()
    {
        return regio;
    }


	public virtual OproepFunctie OproepFunctie
	{
		get;
		set;
	}
}

