/***********************************************************************
 * Module:  Employe.cs
 * Author:  benn
 * Purpose: Definition of the Class Employe
 ***********************************************************************/

using System;

public class Employe
{
   public void EnregistrerLivre()
   {
      // TODO: implement
   }
   
   public void MettreDispoLivre()
   {
      // TODO: implement
   }
   
   public Boolean ProlongerEmprunt()
   {
      // TODO: implement
      return null;
   }
   
   public void GererRetour()
   {
      // TODO: implement
   }

   public System.Collections.ArrayList restauration;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetRestauration()
   {
      if (restauration == null)
         restauration = new System.Collections.ArrayList();
      return restauration;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetRestauration(System.Collections.ArrayList newRestauration)
   {
      RemoveAllRestauration();
      foreach (Restauration oRestauration in newRestauration)
         AddRestauration(oRestauration);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddRestauration(Restauration newRestauration)
   {
      if (newRestauration == null)
         return;
      if (this.restauration == null)
         this.restauration = new System.Collections.ArrayList();
      if (!this.restauration.Contains(newRestauration))
         this.restauration.Add(newRestauration);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveRestauration(Restauration oldRestauration)
   {
      if (oldRestauration == null)
         return;
      if (this.restauration != null)
         if (this.restauration.Contains(oldRestauration))
            this.restauration.Remove(oldRestauration);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllRestauration()
   {
      if (restauration != null)
         restauration.Clear();
   }

   private String Nom;
   private String Poste;
   private int IdEmp;

}