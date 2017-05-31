using System;

namespace Dispatch
{
  //Double Dispatch

  public class Planina
  {
    public virtual string ImePlanine()
    {
      return "Planina";
    }
  }

  public class MedvednicaPlanina : Planina
  {
    public override string ImePlanine()
    {
      return "Medvednica";
    }
  }

  public class Rekreacija
  {
    public virtual void ImePlanine(Planina planina)
    {
      Console.WriteLine("Ivica je planinario na planinu");
    }
    public virtual void ImePlanine(MedvednicaPlanina planina)
    {
      Console.WriteLine("Ivica je planinario na Medvednicu");
    }
  }

  public class Spuštanje : Rekreacija
  {
    public override void ImePlanine(Planina planina)
    {
      Console.WriteLine("Ivica se spustio s planine");
    }
    public override void ImePlanine(MedvednicaPlanina planina)
    {
      Console.WriteLine("Ivica se spustio s Medvednice");
    }
  }
  class Program
  {

    static void Main(string[] args)
    {

      Rekreacija Penjanje = new Rekreacija();
      Spuštanje Spuštanje = new Spuštanje();
      Planina Planina = new Planina();
      MedvednicaPlanina Medvednica = new MedvednicaPlanina();

      //Single Dispatch
      Console.WriteLine("\nSINGLE DISPATCH PRIMJER:");
      Penjanje.ImePlanine(Planina);
      Penjanje.ImePlanine(Medvednica);
      Spuštanje.ImePlanine(Planina);
      Spuštanje.ImePlanine(Medvednica);

      //Double Dispatch (ne radi)
      Console.WriteLine("\nDOUBLE DISPATCH PRIMJER (ne radi ispravno):");
      Rekreacija PenjanjeRef = new Spuštanje();
      Planina PlaninaRef = new MedvednicaPlanina();
      PenjanjeRef.ImePlanine(PlaninaRef);
    }
  }
}
