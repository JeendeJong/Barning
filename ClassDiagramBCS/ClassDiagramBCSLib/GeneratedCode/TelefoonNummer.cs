using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TelefoonNummer
{
	private string telefoonNummer
	{
		get;
		set;
	}

	public virtual PiketFunctionaris PiketFunctionaris
	{
		get;
		set;
	}

    public void setTelefoonNummer(string _telefoonNummer)
    {
        telefoonNummer = _telefoonNummer;
    }
}
