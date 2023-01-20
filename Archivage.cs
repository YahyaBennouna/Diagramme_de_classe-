/***********************************************************************
 * Module:  Archivage.cs
 * Author:  benn
 * Purpose: Definition of the Class Archivage
 ***********************************************************************/

using System;

public class Archivage
{
   public void SetExemplaire()
   {
      // TODO: implement
   }

   public System.Collections.ArrayList exemplaire;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetExemplaire()
   {
      if (exemplaire == null)
         exemplaire = new System.Collections.ArrayList();
      return exemplaire;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetExemplaire(System.Collections.ArrayList newExemplaire)
   {
      RemoveAllExemplaire();
      foreach (Exemplaire oExemplaire in newExemplaire)
         AddExemplaire(oExemplaire);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddExemplaire(Exemplaire newExemplaire)
   {
      if (newExemplaire == null)
         return;
      if (this.exemplaire == null)
         this.exemplaire = new System.Collections.ArrayList();
      if (!this.exemplaire.Contains(newExemplaire))
         this.exemplaire.Add(newExemplaire);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveExemplaire(Exemplaire oldExemplaire)
   {
      if (oldExemplaire == null)
         return;
      if (this.exemplaire != null)
         if (this.exemplaire.Contains(oldExemplaire))
            this.exemplaire.Remove(oldExemplaire);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllExemplaire()
   {
      if (exemplaire != null)
         exemplaire.Clear();
   }

   private DateTime DateArchivage;
   private String Exemplaire;

}