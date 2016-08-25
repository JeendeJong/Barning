using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SmsReacties:ISmsReactie
{
    private DateTime datumTijd { get; set; }
    
    private int responseSmsNr { get; set; }

	private string bericht {get; set; }

    private string locatie { get; set; }

	public virtual OproepMelding OproepMelding  {get; set; }

    Beschikbaar berichtBeschikbaar { get; set; }

    public void setReactie(DateTime _datumTijd, int _responseSmsNr, string _bericht, string _locatie )
    {
        datumTijd = _datumTijd;
        responseSmsNr = _responseSmsNr;
        bericht = _bericht;
        locatie = _locatie;
    }

    public string getBericht()
    {
        return bericht;
    }

    int ISmsReactie.responseSmsNr
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

    string ISmsReactie.bericht
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

    SmsReacties ISmsReactie.SmsReacties
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
