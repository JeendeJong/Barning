using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AppReacties: IAppReactie
{
	private int responseAppNr { get; set; }

	private DateTime datumTijd { get; set; }

	private string bericht { get; set; }

	public virtual OproepMelding OproepMelding { get; set; }

    Beschikbaar berichtBeschikbaar { get; set; }

    int IAppReactie.responseAppNr
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    string IAppReactie.bericht
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    AppReacties IAppReactie.AppReacties
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
}
