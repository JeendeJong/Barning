using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Oproep: IP2000
{
    public string regio;
	public string discipline;
    public string capcode;
    
    public void creeerOproep(string _capcode)
	{
        regio      = _capcode.Substring(0, 2);
        discipline = _capcode.Substring(2, 1);
        capcode    = _capcode;
	}

    public string getRegio()
    {
        return regio;
    }

    public string getOproepCapcode()
    {
        return capcode;
    }

    public string OproepP2000(string _capcode)
    {
        throw new NotImplementedException();
    }
}
