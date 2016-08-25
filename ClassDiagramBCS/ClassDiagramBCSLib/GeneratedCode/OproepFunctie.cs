using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class OproepFunctie
{
	private bool actief	{ get; set; }

	private string activeringsMelding { get; set; }

	private string berichtActieveGebruiker { get; set; }

	private string berichtDeactieveGebruiker { get; set; }

	private int capcodeNr 	{ get; set; }

	private string deactiveringsMelding { get; set; }

	private string totaalAantalPersonenEmail { get; set; }

	private int totaalAantalPersonenSms { get; set; }

	private int totaalAantalPersonen { get; set; }

	private string omschrijving { get; set; }

	private string discipline { get; set; }

	private string korps { get; set; }

	public virtual OproepMelding OproepMelding { get; set; }

	public bool activeerOproepMelding(string _capcode)
	{
        discipline = _capcode.Substring(2, 1);   //0 = Brandweer, 2 = Ambulance en 3 = Politie
        omschrijving = _capcode.Substring(3, 4); //indeling verschilt per regio
        korps = _capcode;                        //via discipline de juiste omschrijving tonen
        
        return actief;
	}

	public virtual void geefPiketFunctionaris()
	{
		throw new System.NotImplementedException();
	}

    public void setOmschrijving(string _omschrijving)
    {
        omschrijving = _omschrijving;
    }

    public void setActive(bool _actief)
    {
        actief = _actief;
    }

    public bool getActief()
    {
        return actief;
    }
}

