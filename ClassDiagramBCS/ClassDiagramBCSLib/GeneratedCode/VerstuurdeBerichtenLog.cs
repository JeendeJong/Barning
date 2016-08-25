using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VerstuurdeBerichtenLog
{
	private string bericht
	{
		get;
		set;
	}

	private int smsNr
	{
		get;
		set;
	}

	private int oproepMeldingId
	{
		get;
		set;
	}

	public virtual DateTime registratieDatumTijd
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
